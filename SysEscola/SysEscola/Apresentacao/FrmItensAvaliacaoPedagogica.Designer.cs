namespace Apresentacao
{
    partial class FrmItensAvaliacaoPedagogica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensAvaliacaoPedagogica));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblTurmasCadastradas = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDesc_Aval_Pedag = new System.Windows.Forms.TextBox();
            this.lblDesc_Aval_Pedag = new System.Windows.Forms.Label();
            this.btnAdministrarSubItens = new System.Windows.Forms.Button();
            this.Cod_Aval_Pedag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Aval_Pedag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(403, 630);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(122, 47);
            this.btnFechar.TabIndex = 45;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInserir.Location = new System.Drawing.Point(403, 136);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(122, 47);
            this.btnInserir.TabIndex = 44;
            this.btnInserir.Text = "Inserir na Grade";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(133, 630);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(122, 47);
            this.btnAlterar.TabIndex = 46;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(8, 630);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(122, 47);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Para localizar um item na grade digite o nome e clique em pesquisar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.Teal;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisar.Location = new System.Drawing.Point(366, 36);
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
            this.txtPesquisar.Location = new System.Drawing.Point(14, 42);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(325, 26);
            this.txtPesquisar.TabIndex = 52;
            // 
            // lblTurmasCadastradas
            // 
            this.lblTurmasCadastradas.AutoSize = true;
            this.lblTurmasCadastradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurmasCadastradas.Location = new System.Drawing.Point(8, 201);
            this.lblTurmasCadastradas.Name = "lblTurmasCadastradas";
            this.lblTurmasCadastradas.Size = new System.Drawing.Size(452, 20);
            this.lblTurmasCadastradas.TabIndex = 56;
            this.lblTurmasCadastradas.Text = "Ítens de Avaliação Pedagogica cadastrados no sistema";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens.ColumnHeadersHeight = 30;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Aval_Pedag,
            this.Desc_Aval_Pedag});
            this.dgvItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItens.Location = new System.Drawing.Point(11, 224);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.RowHeadersWidth = 70;
            this.dgvItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(514, 399);
            this.dgvItens.TabIndex = 55;
            this.dgvItens.TabStop = false;
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
            this.panel2.Size = new System.Drawing.Size(513, 98);
            this.panel2.TabIndex = 58;
            // 
            // txtDesc_Aval_Pedag
            // 
            this.txtDesc_Aval_Pedag.Location = new System.Drawing.Point(12, 145);
            this.txtDesc_Aval_Pedag.MaxLength = 50;
            this.txtDesc_Aval_Pedag.Name = "txtDesc_Aval_Pedag";
            this.txtDesc_Aval_Pedag.Size = new System.Drawing.Size(377, 26);
            this.txtDesc_Aval_Pedag.TabIndex = 59;
            // 
            // lblDesc_Aval_Pedag
            // 
            this.lblDesc_Aval_Pedag.AutoSize = true;
            this.lblDesc_Aval_Pedag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc_Aval_Pedag.Location = new System.Drawing.Point(8, 122);
            this.lblDesc_Aval_Pedag.Name = "lblDesc_Aval_Pedag";
            this.lblDesc_Aval_Pedag.Size = new System.Drawing.Size(153, 20);
            this.lblDesc_Aval_Pedag.TabIndex = 60;
            this.lblDesc_Aval_Pedag.Text = "Descrição do ítem";
            // 
            // btnAdministrarSubItens
            // 
            this.btnAdministrarSubItens.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdministrarSubItens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdministrarSubItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarSubItens.ForeColor = System.Drawing.Color.Teal;
            this.btnAdministrarSubItens.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministrarSubItens.Image")));
            this.btnAdministrarSubItens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrarSubItens.Location = new System.Drawing.Point(258, 630);
            this.btnAdministrarSubItens.Name = "btnAdministrarSubItens";
            this.btnAdministrarSubItens.Size = new System.Drawing.Size(138, 47);
            this.btnAdministrarSubItens.TabIndex = 61;
            this.btnAdministrarSubItens.Text = "Sub Ítens (F5)";
            this.btnAdministrarSubItens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministrarSubItens.UseVisualStyleBackColor = false;
            this.btnAdministrarSubItens.Click += new System.EventHandler(this.btnAdministrarSubItens_Click);
            // 
            // Cod_Aval_Pedag
            // 
            this.Cod_Aval_Pedag.DataPropertyName = "Cod_Aval_Pedag";
            this.Cod_Aval_Pedag.HeaderText = "Código";
            this.Cod_Aval_Pedag.Name = "Cod_Aval_Pedag";
            this.Cod_Aval_Pedag.ReadOnly = true;
            this.Cod_Aval_Pedag.Visible = false;
            // 
            // Desc_Aval_Pedag
            // 
            this.Desc_Aval_Pedag.DataPropertyName = "Desc_Aval_Pedag";
            this.Desc_Aval_Pedag.HeaderText = "Descrição do Ítem";
            this.Desc_Aval_Pedag.Name = "Desc_Aval_Pedag";
            this.Desc_Aval_Pedag.ReadOnly = true;
            this.Desc_Aval_Pedag.Width = 494;
            // 
            // FrmItensAvaliacaoPedagogica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 685);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdministrarSubItens);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblTurmasCadastradas);
            this.Controls.Add(this.lblDesc_Aval_Pedag);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtDesc_Aval_Pedag);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmItensAvaliacaoPedagogica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itens de Avaliação Pedagógica e seus sub ìtens";
            this.Load += new System.EventHandler(this.FrmItensAvaliacaoPedagogica_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmItensAvaliacaoPedagogica_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblTurmasCadastradas;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDesc_Aval_Pedag;
        private System.Windows.Forms.Label lblDesc_Aval_Pedag;
        private System.Windows.Forms.Button btnAdministrarSubItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Aval_Pedag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Aval_Pedag;
    }
}