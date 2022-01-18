using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;
using System.Data;
using ObjetoTrasnferencia;

namespace Apresentacao
{
    public partial class FrmProfessorSelecionar : Form
    {
        public FrmProfessorSelecionar()
        {
            InitializeComponent();
            dgvPrincipal.AutoGenerateColumns = false;
        }

        private void CarregaGrid()
        {
            ProfessorNegocios professorNegocios = new ProfessorNegocios();
            ProfessorColecao professorColecao = professorNegocios.ConsultarPorNome(txtPesquisa.Text);

            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = professorColecao;
            dgvPrincipal.Update();
            dgvPrincipal.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmProfessor frmProfessor = new FrmProfessor(AcaoNaTela.Inserir, null);

            DialogResult dialogResult = frmProfessor.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                CarregaGrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Professor selecionado.");
                return;
            }


            ProfessorNegocios professorNegocios = new ProfessorNegocios();
            Professor professorSelecionado = professorNegocios.ConsultarPorCodigo(Convert.ToInt32((dgvPrincipal.CurrentRow.Cells[0].Value)));

            FrmProfessor frmProfessor = new FrmProfessor(AcaoNaTela.Alterar, professorSelecionado);
            DialogResult dialogResult = frmProfessor.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                CarregaGrid();
            }
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Professor selecionado.");
                return;
            }
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o Professor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;

            }

            Professor professorSelecionado = (dgvPrincipal.SelectedRows[0].DataBoundItem as Professor);
            ProfessorNegocios professorNegocio = new ProfessorNegocios();
            string retorno = professorNegocio.Excluir(professorSelecionado);
            try
            {
                int codProfessor = Convert.ToInt32(retorno);
                MessageBox.Show("Professor excluido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o Prfoessor." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Professor selecionado.");
                return;
            }

            Professor professorSelecionado = new Professor();
            ProfessorNegocios professorNegocio = new ProfessorNegocios();
            professorSelecionado = professorNegocio.ConsultarPorCodigo(Convert.ToInt32(dgvPrincipal.CurrentRow.Cells[0].Value));
            FrmProfessor frmProfessor = new FrmProfessor(AcaoNaTela.Consultar, professorSelecionado);
            frmProfessor.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProfessorSelecionar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void FrmProfessorSelecionar_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
