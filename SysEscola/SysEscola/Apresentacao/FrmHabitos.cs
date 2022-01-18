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
    public partial class FrmHabitos : Form
    {
        string acaoVinda;

        public FrmHabitos(string acao)
        {
            InitializeComponent();

            acaoVinda = acao;
        }

        private void carregaGridHabitos()
        {
            HabitoColecao habitosCoelcao = new HabitoColecao();
            HabitosNegocios habitosNegocios = new HabitosNegocios();

            habitosCoelcao = habitosNegocios.Consultar(txtpesquisaNome.Text);
            dgvHabitos.DataSource = habitosCoelcao;

            dgvHabitos.DataSource = habitosCoelcao;
            dgvHabitos.Update();
            dgvHabitos.Refresh();

        }

        private void frmHabitos_Load(object sender, EventArgs e)
        {
            carregaGridHabitos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregaGridHabitos();
            
        }

        private void novoHabito()
        {
            Habito novoHabito = new Habito();
            novoHabito.Desc_Habito = txtpesquisaNome.Text;
            HabitosNegocios habitoNegocios = new HabitosNegocios();
            string retorno = habitoNegocios.Inserir(novoHabito);

            try
            {

                int codHAbito = Convert.ToInt32(retorno);
                MessageBox.Show("Item inserido com sucesso. Código: " + codHAbito);
                txtpesquisaNome.Text = "";
                carregaGridHabitos();
                
            }
            catch
            {
                MessageBox.Show("Não Foi possivel inserir o Hábito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alterarHabito()
        {
            Habito habitos = new Habito();
            HabitosNegocios habitoNegocio = new HabitosNegocios();
            habitos.Cod_Habito = Convert.ToInt32(dgvHabitos.CurrentRow.Cells[0].Value);
            habitos.Desc_Habito = txtpesquisaNome.Text;
            string retorno = habitoNegocio.Alterar(habitos);
            try
            {
                int codHabito = Convert.ToInt32(retorno);
                MessageBox.Show("Item alterado com sucesso.");
                txtpesquisaNome.Text = "";
                carregaGridHabitos();
                btnAlterar.Text = "Alterar";
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados do item.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (btnAlterar.Text == "Alterar" && dgvHabitos.SelectedRows.Count > 0)
            {
                txtpesquisaNome.Text = Convert.ToString(dgvHabitos.CurrentRow.Cells[1].Value);
                btnAlterar.Text = "Gravar";
            }

            else if (btnAlterar.Text == "Gravar")
            {

                if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "")
                {
                    btnAlterar.Text = "Alterar";
                    return;
                }

                for (int i = 0; i < dgvHabitos.Rows.Count; i++)
                {

                    if (txtpesquisaNome.Text.ToUpper() == dgvHabitos[1, i].Value.ToString().ToUpper())
                    {

                        MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnAlterar.Text = "Alterar";
                        return;
                    }

                }

                alterarHabito();
                
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o item da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            if (dgvHabitos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            Habito habitoSelecionado = (dgvHabitos.SelectedRows[0].DataBoundItem as Habito);
            HabitosNegocios habitoNegocio = new HabitosNegocios();
            string retorno = habitoNegocio.Excluir(habitoSelecionado);

            try
            {
                int codHAbito = Convert.ToInt32(retorno);
                txtpesquisaNome.Text = "";
                carregaGridHabitos();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

             if (string.IsNullOrEmpty(txtpesquisaNome.Text))
            {
                MessageBox.Show("Preencha um nome para o Hábito", "Cuidado !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dgvHabitos.Rows.Count; i++)
            {

                if (txtpesquisaNome.Text.ToUpper() == dgvHabitos[1, i].Value.ToString().ToUpper())
                {

                    MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnAlterar.Text = "Alterar";
                    return;
                }

            }

            novoHabito();
            if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;
        }

        private void FrmHabitos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
