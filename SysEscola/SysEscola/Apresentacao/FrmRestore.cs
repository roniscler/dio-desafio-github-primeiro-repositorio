using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Apresentacao
{
    public partial class FrmRestore : Form
    {
        public FrmRestore()
        {
            InitializeComponent();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ("Data Source=RONI\\SQLEXPRESS;Initial Catalog=EscolaSQL;Integrated Security=True");
                conn.Open();
                string sql1 = string.Format("ALTER DATABASE [EscolaSQL] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu1 = new SqlCommand(sql1, conn);
                bu1.ExecuteNonQuery();
 
                string sql2 = string.Format("USE MASTER RESTORE DATABASE [EscolaSQL] FROM DISK = '" + txtCaminho.Text + "'WITH REPLACE;");
                SqlCommand bu2 = new SqlCommand(sql2, conn);
                bu2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [EscolaSQL] SET MULTI_USER");
                SqlCommand bu3 = new SqlCommand(sql3, conn);
                bu3.ExecuteNonQuery();
                MessageBox.Show("Restauração concluída com sucesso", "Restauração do Backup", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnPastaRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Sql Server database backup files | *.bak*";
            openFileDialog.Title = "Restauração de dados";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = openFileDialog.FileName;
                btnRestore.Enabled = true;
            }
        }
    }
}
