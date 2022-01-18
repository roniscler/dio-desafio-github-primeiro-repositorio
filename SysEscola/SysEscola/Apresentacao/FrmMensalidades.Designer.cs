namespace Apresentacao
{
    partial class FrmMensalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMensalidades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbAluno = new System.Windows.Forms.ComboBox();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.pnlSelecao = new System.Windows.Forms.Panel();
            this.btConsultar = new System.Windows.Forms.Button();
            this.lblQtdeMensalidade = new System.Windows.Forms.Label();
            this.nudQtdeMensalidae = new System.Windows.Forms.NumericUpDown();
            this.lblPlano = new System.Windows.Forms.Label();
            this.cmbPlano = new System.Windows.Forms.ComboBox();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.btnAlterarMensalidade = new System.Windows.Forms.Button();
            this.btnExcluirHabitos = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvMensalidade = new System.Windows.Forms.DataGridView();
            this.clmnCod_Mensalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCodTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCod_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNumMensalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnValorJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnValorMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeraCarnet = new System.Windows.Forms.Button();
            this.ppvCarnet = new System.Windows.Forms.PrintPreviewDialog();
            this.carnet = new System.Drawing.Printing.PrintDocument();
            this.pnlSelecao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeMensalidae)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensalidade)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAluno
            // 
            this.cmbAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAluno.FormattingEnabled = true;
            this.cmbAluno.Location = new System.Drawing.Point(16, 33);
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.Size = new System.Drawing.Size(336, 26);
            this.cmbAluno.TabIndex = 0;
            // 
            // cmbTurma
            // 
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(358, 33);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(238, 26);
            this.cmbTurma.TabIndex = 1;
            // 
            // pnlSelecao
            // 
            this.pnlSelecao.BackColor = System.Drawing.Color.Teal;
            this.pnlSelecao.Controls.Add(this.btConsultar);
            this.pnlSelecao.Controls.Add(this.lblQtdeMensalidade);
            this.pnlSelecao.Controls.Add(this.nudQtdeMensalidae);
            this.pnlSelecao.Controls.Add(this.lblPlano);
            this.pnlSelecao.Controls.Add(this.cmbPlano);
            this.pnlSelecao.Controls.Add(this.lblDataInicial);
            this.pnlSelecao.Controls.Add(this.dtpDataInicial);
            this.pnlSelecao.Controls.Add(this.btnSalvar);
            this.pnlSelecao.Controls.Add(this.lblAluno);
            this.pnlSelecao.Controls.Add(this.lblTurma);
            this.pnlSelecao.Controls.Add(this.cmbTurma);
            this.pnlSelecao.Controls.Add(this.cmbAluno);
            this.pnlSelecao.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlSelecao.Location = new System.Drawing.Point(12, 12);
            this.pnlSelecao.Name = "pnlSelecao";
            this.pnlSelecao.Size = new System.Drawing.Size(814, 147);
            this.pnlSelecao.TabIndex = 2;
            // 
            // btConsultar
            // 
            this.btConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.ForeColor = System.Drawing.Color.Teal;
            this.btConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btConsultar.Image")));
            this.btConsultar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btConsultar.Location = new System.Drawing.Point(611, 25);
            this.btConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(186, 53);
            this.btConsultar.TabIndex = 10;
            this.btConsultar.Text = "Consultar Mensalidades";
            this.btConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // lblQtdeMensalidade
            // 
            this.lblQtdeMensalidade.AutoSize = true;
            this.lblQtdeMensalidade.Location = new System.Drawing.Point(510, 75);
            this.lblQtdeMensalidade.Name = "lblQtdeMensalidade";
            this.lblQtdeMensalidade.Size = new System.Drawing.Size(44, 20);
            this.lblQtdeMensalidade.TabIndex = 9;
            this.lblQtdeMensalidade.Text = "Qtde";
            // 
            // nudQtdeMensalidae
            // 
            this.nudQtdeMensalidae.Location = new System.Drawing.Point(514, 98);
            this.nudQtdeMensalidae.Name = "nudQtdeMensalidae";
            this.nudQtdeMensalidae.Size = new System.Drawing.Size(82, 26);
            this.nudQtdeMensalidae.TabIndex = 8;
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Location = new System.Drawing.Point(12, 73);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(124, 20);
            this.lblPlano.TabIndex = 7;
            this.lblPlano.Text = "Plano Estudantil";
            // 
            // cmbPlano
            // 
            this.cmbPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlano.FormattingEnabled = true;
            this.cmbPlano.Location = new System.Drawing.Point(16, 98);
            this.cmbPlano.Name = "cmbPlano";
            this.cmbPlano.Size = new System.Drawing.Size(336, 26);
            this.cmbPlano.TabIndex = 6;
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(354, 75);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(88, 20);
            this.lblDataInicial.TabIndex = 5;
            this.lblDataInicial.Text = "Data Inicial";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(358, 98);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(150, 26);
            this.dtpDataInicial.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Teal;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(611, 85);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(186, 49);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Gerar Mensalidades";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(12, 10);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(50, 20);
            this.lblAluno.TabIndex = 3;
            this.lblAluno.Text = "Aluno";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(354, 10);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(54, 20);
            this.lblTurma.TabIndex = 2;
            this.lblTurma.Text = "Turma";
            // 
            // btnAlterarMensalidade
            // 
            this.btnAlterarMensalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAlterarMensalidade.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarMensalidade.Image")));
            this.btnAlterarMensalidade.Location = new System.Drawing.Point(162, 14);
            this.btnAlterarMensalidade.Name = "btnAlterarMensalidade";
            this.btnAlterarMensalidade.Size = new System.Drawing.Size(153, 40);
            this.btnAlterarMensalidade.TabIndex = 9;
            this.btnAlterarMensalidade.Text = "Altera Mensalidade";
            this.btnAlterarMensalidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarMensalidade.UseVisualStyleBackColor = true;
            this.btnAlterarMensalidade.Click += new System.EventHandler(this.btnAlterarMensalidade_Click);
            // 
            // btnExcluirHabitos
            // 
            this.btnExcluirHabitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExcluirHabitos.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirHabitos.Image")));
            this.btnExcluirHabitos.Location = new System.Drawing.Point(3, 13);
            this.btnExcluirHabitos.Name = "btnExcluirHabitos";
            this.btnExcluirHabitos.Size = new System.Drawing.Size(153, 40);
            this.btnExcluirHabitos.TabIndex = 8;
            this.btnExcluirHabitos.Text = "Excluir da Lista";
            this.btnExcluirHabitos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirHabitos.UseVisualStyleBackColor = true;
            this.btnExcluirHabitos.Click += new System.EventHandler(this.btnExcluirHabitos_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(683, 731);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(143, 51);
            this.btnFechar.TabIndex = 143;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvMensalidade
            // 
            this.dgvMensalidade.AllowUserToAddRows = false;
            this.dgvMensalidade.AllowUserToDeleteRows = false;
            this.dgvMensalidade.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMensalidade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMensalidade.ColumnHeadersHeight = 48;
            this.dgvMensalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMensalidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCod_Mensalidade,
            this.clmnCodTurma,
            this.clmnCod_Aluno,
            this.clmnNumMensalidade,
            this.clmnDataVencimento,
            this.clmnValor,
            this.clmnValorJuros,
            this.clmnValorMulta,
            this.clmnTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMensalidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMensalidade.Location = new System.Drawing.Point(3, 60);
            this.dgvMensalidade.Name = "dgvMensalidade";
            this.dgvMensalidade.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMensalidade.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMensalidade.RowHeadersVisible = false;
            this.dgvMensalidade.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMensalidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMensalidade.Size = new System.Drawing.Size(806, 496);
            this.dgvMensalidade.TabIndex = 144;
            // 
            // clmnCod_Mensalidade
            // 
            this.clmnCod_Mensalidade.DataPropertyName = "Cod_Mensalidade";
            this.clmnCod_Mensalidade.HeaderText = "Codigo Mensalidade";
            this.clmnCod_Mensalidade.Name = "clmnCod_Mensalidade";
            this.clmnCod_Mensalidade.ReadOnly = true;
            this.clmnCod_Mensalidade.Visible = false;
            // 
            // clmnCodTurma
            // 
            this.clmnCodTurma.DataPropertyName = "Cod_Turma";
            this.clmnCodTurma.HeaderText = "Codigo da Turma";
            this.clmnCodTurma.Name = "clmnCodTurma";
            this.clmnCodTurma.ReadOnly = true;
            this.clmnCodTurma.Visible = false;
            // 
            // clmnCod_Aluno
            // 
            this.clmnCod_Aluno.DataPropertyName = "Cod_Aluno";
            this.clmnCod_Aluno.HeaderText = "Codigo do Aluno";
            this.clmnCod_Aluno.Name = "clmnCod_Aluno";
            this.clmnCod_Aluno.ReadOnly = true;
            this.clmnCod_Aluno.Visible = false;
            // 
            // clmnNumMensalidade
            // 
            this.clmnNumMensalidade.DataPropertyName = "Num_Mensalidade";
            this.clmnNumMensalidade.HeaderText = "Mensalidade";
            this.clmnNumMensalidade.Name = "clmnNumMensalidade";
            this.clmnNumMensalidade.ReadOnly = true;
            this.clmnNumMensalidade.Width = 131;
            // 
            // clmnDataVencimento
            // 
            this.clmnDataVencimento.DataPropertyName = "DataVencimento";
            this.clmnDataVencimento.HeaderText = "data de Vencimento";
            this.clmnDataVencimento.Name = "clmnDataVencimento";
            this.clmnDataVencimento.ReadOnly = true;
            this.clmnDataVencimento.Width = 131;
            // 
            // clmnValor
            // 
            this.clmnValor.DataPropertyName = "Valor";
            this.clmnValor.HeaderText = "Valor";
            this.clmnValor.Name = "clmnValor";
            this.clmnValor.ReadOnly = true;
            this.clmnValor.Width = 131;
            // 
            // clmnValorJuros
            // 
            this.clmnValorJuros.DataPropertyName = "ValorJuros";
            this.clmnValorJuros.HeaderText = "Valor dos Juros";
            this.clmnValorJuros.Name = "clmnValorJuros";
            this.clmnValorJuros.ReadOnly = true;
            this.clmnValorJuros.Width = 131;
            // 
            // clmnValorMulta
            // 
            this.clmnValorMulta.DataPropertyName = "ValorMulta";
            this.clmnValorMulta.HeaderText = "Valor da Multa";
            this.clmnValorMulta.Name = "clmnValorMulta";
            this.clmnValorMulta.ReadOnly = true;
            this.clmnValorMulta.Width = 131;
            // 
            // clmnTotal
            // 
            this.clmnTotal.HeaderText = "Total";
            this.clmnTotal.Name = "clmnTotal";
            this.clmnTotal.ReadOnly = true;
            this.clmnTotal.Width = 134;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGeraCarnet);
            this.panel1.Controls.Add(this.dgvMensalidade);
            this.panel1.Controls.Add(this.btnExcluirHabitos);
            this.panel1.Controls.Add(this.btnAlterarMensalidade);
            this.panel1.Location = new System.Drawing.Point(12, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 559);
            this.panel1.TabIndex = 145;
            // 
            // btnGeraCarnet
            // 
            this.btnGeraCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraCarnet.Image = ((System.Drawing.Image)(resources.GetObject("btnGeraCarnet.Image")));
            this.btnGeraCarnet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeraCarnet.Location = new System.Drawing.Point(321, 14);
            this.btnGeraCarnet.Name = "btnGeraCarnet";
            this.btnGeraCarnet.Size = new System.Drawing.Size(187, 39);
            this.btnGeraCarnet.TabIndex = 145;
            this.btnGeraCarnet.Text = "Imprimir Mensalidades";
            this.btnGeraCarnet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeraCarnet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeraCarnet.UseVisualStyleBackColor = true;
            this.btnGeraCarnet.Click += new System.EventHandler(this.btnGerarCarnet_Click);
            // 
            // ppvCarnet
            // 
            this.ppvCarnet.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppvCarnet.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppvCarnet.ClientSize = new System.Drawing.Size(400, 300);
            this.ppvCarnet.Document = this.carnet;
            this.ppvCarnet.Enabled = true;
            this.ppvCarnet.Icon = ((System.Drawing.Icon)(resources.GetObject("ppvCarnet.Icon")));
            this.ppvCarnet.Name = "ppvCarnet";
            this.ppvCarnet.Visible = false;
            // 
            // carnet
            // 
            this.carnet.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.carnet_PrintPage);
            // 
            // FrmMensalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 785);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlSelecao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMensalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Mensalidades do Sistema";
            this.Load += new System.EventHandler(this.FrmGeraMensalidades_Load);
            this.pnlSelecao.ResumeLayout(false);
            this.pnlSelecao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeMensalidae)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensalidade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.Panel pnlSelecao;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.ComboBox cmbPlano;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.Button btnAlterarMensalidade;
        private System.Windows.Forms.Button btnExcluirHabitos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvMensalidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudQtdeMensalidae;
        private System.Windows.Forms.Label lblQtdeMensalidade;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Mensalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCodTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNumMensalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnValorJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnValorMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotal;
        private System.Windows.Forms.Button btnGeraCarnet;
        private System.Windows.Forms.PrintPreviewDialog ppvCarnet;
        private System.Drawing.Printing.PrintDocument carnet;
    }
}