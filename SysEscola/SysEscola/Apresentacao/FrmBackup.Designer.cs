namespace Apresentacao
{
    partial class FrmBackup
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
            this.pnlBackup = new System.Windows.Forms.Panel();
            this.btnPastaBackup = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lblBackup = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.pnlBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackup
            // 
            this.pnlBackup.BackColor = System.Drawing.Color.Teal;
            this.pnlBackup.Controls.Add(this.btnPastaBackup);
            this.pnlBackup.Controls.Add(this.btnBackup);
            this.pnlBackup.Controls.Add(this.lblBackup);
            this.pnlBackup.Controls.Add(this.txtCaminho);
            this.pnlBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBackup.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlBackup.Location = new System.Drawing.Point(12, 12);
            this.pnlBackup.Name = "pnlBackup";
            this.pnlBackup.Size = new System.Drawing.Size(499, 204);
            this.pnlBackup.TabIndex = 0;
            // 
            // btnPastaBackup
            // 
            this.btnPastaBackup.ForeColor = System.Drawing.Color.Teal;
            this.btnPastaBackup.Location = new System.Drawing.Point(365, 68);
            this.btnPastaBackup.Name = "btnPastaBackup";
            this.btnPastaBackup.Size = new System.Drawing.Size(89, 31);
            this.btnPastaBackup.TabIndex = 3;
            this.btnPastaBackup.Text = "Local";
            this.btnPastaBackup.UseVisualStyleBackColor = true;
            this.btnPastaBackup.Click += new System.EventHandler(this.btnPastaBackup_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Enabled = false;
            this.btnBackup.ForeColor = System.Drawing.Color.Teal;
            this.btnBackup.Location = new System.Drawing.Point(365, 105);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(89, 54);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Iniciar Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Location = new System.Drawing.Point(12, 47);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(127, 20);
            this.lblBackup.TabIndex = 1;
            this.lblBackup.Text = "Local do Backup";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(16, 70);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(343, 26);
            this.txtCaminho.TabIndex = 0;
            this.txtCaminho.TabStop = false;
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 228);
            this.Controls.Add(this.pnlBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup do banco de dados do sistema";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.pnlBackup.ResumeLayout(false);
            this.pnlBackup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackup;
        private System.Windows.Forms.Button btnPastaBackup;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.TextBox txtCaminho;
    }
}