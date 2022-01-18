namespace Apresentacao
{
    partial class FrmRestore
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
            this.pnlRestore = new System.Windows.Forms.Panel();
            this.btnPastaRestore = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblRestore = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.pnlRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRestore
            // 
            this.pnlRestore.BackColor = System.Drawing.Color.Teal;
            this.pnlRestore.Controls.Add(this.btnPastaRestore);
            this.pnlRestore.Controls.Add(this.btnRestore);
            this.pnlRestore.Controls.Add(this.lblRestore);
            this.pnlRestore.Controls.Add(this.txtCaminho);
            this.pnlRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRestore.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlRestore.Location = new System.Drawing.Point(12, 12);
            this.pnlRestore.Name = "pnlRestore";
            this.pnlRestore.Size = new System.Drawing.Size(499, 204);
            this.pnlRestore.TabIndex = 1;
            // 
            // btnPastaRestore
            // 
            this.btnPastaRestore.ForeColor = System.Drawing.Color.Teal;
            this.btnPastaRestore.Location = new System.Drawing.Point(365, 68);
            this.btnPastaRestore.Name = "btnPastaRestore";
            this.btnPastaRestore.Size = new System.Drawing.Size(89, 31);
            this.btnPastaRestore.TabIndex = 3;
            this.btnPastaRestore.Text = "Local";
            this.btnPastaRestore.UseVisualStyleBackColor = true;
            this.btnPastaRestore.Click += new System.EventHandler(this.btnPastaRestore_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.ForeColor = System.Drawing.Color.Teal;
            this.btnRestore.Location = new System.Drawing.Point(365, 105);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(89, 54);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Iniciar Restauração";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.Location = new System.Drawing.Point(12, 47);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(158, 20);
            this.lblRestore.TabIndex = 1;
            this.lblRestore.Text = "Local da restauração";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(16, 70);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(343, 26);
            this.txtCaminho.TabIndex = 0;
            this.txtCaminho.TabStop = false;
            // 
            // FrmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 228);
            this.Controls.Add(this.pnlRestore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restauração do Banco de Dados";
            this.pnlRestore.ResumeLayout(false);
            this.pnlRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRestore;
        private System.Windows.Forms.Button btnPastaRestore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblRestore;
        private System.Windows.Forms.TextBox txtCaminho;
    }
}