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
using Utilitario;

namespace Apresentacao
{
    public partial class FrmTurmas : Form
    {
        int codSerie;
        bool editar;

        public FrmTurmas()
        {
            InitializeComponent();
            dgvTurma.AutoGenerateColumns = false;
        }

        private void CarregaSerie()
        {
            //instancia uma coleção de serie com base na procedure do Banco de Dados
            SerieNegocios serieNegocios = new SerieNegocios();
            SerieEstudantilColecao serieColecao = serieNegocios.ConsultarGrid();

            SerieEstudantil serie = new SerieEstudantil();
            serie.Cod_Serie = 0;
            serie.Nome_Serie = "";
            serieColecao.Insert(0, serie);
            this.cmbCod_Serie.DataSource = serieColecao;
            this.cmbCod_Serie.ValueMember = "Cod_Serie";
            this.cmbCod_Serie.DisplayMember = "Nome_serie";
            this.cmbCod_Serie.SelectedIndex = 0;
        }

        private void SalvaAlteraTurma()
        {

            Turma turma = new Turma();
            turma.Nome_Turma = txtNome_Turma.Text;
            turma.Ano_Letivo = txtANo_Letivo.Text;
            turma.Nr_Sala = Convert.ToString(txtNr_Sala.Text);
            turma.Cod_Serie = Convert.ToInt32(cmbCod_Serie.SelectedValue);
            turma.Observacao = txtObservacao.Text;
            
            if (rdbAtiva.Checked == true)
            {
                turma.Desativada = true;
            }
            else if (rdbInativo.Checked == true)
            {
                turma.Desativada = false;
            }


            if (editar == true)
            {
                turma.Cod_Turma = Convert.ToInt32(txtCod_Turma.Text);
                TurmaNegocios turmaNegocios = new TurmaNegocios();
                string retorno = turmaNegocios.Alterar(turma);

                try
                {
                    int idTurma = Convert.ToInt32(retorno);
                    MessageBox.Show("Turma alterada com sucesso.");
                    LimpaControles limpaControles = new LimpaControles();
                    limpaControles.ClearControls(this);
                    
                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados da Turma.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (editar == false)
            {

                TurmaNegocios turmaNegocios = new TurmaNegocios();
                string retorno = turmaNegocios.Inserir(turma);

                try
                {
                    int idTurma = Convert.ToInt32(retorno);
                    MessageBox.Show("Turma inserida com sucesso. Código: " + idTurma);
                    txtCod_Turma.Text = idTurma.ToString();
                    btnInserir.Text = "Salvar";
                    CarregaTurmaGrid();

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir a turma.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                        
        }

        private void CarregaTurmaGrid()
        {
            TurmaNegocios turmaNegocios = new TurmaNegocios();
            TurmaColecao turmaColecao = turmaNegocios.ConsultarPorNome(txtPesquisar.Text);

            dgvTurma.DataSource = null;
            dgvTurma.DataSource = turmaColecao;

            dgvTurma.Update();
            dgvTurma.Refresh();
        }

        private void CarregaTurma()
        {
            txtCod_Turma.Text = Convert.ToString(dgvTurma.CurrentRow.Cells[0].Value);
            txtNome_Turma.Text = Convert.ToString(dgvTurma.CurrentRow.Cells[1].Value);
            txtANo_Letivo.Text = Convert.ToString(dgvTurma.CurrentRow.Cells[2].Value);
            txtNr_Sala.Text = Convert.ToString(dgvTurma.CurrentRow.Cells[3].Value);
            codSerie = Convert.ToInt32(dgvTurma.CurrentRow.Cells[4].Value);
            cmbCod_Serie.SelectedValue = codSerie;
            txtObservacao.Text = Convert.ToString(dgvTurma.CurrentRow.Cells[5].Value);
            bool Situacao = Convert.ToBoolean(dgvTurma.CurrentRow.Cells[6].Value);
            if (Situacao == true)
            {
                rdbAtiva.Checked = true;
            }
            else if (Situacao == false)
            {
                rdbInativo.Checked = true;
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvTurma.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir a turma da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Turma turma = (dgvTurma.SelectedRows[0].DataBoundItem as Turma);
            TurmaNegocios turmaNegocios = new TurmaNegocios();
            string retorno = turmaNegocios.Excluir(turma);

            try
            {
                int codTurma = Convert.ToInt32(retorno);
                CarregaTurmaGrid();

            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir a turma." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTurmas_Load(object sender, EventArgs e)
        {
            CarregaSerie();
            CarregaTurmaGrid();
            if (dgvTurma.Rows.Count > 0)
            {
                btnAlunosDaTurma.Enabled = true;
                btnProfessoresDaTurma.Enabled = true;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTurma.Rows.Count; i++)
            {

                if (txtNome_Turma.Text.ToUpper() == dgvTurma[1, i].Value.ToString().ToUpper())
                {

                    MessageBox.Show("Nome de Turma já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

            editar = false;
            if (!validaForm()) return;
            SalvaAlteraTurma();
            //LimpaControles lc = new LimpaControles();
            //lc.ClearControls(this);
            CarregaTurmaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvTurma.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma turma para ser alterada", "Turma não eoncontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            editar = true;

            if (btnAlterar.Text == "Alterar")
            {
                CarregaTurma();
                btnInserir.Enabled = false;
                btnExcluir.Enabled = false;
                dgvTurma.Enabled = false;
                btnAlterar.Text = "Salvar";

            }
            else if (btnAlterar.Text == "Salvar")
            {
                 if (!validaForm()) return;
                btnInserir.Enabled = true;
                btnExcluir.Enabled = true;
                btnAlterar.Text = "Alterar";
                SalvaAlteraTurma();
                dgvTurma.Enabled = true;
                CarregaTurmaGrid();
            }
        }

        private void btnAlunosDaTurma_Click(object sender, EventArgs e)
        {

            if (dgvTurma.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe turma selecionada.");
                return;
            }

            Turma turmaSelecionada = (dgvTurma.SelectedRows[0].DataBoundItem as Turma);
            FrmAlunosTurma frmAlunosTurma = new FrmAlunosTurma(turmaSelecionada);
            frmAlunosTurma.ShowDialog();
        }

        private void btnProfessoresDaTurma_Click(object sender, EventArgs e)
        {
            if (dgvTurma.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe turma selecionada.");
                return;
            }

            Turma turmaSelecionada = (dgvTurma.SelectedRows[0].DataBoundItem as Turma);
            FrmProfessorTurma frmProfessorTurma = new FrmProfessorTurma(turmaSelecionada);
            frmProfessorTurma.ShowDialog();
        }

        private void FrmTurmas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (dgvTurma.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Não existe turma selecionada.");
                    return;
                }

                Turma turmaSelecionada = (dgvTurma.SelectedRows[0].DataBoundItem as Turma);
                FrmAlunosTurma frmAlunosTurma = new FrmAlunosTurma(turmaSelecionada);
                frmAlunosTurma.ShowDialog();
            }
            
            if (e.KeyCode == Keys.F6)
            {
                if (dgvTurma.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Não existe turma selecionada.");
                    return;
                }

                Turma turmaSelecionada = (dgvTurma.SelectedRows[0].DataBoundItem as Turma);
                FrmProfessorTurma frmProfessorTurma = new FrmProfessorTurma(turmaSelecionada);
                frmProfessorTurma.ShowDialog();

            }

        }

        private void FrmTurmas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private bool validaForm()
        {

            lblNome_Turma.ForeColor = System.Drawing.SystemColors.ControlText;
            lblAno_Letivo.ForeColor = System.Drawing.SystemColors.ControlText;
            lblNr_Sala.ForeColor = System.Drawing.SystemColors.ControlText;
            lblCod_Serie.ForeColor = System.Drawing.SystemColors.ControlText;

            //===============================================================================================
            if (string.IsNullOrEmpty(txtNome_Turma.Text))
            {
                MessageBox.Show("Nome da turma é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome_Turma.Focus();
                lblNome_Turma.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtANo_Letivo.Text))
            {
                MessageBox.Show("Ano Letivo é obrigátório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtANo_Letivo.Focus();
                lblAno_Letivo.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtNr_Sala.Text))
            {
                MessageBox.Show("Número da sala é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNr_Sala.Focus();
                lblNr_Sala.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (cmbCod_Serie.SelectedIndex == 0)
            {
                MessageBox.Show("Série é obrigatória", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCod_Serie.Focus();
                lblCod_Serie.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            return true;


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaTurmaGrid();
        }
               

    }
}
