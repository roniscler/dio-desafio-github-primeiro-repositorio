namespace Apresentacao
{
    partial class FrmEmprestimoLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmprestimoLivro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCod_Livro = new System.Windows.Forms.TextBox();
            this.lblCod_Livro = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblDgvEmprestimos = new System.Windows.Forms.Label();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.lblNome_Livro = new System.Windows.Forms.Label();
            this.txtNome_Livro = new System.Windows.Forms.TextBox();
            this.pnlDadosLivro = new System.Windows.Forms.Panel();
            this.pnldgvEmprestimo = new System.Windows.Forms.Panel();
            this.lblcmbALunos = new System.Windows.Forms.Label();
            this.cmbAlunos = new System.Windows.Forms.ComboBox();
            this.dtpDataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.lblDataEmprestimo = new System.Windows.Forms.Label();
            this.nudQtdeDias = new System.Windows.Forms.NumericUpDown();
            this.lblQtdeDias = new System.Windows.Forms.Label();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.clmnCod_Empr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCod_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnQtdeDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.pnlDadosLivro.SuspendLayout();
            this.pnldgvEmprestimo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeDias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCod_Livro
            // 
            this.txtCod_Livro.Location = new System.Drawing.Point(35, 39);
            this.txtCod_Livro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCod_Livro.Name = "txtCod_Livro";
            this.txtCod_Livro.Size = new System.Drawing.Size(83, 26);
            this.txtCod_Livro.TabIndex = 0;
            // 
            // lblCod_Livro
            // 
            this.lblCod_Livro.AutoSize = true;
            this.lblCod_Livro.Location = new System.Drawing.Point(31, 14);
            this.lblCod_Livro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod_Livro.Name = "lblCod_Livro";
            this.lblCod_Livro.Size = new System.Drawing.Size(59, 20);
            this.lblCod_Livro.TabIndex = 1;
            this.lblCod_Livro.Text = "Código";
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(722, 573);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(143, 51);
            this.btnFechar.TabIndex = 142;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluir.Location = new System.Drawing.Point(722, 518);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(143, 51);
            this.btnExcluir.TabIndex = 140;
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
            this.btnAlterar.Location = new System.Drawing.Point(722, 463);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(143, 51);
            this.btnAlterar.TabIndex = 139;
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
            this.btnInserir.Location = new System.Drawing.Point(722, 408);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(143, 51);
            this.btnInserir.TabIndex = 138;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblDgvEmprestimos
            // 
            this.lblDgvEmprestimos.AutoSize = true;
            this.lblDgvEmprestimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDgvEmprestimos.Location = new System.Drawing.Point(3, 3);
            this.lblDgvEmprestimos.Name = "lblDgvEmprestimos";
            this.lblDgvEmprestimos.Size = new System.Drawing.Size(180, 20);
            this.lblDgvEmprestimos.TabIndex = 144;
            this.lblDgvEmprestimos.Text = "Empréstimos do livro ";
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.AllowUserToAddRows = false;
            this.dgvEmprestimos.AllowUserToDeleteRows = false;
            this.dgvEmprestimos.AllowUserToOrderColumns = true;
            this.dgvEmprestimos.AllowUserToResizeColumns = false;
            this.dgvEmprestimos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmprestimos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCod_Empr,
            this.clmnNome_Aluno,
            this.clmnCod_Livro,
            this.clmnDataEmprestimo,
            this.clmnQtdeDias,
            this.clmnDataDevolucao});
            this.dgvEmprestimos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmprestimos.Location = new System.Drawing.Point(0, 34);
            this.dgvEmprestimos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEmprestimos.MultiSelect = false;
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmprestimos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmprestimos.RowHeadersVisible = false;
            this.dgvEmprestimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmprestimos.Size = new System.Drawing.Size(710, 405);
            this.dgvEmprestimos.TabIndex = 143;
            this.dgvEmprestimos.TabStop = false;
            this.dgvEmprestimos.SelectionChanged += new System.EventHandler(this.dgvEmprestimos_SelectionChanged);
            // 
            // lblNome_Livro
            // 
            this.lblNome_Livro.AutoSize = true;
            this.lblNome_Livro.Location = new System.Drawing.Point(122, 14);
            this.lblNome_Livro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome_Livro.Name = "lblNome_Livro";
            this.lblNome_Livro.Size = new System.Drawing.Size(110, 20);
            this.lblNome_Livro.TabIndex = 146;
            this.lblNome_Livro.Text = "Nome do Livro";
            // 
            // txtNome_Livro
            // 
            this.txtNome_Livro.Location = new System.Drawing.Point(126, 39);
            this.txtNome_Livro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome_Livro.Name = "txtNome_Livro";
            this.txtNome_Livro.Size = new System.Drawing.Size(484, 26);
            this.txtNome_Livro.TabIndex = 145;
            // 
            // pnlDadosLivro
            // 
            this.pnlDadosLivro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlDadosLivro.Controls.Add(this.lblCod_Livro);
            this.pnlDadosLivro.Controls.Add(this.lblNome_Livro);
            this.pnlDadosLivro.Controls.Add(this.txtNome_Livro);
            this.pnlDadosLivro.Controls.Add(this.txtCod_Livro);
            this.pnlDadosLivro.Enabled = false;
            this.pnlDadosLivro.Location = new System.Drawing.Point(4, 12);
            this.pnlDadosLivro.Name = "pnlDadosLivro";
            this.pnlDadosLivro.Size = new System.Drawing.Size(710, 91);
            this.pnlDadosLivro.TabIndex = 147;
            // 
            // pnldgvEmprestimo
            // 
            this.pnldgvEmprestimo.Controls.Add(this.lblDgvEmprestimos);
            this.pnldgvEmprestimo.Controls.Add(this.dgvEmprestimos);
            this.pnldgvEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pnldgvEmprestimo.Location = new System.Drawing.Point(4, 185);
            this.pnldgvEmprestimo.Name = "pnldgvEmprestimo";
            this.pnldgvEmprestimo.Size = new System.Drawing.Size(710, 439);
            this.pnldgvEmprestimo.TabIndex = 148;
            // 
            // lblcmbALunos
            // 
            this.lblcmbALunos.AutoSize = true;
            this.lblcmbALunos.Location = new System.Drawing.Point(4, 114);
            this.lblcmbALunos.Name = "lblcmbALunos";
            this.lblcmbALunos.Size = new System.Drawing.Size(50, 20);
            this.lblcmbALunos.TabIndex = 149;
            this.lblcmbALunos.Text = "Aluno";
            // 
            // cmbAlunos
            // 
            this.cmbAlunos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlunos.FormattingEnabled = true;
            this.cmbAlunos.Location = new System.Drawing.Point(4, 137);
            this.cmbAlunos.Name = "cmbAlunos";
            this.cmbAlunos.Size = new System.Drawing.Size(359, 28);
            this.cmbAlunos.TabIndex = 150;
            // 
            // dtpDataEmprestimo
            // 
            this.dtpDataEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmprestimo.Location = new System.Drawing.Point(369, 139);
            this.dtpDataEmprestimo.Name = "dtpDataEmprestimo";
            this.dtpDataEmprestimo.Size = new System.Drawing.Size(155, 26);
            this.dtpDataEmprestimo.TabIndex = 151;
            // 
            // lblDataEmprestimo
            // 
            this.lblDataEmprestimo.AutoSize = true;
            this.lblDataEmprestimo.Location = new System.Drawing.Point(365, 114);
            this.lblDataEmprestimo.Name = "lblDataEmprestimo";
            this.lblDataEmprestimo.Size = new System.Drawing.Size(159, 20);
            this.lblDataEmprestimo.TabIndex = 152;
            this.lblDataEmprestimo.Text = "Data do Emprestimo ";
            // 
            // nudQtdeDias
            // 
            this.nudQtdeDias.Location = new System.Drawing.Point(530, 139);
            this.nudQtdeDias.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudQtdeDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtdeDias.Name = "nudQtdeDias";
            this.nudQtdeDias.Size = new System.Drawing.Size(102, 26);
            this.nudQtdeDias.TabIndex = 153;
            this.nudQtdeDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQtdeDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQtdeDias
            // 
            this.lblQtdeDias.AutoSize = true;
            this.lblQtdeDias.Location = new System.Drawing.Point(530, 116);
            this.lblQtdeDias.Name = "lblQtdeDias";
            this.lblQtdeDias.Size = new System.Drawing.Size(102, 20);
            this.lblQtdeDias.TabIndex = 154;
            this.lblQtdeDias.Text = "Qtde de Dias";
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.Enabled = false;
            this.btnDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDevolucao.Image = ((System.Drawing.Image)(resources.GetObject("btnDevolucao.Image")));
            this.btnDevolucao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDevolucao.Location = new System.Drawing.Point(722, 353);
            this.btnDevolucao.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(143, 51);
            this.btnDevolucao.TabIndex = 156;
            this.btnDevolucao.Text = "Devolver";
            this.btnDevolucao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevolucao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevolucao.UseVisualStyleBackColor = true;
            this.btnDevolucao.Click += new System.EventHandler(this.btnDevolucao_Click);
            // 
            // clmnCod_Empr
            // 
            this.clmnCod_Empr.DataPropertyName = "Cod_Emprestimo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.clmnCod_Empr.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmnCod_Empr.HeaderText = "Código";
            this.clmnCod_Empr.Name = "clmnCod_Empr";
            this.clmnCod_Empr.ReadOnly = true;
            this.clmnCod_Empr.Visible = false;
            // 
            // clmnNome_Aluno
            // 
            this.clmnNome_Aluno.DataPropertyName = "Nome_Aluno";
            this.clmnNome_Aluno.HeaderText = "Aluno";
            this.clmnNome_Aluno.Name = "clmnNome_Aluno";
            this.clmnNome_Aluno.ReadOnly = true;
            this.clmnNome_Aluno.Width = 320;
            // 
            // clmnCod_Livro
            // 
            this.clmnCod_Livro.DataPropertyName = "Cod_Livro";
            this.clmnCod_Livro.HeaderText = "Cod_Livro";
            this.clmnCod_Livro.Name = "clmnCod_Livro";
            this.clmnCod_Livro.ReadOnly = true;
            this.clmnCod_Livro.Visible = false;
            this.clmnCod_Livro.Width = 250;
            // 
            // clmnDataEmprestimo
            // 
            this.clmnDataEmprestimo.DataPropertyName = "Data_Emprestimo";
            this.clmnDataEmprestimo.HeaderText = "Data Empréstimo";
            this.clmnDataEmprestimo.Name = "clmnDataEmprestimo";
            this.clmnDataEmprestimo.ReadOnly = true;
            this.clmnDataEmprestimo.Width = 135;
            // 
            // clmnQtdeDias
            // 
            this.clmnQtdeDias.DataPropertyName = "Qtde_Dias";
            this.clmnQtdeDias.HeaderText = "Qtde de Dias";
            this.clmnQtdeDias.Name = "clmnQtdeDias";
            this.clmnQtdeDias.ReadOnly = true;
            // 
            // clmnDataDevolucao
            // 
            this.clmnDataDevolucao.DataPropertyName = "Data_Devolucao";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.clmnDataDevolucao.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmnDataDevolucao.HeaderText = "Data Devolução";
            this.clmnDataDevolucao.Name = "clmnDataDevolucao";
            this.clmnDataDevolucao.ReadOnly = true;
            this.clmnDataDevolucao.Width = 135;
            // 
            // FrmEmprestimoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 648);
            this.ControlBox = false;
            this.Controls.Add(this.btnDevolucao);
            this.Controls.Add(this.lblQtdeDias);
            this.Controls.Add(this.nudQtdeDias);
            this.Controls.Add(this.lblDataEmprestimo);
            this.Controls.Add(this.dtpDataEmprestimo);
            this.Controls.Add(this.lblcmbALunos);
            this.Controls.Add(this.cmbAlunos);
            this.Controls.Add(this.pnldgvEmprestimo);
            this.Controls.Add(this.pnlDadosLivro);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEmprestimoLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empréstimo de Livros";
            this.Load += new System.EventHandler(this.FrmEmprestimoLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.pnlDadosLivro.ResumeLayout(false);
            this.pnlDadosLivro.PerformLayout();
            this.pnldgvEmprestimo.ResumeLayout(false);
            this.pnldgvEmprestimo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod_Livro;
        private System.Windows.Forms.Label lblCod_Livro;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblDgvEmprestimos;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.Label lblNome_Livro;
        private System.Windows.Forms.TextBox txtNome_Livro;
        private System.Windows.Forms.Panel pnlDadosLivro;
        private System.Windows.Forms.Panel pnldgvEmprestimo;
        private System.Windows.Forms.Label lblcmbALunos;
        private System.Windows.Forms.ComboBox cmbAlunos;
        private System.Windows.Forms.DateTimePicker dtpDataEmprestimo;
        private System.Windows.Forms.Label lblDataEmprestimo;
        private System.Windows.Forms.NumericUpDown nudQtdeDias;
        private System.Windows.Forms.Label lblQtdeDias;
        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Empr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnQtdeDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDataDevolucao;
    }
}