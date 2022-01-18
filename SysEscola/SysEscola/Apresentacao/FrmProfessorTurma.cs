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
    public partial class FrmProfessorTurma : Form
    {
        Turma turmatrazida;

        public FrmProfessorTurma(Turma turma)
        {
            InitializeComponent();
            dgvProfessoresTurma.AutoGenerateColumns = false;
            turmatrazida = turma;

        }

        private void CarregaProfessores()
        {
            ProfessorNegocios professorNegocios = new ProfessorNegocios();
            ProfessorColecao elementosColecao = professorNegocios.ConsultarCombo();

            Professor professor = new Professor();
            professor.Cod_Professor = 0;
            professor.Nome_Professor = "";
            elementosColecao.Insert(0, professor);
            this.cmbProfessor.DataSource = elementosColecao;
            this.cmbProfessor.ValueMember = "Cod_Professor";
            this.cmbProfessor.DisplayMember = "Nome_Professor";
            this.cmbProfessor.SelectedIndex = 0;
        }

        private void CarregaGrid()
        {
            EloTurmaProfessorNegocios EloTurmaProfessorNegocios = new EloTurmaProfessorNegocios();
            EloTurmaProfessorColecao eloTurmaProfessorColecaoGrid = EloTurmaProfessorNegocios.ConsultarGrid(Convert.ToInt32(turmatrazida.Cod_Turma));

            dgvProfessoresTurma.DataSource = null;
            dgvProfessoresTurma.DataSource = eloTurmaProfessorColecaoGrid.Select(s => new
            {
                s.professor.Cod_Professor,
                s.turma.Cod_Turma,
                s.professor.Nome_Professor,
                s.DataEntrada,
                s.Cod_Item
            }).ToArray();
            dgvProfessoresTurma.Update();
            dgvProfessoresTurma.Refresh();

        }

        private void FrmProfessorTurma_Load(object sender, EventArgs e)
        {
            CarregaProfessores();
            lblVarNomeTurma.Text = turmatrazida.Nome_Turma;
            CarregaGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dgvProfessoresTurma.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe aluno(a) selecionado.");
                return;
            }

            EloTurmaProfessor eloTurmaProfessorSelecionado = new EloTurmaProfessor();
            EloTurmaProfessorNegocios eloTurmaProfessorNegocios = new EloTurmaProfessorNegocios();
            eloTurmaProfessorSelecionado.Cod_Item = Convert.ToInt16(dgvProfessoresTurma.CurrentRow.Cells[1].Value);
            eloTurmaProfessorSelecionado.turma = new Turma(); 
            eloTurmaProfessorSelecionado.turma.Cod_Turma = Convert.ToInt32(dgvProfessoresTurma.CurrentRow.Cells[0].Value);
            String retorno = eloTurmaProfessorNegocios.Excluir(eloTurmaProfessorSelecionado);
            try
            {
                int Cod_Professor = Convert.ToInt32(retorno);
                MessageBox.Show("PRofessor(a) excluído(a) com sucesso da turma", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o(a) professor(a)." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInserirProfessor_Click(object sender, EventArgs e)
        {
            
            if (cmbProfessor.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um item da lista para inserir na grade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //for (int i = 0; i < dgvProfessoresTurma.Rows.Count; i++)
            //{
            //    if (Convert.ToInt32(cmbProfessor.SelectedValue) == Convert.ToInt32(dgvProfessoresTurma[0, i].Value))
            //    {
            //        MessageBox.Show("Professor(a) já consta na lista. Selecione outro(a)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}


            EloTurmaProfessor eloTurmaProfessor = new EloTurmaProfessor();
            try
            {
                Convert.ToInt32(turmatrazida.Cod_Turma);
            }
            catch
            {
                MessageBox.Show("Selecione uma turma na tela anterior para inserir professores", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            eloTurmaProfessor.turma = new Turma(); 
            eloTurmaProfessor.turma.Cod_Turma = Convert.ToInt32(turmatrazida.Cod_Turma);
            eloTurmaProfessor.professor = new Professor();
            eloTurmaProfessor.professor.Cod_Professor = Convert.ToInt32(cmbProfessor.SelectedValue);
            eloTurmaProfessor.Cod_Item = Convert.ToInt16(dgvProfessoresTurma.Rows.Count + 1);
            eloTurmaProfessor.DataEntrada = dtpDataEntrada.Value;

            EloTurmaProfessorNegocios eloTurmaProfessorNegocios = new EloTurmaProfessorNegocios();
            string retorno = eloTurmaProfessorNegocios.Inserir(eloTurmaProfessor);
            try
            {
                int idElo = Convert.ToInt32(retorno);
                MessageBox.Show("Professor(a) inserido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel inserir um(a) professor(a) para esta turma." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
