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
    public partial class FrmMensalidadeAlterar : Form
    {
        Int32 codMensalidade, codTurma, codAluno;
        Mensalidade novaMensalidade = new Mensalidade();
        public FrmMensalidadeAlterar(Mensalidade mensalidade)
        {
            InitializeComponent();
            novaMensalidade = mensalidade;
            codMensalidade = novaMensalidade.Cod_Mensalidade;
            codTurma = novaMensalidade.turma.Cod_Turma;
            codAluno = novaMensalidade.aluno.Cod_Aluno;
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                txtValor.Text = Convert.ToDecimal(txtValor.Text).ToString("F");
            }
            catch
            {
                MessageBox.Show("Favor digite um valor decimal no formato 0,00");
                txtValor.Focus();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMensalidadeAlterar_Load(object sender, EventArgs e)
        {
            try
            {
                txtNum_Mensalidade.Text = Convert.ToString(novaMensalidade.Num_Mensalidade);
                dtpDataVcto.Value = Convert.ToDateTime(novaMensalidade.DataVencimento);
                txtValor.Text = Convert.ToString(novaMensalidade.Valor);
                txtVlr_Juros.Text = Convert.ToString(novaMensalidade.ValorJuros);
                txtValorMulta.Text = Convert.ToString(novaMensalidade.ValorMulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os dados" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Mensalidade gravarmensalidade = new Mensalidade();
            MensalidadeNegocios mensalidadeNegocios = new MensalidadeNegocios();
            gravarmensalidade.Cod_Mensalidade = Convert.ToInt32(codMensalidade);
            gravarmensalidade.turma = new Turma();
            gravarmensalidade.turma.Cod_Turma = codTurma;
            gravarmensalidade.aluno = new Aluno();
            gravarmensalidade.aluno.Cod_Aluno = codAluno;
            gravarmensalidade.Num_Mensalidade = Convert.ToString(txtNum_Mensalidade.Text);
            gravarmensalidade.DataVencimento = Convert.ToDateTime(dtpDataVcto.Value);
            gravarmensalidade.Valor = Convert.ToDecimal(txtValor.Text);
            gravarmensalidade.ValorMulta = Convert.ToDecimal(txtValorMulta.Text);
            gravarmensalidade.ValorJuros = Convert.ToDecimal(txtVlr_Juros.Text);

            string retorno = mensalidadeNegocios.Alterar(gravarmensalidade);
            try
            {
                Convert.ToInt32(retorno);
                MessageBox.Show("Dados alterados com sucesso ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Yes;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Noa foi possível inserir os dados" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtValorMulta_Leave(object sender, EventArgs e)
        {
            try
            {
                txtValorMulta.Text = Convert.ToDecimal(txtValorMulta.Text).ToString("F");
            }
            catch
            {
                MessageBox.Show("Favor digite um valor decimal no formato 0,00");
                txtValorMulta.Focus();
            }

        }

        private void txtVlr_Juros_Leave(object sender, EventArgs e)
        {
            try
            {
                txtVlr_Juros.Text = Convert.ToDecimal(txtVlr_Juros.Text).ToString("F");
            }
            catch
            {
                MessageBox.Show("Favor digite um valor decimal no formato 0,00");
                txtVlr_Juros.Focus();
            }
        }
    }
}
