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
    public partial class FrmEmprestimoLivro : Form
    {
        LivroDidatico livroVindo;
        bool editar;
        int codEmprestimo;

        public FrmEmprestimoLivro(LivroDidatico livroDidatico)
        {
            InitializeComponent();
            livroVindo = livroDidatico;
            dgvEmprestimos.AutoGenerateColumns = false;
        }

        private void CarregaGrid()
        {
            EmprestimoLivroNegocios emprestimoLivroNegocios = new EmprestimoLivroNegocios();
            EmprestimoLivroColecao emprestimoLivroColecaoGrid = new EmprestimoLivroColecao();
            DataTable dt = new DataTable();
            dt = emprestimoLivroNegocios.ConsultarGridDt(Convert.ToInt32(livroVindo.Cod_Livro)); 
            dgvEmprestimos.DataSource = null;
            dgvEmprestimos.DataSource = dt;
            dgvEmprestimos.Update();
            dgvEmprestimos.Refresh();
        }
  
        private void CarregaGridList()
        {
            EmprestimoLivroNegocios emprestimoLivroNegocios = new EmprestimoLivroNegocios();
            EmprestimoLivroColecao emprestimoLivroColecaoGrid = new EmprestimoLivroColecao();
            emprestimoLivroColecaoGrid = emprestimoLivroNegocios.ConsultarGrid(Convert.ToInt32(livroVindo.Cod_Livro));
            dgvEmprestimos.DataSource = null;
            dgvEmprestimos.DataSource = emprestimoLivroColecaoGrid.Select( s => new
            {
                s.Cod_Emprestimo,
                s.aluno.Nome_Aluno,
                s.livroDidatico.Cod_Livro,
                s.DataEmprestimo,
                s.QtdeDias,
                s.DataDevolucao

            }).ToArray();
            dgvEmprestimos.Update();
            dgvEmprestimos.Refresh();
        }
       
        private void CarregaAlunos()
        {
            AlunoNegocios alunoNegocios = new AlunoNegocios();
            AlunoColecao elementosColecao = alunoNegocios.ConsultarCombo();

            Aluno aluno = new Aluno();
            aluno.Cod_Aluno = 0;
            aluno.Nome_Aluno = "";
            elementosColecao.Insert(0, aluno);
            this.cmbAlunos.DataSource = elementosColecao;
            this.cmbAlunos.ValueMember = "Cod_Aluno";
            this.cmbAlunos.DisplayMember = "Nome_Aluno";
            this.cmbAlunos.SelectedIndex = 0;

        }

        private void SalvaAlteraEmprstimo()
        {
            EmprestimoLivro emprestimoLivro = new EmprestimoLivro();

            emprestimoLivro.Cod_Emprestimo = Convert.ToInt32(codEmprestimo);

            emprestimoLivro.livroDidatico = new LivroDidatico();
            emprestimoLivro.livroDidatico.Cod_Livro = Convert.ToInt32(txtCod_Livro.Text);

            emprestimoLivro.aluno = new Aluno();
            emprestimoLivro.aluno.Cod_Aluno = Convert.ToInt32(cmbAlunos.SelectedValue);
            emprestimoLivro.DataEmprestimo = Convert.ToDateTime(dtpDataEmprestimo.Text);
            emprestimoLivro.QtdeDias = Convert.ToInt16(nudQtdeDias.Value);
            if (editar == true)
            {
                emprestimoLivro.Cod_Emprestimo = Convert.ToInt32(codEmprestimo);
                EmprestimoLivroNegocios emprestimoLivroNegocios = new EmprestimoLivroNegocios();
                string retorno = emprestimoLivroNegocios.Alterar(emprestimoLivro);

                try
                {
                    int idEmprestimo = Convert.ToInt32(retorno);
                    MessageBox.Show("Dados alterados com sucesso.");
                    MarcaEmprestimo();

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (editar == false)
            {

                EmprestimoLivroNegocios emprestimoLivroNegocios = new EmprestimoLivroNegocios();
                string retorno = emprestimoLivroNegocios.Inserir(emprestimoLivro);

                try
                {
                    int idEmprestimo = Convert.ToInt32(retorno);
                    MessageBox.Show("Dados do livro inserido com sucesso. Código: " + idEmprestimo);
                    MarcaEmprestimo();
                    codEmprestimo = Convert.ToInt32(idEmprestimo);
                    btnInserir.Text = "Salvar";
                    this.DialogResult = DialogResult.Yes;

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir os dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MarcaEmprestimo()
        {
            LivroDidatico livroDidatico = new LivroDidatico();
            livroDidatico.Cod_Livro = Convert.ToInt32(txtCod_Livro.Text);
            LivroDidaticoNegocios livroDidaticoNegocios = new LivroDidaticoNegocios();
            string retorno = livroDidaticoNegocios.MarcarEmprestimo(livroDidatico);
            try
            {
                int idLivro = Convert.ToInt32(retorno);

            }
            catch
            {
                return;
            }

   
        }

        private void DesmarcaEmprestimo()
        {
            LivroDidatico livroDidatico = new LivroDidatico();
            livroDidatico.Cod_Livro = Convert.ToInt32(txtCod_Livro.Text);
            LivroDidaticoNegocios livroDidaticoNegocios = new LivroDidaticoNegocios();
            string retorno = livroDidaticoNegocios.desmarcarEmprestimo(livroDidatico);
            try
            {
                int idLivro = Convert.ToInt32(retorno);

            }
            catch
            {
                return;
            }
        }

        private void CarregaEmprestimo()
        {
            codEmprestimo = Convert.ToInt32(dgvEmprestimos.CurrentRow.Cells[0].Value);
            cmbAlunos.Text = Convert.ToString(dgvEmprestimos.CurrentRow.Cells[1].Value);
            dtpDataEmprestimo.Value = Convert.ToDateTime(dgvEmprestimos.CurrentRow.Cells[3].Value);
            nudQtdeDias.Value = Convert.ToInt16(dgvEmprestimos.CurrentRow.Cells[4].Value);
        }

        private bool validaForm()
        {

            lblCod_Livro.ForeColor = System.Drawing.SystemColors.ControlText;
            lblNome_Livro.ForeColor = System.Drawing.SystemColors.ControlText;
            lblcmbALunos.ForeColor = System.Drawing.SystemColors.ControlText;
            lblDataEmprestimo.ForeColor = System.Drawing.SystemColors.ControlText;
            lblQtdeDias.ForeColor = System.Drawing.SystemColors.ControlText;
            
            //===============================================================================================
            if (string.IsNullOrEmpty(txtCod_Livro.Text))
            {
                MessageBox.Show("Cõdigo do livro é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCod_Livro.Focus();
                lblCod_Livro.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtNome_Livro.Text))
            {
                MessageBox.Show("Nome do livro é obrigátório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome_Livro.Focus();
                lblNome_Livro.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (cmbAlunos.SelectedIndex == 0)
            {
                MessageBox.Show("Aluno é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAlunos.Focus();
                lblcmbALunos.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(dtpDataEmprestimo.Text))
            {
                MessageBox.Show("Data do empréstimo é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDataEmprestimo.Focus();
                lblDataEmprestimo.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(nudQtdeDias.Text))
            {
                MessageBox.Show("qtde de dias é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudQtdeDias.Focus();
                lblQtdeDias.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================

            return true;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEmprestimoLivro_Load(object sender, EventArgs e)
        {
            txtCod_Livro.Text = Convert.ToString(livroVindo.Cod_Livro);
            txtNome_Livro.Text = Convert.ToString(livroVindo.Nome_Livro);
            CarregaGrid();
            CarregaAlunos();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvEmprestimos.Rows.Count; i++)
            {

                if (string.IsNullOrWhiteSpace(dgvEmprestimos[5, i].Value.ToString()) == true)
                {

                    MessageBox.Show("Não é possivel gerar um empréstimo para este livro." + "\n Gere a devolução do empréstimo ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

            editar = false;
            if (!validaForm()) return;
            SalvaAlteraEmprstimo();
            CarregaGrid();
        }

        private void dgvEmprestimos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dtDevolucao = Convert.ToDateTime(dgvEmprestimos.CurrentRow.Cells[5].Value);
                btnDevolucao.Enabled = false;
            }
            catch
            {
                btnDevolucao.Enabled = true;
            }

            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvEmprestimos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe registro selecionado na grade.");
                return;
            }
            try
            {
                Convert.ToDateTime(dgvEmprestimos.CurrentRow.Cells[5].Value);
                MessageBox.Show("Não é possivel alterar os dados deste emprestimo." + "\n O livro já foi devolvido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch
            {
                editar = true;

                if (btnAlterar.Text == "Alterar")
                {
                    CarregaEmprestimo();
                    btnInserir.Enabled = false;
                    btnExcluir.Enabled = false;
                    dgvEmprestimos.Enabled = false;
                    btnAlterar.Text = "Salvar";
                }
                else if (btnAlterar.Text == "Salvar")
                {
                    if (!validaForm()) return;
                    btnInserir.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnAlterar.Text = "Alterar";
                    SalvaAlteraEmprstimo();
                    dgvEmprestimos.Enabled = true;
                    CarregaGrid();
                }
            }

        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            
            EmprestimoLivro emprestimoLivro = new EmprestimoLivro();
            emprestimoLivro.Cod_Emprestimo = Convert.ToInt32(dgvEmprestimos.CurrentRow.Cells[0].Value);
            emprestimoLivro.DataDevolucao = DateTime.Now;

            EmprestimoLivroNegocios emprestimoLivroNegocios = new EmprestimoLivroNegocios();
            string retorno = emprestimoLivroNegocios.DatarDevolucao(emprestimoLivro);

            try
            {
                int idEmprestimo = Convert.ToInt32(retorno);
                MessageBox.Show("Dados alterados com sucesso."); 
                DesmarcaEmprestimo();             

            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.DialogResult = DialogResult.Yes;
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvEmprestimos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe registro selecionado.");
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir o registro selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            EmprestimoLivro emprestimoLivro = new EmprestimoLivro();
            emprestimoLivro.Cod_Emprestimo = Convert.ToInt32(dgvEmprestimos.CurrentRow.Cells[0].Value);
            EmprestimoLivroNegocios emprestimoLivroNegocios = new EmprestimoLivroNegocios();
            string retorno = emprestimoLivroNegocios.Excluir(emprestimoLivro);
            try
            {
                int codlivro = Convert.ToInt32(retorno);
                MessageBox.Show("Dados excluidos com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o registro." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
