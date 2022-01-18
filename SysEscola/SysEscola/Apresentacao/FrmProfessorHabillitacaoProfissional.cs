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
    public partial class FrmProfessorHabillitacaoProfissional : Form
    {
        int codigo;
        AcaoNaTela acaoNaTelaSelecionada;
        public FrmProfessorHabillitacaoProfissional(AcaoNaTela acaoNaTela, int codProfesor)
        {
            InitializeComponent();
            dgvHabilt_Profissional.AutoGenerateColumns = false;
            acaoNaTelaSelecionada = acaoNaTela;
            codigo = codProfesor; 
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           
            if (dgvHabilt_Profissional.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado.");
                return;
            }
            if (btnAlterar.Text == "Alterar")
            {
                btnExcluir.Enabled = false;
                btnInserir.Enabled = false;
                btnAlterar.Text = "Salvar";
                dgvHabilt_Profissional.Enabled = false;
                txtDescHabilitacao.Text = Convert.ToString(dgvHabilt_Profissional.CurrentRow.Cells[2].Value);
                dtpDataCunclusao.Value = Convert.ToDateTime(dgvHabilt_Profissional.CurrentRow.Cells[4].Value);
                txtDuracao.Text = Convert.ToString(dgvHabilt_Profissional.CurrentRow.Cells[5].Value);
                txtInstituicao.Text = Convert.ToString(dgvHabilt_Profissional.CurrentRow.Cells[3].Value);

            }
            else if (btnAlterar.Text == "Salvar")
            {
                if (!validaForm()) return;
                Habilit_Profissional habilit_Profissional = new Habilit_Profissional();

                habilit_Profissional.Cod_Habilitacao = Convert.ToInt32(dgvHabilt_Profissional.CurrentRow.Cells[0].Value);
                habilit_Profissional.Cod_Professor = Convert.ToInt32(dgvHabilt_Profissional.CurrentRow.Cells[1].Value);
                habilit_Profissional.Desc_Habilitacao = txtDescHabilitacao.Text;
                habilit_Profissional.Data_Conclusao = dtpDataCunclusao.Value;
                habilit_Profissional.Duracao = txtDuracao.Text;
                habilit_Profissional.Instituicao = Convert.ToString(txtInstituicao.Text);
                Habilt_ProfissionalNegocios habilt_ProfissionalNegocios = new Habilt_ProfissionalNegocios();
                string retorno = habilt_ProfissionalNegocios.Alterar(habilit_Profissional);
                try
                {
                    int idHabilitacao = Convert.ToInt32(retorno);
                    MessageBox.Show("Item alterado com sucesso.");
                    CarregaGridHabilProf();
                    dgvHabilt_Profissional.Enabled = true;
                    txtDescHabilitacao.Text = "";
                    dtpDataCunclusao.Value = DateTime.Now.Date;
                    txtDuracao.Text = "";
                    txtInstituicao.Text = "";



                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados da Habilitação Profssional.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnExcluir.Enabled = true;
                btnInserir.Enabled = true;
                btnAlterar.Text = "Alterar";
                dgvHabilt_Profissional.Enabled = true;

            }
            CarregaGridHabilProf();
        }

        private void CarregaGridHabilProf()
        {
            Habilt_ProfissionalNegocios habilt_ProfissionalNegocios = new Habilt_ProfissionalNegocios();
            Habilit_ProfissionaolColecao habilit_ProfissionaolColecao = habilt_ProfissionalNegocios.Consultar(Convert.ToInt32(codigo));

            dgvHabilt_Profissional.DataSource = null;
            dgvHabilt_Profissional.DataSource = habilit_ProfissionaolColecao;

            dgvHabilt_Profissional.Update();
            dgvHabilt_Profissional.Refresh();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvHabilt_Profissional.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado.");
                return;
            }

            Habilit_Profissional habilit_ProfissionalSelecionado = new Habilit_Profissional();
            Habilt_ProfissionalNegocios habilt_ProfissionalNegocios = new Habilt_ProfissionalNegocios();
            habilit_ProfissionalSelecionado.Cod_Habilitacao = Convert.ToInt32(dgvHabilt_Profissional.CurrentRow.Cells[0].Value);
            habilit_ProfissionalSelecionado.Cod_Professor = Convert.ToInt32(dgvHabilt_Profissional.CurrentRow.Cells[1].Value);
            String retorno = habilt_ProfissionalNegocios.Excluir(habilit_ProfissionalSelecionado);
            try
            {
                int Cod_Aluno = Convert.ToInt32(retorno);
                MessageBox.Show("Item excluído com sucesso da lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGridHabilProf();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (!validaForm()) return;
            if (String.IsNullOrEmpty(txtDescHabilitacao.Text))
            {
                MessageBox.Show("Campo descrição vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Habilit_Profissional habilit_Profissional = new Habilit_Profissional();
            habilit_Profissional.Cod_Habilitacao = Convert.ToInt32(dgvHabilt_Profissional.RowCount + 1);
            habilit_Profissional.Cod_Professor = Convert.ToInt32(codigo);
            habilit_Profissional.Desc_Habilitacao = Convert.ToString(txtDescHabilitacao.Text);
            habilit_Profissional.Data_Conclusao = dtpDataCunclusao.Value;
            habilit_Profissional.Duracao = Convert.ToString(txtDuracao.Text);
            habilit_Profissional.Instituicao = Convert.ToString(txtInstituicao.Text);
            Habilt_ProfissionalNegocios habilt_ProfissionalNegocios = new Habilt_ProfissionalNegocios();
            string retorno = habilt_ProfissionalNegocios.Inserir(habilit_Profissional);
            try
            {
                int idElo = Convert.ToInt32(retorno);
                MessageBox.Show("Habilitação Profissional Inserida com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGridHabilProf();
                txtDescHabilitacao.Text = "";
                dtpDataCunclusao.Value = DateTime.Now;
                txtDuracao.Text = "";
                CarregaGridHabilProf();

            }
            catch
            {
                MessageBox.Show("Não foi possivel inserir uma Habilitação Profssional na grade para esse professor." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void FrmProfessorHabillitacaoProfissional_Load(object sender, EventArgs e)
        {
            CarregaGridHabilProf();
            if (acaoNaTelaSelecionada == AcaoNaTela.Consultar)
            {
                pnlHabilitacaoProfssional.Enabled = false;
            }
        }

        private void FrmProfessorHabillitacaoProfissional_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && acaoNaTelaSelecionada == AcaoNaTela.Consultar)
            {
                this.Close();
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validaForm()
        {

            lblDescricao.ForeColor = System.Drawing.SystemColors.Control;
            lblInstituicao.ForeColor = System.Drawing.SystemColors.Control;
            lblDataConclusao.ForeColor = System.Drawing.SystemColors.Control;
            lblDuracao.ForeColor = System.Drawing.SystemColors.Control;
            
            //===============================================================================================
            if (string.IsNullOrEmpty(txtDescHabilitacao.Text))
            {
                MessageBox.Show("Campo descrição e obrtigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescHabilitacao.Focus();
                lblDescricao.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtInstituicao.Text))
            {
                MessageBox.Show("Campo instituição e obrigatorio", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInstituicao.Focus();
                lblInstituicao.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(dtpDataCunclusao.Text))
            {
                MessageBox.Show("Campo data de conclusão é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDataCunclusao.Focus();
                lblDataConclusao.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtDuracao.Text))
            {
                MessageBox.Show("Campo duração é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDuracao.Focus();
                lblDuracao.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            return true;


        }

    }
}
