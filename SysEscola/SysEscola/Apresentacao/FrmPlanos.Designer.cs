namespace Apresentacao
{
    partial class FrmPlanos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlanos));
            this.lblDica2 = new System.Windows.Forms.Label();
            this.lblDica1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvPlanos = new System.Windows.Forms.DataGridView();
            this.clmnCod_Plano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDesc_Plano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPEsquisaNome = new System.Windows.Forms.TextBox();
            this.lblDescricao_Plano = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDica2
            // 
            this.lblDica2.AutoSize = true;
            this.lblDica2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDica2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDica2.Location = new System.Drawing.Point(3, 31);
            this.lblDica2.Name = "lblDica2";
            this.lblDica2.Size = new System.Drawing.Size(210, 13);
            this.lblDica2.TabIndex = 17;
            this.lblDica2.Text = "Para inserir digite o texto e clique em Inserir";
            // 
            // lblDica1
            // 
            this.lblDica1.AutoSize = true;
            this.lblDica1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDica1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDica1.Location = new System.Drawing.Point(3, 9);
            this.lblDica1.Name = "lblDica1";
            this.lblDica1.Size = new System.Drawing.Size(246, 13);
            this.lblDica1.TabIndex = 16;
            this.lblDica1.Text = "Para pesquisar digite o texto e clique em Pesquisar";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(12, 135);
            this.txtNome.MaxLength = 25;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 26);
            this.txtNome.TabIndex = 2;
            // 
            // dgvPlanos
            // 
            this.dgvPlanos.AllowUserToAddRows = false;
            this.dgvPlanos.AllowUserToOrderColumns = true;
            this.dgvPlanos.AllowUserToResizeColumns = false;
            this.dgvPlanos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCod_Plano,
            this.clmnDesc_Plano,
            this.clmnValor});
            this.dgvPlanos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPlanos.Location = new System.Drawing.Point(12, 174);
            this.dgvPlanos.MultiSelect = false;
            this.dgvPlanos.Name = "dgvPlanos";
            this.dgvPlanos.RowHeadersVisible = false;
            this.dgvPlanos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanos.Size = new System.Drawing.Size(410, 284);
            this.dgvPlanos.TabIndex = 10;
            this.dgvPlanos.TabStop = false;
            // 
            // clmnCod_Plano
            // 
            this.clmnCod_Plano.DataPropertyName = "Cod_Plano";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnCod_Plano.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmnCod_Plano.Frozen = true;
            this.clmnCod_Plano.HeaderText = "Código";
            this.clmnCod_Plano.Name = "clmnCod_Plano";
            this.clmnCod_Plano.ReadOnly = true;
            this.clmnCod_Plano.Width = 90;
            // 
            // clmnDesc_Plano
            // 
            this.clmnDesc_Plano.DataPropertyName = "Desc_Plano";
            this.clmnDesc_Plano.HeaderText = "Descrição do Plano Estudantil";
            this.clmnDesc_Plano.Name = "clmnDesc_Plano";
            this.clmnDesc_Plano.ReadOnly = true;
            this.clmnDesc_Plano.Width = 200;
            // 
            // clmnValor
            // 
            this.clmnValor.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.clmnValor.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmnValor.HeaderText = "Valor";
            this.clmnValor.Name = "clmnValor";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlterar.Location = new System.Drawing.Point(94, 467);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 40);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExcluir.Location = new System.Drawing.Point(205, 467);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 40);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.BackgroundImage")));
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIncluir.Location = new System.Drawing.Point(317, 467);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(105, 40);
            this.btnIncluir.TabIndex = 4;
            this.btnIncluir.Text = "Inserir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Teal;
            this.btnPesquisar.Location = new System.Drawing.Point(299, 32);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 41);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.txtPEsquisaNome);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.lblDica1);
            this.panel1.Controls.Add(this.lblDica2);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 87);
            this.panel1.TabIndex = 21;
            // 
            // txtPEsquisaNome
            // 
            this.txtPEsquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPEsquisaNome.Location = new System.Drawing.Point(6, 47);
            this.txtPEsquisaNome.MaxLength = 25;
            this.txtPEsquisaNome.Name = "txtPEsquisaNome";
            this.txtPEsquisaNome.Size = new System.Drawing.Size(287, 26);
            this.txtPEsquisaNome.TabIndex = 0;
            // 
            // lblDescricao_Plano
            // 
            this.lblDescricao_Plano.AutoSize = true;
            this.lblDescricao_Plano.Location = new System.Drawing.Point(15, 119);
            this.lblDescricao_Plano.Name = "lblDescricao_Plano";
            this.lblDescricao_Plano.Size = new System.Drawing.Size(100, 13);
            this.lblDescricao_Plano.TabIndex = 22;
            this.lblDescricao_Plano.Text = "Descrição do Plano";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(314, 119);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 23;
            this.lblValor.Text = "Valor";
            // 
            // mskValor
            // 
            this.mskValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValor.Location = new System.Drawing.Point(316, 135);
            this.mskValor.Mask = "999.99";
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(100, 26);
            this.mskValor.TabIndex = 3;
            // 
            // FrmPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 517);
            this.Controls.Add(this.mskValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDescricao_Plano);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvPlanos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlanos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planos Estudantis";
            this.Load += new System.EventHandler(this.FrmPlanos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPlanos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDica2;
        private System.Windows.Forms.Label lblDica1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvPlanos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPEsquisaNome;
        private System.Windows.Forms.Label lblDescricao_Plano;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Plano;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDesc_Plano;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnValor;
    }
}