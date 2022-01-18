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
    public partial class FrmItensAvaliacaoPedagogica : Form
    {
        bool editar;
        
        public FrmItensAvaliacaoPedagogica()
        {
            InitializeComponent();
        }

        private void CarregaItens()
        {
            ItensAvaliacaoPedagogicaColecao itensAvaliacao = new ItensAvaliacaoPedagogicaColecao();
            ItensAvaliacaoPedagNegocios itensAvaliacaoPedagNegocios = new ItensAvaliacaoPedagNegocios();
            itensAvaliacao = itensAvaliacaoPedagNegocios.Consultar(txtPesquisar.Text);
            dgvItens.DataSource = itensAvaliacao;

            dgvItens.DataSource = itensAvaliacao;
            dgvItens.Update();
            dgvItens.Refresh();
        }

        private void SalvaAlteraItens()
        {
            ItensAvaliacaoPedagogica itensAvaliacao = new ItensAvaliacaoPedagogica();
            itensAvaliacao.Desc_Aval_Pedag = Convert.ToString(txtDesc_Aval_Pedag.Text);

            if (editar == true)
            {
                itensAvaliacao.Cod_Aval_Pedag = Convert.ToInt32(dgvItens.CurrentRow.Cells[0].Value);
                ItensAvaliacaoPedagNegocios itensAvaliacaoPedagNegocios = new ItensAvaliacaoPedagNegocios();
                string retorno = itensAvaliacaoPedagNegocios.Alterar(itensAvaliacao);

                try
                {
                    int idTurma = Convert.ToInt32(retorno);
                    MessageBox.Show("Ítem alterado com sucesso.");

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados da Avaliação Pedagógica.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (editar == false)
            {
                if (String.IsNullOrEmpty(txtDesc_Aval_Pedag.Text))
                {
                    MessageBox.Show("Digite um nome para o ítem a ser inserido", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ItensAvaliacaoPedagNegocios itensAvaliacaoPedagNegocios = new ItensAvaliacaoPedagNegocios();
                string retorno = itensAvaliacaoPedagNegocios.Inserir(itensAvaliacao);

                try
                {
                    int idItem = Convert.ToInt32(retorno);
                    MessageBox.Show("Ítem inserido com sucesso. Código: " + idItem);
                    CarregaItens();

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir a Avaliação Pedagógica.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaItens();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDesc_Aval_Pedag.Text))
            {
                MessageBox.Show("Digite a descrição do ítem a ser inserido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            editar = false;
            SalvaAlteraItens();
            CarregaItens();
            txtDesc_Aval_Pedag.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvItens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnAlterar.Text == "Alterar")
            {
                editar = true;
                btnInserir.Enabled = false;
                btnExcluir.Enabled = false;
                dgvItens.Enabled = false;
                txtDesc_Aval_Pedag.Text = Convert.ToString(dgvItens.CurrentRow.Cells[1].Value);
                btnAlterar.Text = "Salvar";

            }
            else if (btnAlterar.Text == "Salvar")
            {
                SalvaAlteraItens();
                btnInserir.Enabled = true;
                btnExcluir.Enabled = true;
                btnAlterar.Text = "Alterar";
                dgvItens.Enabled = true;
                CarregaItens();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o ítem da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            if (dgvItens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            ItensAvaliacaoPedagogica itemAvaliacao = (dgvItens.SelectedRows[0].DataBoundItem as ItensAvaliacaoPedagogica);
            ItensAvaliacaoPedagNegocios itensAvaliacaoPedagNegocios = new ItensAvaliacaoPedagNegocios();
            string retorno = itensAvaliacaoPedagNegocios.Excluir(itemAvaliacao);

            try
            {
                int codItemAvaliacao = Convert.ToInt32(retorno);
                CarregaItens();

            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o Ítem de Avaliação Pedagógica." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmItensAvaliacaoPedagogica_Load(object sender, EventArgs e)
        {
            CarregaItens();
        }

        private void btnAdministrarSubItens_Click(object sender, EventArgs e)
        {

            if (dgvItens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe ítem de avaliação pedagógica selecionado.");
                return;
            }
            ItensAvaliacaoPedagogica itensAvalPEdag = (dgvItens.SelectedRows[0].DataBoundItem as ItensAvaliacaoPedagogica);
            FrmSubItensAvaliacaoPedagogica frmSubItensAvaliacaoPedagogica = new FrmSubItensAvaliacaoPedagogica(itensAvalPEdag);
            frmSubItensAvaliacaoPedagogica.ShowDialog();
        }

        private void FrmItensAvaliacaoPedagogica_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (dgvItens.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Não existe ítem de avaliação pegdagógica selecionado.");
                    return;
                }

                ItensAvaliacaoPedagogica itensAvalPEdag = (dgvItens.SelectedRows[0].DataBoundItem as ItensAvaliacaoPedagogica);
                FrmSubItensAvaliacaoPedagogica frmSubItensAvaliacaoPedagogica = new FrmSubItensAvaliacaoPedagogica(itensAvalPEdag);
                frmSubItensAvaliacaoPedagogica.ShowDialog();
            }
        }
    }
}
