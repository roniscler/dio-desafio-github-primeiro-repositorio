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
    public partial class FrmAlunosTurma : Form
    {
        Turma turmaTrazida;

        public FrmAlunosTurma(Turma turma)
        {
            InitializeComponent();
            dgvAlunosdaTurma.AutoGenerateColumns = false;
            turmaTrazida = turma;
        }
        
        private void CarregaAlunos()
        {
            AlunoNegocios alunoNegocios = new AlunoNegocios();
            AlunoColecao alunoColecao = alunoNegocios.ConsultarCombo();

            Aluno aluno = new Aluno();
            aluno.Cod_Aluno = 0;
            aluno.Nome_Aluno = "";
            alunoColecao.Insert(0, aluno);
            this.cmbAlunoTurma.DataSource = alunoColecao;
            this.cmbAlunoTurma.ValueMember = "Cod_Aluno";
            this.cmbAlunoTurma.DisplayMember = "Nome_Aluno";
            this.cmbAlunoTurma.SelectedIndex = 0;

        }

        private void CarregaGrid()
        {
            EloAlunoTurmaNegocios eloAlunoTurmaNegocios = new EloAlunoTurmaNegocios();
            EloAlunoTurmaColecao EloAlunoTurmaColecaoGrid = eloAlunoTurmaNegocios.ConsultarGrid(Convert.ToInt32(turmaTrazida.Cod_Turma));
            //IList<EloAlunoTurma> novoElo = new List<EloAlunoTurma>();
            dgvAlunosdaTurma.DataSource = null;
            dgvAlunosdaTurma.DataSource = EloAlunoTurmaColecaoGrid.Select(s => new {
                s.aluno.Nome_Aluno,
                s.Data_Matricula,
                s.aluno.Cod_Aluno,
                s.turma.Cod_Turma,
                s.Cod_Item
            }).ToArray();

            dgvAlunosdaTurma.Update();
            dgvAlunosdaTurma.Refresh();            
        }

        private void FrmAlunosTurma_Load(object sender, EventArgs e)
        {
            CarregaAlunos();
            lblVarNomeTurma.Text = turmaTrazida.Nome_Turma;
            //txtCodTurma.Text = Convert.ToString(turmaTrazida.Cod_Turma);
            CarregaGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void btnInserirAluno_Click(object sender, EventArgs e)
        {
            
            if (cmbAlunoTurma.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um item da lista para inserir na grade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //for (int i = 0; i < dgvAlunosdaTurma.Rows.Count; i++)
            //{
            //    if (Convert.ToInt32(cmbAlunoTurma.SelectedValue) == Convert.ToInt32(dgvAlunosdaTurma[0, i].Value))
            //    {
            //        MessageBox.Show("Aluno(a) já consta na lista. Selecione outro(a)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}


            EloAlunoTurma eloAlunoTurma = new EloAlunoTurma();
            try
            {
                Convert.ToInt32(turmaTrazida.Cod_Turma);
            }
            catch
            {
                MessageBox.Show("Selecione uma turma na tela anterior para inserir Alunos", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            eloAlunoTurma.turma = new Turma();
            eloAlunoTurma.turma.Cod_Turma = Convert.ToInt32(turmaTrazida.Cod_Turma);
            int codAluno = Convert.ToInt32(cmbAlunoTurma.SelectedValue);
            eloAlunoTurma.aluno = new Aluno();
            eloAlunoTurma.aluno.Cod_Aluno = codAluno;
            eloAlunoTurma.Cod_Item = Convert.ToInt16(dgvAlunosdaTurma.Rows.Count + 1);
            eloAlunoTurma.Data_Matricula = Convert.ToDateTime(dtpMatricula.Value);
            EloAlunoTurmaNegocios eloAlunoTurmaNegocios = new EloAlunoTurmaNegocios();
            string retorno = eloAlunoTurmaNegocios.Inserir(eloAlunoTurma);
            try
            {
                int idElo = Convert.ToInt32(retorno);
                MessageBox.Show("Aluno(a) inserido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel inserir um(a) aluno(a) para esta turma." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvAlunosdaTurma.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe aluno(a) selecionado.");
                return;
            }

            EloAlunoTurma eloAlunoSelecionado = new EloAlunoTurma();
            EloAlunoTurmaNegocios eloAlunoTurmaNegocios = new EloAlunoTurmaNegocios();
            eloAlunoSelecionado.turma = new Turma();
            eloAlunoSelecionado.turma.Cod_Turma = Convert.ToInt32(dgvAlunosdaTurma.CurrentRow.Cells[0].Value);
            eloAlunoSelecionado.Cod_Item = Convert.ToInt16(dgvAlunosdaTurma.CurrentRow.Cells[1].Value);
            String retorno = eloAlunoTurmaNegocios.Excluir(eloAlunoSelecionado);
            try
            {
                int Cod_Aluno = Convert.ToInt32(retorno);
                MessageBox.Show("Aluno(a) excluído(a) com sucesso da turma", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o(a) aluno(a)." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
