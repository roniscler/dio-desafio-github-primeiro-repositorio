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
    public partial class FrmAlunoSelecionar : Form
    {
        public FrmAlunoSelecionar()
        {
            InitializeComponent();
            dgvPrincipal.AutoGenerateColumns = false;

        }
        //====================================================================================================================
        //EVENTO CLICK DO BOTAO PESQUISAR DO GRID DE ALUNOA
        private void btPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid();            
        }
        //====================================================================================================================
        //METODO PARA RECARREGAR O GRID DE ALUNOS
        private void CarregaGrid()
        {
            AlunoNegocios alunoNegocios = new AlunoNegocios();
            AlunoColecao alunoColecao = alunoNegocios.ConsultarPorNome(txtPesquisa.Text);

            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = alunoColecao;

            dgvPrincipal.Update();
            dgvPrincipal.Refresh();

        }
        //====================================================================================================================
        //EVENTO CLICK DO BOTAO QUE CONSULTA O ALUNO NA TELA DE ALUNOS
        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Aluno selecionado.");
                return;
            }
            
            Aluno alunoSelecionado = (dgvPrincipal.SelectedRows[0].DataBoundItem as Aluno);

            FrmAluno frmAluno = new FrmAluno(AcaoNaTela.Consultar, alunoSelecionado);
            frmAluno.Show();
                                  
        }

        //====================================================================================================================
        //EVENTO CLICK DO BOTAO DE FACHAR O FORM
        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //====================================================================================================================
        //EVENTO CLICK DO BOTAO QUE EXCLUI O ALUNO DIRETO NO GRID
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Aluno selecionado.");
                return;
            }
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o Aluno?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;

            }

            Aluno alunoSelecionado = (dgvPrincipal.SelectedRows[0].DataBoundItem as Aluno);
            AlunoNegocios alunoNegocio = new AlunoNegocios();
            string retorno = alunoNegocio.Excluir(alunoSelecionado);
            try
            {
                int codAluno = Convert.ToInt32(retorno);
                MessageBox.Show("Aluno excluido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        //====================================================================================================================
        //EVENTO CLICK QUE CARREGA O FORMULARIO DO ALUNO VAZIO PARA CADASTRO E ATUALIZA O GRID CONFORME A INSERCAO 
        private void btInserir_Click(object sender, EventArgs e)
        {
            FrmAluno frmAluno = new FrmAluno(AcaoNaTela.Inserir, null);
            
            DialogResult dialogResult = frmAluno.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                CarregaGrid();
            }
        }

        //==========================================================================================================================
        //EVENTO CLICK QUE CARREGA O FORMULARIO DO ALUNO COM UM ALUNO CADASTRADO E ATUALIZA O GRID CONFORME A RESPOSTA DO FORM ALUNO
        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Aluno selecionado.");
                return;
            }
           
            Aluno alunoSelecionado = (dgvPrincipal.SelectedRows[0].DataBoundItem as Aluno);
            FrmAluno frmAluno = new FrmAluno(AcaoNaTela.Alterar, alunoSelecionado);
            DialogResult dialogResult = frmAluno.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                CarregaGrid();
            }
           

        }

        private void FrmAlunoSelecionar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void FrmAlunoSelecionar_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
