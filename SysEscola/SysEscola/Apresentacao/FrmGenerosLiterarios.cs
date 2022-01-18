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
    public partial class FrmGenerosLiterarios : Form
    {
        bool editar = false;

        public FrmGenerosLiterarios()
        {
            InitializeComponent();
            dgvItens.AutoGenerateColumns = false;
        }

        private void CarregaItens()
        {
            GenerosLiterariosColecao generosLiterariosColecao = new GenerosLiterariosColecao();
            GenerosLiterariosNegocios generosLiterariosNegocios = new GenerosLiterariosNegocios();
            generosLiterariosColecao = generosLiterariosNegocios.Consultar(txtPesquisar.Text);
            dgvItens.DataSource = generosLiterariosColecao;

            dgvItens.DataSource = generosLiterariosColecao;
            dgvItens.Update();
            dgvItens.Refresh();
        }

        private void SalvaAlteraItens()
        {
            GenerosLiterarios generosLiterarios = new GenerosLiterarios();
            generosLiterarios.Desc_Genero = Convert.ToString(txtDescricao.Text);

            if (editar == true)
            {
                generosLiterarios.Cod_Genero = Convert.ToInt32(dgvItens.CurrentRow.Cells[0].Value);
                GenerosLiterariosNegocios generosLiterariosNegocios = new GenerosLiterariosNegocios();
                string retorno = generosLiterariosNegocios.Alterar(generosLiterarios);

                try
                {
                    int idTurma = Convert.ToInt32(retorno);
                    MessageBox.Show("Ítem alterado com sucesso.");

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar o Gênero Literário .", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (editar == false)
            {
                if (String.IsNullOrEmpty(txtDescricao.Text))
                {
                    MessageBox.Show("Digite um nome para o ítem a ser inserido", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GenerosLiterariosNegocios generosLiterariosNegocios = new GenerosLiterariosNegocios();
                string retorno = generosLiterariosNegocios.Inserir(generosLiterarios);

                try
                {
                    int idItem = Convert.ToInt32(retorno);
                    MessageBox.Show("Ítem inserido com sucesso. Código: " + idItem);
                    CarregaItens();

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir o Gênero Literario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaItens();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Digite a descrição do Genero a ser inserido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            editar = false;
            SalvaAlteraItens();
            CarregaItens();
            txtDescricao.Text = "";

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
            GenerosLiterarios generosLiterarios = (dgvItens.SelectedRows[0].DataBoundItem as GenerosLiterarios);
            GenerosLiterariosNegocios generosLiterariosNegocios = new GenerosLiterariosNegocios();
            string retorno = generosLiterariosNegocios.Excluir(generosLiterarios);

            try
            {
                int codItemAvaliacao = Convert.ToInt32(retorno);
                CarregaItens();

            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o Gênero Literário." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

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
                txtDescricao.Text = Convert.ToString(dgvItens.CurrentRow.Cells[1].Value);
                btnAlterar.Text = "Salvar";

            }
            else if (btnAlterar.Text == "Salvar")
            {
                SalvaAlteraItens();
                btnInserir.Enabled = true;
                btnExcluir.Enabled = true;
                btnAlterar.Text = "Alterar";
                dgvItens.Enabled = true;
                txtDescricao.Text = "";
                CarregaItens();
            }

        }

        private void FrmGenerosLiterarios_Load(object sender, EventArgs e)
        {
            CarregaItens();
        }

    }
}
