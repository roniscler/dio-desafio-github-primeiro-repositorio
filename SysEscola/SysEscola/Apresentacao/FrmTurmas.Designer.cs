namespace Apresentacao
{
    partial class FrmTurmas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurmas));
            this.txtNome_Turma = new System.Windows.Forms.TextBox();
            this.lblNome_Turma = new System.Windows.Forms.Label();
            this.lblAno_Letivo = new System.Windows.Forms.Label();
            this.txtANo_Letivo = new System.Windows.Forms.TextBox();
            this.lblNr_Sala = new System.Windows.Forms.Label();
            this.txtNr_Sala = new System.Windows.Forms.TextBox();
            this.cmbCod_Serie = new System.Windows.Forms.ComboBox();
            this.lblCod_Serie = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.pnlAtivoInativo = new System.Windows.Forms.Panel();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtiva = new System.Windows.Forms.RadioButton();
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.Cod_Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAno_Letivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNr_Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCod_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDesativada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTurmasCadastradas = new System.Windows.Forms.Label();
            this.btnProfessoresDaTurma = new System.Windows.Forms.Button();
            this.btnAlunosDaTurma = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod_Turma = new System.Windows.Forms.TextBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.pnlAtivoInativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome_Turma
            // 
            this.txtNome_Turma.Location = new System.Drawing.Point(17, 34);
            this.txtNome_Turma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome_Turma.MaxLength = 45;
            this.txtNome_Turma.Name = "txtNome_Turma";
            this.txtNome_Turma.Size = new System.Drawing.Size(339, 26);
            this.txtNome_Turma.TabIndex = 0;
            // 
            // lblNome_Turma
            // 
            this.lblNome_Turma.AutoSize = true;
            this.lblNome_Turma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_Turma.Location = new System.Drawing.Point(13, 9);
            this.lblNome_Turma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome_Turma.Name = "lblNome_Turma";
            this.lblNome_Turma.Size = new System.Drawing.Size(122, 20);
            this.lblNome_Turma.TabIndex = 1;
            this.lblNome_Turma.Text = "Nome da Turma";
            // 
            // lblAno_Letivo
            // 
            this.lblAno_Letivo.AutoSize = true;
            this.lblAno_Letivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno_Letivo.Location = new System.Drawing.Point(360, 9);
            this.lblAno_Letivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAno_Letivo.Name = "lblAno_Letivo";
            this.lblAno_Letivo.Size = new System.Drawing.Size(84, 20);
            this.lblAno_Letivo.TabIndex = 3;
            this.lblAno_Letivo.Text = "Ano Letivo";
            // 
            // txtANo_Letivo
            // 
            this.txtANo_Letivo.Location = new System.Drawing.Point(364, 34);
            this.txtANo_Letivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtANo_Letivo.MaxLength = 4;
            this.txtANo_Letivo.Name = "txtANo_Letivo";
            this.txtANo_Letivo.Size = new System.Drawing.Size(80, 26);
            this.txtANo_Letivo.TabIndex = 1;
            this.txtANo_Letivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNr_Sala
            // 
            this.lblNr_Sala.AutoSize = true;
            this.lblNr_Sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNr_Sala.Location = new System.Drawing.Point(448, 9);
            this.lblNr_Sala.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNr_Sala.Name = "lblNr_Sala";
            this.lblNr_Sala.Size = new System.Drawing.Size(84, 20);
            this.lblNr_Sala.TabIndex = 5;
            this.lblNr_Sala.Text = "Nº da Sala";
            // 
            // txtNr_Sala
            // 
            this.txtNr_Sala.Location = new System.Drawing.Point(452, 34);
            this.txtNr_Sala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNr_Sala.MaxLength = 4;
            this.txtNr_Sala.Name = "txtNr_Sala";
            this.txtNr_Sala.Size = new System.Drawing.Size(80, 26);
            this.txtNr_Sala.TabIndex = 2;
            this.txtNr_Sala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbCod_Serie
            // 
            this.cmbCod_Serie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCod_Serie.FormattingEnabled = true;
            this.cmbCod_Serie.Location = new System.Drawing.Point(17, 88);
            this.cmbCod_Serie.Name = "cmbCod_Serie";
            this.cmbCod_Serie.Size = new System.Drawing.Size(285, 28);
            this.cmbCod_Serie.TabIndex = 3;
            // 
            // lblCod_Serie
            // 
            this.lblCod_Serie.AutoSize = true;
            this.lblCod_Serie.Location = new System.Drawing.Point(13, 65);
            this.lblCod_Serie.Name = "lblCod_Serie";
            this.lblCod_Serie.Size = new System.Drawing.Size(46, 20);
            this.lblCod_Serie.TabIndex = 7;
            this.lblCod_Serie.Text = "Série";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(13, 126);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(94, 20);
            this.lblObservacao.TabIndex = 9;
            this.lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(17, 151);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservacao.MaxLength = 20;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(515, 26);
            this.txtObservacao.TabIndex = 5;
            // 
            // pnlAtivoInativo
            // 
            this.pnlAtivoInativo.BackColor = System.Drawing.Color.Teal;
            this.pnlAtivoInativo.Controls.Add(this.rdbInativo);
            this.pnlAtivoInativo.Controls.Add(this.rdbAtiva);
            this.pnlAtivoInativo.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlAtivoInativo.Location = new System.Drawing.Point(329, 71);
            this.pnlAtivoInativo.Name = "pnlAtivoInativo";
            this.pnlAtivoInativo.Size = new System.Drawing.Size(202, 65);
            this.pnlAtivoInativo.TabIndex = 4;
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Checked = true;
            this.rdbInativo.Location = new System.Drawing.Point(118, 21);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(74, 24);
            this.rdbInativo.TabIndex = 1;
            this.rdbInativo.TabStop = true;
            this.rdbInativo.Text = "Inativa";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtiva
            // 
            this.rdbAtiva.AutoSize = true;
            this.rdbAtiva.Location = new System.Drawing.Point(24, 21);
            this.rdbAtiva.Name = "rdbAtiva";
            this.rdbAtiva.Size = new System.Drawing.Size(62, 24);
            this.rdbAtiva.TabIndex = 0;
            this.rdbAtiva.Text = "Ativa";
            this.rdbAtiva.UseVisualStyleBackColor = true;
            // 
            // dgvTurma
            // 
            this.dgvTurma.AllowUserToAddRows = false;
            this.dgvTurma.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Turma,
            this.clmnNome_Turma,
            this.clmnAno_Letivo,
            this.clmnNr_Sala,
            this.clmnCod_Serie,
            this.clmnObservacao,
            this.clmnDesativada});
            this.dgvTurma.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTurma.Location = new System.Drawing.Point(18, 332);
            this.dgvTurma.MultiSelect = false;
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.ReadOnly = true;
            this.dgvTurma.RowHeadersVisible = false;
            this.dgvTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurma.Size = new System.Drawing.Size(514, 372);
            this.dgvTurma.TabIndex = 18;
            this.dgvTurma.TabStop = false;
            // 
            // Cod_Turma
            // 
            this.Cod_Turma.DataPropertyName = "Cod_Turma";
            this.Cod_Turma.HeaderText = "clmnCod_Turma";
            this.Cod_Turma.Name = "Cod_Turma";
            this.Cod_Turma.ReadOnly = true;
            this.Cod_Turma.Visible = false;
            // 
            // clmnNome_Turma
            // 
            this.clmnNome_Turma.DataPropertyName = "Nome_Turma";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmnNome_Turma.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmnNome_Turma.HeaderText = "Nome da Turma";
            this.clmnNome_Turma.Name = "clmnNome_Turma";
            this.clmnNome_Turma.ReadOnly = true;
            this.clmnNome_Turma.Width = 294;
            // 
            // clmnAno_Letivo
            // 
            this.clmnAno_Letivo.DataPropertyName = "Ano_Letivo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnAno_Letivo.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmnAno_Letivo.HeaderText = "Ano Letivo";
            this.clmnAno_Letivo.Name = "clmnAno_Letivo";
            this.clmnAno_Letivo.ReadOnly = true;
            // 
            // clmnNr_Sala
            // 
            this.clmnNr_Sala.DataPropertyName = "Nr_Sala";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnNr_Sala.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmnNr_Sala.HeaderText = "Nº da Sala";
            this.clmnNr_Sala.Name = "clmnNr_Sala";
            this.clmnNr_Sala.ReadOnly = true;
            // 
            // clmnCod_Serie
            // 
            this.clmnCod_Serie.DataPropertyName = "Cod_Serie";
            this.clmnCod_Serie.HeaderText = "Serie";
            this.clmnCod_Serie.Name = "clmnCod_Serie";
            this.clmnCod_Serie.ReadOnly = true;
            this.clmnCod_Serie.Visible = false;
            // 
            // clmnObservacao
            // 
            this.clmnObservacao.DataPropertyName = "Observacao";
            this.clmnObservacao.HeaderText = "Obseervação";
            this.clmnObservacao.Name = "clmnObservacao";
            this.clmnObservacao.ReadOnly = true;
            this.clmnObservacao.Visible = false;
            // 
            // clmnDesativada
            // 
            this.clmnDesativada.DataPropertyName = "Desativada";
            this.clmnDesativada.HeaderText = "Desativada";
            this.clmnDesativada.Name = "clmnDesativada";
            this.clmnDesativada.ReadOnly = true;
            this.clmnDesativada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnDesativada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnDesativada.Visible = false;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInserir.Location = new System.Drawing.Point(141, 711);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(122, 47);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(265, 711);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(122, 47);
            this.btnAlterar.TabIndex = 42;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(17, 711);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(122, 47);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(409, 711);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(122, 47);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTurmasCadastradas
            // 
            this.lblTurmasCadastradas.AutoSize = true;
            this.lblTurmasCadastradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurmasCadastradas.Location = new System.Drawing.Point(14, 309);
            this.lblTurmasCadastradas.Name = "lblTurmasCadastradas";
            this.lblTurmasCadastradas.Size = new System.Drawing.Size(175, 20);
            this.lblTurmasCadastradas.TabIndex = 45;
            this.lblTurmasCadastradas.Text = "Turmas Cadastradas";
            // 
            // btnProfessoresDaTurma
            // 
            this.btnProfessoresDaTurma.Enabled = false;
            this.btnProfessoresDaTurma.Image = ((System.Drawing.Image)(resources.GetObject("btnProfessoresDaTurma.Image")));
            this.btnProfessoresDaTurma.Location = new System.Drawing.Point(195, 185);
            this.btnProfessoresDaTurma.Name = "btnProfessoresDaTurma";
            this.btnProfessoresDaTurma.Size = new System.Drawing.Size(172, 55);
            this.btnProfessoresDaTurma.TabIndex = 46;
            this.btnProfessoresDaTurma.TabStop = false;
            this.btnProfessoresDaTurma.Text = "Administrar Professores (F6)";
            this.btnProfessoresDaTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfessoresDaTurma.UseVisualStyleBackColor = true;
            this.btnProfessoresDaTurma.Click += new System.EventHandler(this.btnProfessoresDaTurma_Click);
            // 
            // btnAlunosDaTurma
            // 
            this.btnAlunosDaTurma.Enabled = false;
            this.btnAlunosDaTurma.Image = ((System.Drawing.Image)(resources.GetObject("btnAlunosDaTurma.Image")));
            this.btnAlunosDaTurma.Location = new System.Drawing.Point(17, 185);
            this.btnAlunosDaTurma.Name = "btnAlunosDaTurma";
            this.btnAlunosDaTurma.Size = new System.Drawing.Size(172, 55);
            this.btnAlunosDaTurma.TabIndex = 47;
            this.btnAlunosDaTurma.TabStop = false;
            this.btnAlunosDaTurma.Text = "Administrar Alunos (F5)";
            this.btnAlunosDaTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlunosDaTurma.UseVisualStyleBackColor = true;
            this.btnAlunosDaTurma.Click += new System.EventHandler(this.btnAlunosDaTurma_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(18, 280);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(362, 26);
            this.txtPesquisar.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisar.Location = new System.Drawing.Point(399, 267);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(132, 39);
            this.btnPesquisar.TabIndex = 50;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Text = " Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Para localizar uma turma digite o nome e clique em pesquisar";
            // 
            // txtCod_Turma
            // 
            this.txtCod_Turma.Location = new System.Drawing.Point(215, -11);
            this.txtCod_Turma.Name = "txtCod_Turma";
            this.txtCod_Turma.Size = new System.Drawing.Size(100, 26);
            this.txtCod_Turma.TabIndex = 48;
            this.txtCod_Turma.Visible = false;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(380, 189);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(50, 20);
            this.lblTurno.TabIndex = 52;
            this.lblTurno.Text = "Turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(384, 212);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(148, 28);
            this.cmbTurno.TabIndex = 53;
            // 
            // FrmTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 771);
            this.ControlBox = false;
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtCod_Turma);
            this.Controls.Add(this.btnAlunosDaTurma);
            this.Controls.Add(this.btnProfessoresDaTurma);
            this.Controls.Add(this.lblTurmasCadastradas);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvTurma);
            this.Controls.Add(this.pnlAtivoInativo);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblCod_Serie);
            this.Controls.Add(this.cmbCod_Serie);
            this.Controls.Add(this.lblNr_Sala);
            this.Controls.Add(this.txtNr_Sala);
            this.Controls.Add(this.lblAno_Letivo);
            this.Controls.Add(this.txtANo_Letivo);
            this.Controls.Add(this.lblNome_Turma);
            this.Controls.Add(this.txtNome_Turma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Turmas";
            this.Load += new System.EventHandler(this.FrmTurmas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTurmas_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmTurmas_KeyUp);
            this.pnlAtivoInativo.ResumeLayout(false);
            this.pnlAtivoInativo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome_Turma;
        private System.Windows.Forms.Label lblNome_Turma;
        private System.Windows.Forms.Label lblAno_Letivo;
        private System.Windows.Forms.TextBox txtANo_Letivo;
        private System.Windows.Forms.Label lblNr_Sala;
        private System.Windows.Forms.TextBox txtNr_Sala;
        private System.Windows.Forms.ComboBox cmbCod_Serie;
        private System.Windows.Forms.Label lblCod_Serie;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Panel pnlAtivoInativo;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtiva;
        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTurmasCadastradas;
        private System.Windows.Forms.Button btnProfessoresDaTurma;
        private System.Windows.Forms.Button btnAlunosDaTurma;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod_Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAno_Letivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNr_Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnObservacao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnDesativada;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbTurno;
    }
}