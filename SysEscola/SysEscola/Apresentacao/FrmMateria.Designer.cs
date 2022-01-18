namespace Apresentacao
{
    partial class FrmMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMateria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            this.clmnCod_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblDicaConsultar = new System.Windows.Forms.Label();
            this.lblDicaInserir = new System.Windows.Forms.Label();
            this.lblNome_Materia = new System.Windows.Forms.Label();
            this.txtNome_Materia = new System.Windows.Forms.TextBox();
            this.lblcmbProfessor = new System.Windows.Forms.Label();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
            this.pnlDataGrid.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(744, 560);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(143, 51);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConsultar.Location = new System.Drawing.Point(744, 276);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(143, 51);
            this.btnConsultar.TabIndex = 12;
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
            this.btnExcluir.Location = new System.Drawing.Point(744, 489);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(143, 51);
            this.btnExcluir.TabIndex = 11;
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
            this.btnAlterar.Location = new System.Drawing.Point(744, 418);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(143, 51);
            this.btnAlterar.TabIndex = 10;
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
            this.btnInserir.Location = new System.Drawing.Point(744, 347);
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
            // dgvMateria
            // 
            this.dgvMateria.AllowUserToAddRows = false;
            this.dgvMateria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCod_Materia,
            this.clmnNome_Materia,
            this.clmnNome_Professor});
            this.dgvMateria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMateria.Location = new System.Drawing.Point(0, 3);
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.ReadOnly = true;
            this.dgvMateria.RowHeadersVisible = false;
            this.dgvMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateria.Size = new System.Drawing.Size(720, 456);
            this.dgvMateria.TabIndex = 14;
            this.dgvMateria.TabStop = false;
            // 
            // clmnCod_Materia
            // 
            this.clmnCod_Materia.DataPropertyName = "Cod_Materia";
            this.clmnCod_Materia.HeaderText = "Código da Materia";
            this.clmnCod_Materia.Name = "clmnCod_Materia";
            this.clmnCod_Materia.ReadOnly = true;
            this.clmnCod_Materia.Visible = false;
            // 
            // clmnNome_Materia
            // 
            this.clmnNome_Materia.DataPropertyName = "Nome_Materia";
            this.clmnNome_Materia.HeaderText = "Nome da Matéria";
            this.clmnNome_Materia.Name = "clmnNome_Materia";
            this.clmnNome_Materia.ReadOnly = true;
            this.clmnNome_Materia.Width = 350;
            // 
            // clmnNome_Professor
            // 
            this.clmnNome_Professor.DataPropertyName = "Nome_Professor";
            this.clmnNome_Professor.HeaderText = "Nome do Professor";
            this.clmnNome_Professor.Name = "clmnNome_Professor";
            this.clmnNome_Professor.ReadOnly = true;
            this.clmnNome_Professor.Width = 350;
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.Controls.Add(this.dgvMateria);
            this.pnlDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDataGrid.Location = new System.Drawing.Point(13, 152);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Size = new System.Drawing.Size(724, 464);
            this.pnlDataGrid.TabIndex = 15;
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.Teal;
            this.pnlCabecalho.Controls.Add(this.lblDicaConsultar);
            this.pnlCabecalho.Controls.Add(this.lblDicaInserir);
            this.pnlCabecalho.Controls.Add(this.lblNome_Materia);
            this.pnlCabecalho.Controls.Add(this.txtNome_Materia);
            this.pnlCabecalho.Controls.Add(this.lblcmbProfessor);
            this.pnlCabecalho.Controls.Add(this.cmbProfessor);
            this.pnlCabecalho.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlCabecalho.Location = new System.Drawing.Point(16, 12);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(715, 124);
            this.pnlCabecalho.TabIndex = 0;
            // 
            // lblDicaConsultar
            // 
            this.lblDicaConsultar.AutoSize = true;
            this.lblDicaConsultar.Location = new System.Drawing.Point(6, 91);
            this.lblDicaConsultar.Name = "lblDicaConsultar";
            this.lblDicaConsultar.Size = new System.Drawing.Size(464, 20);
            this.lblDicaConsultar.TabIndex = 7;
            this.lblDicaConsultar.Text = "Para consultar: Digite o nome da Matéria e clique em \"Consultar\"";
            // 
            // lblDicaInserir
            // 
            this.lblDicaInserir.AutoSize = true;
            this.lblDicaInserir.Location = new System.Drawing.Point(6, 66);
            this.lblDicaInserir.Name = "lblDicaInserir";
            this.lblDicaInserir.Size = new System.Drawing.Size(489, 20);
            this.lblDicaInserir.TabIndex = 6;
            this.lblDicaInserir.Text = "Digite o nome da matéria, selecione o professor e clique em \"Inserir\"";
            // 
            // lblNome_Materia
            // 
            this.lblNome_Materia.AutoSize = true;
            this.lblNome_Materia.Location = new System.Drawing.Point(6, 5);
            this.lblNome_Materia.Name = "lblNome_Materia";
            this.lblNome_Materia.Size = new System.Drawing.Size(130, 20);
            this.lblNome_Materia.TabIndex = 5;
            this.lblNome_Materia.Text = "Nome da Matéria";
            // 
            // txtNome_Materia
            // 
            this.txtNome_Materia.Location = new System.Drawing.Point(10, 30);
            this.txtNome_Materia.MaxLength = 35;
            this.txtNome_Materia.Name = "txtNome_Materia";
            this.txtNome_Materia.Size = new System.Drawing.Size(328, 26);
            this.txtNome_Materia.TabIndex = 0;
            // 
            // lblcmbProfessor
            // 
            this.lblcmbProfessor.AutoSize = true;
            this.lblcmbProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmbProfessor.Location = new System.Drawing.Point(346, 6);
            this.lblcmbProfessor.Name = "lblcmbProfessor";
            this.lblcmbProfessor.Size = new System.Drawing.Size(77, 20);
            this.lblcmbProfessor.TabIndex = 2;
            this.lblcmbProfessor.Text = "Professor";
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Location = new System.Drawing.Point(346, 29);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(359, 28);
            this.cmbProfessor.TabIndex = 1;
            // 
            // FrmMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 630);
            this.ControlBox = false;
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
            this.Name = "FrmMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e manutenção de Matérias";
            this.Load += new System.EventHandler(this.FrmMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
            this.pnlDataGrid.ResumeLayout(false);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvMateria;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblcmbProfessor;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.Label lblNome_Materia;
        private System.Windows.Forms.TextBox txtNome_Materia;
        private System.Windows.Forms.Label lblDicaInserir;
        private System.Windows.Forms.Label lblDicaConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Professor;
    }
}