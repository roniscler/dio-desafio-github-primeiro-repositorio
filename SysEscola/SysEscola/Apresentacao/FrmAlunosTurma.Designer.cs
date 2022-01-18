namespace Apresentacao
{
    partial class FrmAlunosTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlunosTurma));
            this.lblcmbALunos = new System.Windows.Forms.Label();
            this.cmbAlunoTurma = new System.Windows.Forms.ComboBox();
            this.dgvAlunosdaTurma = new System.Windows.Forms.DataGridView();
            this.lblNomeTurma = new System.Windows.Forms.Label();
            this.btnInserirAluno = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblVarNomeTurma = new System.Windows.Forms.Label();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblDataMatricula = new System.Windows.Forms.Label();
            this.dtpMatricula = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.clmnCod_Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCod_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCod_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDataMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosdaTurma)).BeginInit();
            this.pnlCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcmbALunos
            // 
            this.lblcmbALunos.AutoSize = true;
            this.lblcmbALunos.Location = new System.Drawing.Point(3, 46);
            this.lblcmbALunos.Name = "lblcmbALunos";
            this.lblcmbALunos.Size = new System.Drawing.Size(58, 20);
            this.lblcmbALunos.TabIndex = 0;
            this.lblcmbALunos.Text = "Alunos";
            // 
            // cmbAlunoTurma
            // 
            this.cmbAlunoTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlunoTurma.FormattingEnabled = true;
            this.cmbAlunoTurma.Location = new System.Drawing.Point(3, 69);
            this.cmbAlunoTurma.Name = "cmbAlunoTurma";
            this.cmbAlunoTurma.Size = new System.Drawing.Size(445, 28);
            this.cmbAlunoTurma.TabIndex = 1;
            this.cmbAlunoTurma.SelectedIndexChanged += new System.EventHandler(this.cmbAlunos_SelectedIndexChanged);
            // 
            // dgvAlunosdaTurma
            // 
            this.dgvAlunosdaTurma.AllowUserToAddRows = false;
            this.dgvAlunosdaTurma.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlunosdaTurma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlunosdaTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunosdaTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCod_Turma,
            this.clmnCod_Item,
            this.clmnCod_Aluno,
            this.clmnNome_Aluno,
            this.clmnDataMatricula});
            this.dgvAlunosdaTurma.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlunosdaTurma.Location = new System.Drawing.Point(12, 181);
            this.dgvAlunosdaTurma.Name = "dgvAlunosdaTurma";
            this.dgvAlunosdaTurma.ReadOnly = true;
            this.dgvAlunosdaTurma.RowHeadersVisible = false;
            this.dgvAlunosdaTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunosdaTurma.Size = new System.Drawing.Size(580, 469);
            this.dgvAlunosdaTurma.TabIndex = 2;
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTurma.Location = new System.Drawing.Point(3, 19);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(140, 20);
            this.lblNomeTurma.TabIndex = 3;
            this.lblNomeTurma.Text = "Nome da Turma:";
            // 
            // btnInserirAluno
            // 
            this.btnInserirAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirAluno.ForeColor = System.Drawing.Color.Teal;
            this.btnInserirAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirAluno.Image")));
            this.btnInserirAluno.Location = new System.Drawing.Point(454, 69);
            this.btnInserirAluno.Name = "btnInserirAluno";
            this.btnInserirAluno.Size = new System.Drawing.Size(123, 57);
            this.btnInserirAluno.TabIndex = 5;
            this.btnInserirAluno.Text = "Inserir na Lista";
            this.btnInserirAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserirAluno.UseVisualStyleBackColor = true;
            this.btnInserirAluno.Click += new System.EventHandler(this.btnInserirAluno_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(13, 656);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(160, 47);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir da Lista";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(471, 657);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(122, 47);
            this.btnFechar.TabIndex = 45;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblVarNomeTurma
            // 
            this.lblVarNomeTurma.AutoSize = true;
            this.lblVarNomeTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarNomeTurma.Location = new System.Drawing.Point(149, 19);
            this.lblVarNomeTurma.Name = "lblVarNomeTurma";
            this.lblVarNomeTurma.Size = new System.Drawing.Size(0, 20);
            this.lblVarNomeTurma.TabIndex = 46;
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.Teal;
            this.pnlCabecalho.Controls.Add(this.lblDataMatricula);
            this.pnlCabecalho.Controls.Add(this.dtpMatricula);
            this.pnlCabecalho.Controls.Add(this.lblNomeTurma);
            this.pnlCabecalho.Controls.Add(this.lblVarNomeTurma);
            this.pnlCabecalho.Controls.Add(this.lblcmbALunos);
            this.pnlCabecalho.Controls.Add(this.cmbAlunoTurma);
            this.pnlCabecalho.Controls.Add(this.btnInserirAluno);
            this.pnlCabecalho.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlCabecalho.Location = new System.Drawing.Point(12, 12);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(580, 143);
            this.pnlCabecalho.TabIndex = 47;
            // 
            // lblDataMatricula
            // 
            this.lblDataMatricula.AutoSize = true;
            this.lblDataMatricula.Location = new System.Drawing.Point(183, 105);
            this.lblDataMatricula.Name = "lblDataMatricula";
            this.lblDataMatricula.Size = new System.Drawing.Size(134, 20);
            this.lblDataMatricula.TabIndex = 48;
            this.lblDataMatricula.Text = "Data da Matrícula";
            // 
            // dtpMatricula
            // 
            this.dtpMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMatricula.Location = new System.Drawing.Point(323, 100);
            this.dtpMatricula.Name = "dtpMatricula";
            this.dtpMatricula.Size = new System.Drawing.Size(125, 26);
            this.dtpMatricula.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Lista de Alunos Cadastrados na Turma";
            // 
            // clmnCod_Turma
            // 
            this.clmnCod_Turma.DataPropertyName = "Cod_Turma";
            this.clmnCod_Turma.HeaderText = "Cod_Turma";
            this.clmnCod_Turma.Name = "clmnCod_Turma";
            this.clmnCod_Turma.ReadOnly = true;
            this.clmnCod_Turma.Visible = false;
            // 
            // clmnCod_Item
            // 
            this.clmnCod_Item.DataPropertyName = "Cod_Item";
            this.clmnCod_Item.HeaderText = "Codigo do Item";
            this.clmnCod_Item.Name = "clmnCod_Item";
            this.clmnCod_Item.ReadOnly = true;
            this.clmnCod_Item.Visible = false;
            // 
            // clmnCod_Aluno
            // 
            this.clmnCod_Aluno.DataPropertyName = "Cod_Aluno";
            this.clmnCod_Aluno.HeaderText = "Cod_Aluno";
            this.clmnCod_Aluno.Name = "clmnCod_Aluno";
            this.clmnCod_Aluno.ReadOnly = true;
            this.clmnCod_Aluno.Visible = false;
            // 
            // clmnNome_Aluno
            // 
            this.clmnNome_Aluno.DataPropertyName = "Nome_Aluno";
            this.clmnNome_Aluno.HeaderText = "Nome do Aluno";
            this.clmnNome_Aluno.Name = "clmnNome_Aluno";
            this.clmnNome_Aluno.ReadOnly = true;
            this.clmnNome_Aluno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clmnNome_Aluno.Width = 400;
            // 
            // clmnDataMatricula
            // 
            this.clmnDataMatricula.DataPropertyName = "Data_Matricula";
            this.clmnDataMatricula.HeaderText = "Data Matrícula";
            this.clmnDataMatricula.Name = "clmnDataMatricula";
            this.clmnDataMatricula.ReadOnly = true;
            this.clmnDataMatricula.Width = 160;
            // 
            // FrmAlunosTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 708);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvAlunosdaTurma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAlunosTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alunos cadastrados para a turma";
            this.Load += new System.EventHandler(this.FrmAlunosTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosdaTurma)).EndInit();
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcmbALunos;
        private System.Windows.Forms.ComboBox cmbAlunoTurma;
        private System.Windows.Forms.DataGridView dgvAlunosdaTurma;
        private System.Windows.Forms.Label lblNomeTurma;
        private System.Windows.Forms.Button btnInserirAluno;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblVarNomeTurma;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMatricula;
        private System.Windows.Forms.Label lblDataMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDataMatricula;
    }
}