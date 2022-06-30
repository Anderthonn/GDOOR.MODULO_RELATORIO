namespace GDOOR_MODULO_DE_RELATORIO____SANGRIA
{
    partial class frmPrincipal_Relatorio_de_Sangrias
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal_Relatorio_de_Sangrias));
            this.lbDataInicial = new System.Windows.Forms.Label();
            this.dtpDataIncial = new System.Windows.Forms.DateTimePicker();
            this.dtvDados = new System.Windows.Forms.DataGridView();
            this.gbDadosEmpresa = new System.Windows.Forms.GroupBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbNomeSocial = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.gbDadosRelatorio = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lbDataFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDados)).BeginInit();
            this.gbDadosEmpresa.SuspendLayout();
            this.gbDadosRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.AutoSize = true;
            this.lbDataInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbDataInicial.Location = new System.Drawing.Point(15, 5);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(71, 17);
            this.lbDataInicial.TabIndex = 0;
            this.lbDataInicial.Text = "Data Inicial";
            // 
            // dtpDataIncial
            // 
            this.dtpDataIncial.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpDataIncial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataIncial.Location = new System.Drawing.Point(12, 25);
            this.dtpDataIncial.Name = "dtpDataIncial";
            this.dtpDataIncial.Size = new System.Drawing.Size(104, 25);
            this.dtpDataIncial.TabIndex = 1;
            // 
            // dtvDados
            // 
            this.dtvDados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDados.Location = new System.Drawing.Point(6, 19);
            this.dtvDados.Name = "dtvDados";
            this.dtvDados.Size = new System.Drawing.Size(540, 208);
            this.dtvDados.TabIndex = 2;
            // 
            // gbDadosEmpresa
            // 
            this.gbDadosEmpresa.Controls.Add(this.tbTelefone);
            this.gbDadosEmpresa.Controls.Add(this.tbEstado);
            this.gbDadosEmpresa.Controls.Add(this.tbCidade);
            this.gbDadosEmpresa.Controls.Add(this.tbBairro);
            this.gbDadosEmpresa.Controls.Add(this.tbNumero);
            this.gbDadosEmpresa.Controls.Add(this.tbEndereco);
            this.gbDadosEmpresa.Controls.Add(this.tbNomeSocial);
            this.gbDadosEmpresa.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbDadosEmpresa.Location = new System.Drawing.Point(12, 58);
            this.gbDadosEmpresa.Name = "gbDadosEmpresa";
            this.gbDadosEmpresa.Size = new System.Drawing.Size(555, 105);
            this.gbDadosEmpresa.TabIndex = 3;
            this.gbDadosEmpresa.TabStop = false;
            this.gbDadosEmpresa.Text = "Dados da Empresa";
            // 
            // tbTelefone
            // 
            this.tbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelefone.Enabled = false;
            this.tbTelefone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbTelefone.Location = new System.Drawing.Point(7, 74);
            this.tbTelefone.Multiline = true;
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(155, 25);
            this.tbTelefone.TabIndex = 7;
            // 
            // tbEstado
            // 
            this.tbEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEstado.Enabled = false;
            this.tbEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbEstado.Location = new System.Drawing.Point(507, 46);
            this.tbEstado.Multiline = true;
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(40, 25);
            this.tbEstado.TabIndex = 6;
            // 
            // tbCidade
            // 
            this.tbCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCidade.Enabled = false;
            this.tbCidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbCidade.Location = new System.Drawing.Point(421, 46);
            this.tbCidade.Multiline = true;
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(80, 25);
            this.tbCidade.TabIndex = 6;
            // 
            // tbBairro
            // 
            this.tbBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBairro.Enabled = false;
            this.tbBairro.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbBairro.Location = new System.Drawing.Point(283, 46);
            this.tbBairro.Multiline = true;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(132, 25);
            this.tbBairro.TabIndex = 6;
            // 
            // tbNumero
            // 
            this.tbNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumero.Enabled = false;
            this.tbNumero.Location = new System.Drawing.Point(222, 46);
            this.tbNumero.Multiline = true;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(55, 25);
            this.tbNumero.TabIndex = 6;
            // 
            // tbEndereco
            // 
            this.tbEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEndereco.Enabled = false;
            this.tbEndereco.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbEndereco.Location = new System.Drawing.Point(7, 46);
            this.tbEndereco.Multiline = true;
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(209, 25);
            this.tbEndereco.TabIndex = 5;
            // 
            // tbNomeSocial
            // 
            this.tbNomeSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNomeSocial.Enabled = false;
            this.tbNomeSocial.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbNomeSocial.Location = new System.Drawing.Point(7, 18);
            this.tbNomeSocial.Multiline = true;
            this.tbNomeSocial.Name = "tbNomeSocial";
            this.tbNomeSocial.Size = new System.Drawing.Size(540, 25);
            this.tbNomeSocial.TabIndex = 4;
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGerar.Location = new System.Drawing.Point(246, 22);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(80, 30);
            this.btnGerar.TabIndex = 5;
            this.btnGerar.Text = "GERAR";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // gbDadosRelatorio
            // 
            this.gbDadosRelatorio.Controls.Add(this.tbTotal);
            this.gbDadosRelatorio.Controls.Add(this.lbTotal);
            this.gbDadosRelatorio.Controls.Add(this.dtvDados);
            this.gbDadosRelatorio.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbDadosRelatorio.Location = new System.Drawing.Point(12, 169);
            this.gbDadosRelatorio.Name = "gbDadosRelatorio";
            this.gbDadosRelatorio.Size = new System.Drawing.Size(555, 266);
            this.gbDadosRelatorio.TabIndex = 8;
            this.gbDadosRelatorio.TabStop = false;
            this.gbDadosRelatorio.Text = "Dados do Relatório";
            // 
            // tbTotal
            // 
            this.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbTotal.Location = new System.Drawing.Point(436, 233);
            this.tbTotal.Multiline = true;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(110, 25);
            this.tbTotal.TabIndex = 8;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbTotal.Location = new System.Drawing.Point(391, 237);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(43, 17);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "Total: ";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Enabled = false;
            this.dtpDataFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(122, 25);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(104, 25);
            this.dtpDataFinal.TabIndex = 9;
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbDataFinal.Location = new System.Drawing.Point(125, 6);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(65, 17);
            this.lbDataFinal.TabIndex = 10;
            this.lbDataFinal.Text = "Data Final";
            // 
            // frmPrincipal_Relatorio_de_Sangrias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(584, 451);
            this.Controls.Add(this.lbDataFinal);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.gbDadosRelatorio);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.gbDadosEmpresa);
            this.Controls.Add(this.dtpDataIncial);
            this.Controls.Add(this.lbDataInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal_Relatorio_de_Sangrias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo: Relatório de Sangrias - (Sistema: GDOOR)";
            this.Load += new System.EventHandler(this.frmPrincipal_Relatorio_de_Sangrias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDados)).EndInit();
            this.gbDadosEmpresa.ResumeLayout(false);
            this.gbDadosEmpresa.PerformLayout();
            this.gbDadosRelatorio.ResumeLayout(false);
            this.gbDadosRelatorio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataIncial;
        private System.Windows.Forms.DataGridView dtvDados;
        private System.Windows.Forms.GroupBox gbDadosEmpresa;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbNomeSocial;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.GroupBox gbDadosRelatorio;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label lbDataFinal;
    }
}

