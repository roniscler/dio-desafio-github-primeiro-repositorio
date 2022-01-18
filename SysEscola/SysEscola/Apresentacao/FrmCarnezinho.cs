using Negocios;
using ObjetoTrasnferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmCarnezinho : Form
    {
        public FrmCarnezinho()
        {
            InitializeComponent();
            dgvPrincipal.AutoGenerateColumns = false;
        }

        private void CarregaGrid()
        {
            AlunoNegocios alunoNegocios = new AlunoNegocios();
            AlunoColecao alunoColecao = alunoNegocios.ConsultarAtivo();

            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = alunoColecao;

            dgvPrincipal.Update();
            dgvPrincipal.Refresh();

        }

        private void FrmCarnezinho_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

            CarnezinhoNegocios carnezinhoNegociosVerTitulo = new CarnezinhoNegocios();

            string retorno1 = carnezinhoNegociosVerTitulo.ConsultarExistenciaTitulo(Convert.ToString(txtAssunto.Text));

            try
            {
                int codRetorno = Convert.ToInt32(retorno1);

                if (codRetorno >= 1)
                {
                    MessageBox.Show("Titula já Cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Não foi possivel consultar a existencia de titulos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //========================================================================================================================================
                bool voltaValida = validaForm();

                if (voltaValida == false) return;

                if (dgvPrincipal.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um aluno", "Nenhum aluno selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    prgbStatus.Value = 0;
                    int totParc = dgvPrincipal.SelectedRows.Count * Convert.ToInt16(nudQtdeMensalidae.Value);
                    int passo = totParc / 100;
                    int transf = 0;
                    prgbStatus.Minimum = 0;
                    prgbStatus.Maximum = totParc;
                    prgbStatus.Step = totParc / 100;

                    foreach (DataGridViewRow r in dgvPrincipal.SelectedRows)
                    {
                        
                        int qtdeParcelas = Convert.ToInt16(nudQtdeMensalidae.Value);
                        var row = dgvPrincipal.SelectedRows[0];
                        var value = r.Cells[0].Value;
                        

                        for (var i = 1; i <= qtdeParcelas; i++)
                        {                            
                            DateTime dataInicial = Convert.ToDateTime(dtpDataInicial.Value);
                            CarnezinhoNegocios carnezinhoNegocios = new CarnezinhoNegocios();
                            Carnezinho carnezinho = new Carnezinho();

                            carnezinho.Parcela = String.Format("{0}/{1}", Convert.ToString(i), Convert.ToString(qtdeParcelas));
                            carnezinho.Data_Vcto = Convert.ToDateTime(dataInicial.AddMonths(i).ToShortDateString());
                            carnezinho.Valor = Convert.ToDecimal(txtValor.Text);
                            carnezinho.aluno = new Aluno();
                            carnezinho.aluno.Cod_Aluno = Convert.ToInt32(value);
                            carnezinho.Titulo = Convert.ToString(txtAssunto.Text);
                            decimal valor = Convert.ToDecimal(carnezinho.Valor);

                            //prgbStatus.Maximum = qtdeParcelas * dgvPrincipal.SelectedRows.Count;
                            //prgbStatus.Step = totParc / 100;
                            //prgbStatus.PerformStep();


                            string retorno = carnezinhoNegocios.Inserir(carnezinho);
                            try
                            {
                                Convert.ToInt32(retorno);
                                if (passo < totParc)
                                {
                                    passo++;
                                    transf = passo;
                                }                                
                                prgbStatus.Value = transf;
                            }
                            catch
                            {
                                MessageBox.Show("Não foi possivel inserir as mensalidades." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    MessageBox.Show("Geração concluída com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                
            //=================================================================================================================================================


        }

        private bool validaForm()
        {
            
            lblQtde.ForeColor = System.Drawing.SystemColors.Control;
            lblDataInicial.ForeColor = System.Drawing.SystemColors.Control;
            lblValor.ForeColor = System.Drawing.SystemColors.Control;
            lblAssunto.ForeColor = System.Drawing.SystemColors.Control;

            //===============================================================================================

            bool resultado;

            try
            {
                 Convert.ToDecimal(txtValor.Text);
                 resultado = true;
            }
            catch (Exception)
            {
                
                resultado = false;
            }

            if (resultado == false)
            {
                MessageBox.Show("valor inválido", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                lblValor.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            
            if (nudQtdeMensalidae.Value == 0)
            {
                MessageBox.Show("É necessário colocar a quantidade de mensalidades", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudQtdeMensalidae.Focus();
                lblQtde.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(dtpDataInicial.Text))
            {
                MessageBox.Show("Digite uma data válida", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDataInicial.Focus();
                lblDataInicial.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("O campo valor é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                lblValor.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtAssunto.Text))
            {
                MessageBox.Show("Título é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAssunto.Focus();
                lblAssunto.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            
            return true;

        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            FrmCarnezinhoParcelas frmParcelasCarnezinho = new FrmCarnezinhoParcelas();
            frmParcelasCarnezinho.ShowDialog();
        }

    }
}
