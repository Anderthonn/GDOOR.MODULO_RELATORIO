# Module of Report - Indents

### Table of Contents
1 - Introduction;
2 - Screen;
3 - Technologies Used;
4 - Code Explanation.

### 1 - Introduction
The project has been connected to a Firebird database from the GDOOR administrative system. The purpose of this module is to generate reports on cash withdrawals made within a specific date range.

### 2 - Screen
The module features a single screen with a simple interface designed to enhance user usability.

![img](https://imgur.com/yA8DKyO.png)
### 3 - Technologies Used
In this project, we utilized the Visual Studio IDE, opting for the "Windows Forms App (.NET Framework)" project template. The application was coded in C#, and we incorporated two NuGet packages (extensions): "FirebirdSql.Data.FirebirdClient" for connecting to the Firebird database of the GDOOR system, and "iTextSharp" for generating a PDF file with filtered data from the database.


### 4 - Code Explanation
1° Importing the downloaded NuGet Extensions:
```C#
//Extension - (To connect to the database):
//Firebird Entity Framework Provider;
using FirebirdSql.Data.FirebirdClient;
//Extension - (To generate the PDF): ITextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
```
2° Declaration of Firebird Connection Variables: 
```C#
//Variables for connecting to the Firebird Database;
public string strConnection = @"DataSource=localhost; Database=C:\GDOOR Sistemas\GDOOR PRO\DATAGES.FDB; username= SYSDBA; password = masterkey";
public FbConnection con;
```
3° Retrieving Initial Information from the Database and Applying it to a DataGridView and Some TextBoxes:
```C#
            try
            {
                //SQL query that initializes the system with information in the DataGridView;
                con = new FbConnection(strConnection);
                FbCommand comando = new FbCommand(@"SELECT DATA, HORA, OPERADOR, 'R$ '|| CAST(CAST(VALOR AS DECIMAL(15,2)) AS 
                VARCHAR(10)) AS VALOR, OBS FROM MOV_OPERADORES WHERE TIPO = 'SANGRIA' AND OBS <> 'FECHAMENTO DE CAIXA' 
                ORDER BY DATA ASC", con);
                FbDataAdapter data = new FbDataAdapter(comando);
                DataSet dataset = new DataSet();
                con.Open();
                data.Fill(dataset, "MOV_OPERADORES");
                dtvData.DataSource = dataset;
                dtvData.DataMember = "MOV_OPERADORES";

                //SQL queries that initialize the system with company information in TextBoxes;
                FbCommand razaoSocial = new FbCommand(@"SELECT RAZAO_SOCIAL FROM EMITENTE", con);
                FbDataReader rs = razaoSocial.ExecuteReader();
                rs.Read();
                tbSocialName.Text = rs["RAZAO_SOCIAL"].ToString();

                FbCommand endereco = new FbCommand(@"SELECT ENDERECO FROM EMITENTE", con);
                FbDataReader ed = endereco.ExecuteReader();
                ed.Read();
                tbAddress.Text = ed["ENDERECO"].ToString();

                FbCommand numero = new FbCommand(@"SELECT NUM FROM EMITENTE", con);
                FbDataReader nu = numero.ExecuteReader();
                nu.Read();
                tbNumber.Text = nu["NUM"].ToString();

                FbCommand bairro = new FbCommand(@"SELECT BAIRRO FROM EMITENTE", con);
                FbDataReader br = bairro.ExecuteReader();
                br.Read();
                tbNeighborhood.Text = br["BAIRRO"].ToString();

                FbCommand cidade = new FbCommand(@"SELECT CIDADE FROM EMITENTE", con);
                FbDataReader cd = cidade.ExecuteReader();
                cd.Read();
                tbCity.Text = cd["CIDADE"].ToString();

                FbCommand estado = new FbCommand(@"SELECT UF FROM EMITENTE", con);
                FbDataReader uf = estado.ExecuteReader();
                uf.Read();
                tbState.Text = uf["UF"].ToString();

                FbCommand telefone = new FbCommand(@"SELECT TELEFONE FROM EMITENTE", con);
                FbDataReader tl = telefone.ExecuteReader();
                tl.Read();
                tbTelephone.Text = tl["TELEFONE"].ToString();

                con.Close();
            }
            catch
            {
                //Error message in case the connection to the database fails;
                string messageBoxText1 = "Aconteceu um Erro na Conexão com o Banco de Dados!! \r\nPor favor Tente Novamente!!";

                btnGenerate.Enabled = false;
                dtpInitialDate.Enabled = false;
                dtpFinalDate.Enabled = false;

                MessageBox.Show(messageBoxText1, "Atenção, Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
```
4° Afterwards, we programmed a button to query the database for the requested information and generate a PDF.
```C#
            if (dtpFinalDate.Value.Date >= dtpInitialDate.Value.Date)
            {
                try
                {
                    //SQL query that returns filtered results in a DataGridView;
                    con = new FbConnection(strConnection);
                    FbCommand comandoGerar = new FbCommand(@"SELECT DATA, HORA, OPERADOR, 'R$ '|| CAST(CAST(VALOR AS DECIMAL(15,2)) AS VARCHAR(10)) AS VALOR, OBS FROM MOV_OPERADORES WHERE DATA BETWEEN" + "'" + dtpInitialDate.Value.ToString("MM/dd/yyyy") + "'" + "AND" + "'" + dtpFinalDate.Value.ToString("MM/dd/yyyy") + "'" + "AND TIPO = 'SANGRIA' AND OBS NOT CONTAINING 'FECHAMENTO DE CAIXA' ORDER BY DATA ASC", con);
                    FbDataAdapter dataGerar = new FbDataAdapter(comandoGerar);
                    DataSet dataset = new DataSet();
                    con.Open();
                    dataGerar.Fill(dataset, "MOV_OPERADORES");
                    dtvData.DataSource = dataset;
                    dtvData.DataMember = "MOV_OPERADORES";


                    //Creating the iTextSharp table from the DataGridView data;
                    PdfPTable pdfTable = new PdfPTable(dtvData.ColumnCount);

                    //Formatting of the General Table;
                    pdfTable.DefaultCell.Padding = 5;
                    pdfTable.WidthPercentage = 95;
                    pdfTable.HorizontalAlignment = 1;
                    pdfTable.DefaultCell.BorderWidth = 1;

                    //Adding the main columns;
                    foreach (DataGridViewColumn column in dtvData.Columns)
                    {
                        //Formatting of the information in the main columns;
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10F)));
                        cell.Padding = 5;
                        cell.HorizontalAlignment = 1;
                        pdfTable.AddCell(cell);
                    }

                    // Formatting of the main columns' information;
                    foreach (DataGridViewRow row in dtvData.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            //Formatting of the data rows;
                            pdfTable.AddCell(new Phrase(cell.Value?.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10F, Font.Height)));
                            pdfTable.DefaultCell.Padding = 5;
                            pdfTable.HorizontalAlignment = 1;
                        }
                    }

                    //Saving the PDF in a specific location;
                    using (FileStream stream = new FileStream(@"C:\\Relatorios\\" + "Relatorio de Sangria - " + dtpInitialDate.Value.ToString("dd-MM-yyyy - HH-mm") + ".pdf", FileMode.Create))
                    {
                        //Creating a PDF;
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);

                        //Query that calculates the total of withdrawals;
                        FbCommand totalCalculo = new FbCommand(@"SELECT SUM(VALOR) AS TOTAL FROM MOV_OPERADORES WHERE DATA BETWEEN" + "'" + dtpInitialDate.Value.Date.ToString("MM/dd/yyyy") + "'" + "AND" + "'" + dtpFinalDate.Value.Date.ToString("MM/dd/yyyy") + "'" + "AND TIPO = 'SANGRIA' AND OBS NOT CONTAINING 'FECHAMENTO DE CAIXA'", con);
                        FbDataReader tlt = totalCalculo.ExecuteReader();
                        tlt.Read();
                        tbTotal.Text = tlt["TOTAL"].ToString();
                        tbTotal.Text = Convert.ToDouble(tbTotal.Text).ToString("C");

                        PdfPTable pdfTable2 = new PdfPTable(2);

                        //Formatting the filtered information;
                        Paragraph socialName = new Paragraph(16F, tbSocialName.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13F));
                        Paragraph title = new Paragraph(16F, "RELATORIO DE SANGRIA", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13F));
                        Paragraph addressC = new Paragraph(16F, "Endereço: " + tbAddress.Text + "," + " " + tbNumber.Text + "," + " " + tbNeighborhood.Text + " - " + tbCity.Text + "/" + tbState.Text, FontFactory.GetFont(FontFactory.HELVETICA, 12F));
                        Paragraph telephone = new Paragraph(16F, "Telefone: " + tbTelephone.Text, FontFactory.GetFont(FontFactory.HELVETICA, 12F));
                        Paragraph currentDate = new Paragraph(16F, "Emitido em: " + DateTime.Now.ToString("dd/MM/yyyy - HH:mm"), FontFactory.GetFont(FontFactory.HELVETICA, 9F));
                        Paragraph dates = new Paragraph(16F, "De: " + dtpInitialDate.Value.Date.ToString("dd/MM/yyyy") + "   Até: " + dtpFinalDate.Value.Date.ToString("dd/MM/yyyy"), FontFactory.GetFont(FontFactory.HELVETICA, 12F));
                        PdfPCell cell2 = new PdfPCell(new Phrase(16F, "TOTAL: ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10F)));
                        PdfPCell cell3 = new PdfPCell(new Phrase(16F, tbTotal.Text, FontFactory.GetFont(FontFactory.HELVETICA, 10F)));
                        Paragraph space = new Paragraph();

                        cell2.Padding = 3;
                        cell3.Padding = 3;
                        cell2.HorizontalAlignment = 1;
                        cell3.HorizontalAlignment = 1;

                        pdfTable2.AddCell(cell2);
                        pdfTable2.AddCell(cell3);
                        pdfTable2.DefaultCell.Padding = 3;
                        pdfTable2.WidthPercentage = 95;
                        pdfTable2.HorizontalAlignment = 1;
                        pdfTable2.DefaultCell.BorderWidth = Element.ALIGN_LEFT;

                        title.Alignment = Element.ALIGN_CENTER;
                        socialName.Alignment = Element.ALIGN_CENTER;
                        addressC.Alignment = Element.ALIGN_CENTER;
                        telephone.Alignment = Element.ALIGN_CENTER;
                        currentDate.Alignment = Element.ALIGN_CENTER;
                        dates.Alignment = Element.ALIGN_CENTER;
                        space.Add(" ");

                        //Calling the formatted information for the PDF;
                        pdfDoc.Open();
                        pdfDoc.Add(socialName);
                        pdfDoc.Add(addressC);
                        pdfDoc.Add(telephone);
                        pdfDoc.Add(space);
                        pdfDoc.Add(title);
                        pdfDoc.Add(dates);
                        pdfDoc.Add(currentDate);
                        pdfDoc.Add(space);
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Add(space);
                        pdfDoc.Add(pdfTable2);
                        pdfDoc.Close();
                        stream.Close();
                    }

                    con.Close();

                    //Message indicating that the report was generated successfully;
                    string messageBoxText2 = "Relatorio Gerado com Sucesso, Acessa a Pasta 'Relatorios' - C:\\Relatorios.";
                    MessageBox.Show(messageBoxText2, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    //Message indicating that there is no information on this day to be extracted;
                    string messageBoxText3 = "Nem uma Sangria Realizada nesse Dia!!";
                    MessageBox.Show(messageBoxText3, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //Message indicating that the start date must be greater than or equal to the end date.
                string messageBoxText4 = "Por Favor Informe um Data Maior que a Data Final!!";
                MessageBox.Show(messageBoxText4, "Atenção, Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
```
### Created by: Anderthonn Luyz M.G. Batista
