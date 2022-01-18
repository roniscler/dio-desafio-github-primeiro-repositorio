namespace Apresentacao
{
    partial class FrmProfessorHabillitacaoProfissional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessorHabillitacaoProfissional));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHabilitacaoProfssional = new System.Windows.Forms.Panel();
            this.btFechar = new System.Windows.Forms.Button();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblDataConclusao = new System.Windows.Forms.Label();
            this.lblInstituicao = new System.Windows.Forms.Label();
            this.txtInstituicao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.dtpDataCunclusao = new System.Windows.Forms.DateTimePicker();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.txtDescHabilitacao = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblDGVHabilt_Profissional = new System.Windows.Forms.Label();
            this.dgvHabilt_Profissional = new System.Windows.Forms.DataGridView();
            this.Cod_Habilitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Habilitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Conclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHabilitacaoProfssional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabilt_Profissional)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHabilitacaoProfssional
            // 
            this.pnlHabilitacaoProfssional.BackColor = System.Drawing.Color.Teal;
            this.pnlHabilitacaoProfssional.Controls.Add(this.btFechar);
            this.pnlHabilitacaoProfssional.Controls.Add(this.lblDuracao);
            this.pnlHabilitacaoProfssional.Controls.Add(this.lblDataConclusao);
            this.pnlHabilitacaoProfssional.Controls.Add(this.lblInstituicao);
            this.pnlHabilitacaoProfssional.Controls.Add(this.txtInstituicao);
            this.pnlHabilitacaoProfssional.Controls.Add(this.lblDescricao);
            this.pnlHabilitacaoProfssional.Controls.Add(this.dtpDataCunclusao);
            this.pnlHabilitacaoProfssional.Controls.Add(this.btnAlterar);
            this.pnlHabilitacaoProfssional.Controls.Add(this.btnExcluir);
            this.pnlHabilitacaoProfssional.Controls.Add(this.txtDuracao);
            this.pnlHabilitacaoProfssional.Controls.Add(this.txtDescHabilitacao);
            this.pnlHabilitacaoProfssional.Controls.Add(this.btnInserir);
            this.pnlHabilitacaoProfssional.Controls.Add(this.lblDGVHabilt_Profissional);
            this.pnlHabilitacaoProfssional.Controls.Add(this.dgvHabilt_Profissional);
            this.pnlHabilitacaoProfssional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pnlHabilitacaoProfssional.ForeColor = System.Drawing.Color.Teal;
            this.pnlHabilitacaoProfssional.Location = new System.Drawing.Point(12, 12);
            this.pnlHabilitacaoProfssional.Name = "pnlHabilitacaoProfssional";
            this.pnlHabilitacaoProfssional.Size = new System.Drawing.Size(914, 414);
            this.pnlHabilitacaoProfssional.TabIndex = 7;
            // 
            // btFechar
            // 
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.Teal;
            this.btFechar.Image = ((System.Drawing.Image)(resources.GetObject("btFechar.Image")));
            this.btFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btFechar.Location = new System.Drawing.Point(759, 356);
            this.btFechar.Margin = new System.Windows.Forms.Padding(6);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(148, 47);
            this.btFechar.TabIndex = 106;
            this.btFechar.Text = "      Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDuracao.Location = new System.Drawing.Point(153, 131);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(70, 20);
            this.lblDuracao.TabIndex = 105;
            this.lblDuracao.Text = "Duração";
            // 
            // lblDataConclusao
            // 
            this.lblDataConclusao.AutoSize = true;
            this.lblDataConclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataConclusao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDataConclusao.Location = new System.Drawing.Point(4, 131);
            this.lblDataConclusao.Name = "lblDataConclusao";
            this.lblDataConclusao.Size = new System.Drawing.Size(142, 20);
            this.lblDataConclusao.TabIndex = 104;
            this.lblDataConclusao.Text = "Data de conclusão";
            // 
            // lblInstituicao
            // 
            this.lblInstituicao.AutoSize = true;
            this.lblInstituicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstituicao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInstituicao.Location = new System.Drawing.Point(361, 75);
            this.lblInstituicao.Name = "lblInstituicao";
            this.lblInstituicao.Size = new System.Drawing.Size(240, 20);
            this.lblInstituicao.TabIndex = 103;
            this.lblInstituicao.Text = "Instituição onde concluiu o curso";
            // 
            // txtInstituicao
            // 
            this.txtInstituicao.Location = new System.Drawing.Point(365, 101);
            this.txtInstituicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInstituicao.MaxLength = 50;
            this.txtInstituicao.Name = "txtInstituicao";
            this.txtInstituicao.Size = new System.Drawing.Size(351, 23);
            this.txtInstituicao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescricao.Location = new System.Drawing.Point(4, 75);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(267, 20);
            this.lblDescricao.TabIndex = 101;
            this.lblDescricao.Text = "Descrição da habilitação Profissional";
            // 
            // dtpDataCunclusao
            // 
            this.dtpDataCunclusao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCunclusao.Location = new System.Drawing.Point(8, 154);
            this.dtpDataCunclusao.Name = "dtpDataCunclusao";
            this.dtpDataCunclusao.Size = new System.Drawing.Size(143, 23);
            this.dtpDataCunclusao.TabIndex = 2;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.Teal;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(8, 356);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(111, 48);
            this.btnAlterar.TabIndex = 100;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.Teal;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(119, 356);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 48);
            this.btnExcluir.TabIndex = 99;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir da Lista";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(157, 154);
            this.txtDuracao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuracao.MaxLength = 20;
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(427, 23);
            this.txtDuracao.TabIndex = 3;
            // 
            // txtDescHabilitacao
            // 
            this.txtDescHabilitacao.Location = new System.Drawing.Point(8, 101);
            this.txtDescHabilitacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescHabilitacao.MaxLength = 50;
            this.txtDescHabilitacao.Name = "txtDescHabilitacao";
            this.txtDescHabilitacao.Size = new System.Drawing.Size(351, 23);
            this.txtDescHabilitacao.TabIndex = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.Teal;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(230, 356);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(111, 48);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir na Lista";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblDGVHabilt_Profissional
            // 
            this.lblDGVHabilt_Profissional.AutoSize = true;
            this.lblDGVHabilt_Profissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGVHabilt_Profissional.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDGVHabilt_Profissional.Location = new System.Drawing.Point(277, 19);
            this.lblDGVHabilt_Profissional.Name = "lblDGVHabilt_Profissional";
            this.lblDGVHabilt_Profissional.Size = new System.Drawing.Size(324, 24);
            this.lblDGVHabilt_Profissional.TabIndex = 96;
            this.lblDGVHabilt_Profissional.Text = "Títulos, Cursos e Especializações";
            // 
            // dgvHabilt_Profissional
            // 
            this.dgvHabilt_Profissional.AllowUserToAddRows = false;
            this.dgvHabilt_Profissional.AllowUserToDeleteRows = false;
            this.dgvHabilt_Profissional.AllowUserToResizeColumns = false;
            this.dgvHabilt_Profissional.AllowUserToResizeRows = false;
            this.dgvHabilt_Profissional.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHabilt_Profissional.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvHabilt_Profissional.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHabilt_Profissional.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHabilt_Profissional.ColumnHeadersHeight = 30;
            this.dgvHabilt_Profissional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHabilt_Profissional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Habilitacao,
            this.Cod_Professor,
            this.Desc_Habilitacao,
            this.Instituicao,
            this.Data_Conclusao,
            this.Duracao});
            this.dgvHabilt_Profissional.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHabilt_Profissional.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvHabilt_Profissional.Location = new System.Drawing.Point(7, 185);
            this.dgvHabilt_Profissional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHabilt_Profissional.Name = "dgvHabilt_Profissional";
            this.dgvHabilt_Profissional.ReadOnly = true;
            this.dgvHabilt_Profissional.RowHeadersVisible = false;
            this.dgvHabilt_Profissional.RowHeadersWidth = 30;
            this.dgvHabilt_Profissional.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvHabilt_Profissional.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHabilt_Profissional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabilt_Profissional.Size = new System.Drawing.Size(900, 165);
            this.dgvHabilt_Profissional.TabIndex = 95;
            this.dgvHabilt_Profissional.TabStop = false;
            // 
            // Cod_Habilitacao
            // 
            this.Cod_Habilitacao.DataPropertyName = "Cod_Habilitacao";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cod_Habilitacao.DefaultCellStyle = dataGridViewCellStyle6;
            this.Cod_Habilitacao.HeaderText = "Codigo";
            this.Cod_Habilitacao.Name = "Cod_Habilitacao";
            this.Cod_Habilitacao.ReadOnly = true;
            this.Cod_Habilitacao.Visible = false;
            // 
            // Cod_Professor
            // 
            this.Cod_Professor.DataPropertyName = "Cod_Professor";
            this.Cod_Professor.HeaderText = "Codigo do Professor";
            this.Cod_Professor.Name = "Cod_Professor";
            this.Cod_Professor.ReadOnly = true;
            this.Cod_Professor.Visible = false;
            // 
            // Desc_Habilitacao
            // 
            this.Desc_Habilitacao.DataPropertyName = "Desc_Habilitacao";
            this.Desc_Habilitacao.HeaderText = "Descrição da Habilitação";
            this.Desc_Habilitacao.Name = "Desc_Habilitacao";
            this.Desc_Habilitacao.ReadOnly = true;
            this.Desc_Habilitacao.Width = 250;
            // 
            // Instituicao
            // 
            this.Instituicao.DataPropertyName = "Instituicao";
            this.Instituicao.HeaderText = "Instituição";
            this.Instituicao.Name = "Instituicao";
            this.Instituicao.ReadOnly = true;
            this.Instituicao.Width = 250;
            // 
            // Data_Conclusao
            // 
            this.Data_Conclusao.DataPropertyName = "Data_Conclusao";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.Data_Conclusao.DefaultCellStyle = dataGridViewCellStyle7;
            this.Data_Conclusao.HeaderText = "Data de Conclusão";
            this.Data_Conclusao.Name = "Data_Conclusao";
            this.Data_Conclusao.ReadOnly = true;
            this.Data_Conclusao.Width = 150;
            // 
            // Duracao
            // 
            this.Duracao.DataPropertyName = "Duracao";
            this.Duracao.HeaderText = "Duração";
            this.Duracao.Name = "Duracao";
            this.Duracao.ReadOnly = true;
            this.Duracao.Width = 230;
            // 
            // FrmProfessorHabillitacaoProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 452);
            this.ControlBox = false;
            this.Controls.Add(this.pnlHabilitacaoProfssional);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProfessorHabillitacaoProfissional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habilitação Profissional";
            this.Load += new System.EventHandler(this.FrmProfessorHabillitacaoProfissional_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmProfessorHabillitacaoProfissional_KeyUp);
            this.pnlHabilitacaoProfssional.ResumeLayout(false);
            this.pnlHabilitacaoProfssional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabilt_Profissional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHabilitacaoProfssional;
        private System.Windows.Forms.DateTimePicker dtpDataCunclusao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.TextBox txtDescHabilitacao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblDGVHabilt_Profissional;
        private System.Windows.Forms.DataGridView dgvHabilt_Profissional;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblDataConclusao;
        private System.Windows.Forms.Label lblInstituicao;
        private System.Windows.Forms.TextBox txtInstituicao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Habilitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Habilitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Conclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracao;
    }
}