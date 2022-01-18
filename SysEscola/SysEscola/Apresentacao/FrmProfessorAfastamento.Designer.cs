namespace Apresentacao
{
    partial class FrmProfessorAfastamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessorAfastamento));
            this.pnlAfastamento = new System.Windows.Forms.Panel();
            this.dgvProfessorAfastamento = new System.Windows.Forms.DataGridView();
            this.Cod_Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt_Afast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.nrDias = new System.Windows.Forms.NumericUpDown();
            this.lblDias = new System.Windows.Forms.Label();
            this.dtpDt_Afast = new System.Windows.Forms.DateTimePicker();
            this.lblDt_Afast = new System.Windows.Forms.Label();
            this.lblNomeProfessor = new System.Windows.Forms.Label();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlAfastamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessorAfastamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrDias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAfastamento
            // 
            this.pnlAfastamento.BackColor = System.Drawing.Color.Teal;
            this.pnlAfastamento.Controls.Add(this.dgvProfessorAfastamento);
            this.pnlAfastamento.Controls.Add(this.txtMotivo);
            this.pnlAfastamento.Controls.Add(this.lblMotivo);
            this.pnlAfastamento.Controls.Add(this.nrDias);
            this.pnlAfastamento.Controls.Add(this.lblDias);
            this.pnlAfastamento.Controls.Add(this.dtpDt_Afast);
            this.pnlAfastamento.Controls.Add(this.lblDt_Afast);
            this.pnlAfastamento.Controls.Add(this.lblNomeProfessor);
            this.pnlAfastamento.Controls.Add(this.txtNomeProfessor);
            this.pnlAfastamento.Controls.Add(this.btFechar);
            this.pnlAfastamento.Controls.Add(this.btnInserir);
            this.pnlAfastamento.Controls.Add(this.btnAlterar);
            this.pnlAfastamento.Controls.Add(this.btnExcluir);
            this.pnlAfastamento.Location = new System.Drawing.Point(12, 12);
            this.pnlAfastamento.Name = "pnlAfastamento";
            this.pnlAfastamento.Size = new System.Drawing.Size(837, 510);
            this.pnlAfastamento.TabIndex = 58;
            // 
            // dgvProfessorAfastamento
            // 
            this.dgvProfessorAfastamento.AllowUserToAddRows = false;
            this.dgvProfessorAfastamento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfessorAfastamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfessorAfastamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessorAfastamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Professor,
            this.Cod_Item,
            this.Dt_Afast,
            this.Dias,
            this.Motivo});
            this.dgvProfessorAfastamento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProfessorAfastamento.Location = new System.Drawing.Point(18, 108);
            this.dgvProfessorAfastamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProfessorAfastamento.MultiSelect = false;
            this.dgvProfessorAfastamento.Name = "dgvProfessorAfastamento";
            this.dgvProfessorAfastamento.ReadOnly = true;
            this.dgvProfessorAfastamento.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvProfessorAfastamento.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProfessorAfastamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfessorAfastamento.Size = new System.Drawing.Size(800, 329);
            this.dgvProfessorAfastamento.TabIndex = 71;
            // 
            // Cod_Professor
            // 
            this.Cod_Professor.DataPropertyName = "Cod_Professor";
            this.Cod_Professor.HeaderText = "Código do Professor";
            this.Cod_Professor.Name = "Cod_Professor";
            this.Cod_Professor.ReadOnly = true;
            this.Cod_Professor.Visible = false;
            // 
            // Cod_Item
            // 
            this.Cod_Item.DataPropertyName = "Cod_Item";
            this.Cod_Item.HeaderText = "Código do ìtem";
            this.Cod_Item.Name = "Cod_Item";
            this.Cod_Item.ReadOnly = true;
            this.Cod_Item.Visible = false;
            // 
            // Dt_Afast
            // 
            this.Dt_Afast.DataPropertyName = "Dt_Afast";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Dt_Afast.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dt_Afast.HeaderText = "Data do Afastamento";
            this.Dt_Afast.Name = "Dt_Afast";
            this.Dt_Afast.ReadOnly = true;
            this.Dt_Afast.Width = 130;
            // 
            // Dias
            // 
            this.Dias.DataPropertyName = "Dias";
            this.Dias.HeaderText = "Dias";
            this.Dias.Name = "Dias";
            this.Dias.ReadOnly = true;
            this.Dias.Width = 70;
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "Motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 580;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(193, 74);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(626, 26);
            this.txtMotivo.TabIndex = 70;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(14, 80);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(173, 20);
            this.lblMotivo.TabIndex = 69;
            this.lblMotivo.Text = "Motivo do Afastamento";
            // 
            // nrDias
            // 
            this.nrDias.Location = new System.Drawing.Point(502, 48);
            this.nrDias.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nrDias.Name = "nrDias";
            this.nrDias.Size = new System.Drawing.Size(78, 26);
            this.nrDias.TabIndex = 68;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(341, 50);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(150, 20);
            this.lblDias.TabIndex = 67;
            this.lblDias.Text = "Quantidade de Dias";
            // 
            // dtpDt_Afast
            // 
            this.dtpDt_Afast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDt_Afast.Location = new System.Drawing.Point(193, 45);
            this.dtpDt_Afast.Name = "dtpDt_Afast";
            this.dtpDt_Afast.Size = new System.Drawing.Size(143, 26);
            this.dtpDt_Afast.TabIndex = 66;
            // 
            // lblDt_Afast
            // 
            this.lblDt_Afast.AutoSize = true;
            this.lblDt_Afast.Location = new System.Drawing.Point(25, 50);
            this.lblDt_Afast.Name = "lblDt_Afast";
            this.lblDt_Afast.Size = new System.Drawing.Size(162, 20);
            this.lblDt_Afast.TabIndex = 65;
            this.lblDt_Afast.Text = "Data de Afastamento";
            // 
            // lblNomeProfessor
            // 
            this.lblNomeProfessor.AutoSize = true;
            this.lblNomeProfessor.Location = new System.Drawing.Point(42, 16);
            this.lblNomeProfessor.Name = "lblNomeProfessor";
            this.lblNomeProfessor.Size = new System.Drawing.Size(145, 20);
            this.lblNomeProfessor.TabIndex = 64;
            this.lblNomeProfessor.Text = "Nome do Professor";
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Enabled = false;
            this.txtNomeProfessor.Location = new System.Drawing.Point(193, 13);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.ReadOnly = true;
            this.txtNomeProfessor.Size = new System.Drawing.Size(387, 26);
            this.txtNomeProfessor.TabIndex = 63;
            this.txtNomeProfessor.TabStop = false;
            // 
            // btFechar
            // 
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.Teal;
            this.btFechar.Image = ((System.Drawing.Image)(resources.GetObject("btFechar.Image")));
            this.btFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btFechar.Location = new System.Drawing.Point(671, 446);
            this.btFechar.Margin = new System.Windows.Forms.Padding(6);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(148, 47);
            this.btFechar.TabIndex = 62;
            this.btFechar.Text = "      Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click_1);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.Teal;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInserir.Location = new System.Drawing.Point(130, 446);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(6);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(110, 47);
            this.btnInserir.TabIndex = 61;
            this.btnInserir.TabStop = false;
            this.btnInserir.Text = "     Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserirregistro_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.Teal;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(242, 446);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 47);
            this.btnAlterar.TabIndex = 60;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterarregistro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Teal;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(18, 445);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 47);
            this.btnExcluir.TabIndex = 58;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluirregistro_Click);
            // 
            // FrmProfessorAfastamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(865, 537);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAfastamento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProfessorAfastamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afastamentos do Professor";
            this.Load += new System.EventHandler(this.FrmProfessorAfastamento_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmProfessorAfastamento_KeyUp);
            this.pnlAfastamento.ResumeLayout(false);
            this.pnlAfastamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessorAfastamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrDias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAfastamento;
        private System.Windows.Forms.DataGridView dgvProfessorAfastamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt_Afast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.NumericUpDown nrDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.DateTimePicker dtpDt_Afast;
        private System.Windows.Forms.Label lblDt_Afast;
        private System.Windows.Forms.Label lblNomeProfessor;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;

    }
}