using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Negocios;
using ObjetoTrasnferencia;

namespace Apresentacao
{
    public partial class FrmLivroDidatico : Form
    {
        int codLivroDidatico;
        bool editar = false;

        public FrmLivroDidatico()
        {
            InitializeComponent();
            dgvLIvro.AutoGenerateColumns = false;
        }

        private void CarregaGrid()
        {
            LivroDidaticoNegocios livroDidaticoNegocios = new LivroDidaticoNegocios();
            LivroDidaticoColecao livroDidaticoColecaoGrid = new LivroDidaticoColecao(); 
            livroDidaticoColecaoGrid = livroDidaticoNegocios.ConsultarGrid(txtNomeLivro.Text);
            dgvLIvro.DataSource = null;
            dgvLIvro.DataSource = livroDidaticoColecaoGrid.Select(s => new
            {
                s.Cod_Livro,
                s.Nome_Livro,
                s.Editora,
                s.Autor,
                s.Edicao,
                s.Materia,
                s.generosLiterarios.Desc_Genero,
                s.Emprestado,
                s.Ativo,
                s.Data_Cadastro
            }).ToArray();

            dgvLIvro.Update();
            dgvLIvro.Refresh();
        }

        private void SalvaAlteraLivroDidatico()
        {
            LivroDidatico livroDidatico = new LivroDidatico();

            livroDidatico.Cod_Livro = codLivroDidatico;
            livroDidatico.Nome_Livro = txtNomeLivro.Text;
            livroDidatico.Editora = txtEditora.Text;
            livroDidatico.Autor = txtAutor.Text;
            livroDidatico.Edicao = txtEdicao.Text;
            livroDidatico.Materia = txtMateria.Text;
            livroDidatico.generosLiterarios = new GenerosLiterarios();
            livroDidatico.generosLiterarios.Cod_Genero = Convert.ToInt32(cmbGenero.SelectedValue);
            livroDidatico.Data_Cadastro = Convert.ToDateTime(dtpDataCadastro.Value);
            if (chkEmprestado.Checked == true)
            {
                livroDidatico.Emprestado = true;

            }
            else
            {
                livroDidatico.Emprestado = false;
            }
            if (chkAtivo.Checked == true)
            {
                livroDidatico.Ativo = true;
            }
            else
            {
                livroDidatico.Ativo = false;
            }

            if (editar == true)
            {
                livroDidatico.Cod_Livro = Convert.ToInt32(codLivroDidatico);
                LivroDidaticoNegocios livroDidaticoNegocios = new LivroDidaticoNegocios();
                string retorno = livroDidaticoNegocios.Alterar(livroDidatico);

                try
                {
                    int idLivro = Convert.ToInt32(retorno);
                    MessageBox.Show("Dados do livro alterados com sucesso.");

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados do livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (editar == false)
            {

                LivroDidaticoNegocios livroDidaticoNegocios = new LivroDidaticoNegocios();
                string retorno = livroDidaticoNegocios.Inserir(livroDidatico);

                try
                {
                    int idLivro = Convert.ToInt32(retorno);
                    MessageBox.Show("Dados do livro inserido com sucesso. Código: " + idLivro);
                    codLivroDidatico = Convert.ToInt32(idLivro);
                    btnInserir.Text = "Salvar";
                    CarregaGrid();

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir os dados do livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimpaControles limpaControles = new LimpaControles();
            limpaControles.ClearControls(this);

        }

        private void CarregaLivro()
        {
            codLivroDidatico = Convert.ToInt32(dgvLIvro.CurrentRow.Cells[0].Value);
            txtNomeLivro.Text = Convert.ToString(dgvLIvro.CurrentRow.Cells[1].Value);
            txtEditora.Text = Convert.ToString(dgvLIvro.CurrentRow.Cells[2].Value);
            txtAutor.Text = Convert.ToString(dgvLIvro.CurrentRow.Cells[3].Value);
            txtEdicao.Text = Convert.ToString(dgvLIvro.CurrentRow.Cells[4].Value);
            txtMateria.Text = Convert.ToString(dgvLIvro.CurrentRow.Cells[5].Value);
            cmbGenero.Text = Convert.ToString(dgvLIvro.CurrentRow.Cells[6].Value);
            chkEmprestado.Checked = Convert.ToBoolean(dgvLIvro.CurrentRow.Cells[7].Value);
            chkAtivo.Checked = Convert.ToBoolean(dgvLIvro.CurrentRow.Cells[8].Value);
            dtpDataCadastro.Text = Convert.ToString(dgvLIvro.CurrentRow.Cells[9].Value);
        }
        
        private void CarregaGenero()
        {
            GenerosLiterariosNegocios generosLiterariosNegocios = new GenerosLiterariosNegocios();
            GenerosLiterariosColecao generosLiterariosColecao = generosLiterariosNegocios.ConsultarCombo();

            GenerosLiterarios generosLiterarios = new GenerosLiterarios();
            generosLiterarios.Cod_Genero = 0;
            generosLiterarios.Desc_Genero = "";
            generosLiterariosColecao.Insert(0, generosLiterarios);
            this.cmbGenero.DataSource = generosLiterariosColecao;
            this.cmbGenero.ValueMember = "Cod_Genero";
            this.cmbGenero.DisplayMember = "Desc_Genero";
            this.cmbGenero.SelectedIndex = 0;
        }

        private bool validaForm()
        {

            lblNomeLivro.ForeColor = System.Drawing.SystemColors.ControlText;
            lblEditora.ForeColor = System.Drawing.SystemColors.ControlText;
            lblAutor.ForeColor = System.Drawing.SystemColors.ControlText;
            lblEdicao.ForeColor = System.Drawing.SystemColors.ControlText;
            lblMateria.ForeColor = System.Drawing.SystemColors.ControlText;
            lblGenero.ForeColor = System.Drawing.SystemColors.ControlText;
            lblDataCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            chkAtivo.ForeColor = System.Drawing.SystemColors.ControlText;
            //===============================================================================================
            if (string.IsNullOrEmpty(txtNomeLivro.Text))
            {
                MessageBox.Show("Nome do livro é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeLivro.Focus();
                lblNomeLivro.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtEditora.Text))
            {
                MessageBox.Show("Nome da editora é obrigátório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditora.Focus();
                lblEditora.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtAutor.Text))
            {
                MessageBox.Show("Nome do autor é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAutor.Focus();
                lblAutor.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtEdicao.Text))
            {
                MessageBox.Show("Edição do autor é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdicao.Focus();
                lblEdicao.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            //===============================================================================================
            if (string.IsNullOrEmpty(txtMateria.Text))
            {
                MessageBox.Show("Matéria ou assunto para o livro é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMateria.Focus();
                lblMateria.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (cmbGenero.SelectedIndex == 0)
            {
                MessageBox.Show("Gênero é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGenero.Focus();
                lblGenero.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtMateria.Text))
            {
                MessageBox.Show("Indique o status (" + "ativo / inativo" +  " do livro no biblioteca", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMateria.Focus();
                lblMateria.ForeColor = System.Drawing.Color.Red;
                return false;
            }


            return true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLivroDidatico_Load(object sender, EventArgs e)
        {
            CarregaGenero();
            CarregaGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            editar = false;
            if (!validaForm()) return;
            SalvaAlteraLivroDidatico();
            CarregaGrid();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvLIvro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe livro selecionado selecionado.");
                return;
            }

            CarregaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (dgvLIvro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe livro selecionado selecionado.");
                return;
            }

            editar = true;

            if (btnAlterar.Text == "Alterar")
            {
                CarregaLivro();
                btnInserir.Enabled = false;
                btnConsultar.Enabled = false;
                btnExcluir.Enabled = false;
                dgvLIvro.Enabled = false;
                btnAlterar.Text = "Salvar";
            }
            else if (btnAlterar.Text == "Salvar")
            {
                if (!validaForm()) return;
                btnInserir.Enabled = true;
                btnConsultar.Enabled = true;
                btnExcluir.Enabled = true;
                btnAlterar.Text = "Alterar";
                SalvaAlteraLivroDidatico();
                dgvLIvro.Enabled = true;
                CarregaGrid();
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvLIvro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe livro selecionado.");
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir o livro selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            LivroDidatico livroDidatico = new LivroDidatico();
            livroDidatico.Cod_Livro = Convert.ToInt32(dgvLIvro.CurrentRow.Cells[0].Value);
            LivroDidaticoNegocios livroDidaticoNegocios = new LivroDidaticoNegocios();
            string retorno = livroDidaticoNegocios.Excluir(livroDidatico);
            try
            {
                int codlivro = Convert.ToInt32(retorno);
                MessageBox.Show("Livro excluido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o livro." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnEmprestimoLivro_Click(object sender, EventArgs e)
        {
            if (dgvLIvro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe livro selecionado selecionado.");
                return;
            }

            LivroDidatico livroDidatico = new LivroDidatico();
            livroDidatico.Cod_Livro = Convert.ToInt32(dgvLIvro.CurrentRow.Cells[0].Value);
            livroDidatico.Nome_Livro = Convert.ToString(dgvLIvro.CurrentRow.Cells[1].Value);

            FrmEmprestimoLivro frmEmprestimoLivro = new FrmEmprestimoLivro(livroDidatico);
            DialogResult dialogResult = frmEmprestimoLivro.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                CarregaGrid();
            }
 
        }
    }
}
