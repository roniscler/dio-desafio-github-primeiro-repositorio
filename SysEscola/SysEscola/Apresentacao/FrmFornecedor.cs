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
    public partial class FrmFornecedor : Form
    {
        bool editar = false;
        int codFornecedor;

        public FrmFornecedor()
        {
            InitializeComponent();

            dgvFornecedor.AutoGenerateColumns = false;
        }

        private void CarregaGrid()
        {
            FornecedorNegocios fornecedorNegocios = new FornecedorNegocios();
            FornecedorColecao fornecedorColecao = fornecedorNegocios.Consultar(txtNomeFornecdor.Text);

            dgvFornecedor.DataSource = null;
            dgvFornecedor.DataSource = fornecedorColecao;
            
            dgvFornecedor.Update();
            dgvFornecedor.Refresh();

        }

        private void SalvaAlteraRespLegal()
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.Nome_Fornec = txtNomeFornecdor.Text;
            fornecedor.End_Rua = txtEnd_Rua.Text;
            fornecedor.End_Nr = txtEnd_Nr.Text;
            fornecedor.End_Comp = txtEnd_Comp.Text;
            fornecedor.End_Bairro = txtEnd_Bairro.Text;
            fornecedor.End_Cidade = txtEnd_Cidade.Text;
            fornecedor.End_UF = txtUF.Text;
            fornecedor.End_Cep = mskEnd_Cep.Text;
            fornecedor.Telefone = mskTelefone.Text;
            fornecedor.Telefone2 = mskTelefone2.Text;
            fornecedor.Contato = txtContato.Text;
            fornecedor.CNPJ = mskCNPJ.Text;
            fornecedor.Insc_Est = mskInsc_Est.Text;
            fornecedor.Insc_Mun = txtInsc_Mun.Text;

            if (editar == true)
            {
                fornecedor.Cod_Fornecedor = Convert.ToInt32(codFornecedor);
                FornecedorNegocios fornecedorNegocios = new FornecedorNegocios();
                string retorno = fornecedorNegocios.Alterar(fornecedor);

                try
                {
                    int idRespLegal = Convert.ToInt32(retorno);
                    MessageBox.Show("Fornecedor alterado com sucesso.");

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados do Fornecedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (editar == false)
            {

                FornecedorNegocios fornecedorNegocios = new FornecedorNegocios();
                string retorno = fornecedorNegocios.Inserir(fornecedor);

                try
                {
                    int idFornecedor = Convert.ToInt32(retorno);
                    MessageBox.Show("Fornecedor inserido com sucesso. Código: " + idFornecedor);
                    codFornecedor = Convert.ToInt32(idFornecedor);
                    btnInserir.Text = "Salvar";
                    CarregaGrid();

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir o Fornecedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimpaControles limpaControles = new LimpaControles();
            limpaControles.ClearControls(this);

        }

        private void CarregaFornecedor()
        {
            codFornecedor = Convert.ToInt32(dgvFornecedor.CurrentRow.Cells[0].Value);
            txtNomeFornecdor.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[1].Value);
            txtEnd_Rua.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[2].Value);
            txtEnd_Nr.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[3].Value);
            txtEnd_Comp.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[4].Value);
            txtEnd_Bairro.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[5].Value);
            txtEnd_Cidade.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[6].Value);
            txtUF.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[7].Value);
            mskEnd_Cep.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[8].Value);
            mskTelefone.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[9].Value);
            mskTelefone2.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[10].Value);
            txtContato.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[11].Value);
            mskCNPJ.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[12].Value);
            mskInsc_Est.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[13].Value);
            txtInsc_Mun.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[14].Value);

        }

        private void geraMascaraCpfCnpj()
        {
            if (mskCNPJ.TextLength == 11)
            {
                
                bool ValCPF = Validacao.VerifyCpf(mskCNPJ.Text);
                if (ValCPF)
                {
                    mskCNPJ.Mask = "000,000,000-00";
                }
                else
                {
                    MessageBox.Show("CPF Inválido", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskCNPJ.Focus();
                    mskCNPJ.Select(mskCNPJ.Text.Length, 0);
                }

            }
            else if (mskCNPJ.TextLength == 14)
            {
                bool ValCNPJ = Validacao.IsCnpj(mskCNPJ.Text);
                if (ValCNPJ)
                {
                    mskCNPJ.Mask = "00,000,000/0000-00";
                }
                else
                {
                    MessageBox.Show("CNPJ Inválido", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskCNPJ.Focus();
                    mskCNPJ.Select(mskCNPJ.Text.Length, 0);
                }

            }
            else
            {
                MessageBox.Show("O número digitado não parece ser um CPF ou CNPJ verifique.", "Erro de digitação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCNPJ.Focus();
            }

        }

        private bool validaForm()
        {

            lblNomeFornecedor.ForeColor = System.Drawing.SystemColors.ControlText;
            lblEnd_Rua.ForeColor = System.Drawing.SystemColors.ControlText;
            lblEnd_Nr.ForeColor = System.Drawing.SystemColors.ControlText;
            lblEnd_Bairro.ForeColor = System.Drawing.SystemColors.ControlText;
            lblEnd_Cidade.ForeColor = System.Drawing.SystemColors.ControlText;
            lblUF.ForeColor = System.Drawing.SystemColors.ControlText;
            lblEnd_Cep.ForeColor = System.Drawing.SystemColors.ControlText;
            lblCNPJ.ForeColor = System.Drawing.SystemColors.ControlText;
            lblContato.ForeColor = System.Drawing.SystemColors.ControlText;
            //===============================================================================================
            if (string.IsNullOrEmpty(txtNomeFornecdor.Text))
            {
                MessageBox.Show("Nome do Fornecedor é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeFornecdor.Focus();
                lblNomeFornecedor.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtEnd_Rua.Text))
            {
                MessageBox.Show("Nome da Rua é obrigátório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnd_Rua.Focus();
                lblEnd_Rua.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtEnd_Nr.Text))
            {
                MessageBox.Show("Número é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnd_Nr.Focus();
                lblEnd_Nr.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtEnd_Bairro.Text))
            {
                MessageBox.Show("Bairro é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnd_Bairro.Focus();
                lblEnd_Bairro.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtEnd_Cidade.Text))
            {
                MessageBox.Show("Cidade é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnd_Cidade.Focus();
                lblEnd_Cidade.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtUF.Text))
            {
                MessageBox.Show("UF é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUF.Focus();
                lblUF.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(mskEnd_Cep.Text))
            {
                MessageBox.Show("CEP Inválido", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskEnd_Cep.Focus();
                lblEnd_Cep.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            else
            {
                string cep = mskEnd_Cep.Text;

                if (cep.Length != 8)
                {
                    MessageBox.Show("CEP Inválido", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskEnd_Cep.Focus();
                    lblEnd_Cep.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtContato.Text))
            {
                MessageBox.Show("Contato é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContato.Focus();
                lblContato.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(mskCNPJ.Text))
            {
                MessageBox.Show("CPF / CNPJ é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCNPJ.Focus();
                lblCNPJ.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            return true;


        }
    
        private void btnFechar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            editar = false;
            if (!validaForm()) return;
            SalvaAlteraRespLegal();
            LimpaControles lc = new LimpaControles();
            lc.ClearControls(this);
            CarregaGrid();

        }

        private void dgvFornecedor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Formata o campo de CNPJ do fornededor no datagrid
            //========================================================================================
            int numeroColunaCNPJ = 12;
            if (e.ColumnIndex == numeroColunaCNPJ && e.Value != null)
            {
                string cnpj = e.Value.ToString();
                if (cnpj.Length == 14)
                {
                    cnpj = string.Format("{0}.{1}.{2}/{3}-{4}",
                                        cnpj.Substring(0, 2),
                                        cnpj.Substring(2, 3),
                                        cnpj.Substring(5, 3),
                                        cnpj.Substring(8, 4),
                                        cnpj.Substring(11, 2));
                    e.Value = cnpj;
                    e.FormattingApplied = true;
                }
                else if (cnpj.Length == 11)
                {
                    cnpj = string.Format("{0}.{1}.{2}-{3}",
                    cnpj.Substring(0, 3),
                    cnpj.Substring(3, 3),
                    cnpj.Substring(6, 3),
                    cnpj.Substring(9, 1));
                    e.Value = cnpj;
                    e.FormattingApplied = true;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Fornecedor selecionado.");
                return;
            }

            editar = true;

            if (btnAlterar.Text == "Alterar")
            {
                CarregaFornecedor();
                btnInserir.Enabled = false;
                btnConsultar.Enabled = false;
                btnExcluir.Enabled = false;
                dgvFornecedor.Enabled = false;
                btnAlterar.Text = "Salvar";
            }
            else if (btnAlterar.Text == "Salvar")
            {
                if (!validaForm()) return;
                btnInserir.Enabled = true;
                btnConsultar.Enabled = true;
                btnExcluir.Enabled = true;
                btnAlterar.Text = "Alterar";
                SalvaAlteraRespLegal();
                dgvFornecedor.Enabled = true;
                CarregaGrid();
            }

        }

        private void mskCNPJ_Leave(object sender, EventArgs e)
        {
            geraMascaraCpfCnpj();
        }

        private void mskCNPJ_Enter(object sender, EventArgs e)
        {
            mskCNPJ.Mask = "";
        }

        private void mskCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Fornecedor selecionado.");
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir o Fornecedor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Fornecedor fornecedorSelecionado = (dgvFornecedor.SelectedRows[0].DataBoundItem as Fornecedor);
            FornecedorNegocios fornecedorNegocios = new FornecedorNegocios();
            string retorno = fornecedorNegocios.Excluir(fornecedorSelecionado);
            try
            {
                int codFornecedor = Convert.ToInt32(retorno);
                MessageBox.Show("Fornecedor excluido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o Fornecedor." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void FrmFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

    }
}
