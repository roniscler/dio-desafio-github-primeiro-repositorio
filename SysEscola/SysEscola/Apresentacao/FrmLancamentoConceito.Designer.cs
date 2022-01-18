namespace Apresentacao
{
    partial class FrmLancamentoConceito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLancamentoConceito));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConceito = new System.Windows.Forms.Label();
            this.lblSI_Aval_Pedag = new System.Windows.Forms.Label();
            this.cmbConceito = new System.Windows.Forms.ComboBox();
            this.cmbSI_Aval_Pedag = new System.Windows.Forms.ComboBox();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeTurma = new System.Windows.Forms.Label();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.cmbAluno = new System.Windows.Forms.ComboBox();
            this.lblNomeBim = new System.Windows.Forms.Label();
            this.cmbBimestre = new System.Windows.Forms.ComboBox();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvLancamentoConceito = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.clmnCod_Lancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Bim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentoConceito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(8, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "NOTAS LANÇADAS NO SISTEMA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblConceito);
            this.panel1.Controls.Add(this.lblSI_Aval_Pedag);
            this.panel1.Controls.Add(this.cmbConceito);
            this.panel1.Controls.Add(this.cmbSI_Aval_Pedag);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(12, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 73);
            this.panel1.TabIndex = 26;
            // 
            // lblConceito
            // 
            this.lblConceito.AutoSize = true;
            this.lblConceito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConceito.Location = new System.Drawing.Point(343, 5);
            this.lblConceito.Name = "lblConceito";
            this.lblConceito.Size = new System.Drawing.Size(72, 20);
            this.lblConceito.TabIndex = 20;
            this.lblConceito.Text = "Conceito";
            // 
            // lblSI_Aval_Pedag
            // 
            this.lblSI_Aval_Pedag.AutoSize = true;
            this.lblSI_Aval_Pedag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSI_Aval_Pedag.Location = new System.Drawing.Point(10, 5);
            this.lblSI_Aval_Pedag.Name = "lblSI_Aval_Pedag";
            this.lblSI_Aval_Pedag.Size = new System.Drawing.Size(256, 20);
            this.lblSI_Aval_Pedag.TabIndex = 17;
            this.lblSI_Aval_Pedag.Text = "Sub Ítem de Avaliação Pedagógica";
            // 
            // cmbConceito
            // 
            this.cmbConceito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConceito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConceito.FormattingEnabled = true;
            this.cmbConceito.Location = new System.Drawing.Point(343, 28);
            this.cmbConceito.Name = "cmbConceito";
            this.cmbConceito.Size = new System.Drawing.Size(247, 28);
            this.cmbConceito.TabIndex = 19;
            // 
            // cmbSI_Aval_Pedag
            // 
            this.cmbSI_Aval_Pedag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSI_Aval_Pedag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSI_Aval_Pedag.FormattingEnabled = true;
            this.cmbSI_Aval_Pedag.Location = new System.Drawing.Point(10, 28);
            this.cmbSI_Aval_Pedag.Name = "cmbSI_Aval_Pedag";
            this.cmbSI_Aval_Pedag.Size = new System.Drawing.Size(322, 28);
            this.cmbSI_Aval_Pedag.TabIndex = 14;
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.Teal;
            this.pnlCabecalho.Controls.Add(this.label2);
            this.pnlCabecalho.Controls.Add(this.lblNomeTurma);
            this.pnlCabecalho.Controls.Add(this.cmbTurma);
            this.pnlCabecalho.Controls.Add(this.lblNomeAluno);
            this.pnlCabecalho.Controls.Add(this.cmbAluno);
            this.pnlCabecalho.Controls.Add(this.lblNomeBim);
            this.pnlCabecalho.Controls.Add(this.cmbBimestre);
            this.pnlCabecalho.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlCabecalho.Location = new System.Drawing.Point(12, 12);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(1077, 110);
            this.pnlCabecalho.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(746, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Selecione um aluno e uma turma e depois  clique em \"Consultar\" para obter suas av" +
    "aliações";
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTurma.Location = new System.Drawing.Point(375, 17);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(54, 20);
            this.lblNomeTurma.TabIndex = 11;
            this.lblNomeTurma.Text = "Turma";
            // 
            // cmbTurma
            // 
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(375, 40);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(359, 28);
            this.cmbTurma.TabIndex = 1;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.Location = new System.Drawing.Point(10, 17);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(50, 20);
            this.lblNomeAluno.TabIndex = 9;
            this.lblNomeAluno.Text = "Aluno";
            // 
            // cmbAluno
            // 
            this.cmbAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAluno.FormattingEnabled = true;
            this.cmbAluno.Location = new System.Drawing.Point(10, 40);
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.Size = new System.Drawing.Size(359, 28);
            this.cmbAluno.TabIndex = 0;
            // 
            // lblNomeBim
            // 
            this.lblNomeBim.AutoSize = true;
            this.lblNomeBim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeBim.Location = new System.Drawing.Point(740, 17);
            this.lblNomeBim.Name = "lblNomeBim";
            this.lblNomeBim.Size = new System.Drawing.Size(72, 20);
            this.lblNomeBim.TabIndex = 2;
            this.lblNomeBim.Text = "Bimestre";
            // 
            // cmbBimestre
            // 
            this.cmbBimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBimestre.FormattingEnabled = true;
            this.cmbBimestre.Location = new System.Drawing.Point(740, 40);
            this.cmbBimestre.Name = "cmbBimestre";
            this.cmbBimestre.Size = new System.Drawing.Size(142, 28);
            this.cmbBimestre.TabIndex = 2;
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.Controls.Add(this.dgvLancamentoConceito);
            this.pnlDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDataGrid.Location = new System.Drawing.Point(9, 226);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Size = new System.Drawing.Size(1083, 535);
            this.pnlDataGrid.TabIndex = 31;
            // 
            // dgvLancamentoConceito
            // 
            this.dgvLancamentoConceito.AllowUserToAddRows = false;
            this.dgvLancamentoConceito.AllowUserToDeleteRows = false;
            this.dgvLancamentoConceito.AllowUserToResizeColumns = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLancamentoConceito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvLancamentoConceito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLancamentoConceito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCod_Lancamento,
            this.clmnNome_Aluno,
            this.clmnNome_Turma,
            this.clmnNome_Materia,
            this.clmnNome_Bim,
            this.clmnNota});
            this.dgvLancamentoConceito.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLancamentoConceito.Location = new System.Drawing.Point(0, 3);
            this.dgvLancamentoConceito.Name = "dgvLancamentoConceito";
            this.dgvLancamentoConceito.ReadOnly = true;
            this.dgvLancamentoConceito.RowHeadersVisible = false;
            this.dgvLancamentoConceito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLancamentoConceito.Size = new System.Drawing.Size(1080, 529);
            this.dgvLancamentoConceito.TabIndex = 14;
            this.dgvLancamentoConceito.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(1099, 710);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(143, 51);
            this.btnFechar.TabIndex = 30;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConsultar.Location = new System.Drawing.Point(1099, 426);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(143, 51);
            this.btnConsultar.TabIndex = 29;
            this.btnConsultar.TabStop = false;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluir.Location = new System.Drawing.Point(1099, 639);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(143, 51);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(1099, 568);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(143, 51);
            this.btnAlterar.TabIndex = 27;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInserir.Location = new System.Drawing.Point(1099, 497);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(143, 51);
            this.btnInserir.TabIndex = 25;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // clmnCod_Lancamento
            // 
            this.clmnCod_Lancamento.DataPropertyName = "Cod_Lancamento";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnCod_Lancamento.DefaultCellStyle = dataGridViewCellStyle14;
            this.clmnCod_Lancamento.HeaderText = "Cod_Lancamento";
            this.clmnCod_Lancamento.Name = "clmnCod_Lancamento";
            this.clmnCod_Lancamento.ReadOnly = true;
            this.clmnCod_Lancamento.Visible = false;
            // 
            // clmnNome_Aluno
            // 
            this.clmnNome_Aluno.DataPropertyName = "Nome_Aluno";
            this.clmnNome_Aluno.HeaderText = "Nome do Aluno";
            this.clmnNome_Aluno.Name = "clmnNome_Aluno";
            this.clmnNome_Aluno.ReadOnly = true;
            this.clmnNome_Aluno.Width = 280;
            // 
            // clmnNome_Turma
            // 
            this.clmnNome_Turma.DataPropertyName = "Nome_Turma";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnNome_Turma.DefaultCellStyle = dataGridViewCellStyle15;
            this.clmnNome_Turma.HeaderText = "Nome da Turma";
            this.clmnNome_Turma.Name = "clmnNome_Turma";
            this.clmnNome_Turma.ReadOnly = true;
            this.clmnNome_Turma.Width = 250;
            // 
            // clmnNome_Materia
            // 
            this.clmnNome_Materia.DataPropertyName = "Desc_SI_Aval_Pedag";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnNome_Materia.DefaultCellStyle = dataGridViewCellStyle16;
            this.clmnNome_Materia.HeaderText = "Item Avaliado";
            this.clmnNome_Materia.Name = "clmnNome_Materia";
            this.clmnNome_Materia.ReadOnly = true;
            this.clmnNome_Materia.Width = 250;
            // 
            // clmnNome_Bim
            // 
            this.clmnNome_Bim.DataPropertyName = "Nome_Bim";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnNome_Bim.DefaultCellStyle = dataGridViewCellStyle17;
            this.clmnNome_Bim.HeaderText = "Nome do Bimestre";
            this.clmnNome_Bim.Name = "clmnNome_Bim";
            this.clmnNome_Bim.ReadOnly = true;
            this.clmnNome_Bim.Width = 80;
            // 
            // clmnNota
            // 
            this.clmnNota.DataPropertyName = "Desc_Conceito";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnNota.DefaultCellStyle = dataGridViewCellStyle18;
            this.clmnNota.HeaderText = "Conceito";
            this.clmnNota.Name = "clmnNota";
            this.clmnNota.ReadOnly = true;
            this.clmnNota.Width = 200;
            // 
            // FrmLancamentoConceito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 771);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLancamentoConceito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lancamneto de Conceitos";
            this.Load += new System.EventHandler(this.FrmLancamentoConceito_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLancamentoConceito_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentoConceito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSI_Aval_Pedag;
        private System.Windows.Forms.ComboBox cmbSI_Aval_Pedag;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomeTurma;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.Label lblNomeBim;
        private System.Windows.Forms.ComboBox cmbBimestre;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvLancamentoConceito;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblConceito;
        private System.Windows.Forms.ComboBox cmbConceito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Lancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Bim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNota;
    }
}