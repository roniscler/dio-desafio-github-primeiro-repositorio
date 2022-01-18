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
    public partial class FrmContaCorrente : Form
    {
        bool editar = false;

        public FrmContaCorrente()
        {
            InitializeComponent();
            dgvItens.AutoGenerateColumns = false;
        }

        private void CarregaItens()
        {
            ContaCorrenteColecao centroCustoColecao = new ContaCorrenteColecao();
            ContaCorrenteNegocios centroCustoNegocios = new ContaCorrenteNegocios();
            centroCustoColecao = centroCustoNegocios.Consultar(txtPesquisar.Text);
            dgvItens.DataSource = centroCustoColecao;

            dgvItens.DataSource = centroCustoColecao;
            dgvItens.Update();
            dgvItens.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaItens();
        }

        private void SalvaAlteraItens()
        {
            ContaCorrente centroCusto = new ContaCorrente();
            centroCusto.Descricao = Convert.ToString(txtDescCentroCusto.Text);

            if (editar == true)
            {
                centroCusto.CodContaCorrente = Convert.ToInt32(dgvItens.CurrentRow.Cells[0].Value);
                ContaCorrenteNegocios centroCustoNegocios = new ContaCorrenteNegocios();
                string retorno = centroCustoNegocios.Alterar(centroCusto);

                try
                {
                    int idCentroCusto = Convert.ToInt32(retorno);
                    MessageBox.Show("Centro de Custo alterado com sucesso.");

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados do Cerntro de Custo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (editar == false)
            {
                if (String.IsNullOrEmpty(txtDescCentroCusto.Text))
                {
                    MessageBox.Show("Digite um nome para o ítem a ser inserido", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ContaCorrenteNegocios centroCustoNegocios = new ContaCorrenteNegocios();
                string retorno = centroCustoNegocios.Inserir(centroCusto);

                try
                {
                    int idItem = Convert.ToInt32(retorno);
                    MessageBox.Show("Centro de Custo inserido com sucesso. Código: " + idItem);
                    CarregaItens();

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir o Centro de Custo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            editar = false;
            SalvaAlteraItens();
            CarregaItens();
            txtDescCentroCusto.Text = "";

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvItens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir o ítem da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            
            ContaCorrente centroCustoSelecionado = (dgvItens.SelectedRows[0].DataBoundItem as ContaCorrente);
            ContaCorrenteNegocios centroCustoNegocios = new ContaCorrenteNegocios();
            string retorno = centroCustoNegocios.Excluir(centroCustoSelecionado);

            try
            {
                int codCentroCusto = Convert.ToInt32(retorno);
                CarregaItens();

            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o Centro de Custo." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvItens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Centro de Custo selecionado.");
                return;
            }
            if (btnAlterar.Text == "Alterar")
            {
                editar = true;
                btnInserir.Enabled = false;
                btnExcluir.Enabled = false;
                dgvItens.Enabled = false;
                txtDescCentroCusto.Text = Convert.ToString(dgvItens.CurrentRow.Cells[1].Value);
                btnAlterar.Text = "Salvar";

            }
            else if (btnAlterar.Text == "Salvar")
            {
                SalvaAlteraItens();
                btnInserir.Enabled = true;
                btnExcluir.Enabled = true;
                btnAlterar.Text = "Alterar";
                dgvItens.Enabled = true;
                txtDescCentroCusto.Text = "";
                CarregaItens();
            }

        }

        private void btnAdministrarSubItens_Click(object sender, EventArgs e)
        {
            if (dgvItens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Centro de Custo selecionado.");
                return;
            }
            ContaCorrente centroCustoSelecionado = (dgvItens.SelectedRows[0].DataBoundItem as ContaCorrente);
            FrmSubContaCorrente frmSubCentroCusto = new FrmSubContaCorrente(centroCustoSelecionado);
            frmSubCentroCusto.ShowDialog();

        }

        private void FrmCentroCusto_Load(object sender, EventArgs e)
        {
            CarregaItens();
        }


    }
}
