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
    public partial class FrmProfessorAfastamento : Form
    {
        Professor ProfessorSelecionado;
        int CodigoProfesor;
        string NomeProfessor;
        bool editar;
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmProfessorAfastamento(AcaoNaTela acaoNaTela, Professor professor)
        {
            InitializeComponent();
            ProfessorSelecionado = professor;
            CodigoProfesor = ProfessorSelecionado.Cod_Professor;
            NomeProfessor = ProfessorSelecionado.Nome_Professor;
            dgvProfessorAfastamento.AutoGenerateColumns = false;
            acaoNaTelaSelecionada = acaoNaTela;
        }

        private void CarregaAfastamento()
        {
            ProfessorAfastamentoNegocios professorAfastamentoNegocios = new ProfessorAfastamentoNegocios();
            ProfessorAfastamentoColecao professorAfastamentoColecao = professorAfastamentoNegocios.ConsultarGrid(CodigoProfesor);
            dgvProfessorAfastamento.DataSource = null;
            dgvProfessorAfastamento.DataSource = professorAfastamentoColecao;

            dgvProfessorAfastamento.Update();
            dgvProfessorAfastamento.Refresh();
        }
            
        private void SalvaAlteraAfastamento()
        {
            ProfessorAfastamento professorAfastamento = new ProfessorAfastamento();
            professorAfastamento.Dt_afast = dtpDt_Afast.Value;
            professorAfastamento.Dias = Convert.ToInt16(nrDias.Value);
            professorAfastamento.Motivo = txtMotivo.Text;

            if (editar == true)
            {
                professorAfastamento.Cod_Professor = CodigoProfesor;
                professorAfastamento.Cod_Item = Convert.ToUInt16(dgvProfessorAfastamento.CurrentRow.Cells[1].Value);
                ProfessorAfastamentoNegocios professorAfastamentoNegocios = new ProfessorAfastamentoNegocios();
                string retorno = professorAfastamentoNegocios.Alterar(professorAfastamento);

                try
                {
                    int idProfessorAfastamento = Convert.ToInt32(retorno);
                    MessageBox.Show("Afastamento alterado com sucesso.");

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar o afastamento do professor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (editar == false)
            {
                professorAfastamento.Cod_Professor = CodigoProfesor;
                professorAfastamento.Cod_Item = Convert.ToInt32(dgvProfessorAfastamento.Rows.Count) + 1;
                ProfessorAfastamentoNegocios professorAfastamentoNegocios = new ProfessorAfastamentoNegocios();
                string retorno = professorAfastamentoNegocios.Inserir(professorAfastamento);

                try
                {
                    int idProfessorAfastamento = Convert.ToInt32(retorno);
                    MessageBox.Show("Responsável inserido com sucesso.");
                    btnInserir.Text = "Salvar";
                    
                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir o afastamento do professor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            txtMotivo.Text = "";
            nrDias.Value = 0;
            dtpDt_Afast.Value = DateTime.Now;
            CarregaAfastamento();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProfessorAfastamento_Load(object sender, EventArgs e)
        {
            if (acaoNaTelaSelecionada == AcaoNaTela.Consultar)
            {
                 pnlAfastamento.Enabled = false;
            }
            try
            {
                Convert.ToUInt32(CodigoProfesor);
                txtNomeProfessor.Text = NomeProfessor;
                CarregaAfastamento();
            }
            catch
            {
                MessageBox.Show("Não Foi Possivel abrir os dados do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void btnInserirResponsavel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMotivo.Text))
            {
                MessageBox.Show("Digite um motivo para o afastamento");
                return;
            }
            
            SalvaAlteraAfastamento();
        }

        private void btnNovoResponsavel_Click(object sender, EventArgs e)
        {
            txtMotivo.Text = "";
            nrDias.Value = 0;
            dtpDt_Afast.Value = DateTime.Now;
        }

        private void btnAlterarResponsavel_Click(object sender, EventArgs e)
        {
            if (btnAlterar.Text == "Alterar")
            {
            
                btnInserir.Enabled = false;
                btnExcluir.Enabled = false;
                btnAlterar.Text = "Salvar";
                dtpDt_Afast.Value = Convert.ToDateTime(dgvProfessorAfastamento.CurrentRow.Cells[2].Value);
                nrDias.Value = Convert.ToUInt16(dgvProfessorAfastamento.CurrentRow.Cells[3].Value);
                txtMotivo.Text = Convert.ToString(dgvProfessorAfastamento.CurrentRow.Cells[4].Value);
                editar = true;
            
            }
            else if (btnAlterar.Text == "Salvar")
            {

                btnInserir.Enabled = true;
                btnExcluir.Enabled = true;
                btnAlterar.Text = "Alterar";
                SalvaAlteraAfastamento();
                editar = false;
            
            }

        }

        private void btnExcluirResponsavel_Click(object sender, EventArgs e)
        {
            if (dgvProfessorAfastamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Tem certeza que deseja excluir o afastamento da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            ProfessorAfastamento professorAfastamentoSelecionado = (dgvProfessorAfastamento.SelectedRows[0].DataBoundItem as ProfessorAfastamento);
            ProfessorAfastamentoNegocios professorAfastamentoNegocios = new ProfessorAfastamentoNegocios();
            string retorno = professorAfastamentoNegocios.Excluir(professorAfastamentoSelecionado);

            try
            {
                int codResp = Convert.ToInt32(retorno);
                dtpDt_Afast.Focus();
                CarregaAfastamento();

            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o responsável." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void FrmProfessorAfastamento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && acaoNaTelaSelecionada == AcaoNaTela.Consultar)
            {
                this.Close();
            }
        }

        private void btFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluirregistro_Click(object sender, EventArgs e)
        {
            if (dgvProfessorAfastamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado.");
                return;
            }

            ProfessorAfastamento professorAfastamento = new ProfessorAfastamento();
            ProfessorAfastamentoNegocios professorAfastamentoNegocios = new ProfessorAfastamentoNegocios();
            professorAfastamento.Cod_Item = Convert.ToInt32(dgvProfessorAfastamento.CurrentRow.Cells[1].Value);
            professorAfastamento.Cod_Professor = Convert.ToInt32(dgvProfessorAfastamento.CurrentRow.Cells[0].Value);
            String retorno = professorAfastamentoNegocios.Excluir(professorAfastamento);
            try
            {
                int codProfessor = Convert.ToInt32(retorno);
                MessageBox.Show("Item excluído com sucesso da lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaAfastamento();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInserirregistro_Click(object sender, EventArgs e)
        {
            if (!validaForm()) return;
            ProfessorAfastamento professorAfastamento = new ProfessorAfastamento();
            professorAfastamento.Cod_Item = Convert.ToInt32(dgvProfessorAfastamento.RowCount + 1);
            professorAfastamento.Cod_Professor = Convert.ToInt32(CodigoProfesor);
            professorAfastamento.Dt_afast = Convert.ToDateTime(dtpDt_Afast.Value);
            professorAfastamento.Dias = Convert.ToInt16(nrDias.Value);
            professorAfastamento.Motivo = Convert.ToString(txtMotivo.Text);
            ProfessorAfastamentoNegocios professorAfastamentoNegocios = new ProfessorAfastamentoNegocios();
            string retorno = professorAfastamentoNegocios.Inserir(professorAfastamento);
            try
            {
                int idProfessor = Convert.ToInt32(retorno);
                MessageBox.Show("Afastamento Inserida com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nrDias.Value = 0;
                dtpDt_Afast.Value = DateTime.Now;
                txtMotivo.Text = "";
                CarregaAfastamento();

            }
            catch
            {
                MessageBox.Show("Não foi possivel inserir o item na grade para esse professor." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnAlterarregistro_Click(object sender, EventArgs e)
        {
            if (dgvProfessorAfastamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado.");
                return;
            }
            if (btnAlterar.Text == "Alterar")
            {
                btnExcluir.Enabled = false;
                btnInserir.Enabled = false;
                btnAlterar.Text = "Salvar";
                dgvProfessorAfastamento.Enabled = false;
                dtpDt_Afast.Text = Convert.ToString(dgvProfessorAfastamento.CurrentRow.Cells[2].Value);
                nrDias.Value = Convert.ToInt16(dgvProfessorAfastamento.CurrentRow.Cells[3].Value);
                txtMotivo.Text = Convert.ToString(dgvProfessorAfastamento.CurrentRow.Cells[4].Value);

            }
            else if (btnAlterar.Text == "Salvar")
            {
                if (!validaForm()) return;
                Habilit_Profissional habilit_Profissional = new Habilit_Profissional();

                ProfessorAfastamento professorAfastamento = new ProfessorAfastamento();
                professorAfastamento.Cod_Item = Convert.ToInt32(dgvProfessorAfastamento.RowCount + 1);
                professorAfastamento.Cod_Professor = Convert.ToInt32(CodigoProfesor);
                professorAfastamento.Dt_afast = Convert.ToDateTime(dtpDt_Afast.Value);
                professorAfastamento.Dias = Convert.ToInt16(nrDias.Value);
                professorAfastamento.Motivo = Convert.ToString(txtMotivo.Text);
                ProfessorAfastamentoNegocios professorAfastamentoNegocios = new ProfessorAfastamentoNegocios();

                string retorno = professorAfastamentoNegocios.Alterar(professorAfastamento);
                try
                {
                    int idAfastamento = Convert.ToInt32(retorno);
                    MessageBox.Show("Item alterado com sucesso.");
                    CarregaAfastamento();
                    dgvProfessorAfastamento.Enabled = true;
                    dtpDt_Afast.Value = DateTime.Now.Date;
                    nrDias.Value = 0;
                    txtMotivo.Text = "";

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados do afastamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnExcluir.Enabled = true;
                btnInserir.Enabled = true;
                btnAlterar.Text = "Alterar";
                dgvProfessorAfastamento.Enabled = true;

            }

        }

        private bool validaForm()
        {

            lblNomeProfessor.ForeColor = System.Drawing.SystemColors.Control;
            lblDt_Afast.ForeColor = System.Drawing.SystemColors.Control;
            lblDias.ForeColor = System.Drawing.SystemColors.Control;
            lblMotivo.ForeColor = System.Drawing.SystemColors.Control;

            //===============================================================================================
            if (string.IsNullOrEmpty(txtNomeProfessor.Text))
            {
                MessageBox.Show("Nome do Professor é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeProfessor.Focus();
                lblNomeProfessor.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(dtpDt_Afast.Text))
            {
                MessageBox.Show("Campo data de afastamento e obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDt_Afast.Focus();
                lblDt_Afast.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(nrDias.Text))
            {
                MessageBox.Show("Campo quantidade de dias é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nrDias.Focus();
                lblDias.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtMotivo.Text))
            {
                MessageBox.Show("Campo motivo é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMotivo.Focus();
                lblMotivo.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            return true;


        }

    }
}
