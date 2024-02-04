namespace GDOOR_MODULO_DE_RELATORIO____SANGRIA
{
    partial class frmMain_Bleeding_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain_Bleeding_Report));
            this.lbInitialDate = new System.Windows.Forms.Label();
            this.dtpInitialDate = new System.Windows.Forms.DateTimePicker();
            this.dtvData = new System.Windows.Forms.DataGridView();
            this.gbDadosEmpresa = new System.Windows.Forms.GroupBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbNeighborhood = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbSocialName = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gbDataReport = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.dtpFinalDate = new System.Windows.Forms.DateTimePicker();
            this.lbFinalDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvData)).BeginInit();
            this.gbDadosEmpresa.SuspendLayout();
            this.gbDataReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInitialDate
            // 
            this.lbInitialDate.AutoSize = true;
            this.lbInitialDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbInitialDate.Location = new System.Drawing.Point(22, 8);
            this.lbInitialDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInitialDate.Name = "lbInitialDate";
            this.lbInitialDate.Size = new System.Drawing.Size(108, 28);
            this.lbInitialDate.TabIndex = 0;
            this.lbInitialDate.Text = "Data Inicial";
            // 
            // dtpInitialDate
            // 
            this.dtpInitialDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpInitialDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInitialDate.Location = new System.Drawing.Point(18, 38);
            this.dtpInitialDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpInitialDate.Name = "dtpInitialDate";
            this.dtpInitialDate.Size = new System.Drawing.Size(154, 33);
            this.dtpInitialDate.TabIndex = 1;
            // 
            // dtvData
            // 
            this.dtvData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvData.Location = new System.Drawing.Point(9, 29);
            this.dtvData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtvData.Name = "dtvData";
            this.dtvData.RowHeadersWidth = 62;
            this.dtvData.Size = new System.Drawing.Size(810, 320);
            this.dtvData.TabIndex = 2;
            // 
            // gbDadosEmpresa
            // 
            this.gbDadosEmpresa.Controls.Add(this.tbTelephone);
            this.gbDadosEmpresa.Controls.Add(this.tbState);
            this.gbDadosEmpresa.Controls.Add(this.tbCity);
            this.gbDadosEmpresa.Controls.Add(this.tbNeighborhood);
            this.gbDadosEmpresa.Controls.Add(this.tbNumber);
            this.gbDadosEmpresa.Controls.Add(this.tbAddress);
            this.gbDadosEmpresa.Controls.Add(this.tbSocialName);
            this.gbDadosEmpresa.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbDadosEmpresa.Location = new System.Drawing.Point(18, 89);
            this.gbDadosEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDadosEmpresa.Name = "gbDadosEmpresa";
            this.gbDadosEmpresa.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDadosEmpresa.Size = new System.Drawing.Size(832, 162);
            this.gbDadosEmpresa.TabIndex = 3;
            this.gbDadosEmpresa.TabStop = false;
            this.gbDadosEmpresa.Text = "Dados da Empresa";
            // 
            // tbTelephone
            // 
            this.tbTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelephone.Enabled = false;
            this.tbTelephone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbTelephone.Location = new System.Drawing.Point(10, 114);
            this.tbTelephone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTelephone.Multiline = true;
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(232, 37);
            this.tbTelephone.TabIndex = 7;
            // 
            // tbState
            // 
            this.tbState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbState.Enabled = false;
            this.tbState.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbState.Location = new System.Drawing.Point(760, 71);
            this.tbState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbState.Multiline = true;
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(59, 37);
            this.tbState.TabIndex = 6;
            // 
            // tbCity
            // 
            this.tbCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCity.Enabled = false;
            this.tbCity.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbCity.Location = new System.Drawing.Point(632, 71);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCity.Multiline = true;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(119, 37);
            this.tbCity.TabIndex = 6;
            // 
            // tbNeighborhood
            // 
            this.tbNeighborhood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNeighborhood.Enabled = false;
            this.tbNeighborhood.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbNeighborhood.Location = new System.Drawing.Point(424, 71);
            this.tbNeighborhood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNeighborhood.Multiline = true;
            this.tbNeighborhood.Name = "tbNeighborhood";
            this.tbNeighborhood.Size = new System.Drawing.Size(197, 37);
            this.tbNeighborhood.TabIndex = 6;
            // 
            // tbNumber
            // 
            this.tbNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumber.Enabled = false;
            this.tbNumber.Location = new System.Drawing.Point(333, 71);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNumber.Multiline = true;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(82, 37);
            this.tbNumber.TabIndex = 6;
            // 
            // tbAddress
            // 
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddress.Enabled = false;
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbAddress.Location = new System.Drawing.Point(10, 71);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(312, 37);
            this.tbAddress.TabIndex = 5;
            // 
            // tbSocialName
            // 
            this.tbSocialName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSocialName.Enabled = false;
            this.tbSocialName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbSocialName.Location = new System.Drawing.Point(10, 28);
            this.tbSocialName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSocialName.Multiline = true;
            this.tbSocialName.Name = "tbSocialName";
            this.tbSocialName.Size = new System.Drawing.Size(809, 37);
            this.tbSocialName.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Location = new System.Drawing.Point(369, 34);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 46);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "GERAR";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // gbDataReport
            // 
            this.gbDataReport.Controls.Add(this.tbTotal);
            this.gbDataReport.Controls.Add(this.lbTotal);
            this.gbDataReport.Controls.Add(this.dtvData);
            this.gbDataReport.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbDataReport.Location = new System.Drawing.Point(18, 260);
            this.gbDataReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDataReport.Name = "gbDataReport";
            this.gbDataReport.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDataReport.Size = new System.Drawing.Size(832, 409);
            this.gbDataReport.TabIndex = 8;
            this.gbDataReport.TabStop = false;
            this.gbDataReport.Text = "Dados do Relatório";
            // 
            // tbTotal
            // 
            this.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbTotal.Location = new System.Drawing.Point(654, 358);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTotal.Multiline = true;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(164, 37);
            this.tbTotal.TabIndex = 8;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbTotal.Location = new System.Drawing.Point(586, 365);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(63, 28);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "Total: ";
            // 
            // dtpFinalDate
            // 
            this.dtpFinalDate.Enabled = false;
            this.dtpFinalDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpFinalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinalDate.Location = new System.Drawing.Point(183, 38);
            this.dtpFinalDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFinalDate.Name = "dtpFinalDate";
            this.dtpFinalDate.Size = new System.Drawing.Size(154, 33);
            this.dtpFinalDate.TabIndex = 9;
            // 
            // lbFinalDate
            // 
            this.lbFinalDate.AutoSize = true;
            this.lbFinalDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbFinalDate.Location = new System.Drawing.Point(188, 9);
            this.lbFinalDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFinalDate.Name = "lbFinalDate";
            this.lbFinalDate.Size = new System.Drawing.Size(99, 28);
            this.lbFinalDate.TabIndex = 10;
            this.lbFinalDate.Text = "Data Final";
            // 
            // frmMain_Bleeding_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(876, 694);
            this.Controls.Add(this.lbFinalDate);
            this.Controls.Add(this.dtpFinalDate);
            this.Controls.Add(this.gbDataReport);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gbDadosEmpresa);
            this.Controls.Add(this.dtpInitialDate);
            this.Controls.Add(this.lbInitialDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain_Bleeding_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo: Relatório de Sangrias - (Sistema: GDOOR)";
            this.Load += new System.EventHandler(this.frmMain_Bleeding_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvData)).EndInit();
            this.gbDadosEmpresa.ResumeLayout(false);
            this.gbDadosEmpresa.PerformLayout();
            this.gbDataReport.ResumeLayout(false);
            this.gbDataReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInitialDate;
        private System.Windows.Forms.DateTimePicker dtpInitialDate;
        private System.Windows.Forms.DataGridView dtvData;
        private System.Windows.Forms.GroupBox gbDadosEmpresa;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbNeighborhood;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbSocialName;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.GroupBox gbDataReport;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DateTimePicker dtpFinalDate;
        private System.Windows.Forms.Label lbFinalDate;
    }
}

