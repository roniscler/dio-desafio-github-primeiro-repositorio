using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;
using ObjetoTrasnferencia;



namespace Apresentacao
{
    public partial class FrmCarnezinhoParcelas : Form
    {
        CarnezinhoColecao carnezinhoColecaotrf = new CarnezinhoColecao(); 
        public FrmCarnezinhoParcelas()
        {            
            InitializeComponent();
            dgvParcelas.AutoGenerateColumns = false;
        }

        private void FrmParcelasCarnezinho_Load(object sender, EventArgs e)
        {
            CarregaTitulo();
        }

        private void CarregaTitulo()
        {
            lstTitulo.Items.Clear();

            CarnezinhoColecao carnezinhoColecao = new CarnezinhoColecao();
            CarnezinhoNegocios carnezinhoNegocios = new CarnezinhoNegocios();
            carnezinhoColecao = carnezinhoNegocios.ConsultarPorTituloAgrupado();
            for (int i = 0; i < carnezinhoColecao.Count; i++)
            {
                lstTitulo.Items.Add(carnezinhoColecao[i].Titulo);
            }


        }

        private void btnListarParcelas_Click(object sender, EventArgs e)
        {
            ListarParcelas();
        }

        private void ListarParcelas()
        {
            CarnezinhoColecao carnezinhoColecao = new CarnezinhoColecao();
            CarnezinhoNegocios carnezinhoNegocios = new CarnezinhoNegocios();
            if (lstTitulo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item na lista", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                carnezinhoColecao = carnezinhoNegocios.ConsultarTitulo(lstTitulo.SelectedItem.ToString());
                carnezinhoColecaotrf = carnezinhoColecao;

                var novaListUsuario = carnezinhoColecao.Select(usuario => new
                {
                    Cod_Carnezinho = usuario.Cod_Coarnezinho,
                    Parcela = usuario.Parcela,
                    Data_Vcto = usuario.Data_Vcto,
                    Valor = usuario.Valor,
                    Nome_Aluno = usuario.aluno.Nome_Aluno,
                    Titulo = usuario.Titulo,
                    Cod_Aluno = usuario.aluno.Cod_Aluno
                }).ToList();

                dgvParcelas.DataSource = novaListUsuario;
                dgvParcelas.Refresh();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (rdbAlunoSelecionado.Checked == true)
            {
                if (dgvParcelas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um ítem a ser excluido!!!", "Seleção obrigatória", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CarnezinhoNegocios carnezinhoNegocios = new CarnezinhoNegocios();
                string idCarnezinho = carnezinhoNegocios.ExcluirPorAlunoTitulo(Convert.ToInt32(dgvParcelas.CurrentRow.Cells[1].Value), Convert.ToString(dgvParcelas.CurrentRow.Cells[6].Value));
                try
                {
                    Convert.ToInt32(idCarnezinho);
                    MessageBox.Show("Exclusão bem sucedida!!!", "Exclusão de parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvParcelas.DataSource = null;
                    ListarParcelas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (rdbSomenteSelecioada.Checked == true)
            {
                if (dgvParcelas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um ítem a ser excluido!!!", "Seleção obrigatória", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CarnezinhoNegocios carnezinhoNegocios = new CarnezinhoNegocios();
                Carnezinho carnezinho = new Carnezinho();
                carnezinho.Cod_Coarnezinho = Convert.ToInt32(dgvParcelas.CurrentRow.Cells[0].Value);
                string idCarnezinho = carnezinhoNegocios.Excluir(carnezinho);
                try
                {
                    Convert.ToInt32(idCarnezinho);
                    MessageBox.Show("Exclusão bem sucedida!!!", "Exclusão de parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarParcelas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (rdbTodas.Checked == true)
            {
                if (MessageBox.Show("Ação a seguir excluirá todos os registros da base de dados!!!", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    CarnezinhoNegocios carnezinhoNegocios = new CarnezinhoNegocios();
                    string idCarnezinho = carnezinhoNegocios.ExcluirTodos();
                    try
                    {
                        Convert.ToInt32(idCarnezinho);
                        MessageBox.Show("Todas as parcelas excluídas com sucesso!!!", "Limpeza da base de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaTitulo();

                        dgvParcelas.DataSource = null;
                        dgvParcelas.Rows.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }        

            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (carnezinhoColecaotrf.Count == 0 )
            {
                MessageBox.Show("Filtre as parcelasdo evento", "Grade vazia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rbdTodas.Checked == true)
            {
                ListarParcelas();
                Relatorios.FrmCarnezinhorpt frmCarnezinhorpt = new Relatorios.FrmCarnezinhorpt(carnezinhoColecaotrf);
                frmCarnezinhorpt.ShowDialog();
            }
            else if (rbdAluno.Checked == true)
            {
                int codAluno = Convert.ToInt32(dgvParcelas.CurrentRow.Cells[1].Value);
                ListarParcelas();
                carnezinhoColecaotrf.RemoveAll((x) => x.aluno.Cod_Aluno != codAluno);
                Relatorios.FrmCarnezinhorpt frmCarnezinhorpt = new Relatorios.FrmCarnezinhorpt(carnezinhoColecaotrf);
                frmCarnezinhorpt.ShowDialog();
            }
        }

    }
}
