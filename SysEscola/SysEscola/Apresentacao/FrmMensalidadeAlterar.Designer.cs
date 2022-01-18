namespace Apresentacao
{
    partial class FrmMensalidadeAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMensalidadeAlterar));
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtNum_Mensalidade = new System.Windows.Forms.TextBox();
            this.lblNum_Mensalidade = new System.Windows.Forms.Label();
            this.dtpDataVcto = new System.Windows.Forms.DateTimePicker();
            this.lblDtVcto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblVlr_Juros = new System.Windows.Forms.Label();
            this.txtVlr_Juros = new System.Windows.Forms.TextBox();
            this.lblValorMulta = new System.Windows.Forms.Label();
            this.txtValorMulta = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(248, 248);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(135, 55);
            this.btnFechar.TabIndex = 144;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtNum_Mensalidade
            // 
            this.txtNum_Mensalidade.Location = new System.Drawing.Point(198, 47);
            this.txtNum_Mensalidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNum_Mensalidade.Name = "txtNum_Mensalidade";
            this.txtNum_Mensalidade.ReadOnly = true;
            this.txtNum_Mensalidade.Size = new System.Drawing.Size(86, 26);
            this.txtNum_Mensalidade.TabIndex = 145;
            this.txtNum_Mensalidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNum_Mensalidade
            // 
            this.lblNum_Mensalidade.AutoSize = true;
            this.lblNum_Mensalidade.Location = new System.Drawing.Point(9, 50);
            this.lblNum_Mensalidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum_Mensalidade.Name = "lblNum_Mensalidade";
            this.lblNum_Mensalidade.Size = new System.Drawing.Size(181, 20);
            this.lblNum_Mensalidade.TabIndex = 146;
            this.lblNum_Mensalidade.Text = "Número da Mensalidade";
            // 
            // dtpDataVcto
            // 
            this.dtpDataVcto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVcto.Location = new System.Drawing.Point(198, 81);
            this.dtpDataVcto.Name = "dtpDataVcto";
            this.dtpDataVcto.Size = new System.Drawing.Size(129, 26);
            this.dtpDataVcto.TabIndex = 147;
            // 
            // lblDtVcto
            // 
            this.lblDtVcto.AutoSize = true;
            this.lblDtVcto.Location = new System.Drawing.Point(35, 86);
            this.lblDtVcto.Name = "lblDtVcto";
            this.lblDtVcto.Size = new System.Drawing.Size(155, 20);
            this.lblDtVcto.TabIndex = 148;
            this.lblDtVcto.Text = "Data de Vencimento";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(144, 118);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 150;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(198, 115);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(101, 26);
            this.txtValor.TabIndex = 149;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // lblVlr_Juros
            // 
            this.lblVlr_Juros.AutoSize = true;
            this.lblVlr_Juros.Location = new System.Drawing.Point(71, 154);
            this.lblVlr_Juros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVlr_Juros.Name = "lblVlr_Juros";
            this.lblVlr_Juros.Size = new System.Drawing.Size(119, 20);
            this.lblVlr_Juros.TabIndex = 152;
            this.lblVlr_Juros.Text = "Valor dos Juros";
            // 
            // txtVlr_Juros
            // 
            this.txtVlr_Juros.Location = new System.Drawing.Point(198, 151);
            this.txtVlr_Juros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVlr_Juros.Name = "txtVlr_Juros";
            this.txtVlr_Juros.Size = new System.Drawing.Size(101, 26);
            this.txtVlr_Juros.TabIndex = 151;
            this.txtVlr_Juros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVlr_Juros.Leave += new System.EventHandler(this.txtVlr_Juros_Leave);
            // 
            // lblValorMulta
            // 
            this.lblValorMulta.AutoSize = true;
            this.lblValorMulta.Location = new System.Drawing.Point(79, 190);
            this.lblValorMulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorMulta.Name = "lblValorMulta";
            this.lblValorMulta.Size = new System.Drawing.Size(111, 20);
            this.lblValorMulta.TabIndex = 154;
            this.lblValorMulta.Text = "Valor da Multa";
            // 
            // txtValorMulta
            // 
            this.txtValorMulta.Location = new System.Drawing.Point(198, 187);
            this.txtValorMulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorMulta.Name = "txtValorMulta";
            this.txtValorMulta.Size = new System.Drawing.Size(101, 26);
            this.txtValorMulta.TabIndex = 153;
            this.txtValorMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorMulta.Leave += new System.EventHandler(this.txtValorMulta_Leave);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.Teal;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(87, 248);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(141, 55);
            this.btnGravar.TabIndex = 155;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // FrmMensalidadeAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 323);
            this.ControlBox = false;
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblValorMulta);
            this.Controls.Add(this.txtValorMulta);
            this.Controls.Add(this.lblVlr_Juros);
            this.Controls.Add(this.txtVlr_Juros);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblDtVcto);
            this.Controls.Add(this.dtpDataVcto);
            this.Controls.Add(this.lblNum_Mensalidade);
            this.Controls.Add(this.txtNum_Mensalidade);
            this.Controls.Add(this.btnFechar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMensalidadeAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altera as mesalidades geradas pelo sistema";
            this.Load += new System.EventHandler(this.FrmMensalidadeAlterar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtNum_Mensalidade;
        private System.Windows.Forms.Label lblNum_Mensalidade;
        private System.Windows.Forms.DateTimePicker dtpDataVcto;
        private System.Windows.Forms.Label lblDtVcto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblVlr_Juros;
        private System.Windows.Forms.TextBox txtVlr_Juros;
        private System.Windows.Forms.Label lblValorMulta;
        private System.Windows.Forms.TextBox txtValorMulta;
        private System.Windows.Forms.Button btnGravar;
    }
}