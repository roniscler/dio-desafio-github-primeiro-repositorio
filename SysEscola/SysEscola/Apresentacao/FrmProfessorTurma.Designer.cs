namespace Apresentacao
{
    partial class FrmProfessorTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessorTurma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblNomeTurma = new System.Windows.Forms.Label();
            this.lblVarNomeTurma = new System.Windows.Forms.Label();
            this.lblcmbProfessor = new System.Windows.Forms.Label();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.btnInserirProfessor = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvProfessoresTurma = new System.Windows.Forms.DataGridView();
            this.clmnCod_Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCod_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessoresTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Lista de Alunos Cadastrados na Turma";
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.Teal;
            this.pnlCabecalho.Controls.Add(this.dtpDataEntrada);
            this.pnlCabecalho.Controls.Add(this.lblDataEntrada);
            this.pnlCabecalho.Controls.Add(this.lblNomeTurma);
            this.pnlCabecalho.Controls.Add(this.lblVarNomeTurma);
            this.pnlCabecalho.Controls.Add(this.lblcmbProfessor);
            this.pnlCabecalho.Controls.Add(this.cmbProfessor);
            this.pnlCabecalho.Controls.Add(this.btnInserirProfessor);
            this.pnlCabecalho.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlCabecalho.Location = new System.Drawing.Point(12, 14);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(480, 143);
            this.pnlCabecalho.TabIndex = 52;
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(137, 103);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(127, 26);
            this.dtpDataEntrada.TabIndex = 48;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(4, 108);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(127, 20);
            this.lblDataEntrada.TabIndex = 47;
            this.lblDataEntrada.Text = "Data de Entrada";
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
            // lblVarNomeTurma
            // 
            this.lblVarNomeTurma.AutoSize = true;
            this.lblVarNomeTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarNomeTurma.Location = new System.Drawing.Point(149, 19);
            this.lblVarNomeTurma.Name = "lblVarNomeTurma";
            this.lblVarNomeTurma.Size = new System.Drawing.Size(0, 20);
            this.lblVarNomeTurma.TabIndex = 46;
            // 
            // lblcmbProfessor
            // 
            this.lblcmbProfessor.AutoSize = true;
            this.lblcmbProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmbProfessor.Location = new System.Drawing.Point(3, 45);
            this.lblcmbProfessor.Name = "lblcmbProfessor";
            this.lblcmbProfessor.Size = new System.Drawing.Size(94, 20);
            this.lblcmbProfessor.TabIndex = 0;
            this.lblcmbProfessor.Text = "Professores";
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Location = new System.Drawing.Point(3, 68);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(359, 28);
            this.cmbProfessor.TabIndex = 1;
            // 
            // btnInserirProfessor
            // 
            this.btnInserirProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirProfessor.ForeColor = System.Drawing.Color.Teal;
            this.btnInserirProfessor.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirProfessor.Image")));
            this.btnInserirProfessor.Location = new System.Drawing.Point(365, 67);
            this.btnInserirProfessor.Name = "btnInserirProfessor";
            this.btnInserirProfessor.Size = new System.Drawing.Size(112, 46);
            this.btnInserirProfessor.TabIndex = 5;
            this.btnInserirProfessor.Text = "Inserir na Lista";
            this.btnInserirProfessor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserirProfessor.UseVisualStyleBackColor = true;
            this.btnInserirProfessor.Click += new System.EventHandler(this.btnInserirProfessor_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(370, 659);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(122, 47);
            this.btnFechar.TabIndex = 50;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(13, 658);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(160, 47);
            this.btnExcluir.TabIndex = 49;
            this.btnExcluir.Text = "Excluir da Lista";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvProfessoresTurma
            // 
            this.dgvProfessoresTurma.AllowUserToAddRows = false;
            this.dgvProfessoresTurma.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfessoresTurma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfessoresTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessoresTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCod_Turma,
            this.clmnCod_Item,
            this.Cod_Professor,
            this.NomeProfessor,
            this.DataEntrada});
            this.dgvProfessoresTurma.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProfessoresTurma.Location = new System.Drawing.Point(12, 183);
            this.dgvProfessoresTurma.Name = "dgvProfessoresTurma";
            this.dgvProfessoresTurma.ReadOnly = true;
            this.dgvProfessoresTurma.RowHeadersVisible = false;
            this.dgvProfessoresTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfessoresTurma.Size = new System.Drawing.Size(480, 469);
            this.dgvProfessoresTurma.TabIndex = 48;
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
            // Cod_Professor
            // 
            this.Cod_Professor.DataPropertyName = "Cod_Professor";
            this.Cod_Professor.HeaderText = "Cod_Professor";
            this.Cod_Professor.Name = "Cod_Professor";
            this.Cod_Professor.ReadOnly = true;
            this.Cod_Professor.Visible = false;
            // 
            // NomeProfessor
            // 
            this.NomeProfessor.DataPropertyName = "Nome_Professor";
            this.NomeProfessor.HeaderText = "Nome do Professor";
            this.NomeProfessor.Name = "NomeProfessor";
            this.NomeProfessor.ReadOnly = true;
            this.NomeProfessor.Width = 340;
            // 
            // DataEntrada
            // 
            this.DataEntrada.DataPropertyName = "DataEntrada";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DataEntrada.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataEntrada.HeaderText = "DataEntrada";
            this.DataEntrada.Name = "DataEntrada";
            this.DataEntrada.ReadOnly = true;
            this.DataEntrada.Width = 120;
            // 
            // FrmProfessorTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 708);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvProfessoresTurma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmProfessorTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professores da Turma";
            this.Load += new System.EventHandler(this.FrmProfessorTurma_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessoresTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblNomeTurma;
        private System.Windows.Forms.Label lblVarNomeTurma;
        private System.Windows.Forms.Label lblcmbProfessor;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.Button btnInserirProfessor;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvProfessoresTurma;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrada;
    }
}