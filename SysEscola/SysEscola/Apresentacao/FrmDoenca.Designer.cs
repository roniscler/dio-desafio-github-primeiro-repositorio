namespace Apresentacao
{
    partial class FrmDoenca
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
            this.dgvDoenca = new System.Windows.Forms.DataGridView();
            this.txtpesquisaNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblDica1 = new System.Windows.Forms.Label();
            this.lblDica2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cod_Doenca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Doenca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoenca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoenca
            // 
            this.dgvDoenca.AllowUserToAddRows = false;
            this.dgvDoenca.AllowUserToOrderColumns = true;
            this.dgvDoenca.AllowUserToResizeColumns = false;
            this.dgvDoenca.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoenca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoenca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoenca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Doenca,
            this.Nome_Doenca});
            this.dgvDoenca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDoenca.Location = new System.Drawing.Point(13, 98);
            this.dgvDoenca.MultiSelect = false;
            this.dgvDoenca.Name = "dgvDoenca";
            this.dgvDoenca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoenca.Size = new System.Drawing.Size(361, 284);
            this.dgvDoenca.TabIndex = 0;
            // 
            // txtpesquisaNome
            // 
            this.txtpesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtpesquisaNome.Location = new System.Drawing.Point(13, 59);
            this.txtpesquisaNome.MaxLength = 25;
            this.txtpesquisaNome.Name = "txtpesquisaNome";
            this.txtpesquisaNome.Size = new System.Drawing.Size(250, 26);
            this.txtpesquisaNome.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesquisar.Location = new System.Drawing.Point(270, 59);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 26);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIncluir.Location = new System.Drawing.Point(270, 431);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(105, 34);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "Inserir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExcluir.Location = new System.Drawing.Point(158, 431);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 34);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlterar.Location = new System.Drawing.Point(47, 431);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 34);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblDica1
            // 
            this.lblDica1.AutoSize = true;
            this.lblDica1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDica1.ForeColor = System.Drawing.Color.Teal;
            this.lblDica1.Location = new System.Drawing.Point(6, 15);
            this.lblDica1.Name = "lblDica1";
            this.lblDica1.Size = new System.Drawing.Size(246, 13);
            this.lblDica1.TabIndex = 6;
            this.lblDica1.Text = "Para pesquisar digite o texto e clique em Pesquisar";
            // 
            // lblDica2
            // 
            this.lblDica2.AutoSize = true;
            this.lblDica2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDica2.ForeColor = System.Drawing.Color.Teal;
            this.lblDica2.Location = new System.Drawing.Point(6, 37);
            this.lblDica2.Name = "lblDica2";
            this.lblDica2.Size = new System.Drawing.Size(210, 13);
            this.lblDica2.TabIndex = 7;
            this.lblDica2.Text = "Para inserir digite o texto e clique em Inserir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(9, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Para alterar selecione item na lista e clique em \"alterar\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(12, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Altere e clique em gavar para efetivar a alteração do item.";
            // 
            // Cod_Doenca
            // 
            this.Cod_Doenca.DataPropertyName = "Cod_Doenca";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cod_Doenca.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cod_Doenca.Frozen = true;
            this.Cod_Doenca.HeaderText = "Código";
            this.Cod_Doenca.Name = "Cod_Doenca";
            this.Cod_Doenca.ReadOnly = true;
            this.Cod_Doenca.Width = 90;
            // 
            // Nome_Doenca
            // 
            this.Nome_Doenca.DataPropertyName = "Nome_Doenca";
            this.Nome_Doenca.HeaderText = "Nome da Doença";
            this.Nome_Doenca.Name = "Nome_Doenca";
            this.Nome_Doenca.ReadOnly = true;
            this.Nome_Doenca.Width = 200;
            // 
            // FrmDoenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDica2);
            this.Controls.Add(this.lblDica1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtpesquisaNome);
            this.Controls.Add(this.dgvDoenca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoenca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Doenças do Sistema";
            this.Load += new System.EventHandler(this.frmDoenca_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDoenca_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoenca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoenca;
        private System.Windows.Forms.TextBox txtpesquisaNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblDica1;
        private System.Windows.Forms.Label lblDica2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Doenca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Doenca;
    }
}