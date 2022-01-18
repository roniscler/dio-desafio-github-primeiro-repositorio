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
    public partial class FrmSubItensAvaliacaoPedagogica : Form
    {
        ItensAvaliacaoPedagogica ItemAvalpedagTrasnf;
        bool editar;

        public FrmSubItensAvaliacaoPedagogica(ItensAvaliacaoPedagogica novoItemAvalPedag)
        {
            InitializeComponent();
            dgvSubItem.AutoGenerateColumns = false;
            ItemAvalpedagTrasnf = novoItemAvalPedag;

        }

        private void CarregaSubItens()
        {
            SubItensAvaliacaoPedagogicaColecao SubItensAvaliacao = new SubItensAvaliacaoPedagogicaColecao();
            SubItemAvaliacaoPedagogicaNegocios subItemAvaliacaoPedagogicaNegocios = new SubItemAvaliacaoPedagogicaNegocios();
            SubItensAvaliacao = subItemAvaliacaoPedagogicaNegocios.Consultar(txtPesquisar.Text, ItemAvalpedagTrasnf.Cod_Aval_Pedag);
            dgvSubItem.DataSource = SubItensAvaliacao;

            dgvSubItem.DataSource = SubItensAvaliacao;
            dgvSubItem.Update();
            dgvSubItem.Refresh();

        }

        private void SalvaAlteraSubItens()
        {
            SubItensAvaliacaoPedagogica subItensAvaliacao = new SubItensAvaliacaoPedagogica();
            subItensAvaliacao.Desc_SI_Aval_Pedag = Convert.ToString(txtDesc_SI_Aval_Pedag.Text);

            if (editar == true)
            {
                subItensAvaliacao.Cod_SI_Aval_Pedag = Convert.ToInt32(dgvSubItem.CurrentRow.Cells[0].Value);
                subItensAvaliacao.Cod_Aval_Pedag = Convert.ToInt32(dgvSubItem.CurrentRow.Cells[1].Value);
                SubItemAvaliacaoPedagogicaNegocios subItensAvaliacaoPedagNegocios = new SubItemAvaliacaoPedagogicaNegocios();
                string retorno = subItensAvaliacaoPedagNegocios.Alterar(subItensAvaliacao);

                try
                {
                    int idTurma = Convert.ToInt32(retorno);
                    MessageBox.Show("Sub ítem alterado com sucesso.");

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados do Sub Ítem de Avaliação Pedagógica.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (editar == false)
            {
                if (String.IsNullOrEmpty(txtDesc_SI_Aval_Pedag.Text))
                {
                    MessageBox.Show("Digite um nome para o sub ítem a ser inserido", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                subItensAvaliacao.Cod_Aval_Pedag = ItemAvalpedagTrasnf.Cod_Aval_Pedag;
                SubItemAvaliacaoPedagogicaNegocios subItensAvaliacaoPedagNegocios = new SubItemAvaliacaoPedagogicaNegocios();
                string retorno = subItensAvaliacaoPedagNegocios.Inserir(subItensAvaliacao);

                try
                {
                    int idItem = Convert.ToInt32(retorno);
                    MessageBox.Show("Ítem inserido com sucesso. Código: " + idItem);
                    CarregaSubItens();

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir o Sub Ítem de Avaliação Pedagógica.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSubItensAvaliacaoPedagogica_Load(object sender, EventArgs e)
        {
            lblDescricaoItem2.Text = Convert.ToString(ItemAvalpedagTrasnf.Desc_Aval_Pedag);
            CarregaSubItens();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaSubItens();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            editar = false;
            SalvaAlteraSubItens();
            CarregaSubItens();
            txtDesc_SI_Aval_Pedag.Text = "";

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvSubItem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir o ítem da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            SubItensAvaliacaoPedagogica subItemAvaliacao = (dgvSubItem.SelectedRows[0].DataBoundItem as SubItensAvaliacaoPedagogica);
            SubItemAvaliacaoPedagogicaNegocios subItensAvaliacaoPedagNegocios = new SubItemAvaliacaoPedagogicaNegocios();
            string retorno = subItensAvaliacaoPedagNegocios.Excluir(subItemAvaliacao);

            try
            {
                int codItemAvaliacao = Convert.ToInt32(retorno);
                CarregaSubItens();

            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o Sub Ítem de Avaliação Pedagógica." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
                txtDesc_SI_Aval_Pedag.Text = Convert.ToString(dgvSubItem.CurrentRow.Cells[2].Value);
                btnAlterar.Text = "Salvar";

            }
            else if (btnAlterar.Text == "Salvar")
            {
                SalvaAlteraSubItens();
                btnInserir.Enabled = true;
                btnExcluir.Enabled = true;
                btnAlterar.Text = "Alterar";
                dgvSubItem.Enabled = true;
                txtDesc_SI_Aval_Pedag.Text = "";
                CarregaSubItens();
            }

        }
    }
}
