namespace Apresentacao
{
    partial class FrmCarnezinho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCarnezinho = new System.Windows.Forms.Panel();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.gbpParcelas = new System.Windows.Forms.GroupBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.lblQtde = new System.Windows.Forms.Label();
            this.nudQtdeMensalidae = new System.Windows.Forms.NumericUpDown();
            this.lblInstrucao2 = new System.Windows.Forms.Label();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.ColCodAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prgbStatus = new System.Windows.Forms.ProgressBar();
            this.pnlCarnezinho.SuspendLayout();
            this.gbpParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeMensalidae)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCarnezinho
            // 
            this.pnlCarnezinho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCarnezinho.BackColor = System.Drawing.Color.Teal;
            this.pnlCarnezinho.Controls.Add(this.prgbStatus);
            this.pnlCarnezinho.Controls.Add(this.btnGerenciar);
            this.pnlCarnezinho.Controls.Add(this.gbpParcelas);
            this.pnlCarnezinho.Controls.Add(this.lblInstrucao2);
            this.pnlCarnezinho.Controls.Add(this.lblInstrucao);
            this.pnlCarnezinho.Controls.Add(this.btnGerar);
            this.pnlCarnezinho.Controls.Add(this.dgvPrincipal);
            this.pnlCarnezinho.ForeColor = System.Drawing.Color.Teal;
            this.pnlCarnezinho.Location = new System.Drawing.Point(12, 12);
            this.pnlCarnezinho.Name = "pnlCarnezinho";
            this.pnlCarnezinho.Size = new System.Drawing.Size(576, 764);
            this.pnlCarnezinho.TabIndex = 0;
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.Location = new System.Drawing.Point(283, 703);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(135, 50);
            this.btnGerenciar.TabIndex = 12;
            this.btnGerenciar.Text = "Gerenciar Parcelas";
            this.btnGerenciar.UseVisualStyleBackColor = true;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // gbpParcelas
            // 
            this.gbpParcelas.Controls.Add(this.lblAssunto);
            this.gbpParcelas.Controls.Add(this.txtAssunto);
            this.gbpParcelas.Controls.Add(this.lblValor);
            this.gbpParcelas.Controls.Add(this.txtValor);
            this.gbpParcelas.Controls.Add(this.lblDataInicial);
            this.gbpParcelas.Controls.Add(this.dtpDataInicial);
            this.gbpParcelas.Controls.Add(this.lblQtde);
            this.gbpParcelas.Controls.Add(this.nudQtdeMensalidae);
            this.gbpParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpParcelas.ForeColor = System.Drawing.SystemColors.Control;
            this.gbpParcelas.Location = new System.Drawing.Point(15, 56);
            this.gbpParcelas.Name = "gbpParcelas";
            this.gbpParcelas.Size = new System.Drawing.Size(544, 105);
            this.gbpParcelas.TabIndex = 11;
            this.gbpParcelas.TabStop = false;
            this.gbpParcelas.Text = "Dados das parcelas";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(224, 70);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(68, 20);
            this.lblAssunto.TabIndex = 16;
            this.lblAssunto.Text = "Assunto";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(298, 70);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(233, 26);
            this.txtAssunto.TabIndex = 15;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(47, 70);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 14;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(104, 70);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(110, 26);
            this.txtValor.TabIndex = 13;
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(187, 34);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(88, 20);
            this.lblDataInicial.TabIndex = 12;
            this.lblDataInicial.Text = "Data Inicial";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(281, 34);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(150, 26);
            this.dtpDataInicial.TabIndex = 11;
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQtde.Location = new System.Drawing.Point(6, 36);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(92, 20);
            this.lblQtde.TabIndex = 10;
            this.lblQtde.Text = "Quantidade";
            // 
            // nudQtdeMensalidae
            // 
            this.nudQtdeMensalidae.Location = new System.Drawing.Point(104, 34);
            this.nudQtdeMensalidae.Name = "nudQtdeMensalidae";
            this.nudQtdeMensalidae.Size = new System.Drawing.Size(66, 26);
            this.nudQtdeMensalidae.TabIndex = 9;
            // 
            // lblInstrucao2
            // 
            this.lblInstrucao2.AutoSize = true;
            this.lblInstrucao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucao2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInstrucao2.Location = new System.Drawing.Point(12, 28);
            this.lblInstrucao2.Name = "lblInstrucao2";
            this.lblInstrucao2.Size = new System.Drawing.Size(185, 16);
            this.lblInstrucao2.TabIndex = 7;
            this.lblInstrucao2.Text = "suas repectivas mensalidade";
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.AutoSize = true;
            this.lblInstrucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInstrucao.Location = new System.Drawing.Point(12, 12);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(413, 16);
            this.lblInstrucao.TabIndex = 6;
            this.lblInstrucao.Text = "Pressione a tecla \"Shift\" e clique sobre os alunos na lista para gerar ";
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(424, 703);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(135, 50);
            this.btnGerar.TabIndex = 5;
            this.btnGerar.Text = "Gerar Carnezinho";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodAluno,
            this.ColNomeAluno});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrincipal.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPrincipal.Location = new System.Drawing.Point(15, 168);
            this.dgvPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvPrincipal.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(544, 501);
            this.dgvPrincipal.TabIndex = 4;
            this.dgvPrincipal.TabStop = false;
            // 
            // ColCodAluno
            // 
            this.ColCodAluno.DataPropertyName = "Cod_Aluno";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "#,##0";
            this.ColCodAluno.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColCodAluno.HeaderText = "Código";
            this.ColCodAluno.Name = "ColCodAluno";
            this.ColCodAluno.ReadOnly = true;
            this.ColCodAluno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColNomeAluno
            // 
            this.ColNomeAluno.DataPropertyName = "Nome_Aluno";
            this.ColNomeAluno.HeaderText = "Nome do Aluno";
            this.ColNomeAluno.Name = "ColNomeAluno";
            this.ColNomeAluno.ReadOnly = true;
            this.ColNomeAluno.Width = 370;
            // 
            // prgbStatus
            // 
            this.prgbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prgbStatus.Location = new System.Drawing.Point(15, 676);
            this.prgbStatus.Name = "prgbStatus";
            this.prgbStatus.Size = new System.Drawing.Size(544, 23);
            this.prgbStatus.Step = 1;
            this.prgbStatus.TabIndex = 13;
            // 
            // FrmCarnezinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 788);
            this.Controls.Add(this.pnlCarnezinho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarnezinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geração de Carnet\'s Promocionais";
            this.Load += new System.EventHandler(this.FrmCarnezinho_Load);
            this.pnlCarnezinho.ResumeLayout(false);
            this.pnlCarnezinho.PerformLayout();
            this.gbpParcelas.ResumeLayout(false);
            this.gbpParcelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeMensalidae)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCarnezinho;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomeAluno;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.Label lblInstrucao2;
        private System.Windows.Forms.GroupBox gbpParcelas;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.NumericUpDown nudQtdeMensalidae;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.ProgressBar prgbStatus;
    }
}