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
    public partial class FrmDoenca : Form
    {
        string acaoVinda;

        public FrmDoenca(string acao)
        {
            InitializeComponent();
            
            acaoVinda = acao;
        }

        private void frmDoenca_Load(object sender, EventArgs e)
        {
            carregaGridDoenca();
        }

        private void carregaGridDoenca()
        {
            DoencaColecao doencaCoelcao = new DoencaColecao();
            DoencaNegocio doencaNegocio = new DoencaNegocio();
            doencaCoelcao = doencaNegocio.ConsultarGrid(txtpesquisaNome.Text);
            dgvDoenca.DataSource = doencaCoelcao;

            dgvDoenca.DataSource = doencaCoelcao;
            dgvDoenca.Update();
            dgvDoenca.Refresh();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregaGridDoenca();
            
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "") return;

            for (int i = 0; i < dgvDoenca.Rows.Count; i++)
            {

                if (txtpesquisaNome.Text.ToUpper() == dgvDoenca[1, i].Value.ToString().ToUpper())
                {

                    MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnAlterar.Text = "Alterar";
                    return;
                }

            }

            novaDoenca();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o item da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            if (dgvDoenca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            Doenca doencaSelecionada = (dgvDoenca.SelectedRows[0].DataBoundItem as Doenca);
            DoencaNegocio doencaNegocio = new DoencaNegocio();
            string retorno = doencaNegocio.Excluir(doencaSelecionada);

            try
            {
                int codDoenca = Convert.ToInt32(retorno);
                txtpesquisaNome.Text = "";
                carregaGridDoenca();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (btnAlterar.Text == "Alterar" && dgvDoenca.SelectedRows.Count > 0)
                if (btnAlterar.Text == "Alterar")
            {
                txtpesquisaNome.Text = Convert.ToString(dgvDoenca.CurrentRow.Cells[1].Value);
                btnAlterar.Text = "Gravar";
            }

            else if (btnAlterar.Text == "Gravar")
            {
                
                if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "")
                {
                    btnAlterar.Text = "Alterar";
                    return;
                }

                for (int i = 0; i < dgvDoenca.Rows.Count; i++)
                {

                    if (txtpesquisaNome.Text.ToUpper() == dgvDoenca[1, i].Value.ToString().ToUpper())
                    {

                        MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnAlterar.Text = "Alterar";
                        return;
                    }

                }

                alterarDoenca();
                
            }
        }

        private void novaDoenca()
        {
            Doenca novadoenca = new Doenca();
            novadoenca.Nome_Doenca = txtpesquisaNome.Text;
            DoencaNegocio doencaNegocio = new DoencaNegocio();
            string retorno = doencaNegocio.Inserir(novadoenca);

            try
            {

                int codDoenca = Convert.ToInt32(retorno);
                MessageBox.Show("Item inserido com sucesso. Código: " + codDoenca);
                txtpesquisaNome.Text = "";
                carregaGridDoenca();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show("Não Foi possivel inserir a Doença.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alterarDoenca()
        {
            Doenca doenca = new Doenca();
            DoencaNegocio doencaNegocio = new DoencaNegocio();
            doenca.Cod_Doenca = Convert.ToInt32(dgvDoenca.CurrentRow.Cells[0].Value);
            doenca.Nome_Doenca = txtpesquisaNome.Text;
            string retorno = doencaNegocio.Alterar(doenca);
            try
            {
                int codDoenca = Convert.ToInt32(retorno);
                MessageBox.Show("Item alterado com sucesso.");
                txtpesquisaNome.Text = "";
                carregaGridDoenca();
                btnAlterar.Text = "Alterar";
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;
                
            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados do item.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDoenca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

    }
}
