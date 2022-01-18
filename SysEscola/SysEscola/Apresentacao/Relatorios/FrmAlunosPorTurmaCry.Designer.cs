namespace Apresentacao.Relatorios
{
    partial class FrmAlunosPorTurmaCry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlunosPorTurmaCry));
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.cmbTurmas = new System.Windows.Forms.ComboBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.btnGerarRelatorioTurma = new System.Windows.Forms.Button();
            this.rpvwAlunosPorTurma = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnlCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCabecalho.BackColor = System.Drawing.Color.Teal;
            this.pnlCabecalho.Controls.Add(this.cmbTurmas);
            this.pnlCabecalho.Controls.Add(this.lblTurma);
            this.pnlCabecalho.Controls.Add(this.btnGerarRelatorioTurma);
            this.pnlCabecalho.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlCabecalho.Location = new System.Drawing.Point(12, 12);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(1154, 113);
            this.pnlCabecalho.TabIndex = 49;
            // 
            // cmbTurmas
            // 
            this.cmbTurmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurmas.FormattingEnabled = true;
            this.cmbTurmas.Location = new System.Drawing.Point(18, 46);
            this.cmbTurmas.Name = "cmbTurmas";
            this.cmbTurmas.Size = new System.Drawing.Size(333, 26);
            this.cmbTurmas.TabIndex = 7;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.Location = new System.Drawing.Point(14, 16);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(158, 20);
            this.lblTurma.TabIndex = 6;
            this.lblTurma.Text = "Selecione a Turma";
            // 
            // btnGerarRelatorioTurma
            // 
            this.btnGerarRelatorioTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorioTurma.ForeColor = System.Drawing.Color.Teal;
            this.btnGerarRelatorioTurma.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarRelatorioTurma.Image")));
            this.btnGerarRelatorioTurma.Location = new System.Drawing.Point(377, 35);
            this.btnGerarRelatorioTurma.Name = "btnGerarRelatorioTurma";
            this.btnGerarRelatorioTurma.Size = new System.Drawing.Size(123, 38);
            this.btnGerarRelatorioTurma.TabIndex = 5;
            this.btnGerarRelatorioTurma.Text = "Visualizar";
            this.btnGerarRelatorioTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerarRelatorioTurma.UseVisualStyleBackColor = true;
            this.btnGerarRelatorioTurma.Click += new System.EventHandler(this.btnGerarRelatorioTurma_Click);
            // 
            // rpvwAlunosPorTurma
            // 
            this.rpvwAlunosPorTurma.ActiveViewIndex = -1;
            this.rpvwAlunosPorTurma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvwAlunosPorTurma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpvwAlunosPorTurma.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpvwAlunosPorTurma.Location = new System.Drawing.Point(12, 131);
            this.rpvwAlunosPorTurma.Name = "rpvwAlunosPorTurma";
            this.rpvwAlunosPorTurma.Size = new System.Drawing.Size(1154, 433);
            this.rpvwAlunosPorTurma.TabIndex = 50;
            this.rpvwAlunosPorTurma.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmAlunosPorTurmaCry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 576);
            this.Controls.Add(this.rpvwAlunosPorTurma);
            this.Controls.Add(this.pnlCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlunosPorTurmaCry";
            this.Text = "Impressão de alunos por turma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAlunosPorTurmaCry_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.ComboBox cmbTurmas;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Button btnGerarRelatorioTurma;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpvwAlunosPorTurma;
    }
}