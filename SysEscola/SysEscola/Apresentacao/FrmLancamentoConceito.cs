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
    public partial class FrmLancamentoConceito : Form
    {
        public FrmLancamentoConceito()
        {
            InitializeComponent();
            dgvLancamentoConceito.AutoGenerateColumns = false;
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

        private void CarregaSIAvalPedag()
        {
            SubItemAvaliacaoPedagogicaNegocios subItemAvaliacaoPedagogicaNegocios = new SubItemAvaliacaoPedagogicaNegocios();
            SubItensAvaliacaoPedagogicaColecao subItemAvaliacaoPedagogicaColecao = subItemAvaliacaoPedagogicaNegocios.ConsultarCombo();

            SubItensAvaliacaoPedagogica subItemAvaliacaoPedagogica = new SubItensAvaliacaoPedagogica();
            subItemAvaliacaoPedagogica.Cod_SI_Aval_Pedag = 0;
            subItemAvaliacaoPedagogica.Desc_SI_Aval_Pedag = "";
            subItemAvaliacaoPedagogicaColecao.Insert(0, subItemAvaliacaoPedagogica);
            this.cmbSI_Aval_Pedag.DataSource = subItemAvaliacaoPedagogicaColecao;
            this.cmbSI_Aval_Pedag.ValueMember = "Cod_SI_Aval_Pedag";
            this.cmbSI_Aval_Pedag.DisplayMember = "Desc_SI_Aval_Pedag";
            this.cmbSI_Aval_Pedag.SelectedIndex = 0;

        }

        private void CarregaConceito()
        {
            TipoConceitoNegocios tipoConceitoNegocios = new TipoConceitoNegocios();
            TipoConceitoColecao tipoConceitoColecao = tipoConceitoNegocios.Consultar();

            TipoConceito tipoConceito = new TipoConceito();
            tipoConceito.Cod_Conceito = 0;
            tipoConceito.Desc_Conceito = "";
            tipoConceitoColecao.Insert(0, tipoConceito);
            this.cmbConceito.DataSource = tipoConceitoColecao;
            this.cmbConceito.ValueMember = "Cod_Conceito";
            this.cmbConceito.DisplayMember = "Desc_Conceito";
            this.cmbConceito.SelectedIndex = 0;

        }

        private void carregaGridLancamento()
        {
            LancamentoConceitoColecao lancamentoConceitoColecao = new LancamentoConceitoColecao();
            LancamentoConceitoNegocios lancamentoConceitoNegocios = new LancamentoConceitoNegocios();

            lancamentoConceitoColecao = lancamentoConceitoNegocios.ConsultarGrid(Convert.ToInt32(cmbAluno.SelectedValue), Convert.ToInt32(cmbTurma.SelectedValue));
            dgvLancamentoConceito.DataSource = lancamentoConceitoColecao;

            dgvLancamentoConceito.DataSource = lancamentoConceitoColecao.Select(s => new
            {
                s.Cod_Lancamento,
                s.aluno.Nome_Aluno,
                s.turma.Nome_Turma,
                s.subItensAvaliacaoPedagogica.Desc_SI_Aval_Pedag,
                s.bimestres.Nome_Bim,
                s.tipoConceito.Desc_Conceito

            }).ToArray();

            dgvLancamentoConceito.Update();
            dgvLancamentoConceito.Refresh();

        }

        private void novoLancamentoConceito()
        {
            LancamentoConceito novoLancamentoConceito = new LancamentoConceito();

            novoLancamentoConceito.aluno = new Aluno();
            novoLancamentoConceito.aluno.Cod_Aluno = Convert.ToInt32(cmbAluno.SelectedValue);

            novoLancamentoConceito.turma = new Turma();
            novoLancamentoConceito.turma.Cod_Turma = Convert.ToInt32(cmbTurma.SelectedValue);

            novoLancamentoConceito.subItensAvaliacaoPedagogica = new SubItensAvaliacaoPedagogica();
            novoLancamentoConceito.subItensAvaliacaoPedagogica.Cod_SI_Aval_Pedag = Convert.ToInt32(cmbSI_Aval_Pedag.SelectedValue);

            novoLancamentoConceito.bimestres = new Bimestres();
            novoLancamentoConceito.bimestres.Cod_Bimestre = Convert.ToInt32(cmbBimestre.SelectedValue);

            novoLancamentoConceito.tipoConceito = new TipoConceito();
            novoLancamentoConceito.tipoConceito.Cod_Conceito = Convert.ToInt32(cmbConceito.SelectedValue);

            LancamentoConceitoNegocios LancamentoConceitoNegocios = new LancamentoConceitoNegocios();
            string retorno = LancamentoConceitoNegocios.Inserir(novoLancamentoConceito);

            try
            {

                int codLancamento = Convert.ToInt32(retorno);
                MessageBox.Show("Nota inserido com sucesso. Código: " + codLancamento);
                cmbSI_Aval_Pedag.SelectedIndex = 0;
                cmbConceito.SelectedIndex = 0;
                cmbAluno.Focus();

            }
            catch
            {
                MessageBox.Show("Não Foi possivel inserir a nota.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            carregaGridLancamento();
        }

        private void AlterarLancamentoConceito()
        {
            LancamentoConceito lancamentoConceito = new LancamentoConceito();
            LancamentoConceitoNegocios lancamentoConceitoNegocios = new LancamentoConceitoNegocios();
            lancamentoConceito.Cod_Lancamento = Convert.ToInt32(dgvLancamentoConceito.CurrentRow.Cells[0].Value);
            lancamentoConceito.aluno.Cod_Aluno = Convert.ToInt32(cmbAluno.SelectedValue);
            lancamentoConceito.turma.Cod_Turma = Convert.ToInt32(cmbTurma.SelectedValue);
            lancamentoConceito.bimestres.Cod_Bimestre = Convert.ToInt32(cmbBimestre.SelectedValue);
            lancamentoConceito.subItensAvaliacaoPedagogica.Cod_SI_Aval_Pedag = Convert.ToInt32(cmbSI_Aval_Pedag.SelectedValue);
            lancamentoConceito.tipoConceito.Cod_Conceito = Convert.ToInt32(cmbConceito.SelectedValue);
            string retorno = lancamentoConceitoNegocios.Alterar(lancamentoConceito);
            try
            {
                int codLancamento = Convert.ToInt32(retorno);
                MessageBox.Show("Lançamento alterado com sucesso.");
                cmbSI_Aval_Pedag.Focus();
                cmbConceito.SelectedIndex = 0;
                cmbSI_Aval_Pedag.SelectedIndex = 0;
                carregaGridLancamento();
                btnAlterar.Text = "Alterar";

            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados do lancamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmLancamentoConceito_Load(object sender, EventArgs e)
        {
            CarregaAlunos();
            CarregaBimestres();
            CarregaSIAvalPedag();
            CarregaTurma();
            CarregaConceito();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLancamentoConceito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbAluno.Text) || string.IsNullOrEmpty(cmbTurma.Text) || string.IsNullOrEmpty(cmbBimestre.Text) || string.IsNullOrEmpty(cmbBimestre.Text) || string.IsNullOrEmpty(cmbSI_Aval_Pedag.Text) || string.IsNullOrEmpty(cmbConceito.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios", "Cuidado !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAluno.Focus();
                return;
            }
            novoLancamentoConceito();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregaGridLancamento();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvLancamentoConceito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnAlterar.Text == "Alterar")
            {
                cmbAluno.Text = Convert.ToString(dgvLancamentoConceito.CurrentRow.Cells[1].Value);
                cmbTurma.Text = Convert.ToString(dgvLancamentoConceito.CurrentRow.Cells[2].Value);
                cmbBimestre.Text = Convert.ToString(dgvLancamentoConceito.CurrentRow.Cells[4].Value);
                cmbSI_Aval_Pedag.Text = Convert.ToString(dgvLancamentoConceito.CurrentRow.Cells[3].Value);
                cmbConceito.Text = Convert.ToString(dgvLancamentoConceito.CurrentRow.Cells[5].Value);
                btnAlterar.Text = "Gravar";
                btnInserir.Enabled = false;
                btnConsultar.Enabled = false;
                btnExcluir.Enabled = false;
                dgvLancamentoConceito.Enabled = false;
            }

            else if (btnAlterar.Text == "Gravar")
            {

                if (string.IsNullOrEmpty(cmbAluno.Text) || string.IsNullOrEmpty(cmbTurma.Text) || string.IsNullOrEmpty(cmbSI_Aval_Pedag.Text) || string.IsNullOrEmpty(cmbBimestre.Text) || string.IsNullOrEmpty(cmbConceito.Text))
                {
                    MessageBox.Show("Todos os campos são obrigatórios", "Cuidado !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                btnInserir.Enabled = true;
                btnConsultar.Enabled = true;
                btnExcluir.Enabled = true;
                dgvLancamentoConceito.Enabled = true;
                AlterarLancamentoConceito();

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvLancamentoConceito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Tem certeza que deseja excluir o conceito da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            LancamentoConceito lancamentoConceito = new LancamentoConceito();
            lancamentoConceito.Cod_Lancamento = Convert.ToInt32(dgvLancamentoConceito.CurrentRow.Cells[0].Value);
            LancamentoConceitoNegocios lancamentoConceitoNegocios = new LancamentoConceitoNegocios();
            string retorno = lancamentoConceitoNegocios.Excluir(lancamentoConceito);

            try
            {
                int codLancamento = Convert.ToInt32(retorno);
                cmbAluno.Focus();
                carregaGridLancamento();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o conceito." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
