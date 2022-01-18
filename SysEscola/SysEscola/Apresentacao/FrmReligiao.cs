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
    public partial class FrmReligiao : Form
    {
        string acaoVinda = null;

        public FrmReligiao(string acao)
        {
            acaoVinda = acao;

            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            CarregaGridReligiao();

        }

        private void CarregaGridReligiao()
        {
            ReligiaoColecao religiaoColecao = new ReligiaoColecao();
            ReligiaoNegocios religiaoNegocio = new ReligiaoNegocios();
            religiaoColecao = religiaoNegocio.Consultar(txtpesquisaNome.Text);
            dgvReligiao.DataSource = religiaoColecao;

            dgvReligiao.DataSource = religiaoColecao;
            dgvReligiao.Update();
            dgvReligiao.Refresh();
        }

        private void FrmReligiao_Load(object sender, EventArgs e)
        {
            CarregaGridReligiao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvReligiao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnAlterar.Text == "Alterar")
            {
                txtpesquisaNome.Text = Convert.ToString(dgvReligiao.CurrentRow.Cells[1].Value);
                btnAlterar.Text = "Gravar";
            }

            else if (btnAlterar.Text == "Gravar")
            {

                if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "")
                {
                    btnAlterar.Text = "Alterar";
                    return;
                }

                for (int i = 0; i < dgvReligiao.Rows.Count; i++)
                {

                    if (txtpesquisaNome.Text.ToUpper() == dgvReligiao[1, i].Value.ToString().ToUpper())
                    {

                        MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnAlterar.Text = "Alterar";
                        return;
                    }

                }

                alterarReligiao();
              
            }
        }

        private void alterarReligiao()
        {
            Religiao religiao = new Religiao();
            ReligiaoNegocios religiaoNegocio = new ReligiaoNegocios();
            religiao.Cod_religiao = Convert.ToInt32(dgvReligiao.CurrentRow.Cells[0].Value);
            religiao.Nome_Religiao = txtpesquisaNome.Text;
            string retorno = religiaoNegocio.Alterar(religiao);
            try
            {
                int codelem = Convert.ToInt32(retorno);
                MessageBox.Show("Item alterado com sucesso.");
                txtpesquisaNome.Text = "";
                CarregaGridReligiao();
                btnAlterar.Text = "Alterar";
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados do item.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void novaReligiao()
        {
            Religiao novaReligiao = new Religiao();
            novaReligiao.Nome_Religiao = txtpesquisaNome.Text;
            ReligiaoNegocios religiaoNegocios = new ReligiaoNegocios();
            string retorno = religiaoNegocios.Inserir(novaReligiao);

            try
            {

                int codElem = Convert.ToInt32(retorno);
                MessageBox.Show("Item inserido com sucesso. Código: " + codElem);
                txtpesquisaNome.Text = "";
                CarregaGridReligiao();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show("Não Foi possivel inserir a Religião.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvReligiao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir o item da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Religiao religiaoSelecionada = (dgvReligiao.SelectedRows[0].DataBoundItem as Religiao);
            ReligiaoNegocios religiaoNegocios = new ReligiaoNegocios();
            string retorno = religiaoNegocios.Excluir(religiaoSelecionada);

            try
            {
                int codDoenca = Convert.ToInt32(retorno);
                txtpesquisaNome.Text = "";
                CarregaGridReligiao();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "") return;

            for (int i = 0; i < dgvReligiao.Rows.Count; i++)
            {

                if (txtpesquisaNome.Text.ToUpper() == dgvReligiao[1, i].Value.ToString().ToUpper())
                {

                    MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnAlterar.Text = "Alterar";
                    return;
                }

            }

            novaReligiao();
        }

        private void FrmReligiao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

    }
}
