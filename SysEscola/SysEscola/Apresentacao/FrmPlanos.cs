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
    public partial class FrmPlanos : Form
    {
        string acaoVinda;

        public FrmPlanos(string acao)
        {
            InitializeComponent();
            acaoVinda = acao;
        }

        private void CarregaPlanos()
        {
            PlanosColecao PalnosCoelcao = new PlanosColecao();
            PlanosNegocios planosNegocios = new PlanosNegocios();

            PalnosCoelcao = planosNegocios.ConsultarNome(txtNome.Text);
            dgvPlanos.DataSource = PalnosCoelcao;

            dgvPlanos.DataSource = PalnosCoelcao;
            dgvPlanos.Update();
            dgvPlanos.Refresh();

        }

        private void NovoPlano()
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(mskValor.Text))
            {
                MessageBox.Show("Preencha um nome para o Plano Estudantil", "Cuidado !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            for (int i = 0; i < dgvPlanos.Rows.Count; i++)
            {

                if (txtNome.Text.ToUpper() == dgvPlanos[1, i].Value.ToString().ToUpper())
                {

                    MessageBox.Show("Plano já cadastrado. Altere o nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnAlterar.Text = "Alterar";
                    return;
                }

            }

            Planos novoPlano = new Planos();
            novoPlano.Desc_Plano = Convert.ToString(txtNome.Text);
            novoPlano.Valor = Convert.ToDecimal(mskValor.Text);
            PlanosNegocios PlanosNegocios = new PlanosNegocios();
            string retorno = PlanosNegocios.Inserir(novoPlano);

            try
            {

                int codPlano = Convert.ToInt32(retorno);
                MessageBox.Show("Item inserido com sucesso. Código: " + codPlano);
                txtNome.Text = "";
                mskValor.Text = "";
                CarregaPlanos();

            }
            catch
            {
                MessageBox.Show("Não Foi possivel inserir o Plano.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AlteraPlano()
        {
            Planos planos = new Planos ();
            PlanosNegocios planosNegocios = new PlanosNegocios();
            planos.Cod_Plano = Convert.ToInt32(dgvPlanos.CurrentRow.Cells[0].Value);
            planos.Desc_Plano = txtNome.Text;
            planos.Valor = Convert.ToDecimal(mskValor.Text);
            string retorno = planosNegocios.Alterar(planos);
            try
            {
                int codHabito = Convert.ToInt32(retorno);
                MessageBox.Show("Item alterado com sucesso.");
                txtNome.Text = "";
                mskValor.Text = "";
                CarregaPlanos();
                btnAlterar.Text = "Alterar";
                btnExcluir.Enabled = true;
                btnIncluir.Enabled = true;
                dgvPlanos.Enabled = true;

                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados do item.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvPlanos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnAlterar.Text == "Alterar")
            {
                txtNome.Text = Convert.ToString(dgvPlanos.CurrentRow.Cells[1].Value);
                mskValor.Text = Convert.ToString(dgvPlanos.CurrentRow.Cells[2].Value);
                btnAlterar.Text = "Gravar";
                btnExcluir.Enabled = false;
                btnIncluir.Enabled = false;
                dgvPlanos.Enabled = false;
            }

            else if (btnAlterar.Text == "Gravar")
            {

                if (txtNome.Text == null || txtNome.Text == "")
                {
                    btnAlterar.Text = "Alterar";
                    btnExcluir.Enabled = true;
                    btnIncluir.Enabled = true;
                    dgvPlanos.Enabled = true;

                    return;
                }

                AlteraPlano();

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPlanos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Tem certeza que deseja excluir o Plano da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Planos PlanoSelecionado = (dgvPlanos.SelectedRows[0].DataBoundItem as Planos);
            PlanosNegocios planosNegocios = new PlanosNegocios();
            string retorno = planosNegocios.Excluir(PlanoSelecionado);

            try
            {
                int codPlano = Convert.ToInt32(retorno);
                txtNome.Text = "";
                CarregaPlanos();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o plano." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            NovoPlano();
            if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaPlanos();
        }

        private void FrmPlanos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }

        }

        private void FrmPlanos_Load(object sender, EventArgs e)
        {
            CarregaPlanos();
        }
    }
}
