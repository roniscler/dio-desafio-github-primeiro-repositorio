namespace Apresentacao.Relatorios
{
    partial class FrmFichaProfessor
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
            this.rpvwFichaProfessor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.btnFichaProfessor = new System.Windows.Forms.Button();
            this.pnlProfessor = new System.Windows.Forms.Panel();
            this.pnlProfessor.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpvwFichaProfessor
            // 
            this.rpvwFichaProfessor.ActiveViewIndex = -1;
            this.rpvwFichaProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvwFichaProfessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpvwFichaProfessor.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpvwFichaProfessor.Location = new System.Drawing.Point(12, 134);
            this.rpvwFichaProfessor.Name = "rpvwFichaProfessor";
            this.rpvwFichaProfessor.Size = new System.Drawing.Size(1196, 616);
            this.rpvwFichaProfessor.TabIndex = 0;
            this.rpvwFichaProfessor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Location = new System.Drawing.Point(23, 48);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(428, 28);
            this.cmbProfessor.TabIndex = 1;
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(19, 23);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(77, 20);
            this.lblProfessor.TabIndex = 2;
            this.lblProfessor.Text = "Professor";
            // 
            // btnFichaProfessor
            // 
            this.btnFichaProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFichaProfessor.ForeColor = System.Drawing.Color.Teal;
            this.btnFichaProfessor.Location = new System.Drawing.Point(486, 33);
            this.btnFichaProfessor.Name = "btnFichaProfessor";
            this.btnFichaProfessor.Size = new System.Drawing.Size(126, 43);
            this.btnFichaProfessor.TabIndex = 3;
            this.btnFichaProfessor.Text = "Vizualisar";
            this.btnFichaProfessor.UseVisualStyleBackColor = true;
            this.btnFichaProfessor.Click += new System.EventHandler(this.btnFichaProfessor_Click);
            // 
            // pnlProfessor
            // 
            this.pnlProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProfessor.BackColor = System.Drawing.Color.Teal;
            this.pnlProfessor.Controls.Add(this.lblProfessor);
            this.pnlProfessor.Controls.Add(this.btnFichaProfessor);
            this.pnlProfessor.Controls.Add(this.cmbProfessor);
            this.pnlProfessor.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlProfessor.Location = new System.Drawing.Point(12, 12);
            this.pnlProfessor.Name = "pnlProfessor";
            this.pnlProfessor.Size = new System.Drawing.Size(1196, 100);
            this.pnlProfessor.TabIndex = 4;
            // 
            // FrmFichaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 762);
            this.Controls.Add(this.pnlProfessor);
            this.Controls.Add(this.rpvwFichaProfessor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFichaProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha do professor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFichaProfessorcs_Load);
            this.pnlProfessor.ResumeLayout(false);
            this.pnlProfessor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpvwFichaProfessor;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Button btnFichaProfessor;
        private System.Windows.Forms.Panel pnlProfessor;
    }
}