using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ObjetoTrasnferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FrmSubContaCorrente : Form
    {
        bool editar = false;
        ContaCorrente centroCustoSelecionado = new ContaCorrente();

        public FrmSubContaCorrente(ContaCorrente centroCusto)
        {
            InitializeComponent();
            dgvSubItem.AutoGenerateColumns = false;
            centroCustoSelecionado = centroCusto;
        }

        private void CarregaSubItens()
        {
            SubContaCorrenteColecao subCentroCustoColecao = new SubContaCorrenteColecao();
            SubContaCorrenteNegocios subCentroCustoNegocios = new SubContaCorrenteNegocios();
            subCentroCustoColecao = subCentroCustoNegocios.Consultar(centroCustoSelecionado.CodContaCorrente, txtPesquisar.Text);
            dgvSubItem.DataSource = subCentroCustoColecao;

            dgvSubItem.DataSource = subCentroCustoColecao.Select(s => new
            {
                s.CodSubConta,
                s.contaCorrente.CodContaCorrente,
                s.Descricao

            }).ToArray();

            dgvSubItem.Update();
            dgvSubItem.Refresh();

        }

        private void SalvaAlteraSubCentroCusto()
        {
            SubContaCorrente subContaCorrente = new SubContaCorrente();
            subContaCorrente.Descricao = Convert.ToString(txtDescricao.Text);

            if (editar == true)
            {
                subContaCorrente.CodSubConta = Convert.ToInt32(dgvSubItem.CurrentRow.Cells[0].Value);

                subContaCorrente.contaCorrente = new ContaCorrente();
                SubContaCorrenteNegocios subCentroCustoNegocios = new SubContaCorrenteNegocios();
                string retorno = subCentroCustoNegocios.Alterar(subContaCorrente);

                try
                {
                    int idSubCentroCusto = Convert.ToInt32(retorno);
                    MessageBox.Show("Sub ítem alterado com sucesso.");

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados do sub ítem do Centro de Custos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (editar == false)
            {
                if (String.IsNullOrEmpty(txtDescricao.Text))
                {
                    MessageBox.Show("Digite um nome para o sub ítem a ser inserido", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                subContaCorrente.contaCorrente = new ContaCorrente();
                subContaCorrente.contaCorrente.CodContaCorrente = centroCustoSelecionado.CodContaCorrente;
                SubContaCorrenteNegocios subCentroCustoNegocios = new SubContaCorrenteNegocios();
                string retorno = subCentroCustoNegocios.Inserir(subContaCorrente);

                try
                {
                    int idItem = Convert.ToInt32(retorno);
                    MessageBox.Show("Sub item inserido com sucesso. Código: " + idItem);
                    CarregaSubItens();

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir o sub ítem do Centro de Custos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaSubItens();
        }

        private void FrmSubCentroCusto_Load(object sender, EventArgs e)
        {
            lblDescricaoItem2.Text = Convert.ToString(centroCustoSelecionado.Descricao);
            CarregaSubItens();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Preencha uma descrição para o ítem", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            editar = false;
            SalvaAlteraSubCentroCusto();
            CarregaSubItens();
            txtDescricao.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvSubItem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnAlterar.Text == "Alterar")
            {
                editar = true;
                btnInserir.Enabled = false;
                btnExcluir.Enabled = false;
                dgvSubItem.Enabled = false;
                txtDescricao.Text = Convert.ToString(dgvSubItem.CurrentRow.Cells[2].Value);
                btnAlterar.Text = "Salvar";

            }
            else if (btnAlterar.Text == "Salvar")
            {
                SalvaAlteraSubCentroCusto();
                btnInserir.Enabled = true;
                btnExcluir.Enabled = true;
                btnAlterar.Text = "Alterar";
                dgvSubItem.Enabled = true;
                txtDescricao.Text = "";
                CarregaSubItens();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dgvSubItem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir o ítem da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            SubContaCorrente subContaCorrente = new SubContaCorrente();
            subContaCorrente.CodSubConta = Convert.ToInt32(dgvSubItem.CurrentRow.Cells[0].Value);
            SubContaCorrenteNegocios subCentroCustoNegocios = new SubContaCorrenteNegocios();
            string retorno = subCentroCustoNegocios.Excluir(subContaCorrente);

            try
            {
                int codItem = Convert.ToInt32(retorno);
                CarregaSubItens();

            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o sub ítem do Centro de Custo." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
