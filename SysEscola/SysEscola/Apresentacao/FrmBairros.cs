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
    public partial class FrmBairros : Form
    {
        string acaoVinda;

        public FrmBairros(string acao)
        {
            acaoVinda = acao;

            InitializeComponent();
        }

        private void carregaGridBairros()
        {
            BairrosColecao bairrosCoelcao = new BairrosColecao();
            BairrosNegocios bairrosNegocios = new BairrosNegocios();

            bairrosCoelcao = bairrosNegocios.Consultar(txtpesquisaNome.Text);
            dgvBairros.DataSource = bairrosCoelcao;

            dgvBairros.DataSource = bairrosCoelcao;
            dgvBairros.Update();
            dgvBairros.Refresh();

        }

        private void novoBairro()
        {
            Bairros novoBairro = new Bairros();
            novoBairro.Nome_Bairro = txtpesquisaNome.Text;
            BairrosNegocios bairrosNegocios = new BairrosNegocios();
            string retorno = bairrosNegocios.Inserir(novoBairro);

            try
            {

                int codElem = Convert.ToInt32(retorno);
                MessageBox.Show("Bairro inserido com sucesso. Código: " + codElem);
                txtpesquisaNome.Text = "";
                carregaGridBairros();

            }
            catch
            {
                MessageBox.Show("Não Foi possivel inserir o bairro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alterarBairro()
        {
            Bairros bairros = new Bairros();
            BairrosNegocios bairrosNegocios = new BairrosNegocios();
            bairros.Cod_Bairro = Convert.ToInt32(dgvBairros.CurrentRow.Cells[0].Value);
            bairros.Nome_Bairro = txtpesquisaNome.Text;
            string retorno = bairrosNegocios.Alterar(bairros);
            try
            {
                int codElem = Convert.ToInt32(retorno);
                MessageBox.Show("Bairro alterado com sucesso.");
                txtpesquisaNome.Text = "";
                carregaGridBairros();
                btnAlterar.Text = "Alterar";
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados do Bairro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregaGridBairros();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvBairros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnAlterar.Text == "Alterar")
            {
                txtpesquisaNome.Text = Convert.ToString(dgvBairros.CurrentRow.Cells[1].Value);
                btnAlterar.Text = "Gravar";
            }

            else if (btnAlterar.Text == "Gravar")
            {

                if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "")
                {
                    btnAlterar.Text = "Alterar";
                    return;
                }

                for (int i = 0; i < dgvBairros.Rows.Count; i++)
                {

                    if (txtpesquisaNome.Text.ToUpper() == dgvBairros[1, i].Value.ToString().ToUpper())
                    {

                        MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnAlterar.Text = "Alterar";
                        return;
                    }

                }

                alterarBairro();

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvBairros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir o item da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Bairros bairroSelecionado = (dgvBairros.SelectedRows[0].DataBoundItem as Bairros);
            BairrosNegocios bairrosNegocios = new BairrosNegocios();
            string retorno = bairrosNegocios.Excluir(bairroSelecionado);

            try
            {
                int codElem = Convert.ToInt32(retorno);
                txtpesquisaNome.Text = "";
                carregaGridBairros();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "") return;

            for (int i = 0; i < dgvBairros.Rows.Count; i++)
            {

                if (txtpesquisaNome.Text.ToUpper() == dgvBairros[1, i].Value.ToString().ToUpper())
                {

                    MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnAlterar.Text = "Alterar";
                    return;
                }

            }

            novoBairro();
            if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;
        }

        private void FrmBairros_Load(object sender, EventArgs e)
        {
            carregaGridBairros();
        }

        private void FrmBairros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }


    }
}
