# Modulo de Relatório - Sangrias

### Sumário
1 - Introdução;  
2 - Tela;  
3 - Tecnologias Usadas;  
4 - Explicação do código.

### 1 - Introdução
O projeto foi conectado a uma base de dados Firebird do sistema administrativo [GDOOR](https://gdoor.com.br/), o objeto desse modulo é gerar relatorios de sangrias realizadas em um determinado periodo de datas.

### 2 - Tela
O modulo possui uma unica tela, com uma interface simple para ajudar o usuario na usabilidade.  

![img](https://imgur.com/yA8DKyO.png)
### 3 - Tecnologias Usadas
Nesse projeto usamos a IDE Visual Studio, o modelo de projeto escolhido foi o "[Aplicativo do Windows Form (.NET Framework)](https://docs.microsoft.com/pt-br/dotnet/desktop/winforms/overview/?view=netdesktop-6.0)", a aplicação foi programada na linguagem [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/), aplicamos dois pacotes (Extenções) [NuGet](https://www.nuget.org/) o "[FirebirdSql.Data.FirebirdClient](https://www.nuget.org/packages/FirebirdSql.Data.FirebirdClient/)" para conectar a base de dados [Firebird](https://firebirdsql.org/) do sistema [GDOOR](https://gdoor.com.br/) é também utilizamos o pacote "[iTextSharp](https://www.nuget.org/packages/iTextSharp/)" para gerar um arquivo PDF com os dados filtrados do banco de dados.  


### 4 - Explicação do Código  

1° Chamamos as Extençõe baixadas do NuGet;
```C#
//Extensão - (Para conectar com o banco de dados): 
//Firebird Entity Framework Provider;
using FirebirdSql.Data.FirebirdClient;
// Extensão - (Para gerar o PDF): ITextSharp;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
```
2° Declaramos as variavei de conexão com Firebird; 
```C#
// Variaveis de conexão com o Banco de Dados Firebird;
public string strConexao = @"DataSource=localhost; Database=C:\GDOOR Sistemas\GDOOR PRO\DATAGES.FDB; username= SYSDBA; password = masterkey";
public FbConnection con;
```
3° Buscamos as informações iniciais no banco e aplicamos essas informações em um DataGridView e em alguns TextBox;
```C#
try
{
    //Consulta SQL que inicia o sistema com informações no DataGridView;
    con = new FbConnection(strConexao);
    FbCommand comando = new FbCommand(@"SELECT DATA, HORA, OPERADOR, 'R$ '|| CAST(CAST(VALOR AS DECIMAL(15,2)) AS 
    VARCHAR(10)) AS VALOR, OBS FROM MOV_OPERADORES WHERE TIPO = 'SANGRIA' AND OBS <> 'FECHAMENTO DE CAIXA' 
    ORDER BY DATA ASC", con);
    FbDataAdapter data = new FbDataAdapter(comando);
    DataSet dataset = new DataSet();
    con.Open();
    data.Fill(dataset, "MOV_OPERADORES");
    dtvDados.DataSource = dataset;
    dtvDados.DataMember = "MOV_OPERADORES";

    //Consultas SQL que inicia o sistema com informações da empresa em um TextBox;
    FbCommand razaoSocial = new FbCommand(@"SELECT RAZAO_SOCIAL FROM EMITENTE", con);
    FbDataReader rs = razaoSocial.ExecuteReader();
    rs.Read();
    tbNomeSocial.Text = rs["RAZAO_SOCIAL"].ToString();

    FbCommand endereco = new FbCommand(@"SELECT ENDERECO FROM EMITENTE", con);
    FbDataReader ed = endereco.ExecuteReader();
    ed.Read();
    tbEndereco.Text = ed["ENDERECO"].ToString();

    FbCommand numero = new FbCommand(@"SELECT NUM FROM EMITENTE", con);
    FbDataReader nu = numero.ExecuteReader();
    nu.Read();
    tbNumero.Text = nu["NUM"].ToString();

    FbCommand bairro = new FbCommand(@"SELECT BAIRRO FROM EMITENTE", con);
    FbDataReader br = bairro.ExecuteReader();
    br.Read();
    tbBairro.Text = br["BAIRRO"].ToString();

    FbCommand cidade = new FbCommand(@"SELECT CIDADE FROM EMITENTE", con);
    FbDataReader cd = cidade.ExecuteReader();
    cd.Read();
    tbCidade.Text = cd["CIDADE"].ToString();

    FbCommand estado = new FbCommand(@"SELECT UF FROM EMITENTE", con);
    FbDataReader uf = estado.ExecuteReader();
    uf.Read();
    tbEstado.Text = uf["UF"].ToString();

    FbCommand telefone = new FbCommand(@"SELECT TELEFONE FROM EMITENTE", con);
    FbDataReader tl = telefone.ExecuteReader();
    tl.Read();
    tbTelefone.Text = tl["TELEFONE"].ToString();

    con.Close();
}
catch
{
    //Mensagem de erro caso a conexão com o banco de dado falhe;
    string messageBoxText1 = "Aconteceu um Erro na Conexão com o Banco de Dados!! \r\nPor favor Tente Novamente!!";

    btnGerar.Enabled = false;
    dtpDataIncial.Enabled = false;
    dtpDataFinal.Enabled = false;

    MessageBox.Show(messageBoxText1, "Atenção, Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
```
4° Depois programamos um botão para consultar no banco as informações requisitadas e gerar um PDF;  
```C#
if (dtpDataFinal.Value.Date >= dtpDataIncial.Value.Date)
{
    try
    {
        // Consulta SQL que retorna os resultados filtrados em um DataGridView;
        con = new FbConnection(strConexao);
        FbCommand comandoGerar = new FbCommand(@"SELECT DATA, HORA, OPERADOR, 'R$ '|| CAST(CAST(VALOR AS DECIMAL(15,2)) AS VARCHAR(10)) AS VALOR, OBS FROM MOV_OPERADORES WHERE DATA BETWEEN" + "'" + dtpDataIncial.Value.ToString("MM/dd/yyyy") + "'" + "AND" + "'" + dtpDataFinal.Value.ToString("MM/dd/yyyy") + "'" + "AND TIPO = 'SANGRIA' AND OBS NOT CONTAINING 'FECHAMENTO DE CAIXA' ORDER BY DATA ASC", con);
        FbDataAdapter dataGerar = new FbDataAdapter(comandoGerar);
        DataSet dataset = new DataSet();
        con.Open();
        dataGerar.Fill(dataset, "MOV_OPERADORES");
        dtvDados.DataSource = dataset;
        dtvDados.DataMember = "MOV_OPERADORES";


        //Criando a tabela iTextSharp a partir dos dados do DataGridView;
        PdfPTable pdfTable = new PdfPTable(dtvDados.ColumnCount);

        //Formatação da Tabela Geral;
        pdfTable.DefaultCell.Padding = 5;
        pdfTable.WidthPercentage = 95;
        pdfTable.HorizontalAlignment = 1;
        pdfTable.DefaultCell.BorderWidth = 1;

        //Adicionando as colunas principais;
        foreach (DataGridViewColumn column in dtvDados.Columns)
        {
            //Formatação das informações das colunas principais;
            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10F)));
            cell.Padding = 5;
            cell.HorizontalAlignment = 1;
            pdfTable.AddCell(cell);
        }

        //Adicionando a sequencia de dados do DataGridView no PDF;
        foreach (DataGridViewRow row in dtvDados.Rows)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                //Formatação das linhas de dados;
                pdfTable.AddCell(new Phrase(cell.Value?.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10F, Font.Height)));
                pdfTable.DefaultCell.Padding = 5;
                pdfTable.HorizontalAlignment = 1;
            }
        }

        //Salvando o PDF em um lugar específico;
        using (FileStream stream = new FileStream(@"C:\\Relatorios\\" + "Relatorio de Sangria - " + dtpDataIncial.Value.ToString("dd-MM-yyyy - HH-mm") + ".pdf", FileMode.Create))
        {
            //Criando um PDF;
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            PdfWriter.GetInstance(pdfDoc, stream);

            // Consulta que calcula o total das sangrias;
            FbCommand totalCalculo = new FbCommand(@"SELECT SUM(VALOR) AS TOTAL FROM MOV_OPERADORES WHERE DATA BETWEEN" + "'" + dtpDataIncial.Value.Date.ToString("MM/dd/yyyy") + "'" + "AND" + "'" + dtpDataFinal.Value.Date.ToString("MM/dd/yyyy") + "'" + "AND TIPO = 'SANGRIA' AND OBS NOT CONTAINING 'FECHAMENTO DE CAIXA'", con);
            FbDataReader tlt = totalCalculo.ExecuteReader();
            tlt.Read();
            tbTotal.Text = tlt["TOTAL"].ToString();
            tbTotal.Text = Convert.ToDouble(tbTotal.Text).ToString("C");

            PdfPTable pdfTable2 = new PdfPTable(2);

            //Formatando as informações filtradas;
            Paragraph nomeSocial = new Paragraph(16F, tbNomeSocial.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13F));
            Paragraph titulo = new Paragraph(16F, "RELATORIO DE SANGRIA", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13F));
            Paragraph enderecoC = new Paragraph(16F, "Endereço: " + tbEndereco.Text + "," + " " + tbNumero.Text + "," + " " + tbBairro.Text + " - " + tbCidade.Text + "/" + tbEstado.Text, FontFactory.GetFont(FontFactory.HELVETICA, 12F));
            Paragraph telefone = new Paragraph(16F, "Telefone: " + tbTelefone.Text, FontFactory.GetFont(FontFactory.HELVETICA, 12F));
            Paragraph dataAtual = new Paragraph(16F, "Emitido em: " + DateTime.Now.ToString("dd/MM/yyyy - HH:mm"), FontFactory.GetFont(FontFactory.HELVETICA, 9F));
            Paragraph datas = new Paragraph(16F, "De: " + dtpDataIncial.Value.Date.ToString("dd/MM/yyyy") + "   Até: " + dtpDataFinal.Value.Date.ToString("dd/MM/yyyy"), FontFactory.GetFont(FontFactory.HELVETICA, 12F));
            PdfPCell cell2 = new PdfPCell(new Phrase(16F, "TOTAL: ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10F)));
            PdfPCell cell3 = new PdfPCell(new Phrase(16F, tbTotal.Text, FontFactory.GetFont(FontFactory.HELVETICA, 10F)));
            Paragraph espaco = new Paragraph();

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

            titulo.Alignment = Element.ALIGN_CENTER;
            nomeSocial.Alignment = Element.ALIGN_CENTER;
            enderecoC.Alignment = Element.ALIGN_CENTER;
            telefone.Alignment = Element.ALIGN_CENTER;
            dataAtual.Alignment = Element.ALIGN_CENTER;
            datas.Alignment = Element.ALIGN_CENTER;
            espaco.Add(" ");

            // Chamando as informações formatadas para o PDF;
            pdfDoc.Open();
            pdfDoc.Add(nomeSocial);
            pdfDoc.Add(enderecoC);
            pdfDoc.Add(telefone);
            pdfDoc.Add(espaco);
            pdfDoc.Add(titulo);
            pdfDoc.Add(datas);
            pdfDoc.Add(dataAtual);
            pdfDoc.Add(espaco);
            pdfDoc.Add(pdfTable);
            pdfDoc.Add(espaco);
            pdfDoc.Add(pdfTable2);
            pdfDoc.Close();
            stream.Close();
        }

        con.Close();

        // Mensagem informando que o relatorio foi gerado com sucesso;
        string messageBoxText2 = "Relatorio Gerado com Sucesso, Acessa a Pasta 'Relatorios' - C:\\Relatorios.";
        MessageBox.Show(messageBoxText2, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    catch
    {
        //Mensagem informando que não exite informações nesse dia para serem extraidas;
        string messageBoxText3 = "Nem uma Sangria Realizada nesse Dia!!";
        MessageBox.Show(messageBoxText3, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
else
{
    //Mensagem informando que a data inical tem que ser maior ou igual a data final.
    string messageBoxText4 = "Por Favor Informe um Data Maior que a data Final!!";
    MessageBox.Show(messageBoxText4, "Atenção, Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
```
### Criado por: Anderthonn Luyz M.G. Batista
