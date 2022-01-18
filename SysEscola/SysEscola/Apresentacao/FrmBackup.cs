using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;

namespace Apresentacao
{
    public partial class FrmBackup : Form
    {
        
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {

        }

        private void btnPastaBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog bkp = new FolderBrowserDialog();
            if(bkp.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = bkp.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCaminho.Text))
                {
                    MessageBox.Show("Por favor entre com o local para o Backup", "Caminho inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {                    
                    BackupRestoreNegocios backupRestoreNegocios = new BackupRestoreNegocios();
                    string resultado = backupRestoreNegocios.Backup(txtCaminho.Text + @"\", "SysEscola");
                    MessageBox.Show(resultado, "Backup", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
