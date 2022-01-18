namespace Apresentacao.Relatorios
{
    partial class FrmCarnezinhorpt
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
            this.rpvwCarnezinho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpvwCarnezinho
            // 
            this.rpvwCarnezinho.ActiveViewIndex = -1;
            this.rpvwCarnezinho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpvwCarnezinho.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpvwCarnezinho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvwCarnezinho.Location = new System.Drawing.Point(0, 0);
            this.rpvwCarnezinho.Name = "rpvwCarnezinho";
            this.rpvwCarnezinho.Size = new System.Drawing.Size(1584, 1015);
            this.rpvwCarnezinho.TabIndex = 0;
            // 
            // FrmCarnezinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 1015);
            this.Controls.Add(this.rpvwCarnezinho);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarnezinho";
            this.Text = "Carnezinho de mensalidades de eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCarnezinho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpvwCarnezinho;
    }
}