namespace Apresentacao
{
    partial class FrmLivroDidatico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivroDidatico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.lblPnlPesquisa = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.lblNomeLivro = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lbldgvFornecedor = new System.Windows.Forms.Label();
            this.lblEdicao = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.dgvLIvro = new System.Windows.Forms.DataGridView();
            this.clmnCod_LIvro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEdicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmprestado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.chkEmprestado = new System.Windows.Forms.CheckBox();
            this.pnlEmprestado = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.btnEmprestimoLivro = new System.Windows.Forms.Button();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIvro)).BeginInit();
            this.pnlEmprestado.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlPesquisa.Controls.Add(this.lblPnlPesquisa);
            this.pnlPesquisa.Controls.Add(this.txtNomeLivro);
            this.pnlPesquisa.Controls.Add(this.lblNomeLivro);
            this.pnlPesquisa.Location = new System.Drawing.Point(12, 13);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(749, 75);
            this.pnlPesquisa.TabIndex = 0;
            // 
            // lblPnlPesquisa
            // 
            this.lblPnlPesquisa.AutoSize = true;
            this.lblPnlPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPnlPesquisa.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPnlPesquisa.Location = new System.Drawing.Point(134, 9);
            this.lblPnlPesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPnlPesquisa.Name = "lblPnlPesquisa";
            this.lblPnlPesquisa.Size = new System.Drawing.Size(429, 17);
            this.lblPnlPesquisa.TabIndex = 42;
            this.lblPnlPesquisa.Text = "Para localizar um fornecedor digite o nome e clique em \"Consultar\"";
            this.lblPnlPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(138, 34);
            this.txtNomeLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeLivro.MaxLength = 35;
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(406, 26);
            this.txtNomeLivro.TabIndex = 0;
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeLivro.Location = new System.Drawing.Point(82, 37);
            this.lblNomeLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(51, 20);
            this.lblNomeLivro.TabIndex = 41;
            this.lblNomeLivro.Text = "Nome";
            this.lblNomeLivro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(766, 635);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(143, 51);
            this.btnFechar.TabIndex = 137;
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
            this.btnConsultar.Location = new System.Drawing.Point(766, 415);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(143, 51);
            this.btnConsultar.TabIndex = 136;
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
            this.btnExcluir.Location = new System.Drawing.Point(766, 580);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(143, 51);
            this.btnExcluir.TabIndex = 135;
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
            this.btnAlterar.Location = new System.Drawing.Point(766, 525);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(143, 51);
            this.btnAlterar.TabIndex = 134;
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
            this.btnInserir.Location = new System.Drawing.Point(766, 470);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(143, 51);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lbldgvFornecedor
            // 
            this.lbldgvFornecedor.AutoSize = true;
            this.lbldgvFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldgvFornecedor.Location = new System.Drawing.Point(8, 311);
            this.lbldgvFornecedor.Name = "lbldgvFornecedor";
            this.lbldgvFornecedor.Size = new System.Drawing.Size(380, 20);
            this.lbldgvFornecedor.TabIndex = 133;
            this.lbldgvFornecedor.Text = "Lista de fornecedores cadastrados no sistema";
            // 
            // lblEdicao
            // 
            this.lblEdicao.Location = new System.Drawing.Point(75, 165);
            this.lblEdicao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdicao.Name = "lblEdicao";
            this.lblEdicao.Size = new System.Drawing.Size(70, 26);
            this.lblEdicao.TabIndex = 125;
            this.lblEdicao.Text = "Edição";
            this.lblEdicao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAutor
            // 
            this.lblAutor.Location = new System.Drawing.Point(90, 132);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(55, 26);
            this.lblAutor.TabIndex = 122;
            this.lblAutor.Text = "Autor";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(150, 132);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutor.MaxLength = 35;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(406, 26);
            this.txtAutor.TabIndex = 2;
            // 
            // lblEditora
            // 
            this.lblEditora.Location = new System.Drawing.Point(31, 96);
            this.lblEditora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(114, 26);
            this.lblEditora.TabIndex = 120;
            this.lblEditora.Text = "Editora";
            this.lblEditora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(150, 96);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditora.MaxLength = 35;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(406, 26);
            this.txtEditora.TabIndex = 1;
            // 
            // dgvLIvro
            // 
            this.dgvLIvro.AllowUserToAddRows = false;
            this.dgvLIvro.AllowUserToDeleteRows = false;
            this.dgvLIvro.AllowUserToOrderColumns = true;
            this.dgvLIvro.AllowUserToResizeColumns = false;
            this.dgvLIvro.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLIvro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLIvro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLIvro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCod_LIvro,
            this.clmnNome_Livro,
            this.clmnEditora,
            this.clmnAutor,
            this.clmnEdicao,
            this.clmnMateria,
            this.clmnGenero,
            this.clmnEmprestado,
            this.clmnAtivo,
            this.clmnDataCadastro});
            this.dgvLIvro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLIvro.Location = new System.Drawing.Point(0, 2);
            this.dgvLIvro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLIvro.MultiSelect = false;
            this.dgvLIvro.Name = "dgvLIvro";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvLIvro.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLIvro.RowHeadersVisible = false;
            this.dgvLIvro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLIvro.Size = new System.Drawing.Size(752, 350);
            this.dgvLIvro.TabIndex = 119;
            this.dgvLIvro.TabStop = false;
            // 
            // clmnCod_LIvro
            // 
            this.clmnCod_LIvro.DataPropertyName = "Cod_Livro";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnCod_LIvro.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmnCod_LIvro.HeaderText = "Código";
            this.clmnCod_LIvro.Name = "clmnCod_LIvro";
            // 
            // clmnNome_Livro
            // 
            this.clmnNome_Livro.DataPropertyName = "Nome_Livro";
            this.clmnNome_Livro.HeaderText = "Nome do Livro";
            this.clmnNome_Livro.Name = "clmnNome_Livro";
            this.clmnNome_Livro.Width = 250;
            // 
            // clmnEditora
            // 
            this.clmnEditora.DataPropertyName = "Editora";
            this.clmnEditora.HeaderText = "Editora";
            this.clmnEditora.Name = "clmnEditora";
            this.clmnEditora.Width = 250;
            // 
            // clmnAutor
            // 
            this.clmnAutor.DataPropertyName = "Autor";
            this.clmnAutor.HeaderText = "Autor";
            this.clmnAutor.Name = "clmnAutor";
            this.clmnAutor.Visible = false;
            // 
            // clmnEdicao
            // 
            this.clmnEdicao.DataPropertyName = "Edicao";
            this.clmnEdicao.HeaderText = "Edição";
            this.clmnEdicao.Name = "clmnEdicao";
            this.clmnEdicao.Visible = false;
            // 
            // clmnMateria
            // 
            this.clmnMateria.DataPropertyName = "Materia";
            this.clmnMateria.HeaderText = "Matéria";
            this.clmnMateria.Name = "clmnMateria";
            this.clmnMateria.Visible = false;
            // 
            // clmnGenero
            // 
            this.clmnGenero.DataPropertyName = "Desc_Genero";
            this.clmnGenero.HeaderText = "Genero";
            this.clmnGenero.Name = "clmnGenero";
            this.clmnGenero.Visible = false;
            // 
            // clmnEmprestado
            // 
            this.clmnEmprestado.DataPropertyName = "Emprestado";
            this.clmnEmprestado.HeaderText = "Emprestado";
            this.clmnEmprestado.Name = "clmnEmprestado";
            this.clmnEmprestado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnEmprestado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnEmprestado.Width = 80;
            // 
            // clmnAtivo
            // 
            this.clmnAtivo.DataPropertyName = "Ativo";
            this.clmnAtivo.HeaderText = "Ativo";
            this.clmnAtivo.Name = "clmnAtivo";
            this.clmnAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnAtivo.Width = 50;
            // 
            // clmnDataCadastro
            // 
            this.clmnDataCadastro.DataPropertyName = "Data_Cadastro";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.clmnDataCadastro.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmnDataCadastro.HeaderText = "Data de Cadastro";
            this.clmnDataCadastro.Name = "clmnDataCadastro";
            this.clmnDataCadastro.Visible = false;
            // 
            // txtEdicao
            // 
            this.txtEdicao.Location = new System.Drawing.Point(150, 165);
            this.txtEdicao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdicao.MaxLength = 2;
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(88, 26);
            this.txtEdicao.TabIndex = 3;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(149, 198);
            this.txtMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMateria.MaxLength = 25;
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(282, 26);
            this.txtMateria.TabIndex = 4;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(83, 201);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(62, 20);
            this.lblMateria.TabIndex = 123;
            this.lblMateria.Text = "Matéria";
            this.lblMateria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(149, 232);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(334, 28);
            this.cmbGenero.TabIndex = 5;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(82, 235);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(63, 20);
            this.lblGenero.TabIndex = 139;
            this.lblGenero.Text = "Gênero";
            // 
            // chkEmprestado
            // 
            this.chkEmprestado.AutoSize = true;
            this.chkEmprestado.Enabled = false;
            this.chkEmprestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmprestado.Location = new System.Drawing.Point(40, 20);
            this.chkEmprestado.Name = "chkEmprestado";
            this.chkEmprestado.Size = new System.Drawing.Size(125, 24);
            this.chkEmprestado.TabIndex = 140;
            this.chkEmprestado.Text = "Emprestado";
            this.chkEmprestado.UseVisualStyleBackColor = true;
            // 
            // pnlEmprestado
            // 
            this.pnlEmprestado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlEmprestado.Controls.Add(this.chkEmprestado);
            this.pnlEmprestado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlEmprestado.Location = new System.Drawing.Point(563, 96);
            this.pnlEmprestado.Name = "pnlEmprestado";
            this.pnlEmprestado.Size = new System.Drawing.Size(198, 62);
            this.pnlEmprestado.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.chkAtivo);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(563, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 62);
            this.panel2.TabIndex = 7;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.Location = new System.Drawing.Point(40, 20);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(68, 24);
            this.chkAtivo.TabIndex = 0;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLIvro);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 361);
            this.panel1.TabIndex = 144;
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(151, 266);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(117, 26);
            this.dtpDataCadastro.TabIndex = 145;
            this.dtpDataCadastro.Value = new System.DateTime(2014, 5, 4, 21, 11, 28, 0);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 271);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(132, 20);
            this.lblDataCadastro.TabIndex = 146;
            this.lblDataCadastro.Text = "data de Cadastro";
            // 
            // btnEmprestimoLivro
            // 
            this.btnEmprestimoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEmprestimoLivro.Image = ((System.Drawing.Image)(resources.GetObject("btnEmprestimoLivro.Image")));
            this.btnEmprestimoLivro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEmprestimoLivro.Location = new System.Drawing.Point(766, 359);
            this.btnEmprestimoLivro.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmprestimoLivro.Name = "btnEmprestimoLivro";
            this.btnEmprestimoLivro.Size = new System.Drawing.Size(143, 51);
            this.btnEmprestimoLivro.TabIndex = 147;
            this.btnEmprestimoLivro.TabStop = false;
            this.btnEmprestimoLivro.Text = "Emprestimo";
            this.btnEmprestimoLivro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmprestimoLivro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmprestimoLivro.UseVisualStyleBackColor = true;
            this.btnEmprestimoLivro.Click += new System.EventHandler(this.btnEmprestimoLivro_Click);
            // 
            // FrmLivroDidatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 699);
            this.ControlBox = false;
            this.Controls.Add(this.btnEmprestimoLivro);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.dtpDataCadastro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEmprestado);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lbldgvFornecedor);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.lblEdicao);
            this.Controls.Add(this.txtEdicao);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.txtEditora);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLivroDidatico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livros da Escola";
            this.Load += new System.EventHandler(this.FrmLivroDidatico_Load);
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIvro)).EndInit();
            this.pnlEmprestado.ResumeLayout(false);
            this.pnlEmprestado.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.Label lblPnlPesquisa;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label lblNomeLivro;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lbldgvFornecedor;
        private System.Windows.Forms.Label lblEdicao;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.DataGridView dgvLIvro;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.CheckBox chkEmprestado;
        private System.Windows.Forms.Panel pnlEmprestado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_LIvro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEdicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnGenero;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnEmprestado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDataCadastro;
        private System.Windows.Forms.Button btnEmprestimoLivro;

    }
}