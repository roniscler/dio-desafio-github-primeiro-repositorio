namespace Apresentacao
{
    partial class FrmLancamentoNota
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLancamentoNota));
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeTurma = new System.Windows.Forms.Label();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.cmbAluno = new System.Windows.Forms.ComboBox();
            this.lblNomeBim = new System.Windows.Forms.Label();
            this.cmbBimestre = new System.Windows.Forms.ComboBox();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvLancamentoNota = new System.Windows.Forms.DataGridView();
            this.clmnCod_Lancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Bim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNomeMateria = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCabecalho.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentoNota)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlCabecalho.Location = new System.Drawing.Point(5, 10);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(1077, 110);
            this.pnlCabecalho.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(702, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Selecione um aluno e uma turma e depois clique em \"Consultar\" para obter suas not" +
    "as";
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
            this.pnlDataGrid.Controls.Add(this.dgvLancamentoNota);
            this.pnlDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDataGrid.Location = new System.Drawing.Point(2, 224);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Size = new System.Drawing.Size(1083, 535);
            this.pnlDataGrid.TabIndex = 22;
            // 
            // dgvLancamentoNota
            // 
            this.dgvLancamentoNota.AllowUserToAddRows = false;
            this.dgvLancamentoNota.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLancamentoNota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLancamentoNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLancamentoNota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCod_Lancamento,
            this.clmnNome_Aluno,
            this.clmnNome_Turma,
            this.clmnNome_Materia,
            this.clmnNome_Bim,
            this.clmnNota});
            this.dgvLancamentoNota.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLancamentoNota.Location = new System.Drawing.Point(0, 3);
            this.dgvLancamentoNota.Name = "dgvLancamentoNota";
            this.dgvLancamentoNota.ReadOnly = true;
            this.dgvLancamentoNota.RowHeadersVisible = false;
            this.dgvLancamentoNota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLancamentoNota.Size = new System.Drawing.Size(1080, 529);
            this.dgvLancamentoNota.TabIndex = 14;
            this.dgvLancamentoNota.TabStop = false;
            // 
            // clmnCod_Lancamento
            // 
            this.clmnCod_Lancamento.DataPropertyName = "Cod_Lancamento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnCod_Lancamento.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.clmnNome_Aluno.Width = 300;
            // 
            // clmnNome_Turma
            // 
            this.clmnNome_Turma.DataPropertyName = "Nome_Turma";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnNome_Turma.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmnNome_Turma.HeaderText = "Nome da Turma";
            this.clmnNome_Turma.Name = "clmnNome_Turma";
            this.clmnNome_Turma.ReadOnly = true;
            this.clmnNome_Turma.Width = 250;
            // 
            // clmnNome_Materia
            // 
            this.clmnNome_Materia.DataPropertyName = "Nome_Materia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnNome_Materia.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmnNome_Materia.HeaderText = "Nome da Materia";
            this.clmnNome_Materia.Name = "clmnNome_Materia";
            this.clmnNome_Materia.ReadOnly = true;
            this.clmnNome_Materia.Width = 250;
            // 
            // clmnNome_Bim
            // 
            this.clmnNome_Bim.DataPropertyName = "Nome_Bim";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnNome_Bim.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmnNome_Bim.HeaderText = "Nome do Bimestre";
            this.clmnNome_Bim.Name = "clmnNome_Bim";
            this.clmnNome_Bim.ReadOnly = true;
            this.clmnNome_Bim.Width = 130;
            // 
            // clmnNota
            // 
            this.clmnNota.DataPropertyName = "Nota";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmnNota.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmnNota.HeaderText = "Nota";
            this.clmnNota.Name = "clmnNota";
            this.clmnNota.ReadOnly = true;
            this.clmnNota.Width = 130;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(1092, 708);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(143, 51);
            this.btnFechar.TabIndex = 21;
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
            this.btnConsultar.Location = new System.Drawing.Point(1092, 424);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(143, 51);
            this.btnConsultar.TabIndex = 20;
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
            this.btnExcluir.Location = new System.Drawing.Point(1092, 637);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(143, 51);
            this.btnExcluir.TabIndex = 19;
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
            this.btnAlterar.Location = new System.Drawing.Point(1092, 566);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(143, 51);
            this.btnAlterar.TabIndex = 18;
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
            this.btnInserir.Location = new System.Drawing.Point(1092, 495);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(143, 51);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblNomeMateria);
            this.panel1.Controls.Add(this.cmbMateria);
            this.panel1.Controls.Add(this.lblNota);
            this.panel1.Controls.Add(this.txtNota);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(5, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 73);
            this.panel1.TabIndex = 14;
            // 
            // lblNomeMateria
            // 
            this.lblNomeMateria.AutoSize = true;
            this.lblNomeMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMateria.Location = new System.Drawing.Point(10, 5);
            this.lblNomeMateria.Name = "lblNomeMateria";
            this.lblNomeMateria.Size = new System.Drawing.Size(62, 20);
            this.lblNomeMateria.TabIndex = 17;
            this.lblNomeMateria.Text = "Matéria";
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(10, 28);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(322, 28);
            this.cmbMateria.TabIndex = 14;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(334, 3);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(43, 20);
            this.lblNota.TabIndex = 16;
            this.lblNota.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(338, 29);
            this.txtNota.MaxLength = 35;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(132, 26);
            this.txtNota.TabIndex = 15;
            this.txtNota.Leave += new System.EventHandler(this.txtNota_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(1, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "NOTAS LANÇADAS NO SISTEMA";
            // 
            // FrmLancamentoNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
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
            this.Name = "FrmLancamentoNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Notas";
            this.Load += new System.EventHandler(this.FrmLancamentoNota_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLancamentoNota_KeyDown);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentoNota)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblNomeBim;
        private System.Windows.Forms.ComboBox cmbBimestre;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvLancamentoNota;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblNomeTurma;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNomeMateria;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Lancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Bim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNota;
    }
}