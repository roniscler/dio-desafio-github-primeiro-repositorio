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
    public partial class FrmLancamentoNota : Form
    {
        public FrmLancamentoNota()
        {
            InitializeComponent();
            dgvLancamentoNota.AutoGenerateColumns = false;
        }

        private void CarregaAlunos()
        {
            AlunoNegocios alunoNegocios = new AlunoNegocios();
            AlunoColecao AlunoColecao = alunoNegocios.ConsultarCombo();

            Aluno aluno = new Aluno();
            aluno.Cod_Aluno = 0;
            aluno.Nome_Aluno = "";
            AlunoColecao.Insert(0, aluno);
            this.cmbAluno.DataSource = AlunoColecao;
            this.cmbAluno.ValueMember = "Cod_Aluno";
            this.cmbAluno.DisplayMember = "Nome_Aluno";
            this.cmbAluno.SelectedIndex = 0;

        }

        private void CarregaTurma()
        {
            TurmaNegocios turmaNegocios = new TurmaNegocios();
            TurmaColecao turmaColecao = turmaNegocios.ConsultarPorNome("");

            Turma turma = new Turma();
            turma.Cod_Turma = 0;
            turma.Nome_Turma = "";
            turmaColecao.Insert(0, turma);
            this.cmbTurma.DataSource = turmaColecao;
            this.cmbTurma.ValueMember = "Cod_Turma";
            this.cmbTurma.DisplayMember = "Nome_Turma";
            this.cmbTurma.SelectedIndex = 0;

        }

        private void CarregaBimestres()
        {

            BimestreNegocios bimestreNegocios = new BimestreNegocios();
            BimestresColecao elementosColecao = bimestreNegocios.Consultar();

            Bimestres bimestres = new Bimestres();
            bimestres.Cod_Bimestre = 0;
            bimestres.Nome_Bim = "";
            elementosColecao.Insert(0, bimestres);
            this.cmbBimestre.DataSource = elementosColecao;
            this.cmbBimestre.ValueMember = "Cod_Bimestre";
            this.cmbBimestre.DisplayMember = "Nome_Bim";
            this.cmbBimestre.SelectedIndex = 0;

        }

        private void CarregaMateria()
        {
            MateriaNegocios materiaNegocios = new MateriaNegocios();
            MateriaColecao materiaColecao = materiaNegocios.ConsultarCombo();

            Materia materia = new Materia();
            materia.Cod_Materia = 0;
            materia.Nome_Materia = "";
            materiaColecao.Insert(0, materia);
            this.cmbMateria.DataSource = materiaColecao;
            this.cmbMateria.ValueMember = "Cod_Materia";
            this.cmbMateria.DisplayMember = "Nome_Materia";
            this.cmbMateria.SelectedIndex = 0;

        }

        private void carregaGridLancamento()
        {
            LancamentoNotaColecao lancamentoNotaColecaoGrid = new LancamentoNotaColecao();
            LancamentoNotaNegocios lancamentoNotaNegocios = new LancamentoNotaNegocios();
            
            lancamentoNotaColecaoGrid = lancamentoNotaNegocios.ConsultarGrid(Convert.ToInt32(cmbAluno.SelectedValue), Convert.ToInt32(cmbTurma.SelectedValue));
            dgvLancamentoNota.DataSource = lancamentoNotaColecaoGrid;

            dgvLancamentoNota.DataSource = lancamentoNotaColecaoGrid.Select(s => new
            {
                s.Cod_Lancamento,
                s.aluno.Nome_Aluno,
                s.turma.Nome_Turma,
                s.materia.Nome_Materia,
                Nome_Bimstre = s.bimestres.Nome_Bim,
                s.Nota
            }).ToArray();

            dgvLancamentoNota.Update();
            dgvLancamentoNota.Refresh();

        }

        private void novoLancamentoNota()
        {
            LancamentoNota novoLancamentoNota = new LancamentoNota();

            novoLancamentoNota.aluno = new Aluno();
            novoLancamentoNota.aluno.Cod_Aluno = Convert.ToInt32(cmbAluno.SelectedValue);
            novoLancamentoNota.turma = new Turma();
            novoLancamentoNota.turma.Cod_Turma = Convert.ToInt32(cmbTurma.SelectedValue);
            novoLancamentoNota.materia = new Materia();
            novoLancamentoNota.materia.Cod_Materia = Convert.ToInt32(cmbMateria.SelectedValue);
            novoLancamentoNota.bimestres = new Bimestres();
            novoLancamentoNota.bimestres.Cod_Bimestre = Convert.ToInt32(cmbBimestre.SelectedValue);
            novoLancamentoNota.Nota = Convert.ToDecimal(txtNota.Text);

            LancamentoNotaNegocios lancamentoNotaNegocios = new LancamentoNotaNegocios();
            string retorno = lancamentoNotaNegocios.Inserir(novoLancamentoNota);

            try
            {

                int codLancamento = Convert.ToInt32(retorno);
                MessageBox.Show("Nota inserido com sucesso. Código: " + codLancamento);
                txtNota.Text = "";
                cmbAluno.Focus();
                
            }
            catch
            {
                MessageBox.Show("Não Foi possivel inserir a nota.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            carregaGridLancamento();
        }

        private void AlterarLancamentoNota()
        {
            LancamentoNota lancamentoNota = new LancamentoNota();
            LancamentoNotaNegocios lancamentoNotaNegocios = new LancamentoNotaNegocios();
            lancamentoNota.Cod_Lancamento = Convert.ToInt32(dgvLancamentoNota.CurrentRow.Cells[0].Value);
            lancamentoNota.aluno.Cod_Aluno = Convert.ToInt32(cmbAluno.SelectedValue);
            lancamentoNota.turma.Cod_Turma = Convert.ToInt32(cmbTurma.SelectedValue);
            lancamentoNota.bimestres.Cod_Bimestre = Convert.ToInt32(cmbBimestre.SelectedValue);
            lancamentoNota.materia.Cod_Materia = Convert.ToInt32(cmbMateria.SelectedValue);
            lancamentoNota.Nota = Convert.ToDecimal(txtNota.Text);
            string retorno = lancamentoNotaNegocios.Alterar(lancamentoNota);
            try
            {
                int codHabito = Convert.ToInt32(retorno);
                MessageBox.Show("Item alterado com sucesso.");
                txtNota.Text = "";
                cmbTurma.SelectedIndex = 0;
                cmbBimestre.SelectedIndex = 0;
                cmbMateria.SelectedIndex = 0;
                carregaGridLancamento();
                btnAlterar.Text = "Alterar";

            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados do lancamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbAluno.Text) || string.IsNullOrEmpty(cmbTurma.Text) || string.IsNullOrEmpty(cmbMateria.Text) || string.IsNullOrEmpty(cmbBimestre.Text) || string.IsNullOrEmpty(txtNota.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios", "Cuidado !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAluno.Focus();
                return;
            }
            novoLancamentoNota();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLancamentoNota_Load(object sender, EventArgs e)
        {
            CarregaAlunos();
            CarregaTurma();
            CarregaBimestres();
            CarregaMateria();
            carregaGridLancamento();
        }

        private void txtNota_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtNota.Text);
            }
            catch
            {
                MessageBox.Show("Número decimal invalido");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregaGridLancamento();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvLancamentoNota.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Tem certeza que deseja excluir a nota da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            LancamentoNota lancamentoNota = new LancamentoNota();
            lancamentoNota.Cod_Lancamento = Convert.ToInt32(dgvLancamentoNota.CurrentRow.Cells[0].Value);
            LancamentoNotaNegocios lancamentoNotaNegocios = new LancamentoNotaNegocios();
            string retorno = lancamentoNotaNegocios.Excluir(lancamentoNota);

            try
            {
                int codLancamento = Convert.ToInt32(retorno);
                cmbAluno.Focus();
                carregaGridLancamento();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir a nota." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvLancamentoNota.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnAlterar.Text == "Alterar")
            {
                cmbAluno.Text = Convert.ToString(dgvLancamentoNota.CurrentRow.Cells[1].Value);
                cmbTurma.Text = Convert.ToString(dgvLancamentoNota.CurrentRow.Cells[2].Value);
                cmbBimestre.Text = Convert.ToString(dgvLancamentoNota.CurrentRow.Cells[4].Value);
                cmbMateria.Text = Convert.ToString(dgvLancamentoNota.CurrentRow.Cells[3].Value);
                txtNota.Text = Convert.ToString(dgvLancamentoNota.CurrentRow.Cells[5].Value);
                btnAlterar.Text = "Gravar";
                btnInserir.Enabled = false;
                btnConsultar.Enabled = false;
                btnExcluir.Enabled = false;
                dgvLancamentoNota.Enabled = false;
            }

            else if (btnAlterar.Text == "Gravar")
            {

            if (string.IsNullOrEmpty(cmbAluno.Text) || string.IsNullOrEmpty(cmbTurma.Text) || string.IsNullOrEmpty(cmbMateria.Text) || string.IsNullOrEmpty(cmbBimestre.Text) || string.IsNullOrEmpty(txtNota.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios", "Cuidado !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
  
            btnInserir.Enabled = true;
            btnConsultar.Enabled = true;
            btnExcluir.Enabled = true;
            dgvLancamentoNota.Enabled = true;
            AlterarLancamentoNota();

            }

        }

        private void FrmLancamentoNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

    }
}
