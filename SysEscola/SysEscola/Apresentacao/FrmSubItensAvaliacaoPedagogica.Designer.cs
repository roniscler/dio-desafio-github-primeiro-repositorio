namespace Apresentacao
{
    partial class FrmSubItensAvaliacaoPedagogica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubItensAvaliacaoPedagogica));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSubItem = new System.Windows.Forms.DataGridView();
            this.clmnCodSubItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCod_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDescSubItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesc_Aval_Pedag = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtDesc_SI_Aval_Pedag = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescricaoItem2 = new System.Windows.Forms.Label();
            this.lblDescricaoItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubItem)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Sub Ítens";
            // 
            // dgvSubItem
            // 
            this.dgvSubItem.AllowUserToAddRows = false;
            this.dgvSubItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubItem.ColumnHeadersHeight = 30;
            this.dgvSubItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCodSubItem,
            this.clmnCod_Item,
            this.clmnDescSubItem});
            this.dgvSubItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubItem.Location = new System.Drawing.Point(12, 242);
            this.dgvSubItem.MultiSelect = false;
            this.dgvSubItem.Name = "dgvSubItem";
            this.dgvSubItem.ReadOnly = true;
            this.dgvSubItem.RowHeadersVisible = false;
            this.dgvSubItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSubItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSubItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubItem.Size = new System.Drawing.Size(513, 394);
            this.dgvSubItem.TabIndex = 63;
            this.dgvSubItem.TabStop = false;
            // 
            // clmnCodSubItem
            // 
            this.clmnCodSubItem.DataPropertyName = "Cod_SI_Aval_Pedag";
            this.clmnCodSubItem.HeaderText = "Código do Sub Ítem";
            this.clmnCodSubItem.Name = "clmnCodSubItem";
            this.clmnCodSubItem.ReadOnly = true;
            this.clmnCodSubItem.Visible = false;
            // 
            // clmnCod_Item
            // 
            this.clmnCod_Item.DataPropertyName = "Cod_Aval_Pedag";
            this.clmnCod_Item.HeaderText = "Código do Ítem";
            this.clmnCod_Item.Name = "clmnCod_Item";
            this.clmnCod_Item.ReadOnly = true;
            this.clmnCod_Item.Visible = false;
            // 
            // clmnDescSubItem
            // 
            this.clmnDescSubItem.DataPropertyName = "Desc_SI_Aval_Pedag";
            this.clmnDescSubItem.HeaderText = "Descrição do Sub Ítem";
            this.clmnDescSubItem.Name = "clmnDescSubItem";
            this.clmnDescSubItem.ReadOnly = true;
            this.clmnDescSubItem.Width = 493;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Controls.Add(this.txtPesquisar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 88);
            this.panel2.TabIndex = 66;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.Teal;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisar.Location = new System.Drawing.Point(362, 43);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(132, 39);
            this.btnPesquisar.TabIndex = 53;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Text = " Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(10, 49);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(325, 26);
            this.txtPesquisar.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Para localizar um item na grade digite o nome e clique em pesquisar";
            // 
            // lblDesc_Aval_Pedag
            // 
            this.lblDesc_Aval_Pedag.AutoSize = true;
            this.lblDesc_Aval_Pedag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc_Aval_Pedag.Location = new System.Drawing.Point(8, 170);
            this.lblDesc_Aval_Pedag.Name = "lblDesc_Aval_Pedag";
            this.lblDesc_Aval_Pedag.Size = new System.Drawing.Size(153, 20);
            this.lblDesc_Aval_Pedag.TabIndex = 68;
            this.lblDesc_Aval_Pedag.Text = "Descrição do ítem";
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInserir.Location = new System.Drawing.Point(403, 184);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(122, 47);
            this.btnInserir.TabIndex = 65;
            this.btnInserir.Text = "Inserir na Grade";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtDesc_SI_Aval_Pedag
            // 
            this.txtDesc_SI_Aval_Pedag.Location = new System.Drawing.Point(12, 193);
            this.txtDesc_SI_Aval_Pedag.MaxLength = 50;
            this.txtDesc_SI_Aval_Pedag.Name = "txtDesc_SI_Aval_Pedag";
            this.txtDesc_SI_Aval_Pedag.Size = new System.Drawing.Size(377, 26);
            this.txtDesc_SI_Aval_Pedag.TabIndex = 67;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(12, 644);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(122, 47);
            this.btnExcluir.TabIndex = 69;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(142, 644);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(122, 47);
            this.btnAlterar.TabIndex = 71;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(405, 644);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(122, 47);
            this.btnFechar.TabIndex = 70;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblDescricaoItem2);
            this.panel1.Controls.Add(this.lblDescricaoItem);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(12, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 61);
            this.panel1.TabIndex = 72;
            // 
            // lblDescricaoItem2
            // 
            this.lblDescricaoItem2.AutoSize = true;
            this.lblDescricaoItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoItem2.Location = new System.Drawing.Point(89, 19);
            this.lblDescricaoItem2.Name = "lblDescricaoItem2";
            this.lblDescricaoItem2.Size = new System.Drawing.Size(0, 24);
            this.lblDescricaoItem2.TabIndex = 67;
            // 
            // lblDescricaoItem
            // 
            this.lblDescricaoItem.AutoSize = true;
            this.lblDescricaoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoItem.Location = new System.Drawing.Point(22, 19);
            this.lblDescricaoItem.Name = "lblDescricaoItem";
            this.lblDescricaoItem.Size = new System.Drawing.Size(65, 24);
            this.lblDescricaoItem.TabIndex = 66;
            this.lblDescricaoItem.Text = "ITEM:";
            // 
            // FrmSubItensAvaliacaoPedagogica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDesc_Aval_Pedag);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtDesc_SI_Aval_Pedag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSubItem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSubItensAvaliacaoPedagogica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub Ítens de Avaliação PEdagógica";
            this.Load += new System.EventHandler(this.FrmSubItensAvaliacaoPedagogica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSubItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDesc_Aval_Pedag;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtDesc_SI_Aval_Pedag;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescricaoItem2;
        private System.Windows.Forms.Label lblDescricaoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCodSubItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDescSubItem;
    }
}