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
    public partial class FrmHoraRegular : Form
    {
        string acaoVinda;

        public FrmHoraRegular(string acao)
        {
            InitializeComponent();
            acaoVinda = acao;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregaGridHoraRegular();
        }

        private void carregaGridHoraRegular()
        {
            HorarioRegularColecao horaRegularCoelcao = new HorarioRegularColecao();
            HorarioRegularNegocios horarioRegularNegocios = new HorarioRegularNegocios();
            horaRegularCoelcao = horarioRegularNegocios.Consultar(txtpesquisaNome.Text);
            dgvHoraRegular.DataSource = horaRegularCoelcao;

            dgvHoraRegular.DataSource = horaRegularCoelcao;
            dgvHoraRegular.Update();
            dgvHoraRegular.Refresh();
        }

        private void FrmHoraRegular_Load(object sender, EventArgs e)
        {
            carregaGridHoraRegular();
        }

        private void AlteraHoraRegular()
        {
            HorarioRegular horaRegular = new HorarioRegular();
            HorarioRegularNegocios horarioRegularNegocios = new HorarioRegularNegocios();
            horaRegular.Cod_Horario = Convert.ToInt32(dgvHoraRegular.CurrentRow.Cells[0].Value);
            horaRegular.Desc_Horario = txtpesquisaNome.Text;
            string retorno = horarioRegularNegocios.Alterar(horaRegular);
            try
            {
                int codElemento = Convert.ToInt32(retorno);
                MessageBox.Show("Item alterado com sucesso.");
                txtpesquisaNome.Text = "";
                carregaGridHoraRegular();
                btnAlterar.Text = "Alterar";
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados do item.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NovaHoraRegular()
        {
            HorarioRegular novaHoraRegular = new HorarioRegular();
            novaHoraRegular.Desc_Horario = txtpesquisaNome.Text;
            HorarioRegularNegocios horarioRegularNegocios = new HorarioRegularNegocios();
            string retorno = horarioRegularNegocios.Inserir(novaHoraRegular);

            try
            {

                int codElemento = Convert.ToInt32(retorno);
                MessageBox.Show("Item inserido com sucesso. Código: " + codElemento);
                txtpesquisaNome.Text = "";
                carregaGridHoraRegular();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show("Não Foi possivel inserir o Horario Regular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (btnAlterar.Text == "Alterar" && dgvHoraRegular.SelectedRows.Count > 0)
            {
                txtpesquisaNome.Text = Convert.ToString(dgvHoraRegular.CurrentRow.Cells[1].Value);
                btnAlterar.Text = "Gravar";
            }

            else if (btnAlterar.Text == "Gravar")
            {

                if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "")
                {
                    btnAlterar.Text = "Alterar";
                    return;
                }

                for (int i = 0; i < dgvHoraRegular.Rows.Count; i++)
                {

                    if (txtpesquisaNome.Text.ToUpper() == dgvHoraRegular[1, i].Value.ToString().ToUpper())
                    {

                        MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnAlterar.Text = "Alterar";
                        return;
                    }

                }

                AlteraHoraRegular();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "") return;

            for (int i = 0; i < dgvHoraRegular.Rows.Count; i++)
            {

                if (txtpesquisaNome.Text.ToUpper() == dgvHoraRegular[1, i].Value.ToString().ToUpper())
                {

                    MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnAlterar.Text = "Alterar";
                    return;
                }

            }

            NovaHoraRegular();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o item da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            if (dgvHoraRegular.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HorarioRegular horaRegularSelecionada = (dgvHoraRegular.SelectedRows[0].DataBoundItem as HorarioRegular);
            HorarioRegularNegocios horarioRegularNegocios = new HorarioRegularNegocios();
            string retorno = horarioRegularNegocios.Excluir(horaRegularSelecionada);

            try
            {
                int codElemento = Convert.ToInt32(retorno);
                txtpesquisaNome.Text = "";
                carregaGridHoraRegular();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmHoraRegular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
