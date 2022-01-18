namespace Apresentacao
{
    partial class FrmHabitos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDica2 = new System.Windows.Forms.Label();
            this.lblDica1 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtpesquisaNome = new System.Windows.Forms.TextBox();
            this.dgvHabitos = new System.Windows.Forms.DataGridView();
            this.Cod_Habito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Habito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(15, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Altere e clique em gavar para efetivar a alteração do item.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Para alterar selecione item na lista e clique em \"alterar\"";
            // 
            // lblDica2
            // 
            this.lblDica2.AutoSize = true;
            this.lblDica2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDica2.ForeColor = System.Drawing.Color.Teal;
            this.lblDica2.Location = new System.Drawing.Point(9, 33);
            this.lblDica2.Name = "lblDica2";
            this.lblDica2.Size = new System.Drawing.Size(210, 13);
            this.lblDica2.TabIndex = 17;
            this.lblDica2.Text = "Para inserir digite o texto e clique em Inserir";
            // 
            // lblDica1
            // 
            this.lblDica1.AutoSize = true;
            this.lblDica1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDica1.ForeColor = System.Drawing.Color.Teal;
            this.lblDica1.Location = new System.Drawing.Point(9, 11);
            this.lblDica1.Name = "lblDica1";
            this.lblDica1.Size = new System.Drawing.Size(246, 13);
            this.lblDica1.TabIndex = 16;
            this.lblDica1.Text = "Para pesquisar digite o texto e clique em Pesquisar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlterar.Location = new System.Drawing.Point(50, 427);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 34);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExcluir.Location = new System.Drawing.Point(161, 427);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 34);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInserir.Location = new System.Drawing.Point(273, 427);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(105, 34);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesquisar.Location = new System.Drawing.Point(273, 55);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 26);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtpesquisaNome
            // 
            this.txtpesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtpesquisaNome.Location = new System.Drawing.Point(16, 55);
            this.txtpesquisaNome.MaxLength = 35;
            this.txtpesquisaNome.Name = "txtpesquisaNome";
            this.txtpesquisaNome.Size = new System.Drawing.Size(250, 26);
            this.txtpesquisaNome.TabIndex = 11;
            // 
            // dgvHabitos
            // 
            this.dgvHabitos.AllowUserToAddRows = false;
            this.dgvHabitos.AllowUserToOrderColumns = true;
            this.dgvHabitos.AllowUserToResizeColumns = false;
            this.dgvHabitos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHabitos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHabitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Habito,
            this.Desc_Habito});
            this.dgvHabitos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHabitos.Location = new System.Drawing.Point(16, 94);
            this.dgvHabitos.MultiSelect = false;
            this.dgvHabitos.Name = "dgvHabitos";
            this.dgvHabitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitos.Size = new System.Drawing.Size(361, 284);
            this.dgvHabitos.TabIndex = 10;
            // 
            // Cod_Habito
            // 
            this.Cod_Habito.DataPropertyName = "Cod_Habito";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cod_Habito.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cod_Habito.Frozen = true;
            this.Cod_Habito.HeaderText = "Código";
            this.Cod_Habito.Name = "Cod_Habito";
            this.Cod_Habito.ReadOnly = true;
            this.Cod_Habito.Width = 90;
            // 
            // Desc_Habito
            // 
            this.Desc_Habito.DataPropertyName = "Desc_Habito";
            this.Desc_Habito.HeaderText = "Descrição";
            this.Desc_Habito.Name = "Desc_Habito";
            this.Desc_Habito.ReadOnly = true;
            this.Desc_Habito.Width = 200;
            // 
            // FrmHabitos
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
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtpesquisaNome);
            this.Controls.Add(this.dgvHabitos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHabitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hábitos dos ALuno";
            this.Load += new System.EventHandler(this.frmHabitos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmHabitos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDica2;
        private System.Windows.Forms.Label lblDica1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtpesquisaNome;
        private System.Windows.Forms.DataGridView dgvHabitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Habito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Habito;
    }
}