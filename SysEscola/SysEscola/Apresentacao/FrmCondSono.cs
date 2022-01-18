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
    public partial class FrmCondSono : Form
    {
        string acaoVinda;

        public FrmCondSono(string acao)
        {
            InitializeComponent();

            acaoVinda = acao;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (btnAlterar.Text == "Alterar" && dgvCondSono.SelectedRows.Count > 0)
            {
                txtpesquisaNome.Text = Convert.ToString(dgvCondSono.CurrentRow.Cells[1].Value);
                btnAlterar.Text = "Gravar";
            }

            else if (btnAlterar.Text == "Gravar")
            {

                if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "")
                {
                    btnAlterar.Text = "Alterar";
                    return;
                }

                for (int i = 0; i < dgvCondSono.Rows.Count; i++)
                {

                    if (txtpesquisaNome.Text.ToUpper() == dgvCondSono[1, i].Value.ToString().ToUpper())
                    {

                        MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnAlterar.Text = "Alterar";
                        return;
                    }

                }

                alterarCondSono();

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGridCondSono();
        }

        private void CarregaGridCondSono()
        {

            CondicoesSonoColecao condicoesSonoColecao = new CondicoesSonoColecao();
            CondicoesSonoNegocios condSonoNegocio = new CondicoesSonoNegocios();
            condicoesSonoColecao = condSonoNegocio.Consultar(txtpesquisaNome.Text);
            dgvCondSono.DataSource = condicoesSonoColecao;

            dgvCondSono.DataSource = condicoesSonoColecao;
            dgvCondSono.Update();
            dgvCondSono.Refresh();
        }

        private void FrmCondSono_Load(object sender, EventArgs e)
        {
            CarregaGridCondSono();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja excluir o item da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No)return;

            if (dgvCondSono.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            CondicoesSono condicoesSonoSelecionado = (dgvCondSono.SelectedRows[0].DataBoundItem as CondicoesSono);
            CondicoesSonoNegocios condSonoNegocios = new CondicoesSonoNegocios();
            string retorno = condSonoNegocios.Excluir(condicoesSonoSelecionado);

            try
            {
                int codDoenca = Convert.ToInt32(retorno);
                txtpesquisaNome.Text = "";
                CarregaGridCondSono();
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

            for (int i = 0; i < dgvCondSono.Rows.Count; i++)
            {

                if (txtpesquisaNome.Text.ToUpper() == dgvCondSono[1, i].Value.ToString().ToUpper())
                {

                    MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnAlterar.Text = "Alterar";
                    return;
                }

            }

            novaCondSono();

        }

        private void novaCondSono()
        {
            CondicoesSono novaCondSono = new CondicoesSono();
            novaCondSono.Desc_Cond_Sono = txtpesquisaNome.Text;
            CondicoesSonoNegocios condicoesSonoNegocios = new CondicoesSonoNegocios();
            string retorno = condicoesSonoNegocios.Inserir(novaCondSono);

            try
            {

                int codCondSono = Convert.ToInt32(retorno);
                MessageBox.Show("Item inserido com sucesso. Código: " + codCondSono);
                txtpesquisaNome.Text = "";
                CarregaGridCondSono();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show("Não Foi possivel inserir a Condição de Sono.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void alterarCondSono()
        {

            CondicoesSono condicoesSono = new CondicoesSono();
            CondicoesSonoNegocios condicoesSonoNegocios = new CondicoesSonoNegocios();
            condicoesSono.Cod_Cond_Sono = Convert.ToInt32(dgvCondSono.CurrentRow.Cells[0].Value);
            condicoesSono.Desc_Cond_Sono = txtpesquisaNome.Text;
            string retorno = condicoesSonoNegocios.Alterar(condicoesSono);
            try
            {
                int codCondSono = Convert.ToInt32(retorno);
                MessageBox.Show("Item alterado com sucesso.");
                txtpesquisaNome.Text = "";
                CarregaGridCondSono();
                btnAlterar.Text = "Alterar";
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados do item.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCondSono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

    }
}
