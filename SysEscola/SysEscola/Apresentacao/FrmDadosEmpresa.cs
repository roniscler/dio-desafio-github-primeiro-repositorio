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
    public partial class FrmDadosEmpresa : Form
    {
        public FrmDadosEmpresa()
        {
            InitializeComponent();
        }

        private void FrmDadosEmpresa_Load(object sender, EventArgs e)
        {

            consultarEmpresa();


        }
        
        private void inserirEmpresa()
        {
            DadosEmpresa dadosEmpresa = new DadosEmpresa();

            dadosEmpresa.Nome_Empresa = txtNome_Empresa.Text;
            dadosEmpresa.Nome_Fantasia = txtNome_Fantasia.Text;
            dadosEmpresa.CNPJ = mskCNPJ.Text;
            dadosEmpresa.Insc_Estadual = mskInsc_Estadual.Text;
            dadosEmpresa.Insc_Municipal = mskInsc_Municipal.Text;
            dadosEmpresa.Emp_Telefone = mskEmp_Telefone.Text;
            dadosEmpresa.End_Rua = txtEnd_Rua.Text;
            dadosEmpresa.End_Nr = Txt_End_Nr.Text;
            dadosEmpresa.End_Comp = txtEnd_Comp.Text;
            dadosEmpresa.Bairro = txtEnd_Bairro.Text;
            dadosEmpresa.End_Cidade = txtEnd_Cidade.Text;
            dadosEmpresa.Emp_UF = txt_Emp_UF.Text;
            dadosEmpresa.End_Cep = mskEnd_Cep.Text;
            dadosEmpresa.Nome_Diretora = txtNome_Diretora.Text;
            dadosEmpresa.Nome_Pedagoda = txtNome_Pedagoga.Text;
            if (!string.IsNullOrEmpty(mskTaxa_Multa_Dia.Text)) dadosEmpresa.Taxa_Multa = Convert.ToDecimal(mskTaxa_Multa_Dia.Text);
            if (!string.IsNullOrEmpty(mskTaxa_Juros.Text)) dadosEmpresa.Taxa_Juros = Convert.ToDecimal(mskTaxa_Juros.Text);
            if (!string.IsNullOrEmpty(mskTaxa_Juros.Text)) dadosEmpresa.Lim_Dias_Multa = Convert.ToInt16(txtLim_Dia_Multa.Text);

            Dados_EmpresaNegocios dadosEmpresaNegocio = new Dados_EmpresaNegocios();
            string retorno = dadosEmpresaNegocio.Inserir(dadosEmpresa);

            try
            {
                int idEmp = Convert.ToInt32(retorno);
                MessageBox.Show("Dados da empresa inseridos com sucesso. Código: " + idEmp);
                txtCod_Empresa.Text = Convert.ToString(idEmp);
                btnInserir.Enabled = false;
                btnAlterar.Enabled = true;


            }
            catch
            {
                MessageBox.Show("Não Foi possivel inserir os dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         
        }

        private void consultarEmpresa()
        {
            Dados_EmpresaNegocios dados_EmpresaNegocios = new Dados_EmpresaNegocios();

            DataTable dtDadosEmpresa = new DataTable();

            try
            {

            dtDadosEmpresa = dados_EmpresaNegocios.Consultar();

            }
            catch
            {
                MessageBox.Show("Não Foi possivel carregar os dados da Empresa. Cadastre uma nova empresa no sistema","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (dtDadosEmpresa.Rows.Count == 1)
            {
                btnInserir.Enabled = false;

                DadosEmpresa dadosEmpresa = new DadosEmpresa();

                txtCod_Empresa.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Cod_Empresa"]);
                txtNome_Empresa.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Nome_Empresa"]);
                txtNome_Fantasia.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Nome_Fantasia"]);
                mskCNPJ.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["CNPJ"]);
                txtEnd_Rua.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Emp_End_Rua"]);
                Txt_End_Nr.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Emp_End_Nr"]);
                txtEnd_Comp.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Emp_End_Comp"]);
                txtEnd_Bairro.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Emp_End_Bairro"]);
                txtEnd_Cidade.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Emp_End_Cidade"]);
                mskEnd_Cep.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Emp_End_Cep"]);
                txt_Emp_UF.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Emp_UF"]);
                mskInsc_Estadual.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Insc_Estadual"]);
                mskEmp_Telefone.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Emp_Telefone"]);
                txtNome_Diretora.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Nome_Diretora"]);
                txtNome_Pedagoga.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Nome_Pedagoga"]);
                mskTaxa_Multa_Dia.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Taxa_Multa_Dia"]);
                mskTaxa_Juros.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Taxa_Juros"]);
                txtLim_Dia_Multa.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Lim_Dias_Multa"]);
                mskInsc_Municipal.Text = Convert.ToString(dtDadosEmpresa.Rows[0]["Insc_Municipal"]);

            }
            else
            {
                btnAlterar.Enabled = false;
            }
            
        }

        private void alterarEmpresa()
        {
            DadosEmpresa dadosEmpresa = new DadosEmpresa();

            dadosEmpresa.Cod_Empresa = Convert.ToInt32(txtCod_Empresa.Text);
            dadosEmpresa.Nome_Empresa = txtNome_Empresa.Text;
            dadosEmpresa.Nome_Fantasia = txtNome_Fantasia.Text;
            dadosEmpresa.CNPJ = mskCNPJ.Text;
            dadosEmpresa.Insc_Estadual = mskInsc_Estadual.Text;
            dadosEmpresa.Insc_Municipal = mskInsc_Municipal.Text;
            dadosEmpresa.Emp_Telefone = mskEmp_Telefone.Text;
            dadosEmpresa.End_Rua = txtEnd_Rua.Text;
            dadosEmpresa.End_Nr = Txt_End_Nr.Text;
            dadosEmpresa.End_Comp = txtEnd_Comp.Text;
            dadosEmpresa.Bairro = txtEnd_Bairro.Text;
            dadosEmpresa.End_Cidade = txtEnd_Cidade.Text;
            dadosEmpresa.Emp_UF = txt_Emp_UF.Text;
            dadosEmpresa.End_Cep = mskEnd_Cep.Text;
            dadosEmpresa.Nome_Diretora = txtNome_Diretora.Text;
            dadosEmpresa.Nome_Pedagoda = txtNome_Pedagoga.Text;
            if (!string.IsNullOrEmpty(mskTaxa_Multa_Dia.Text)) dadosEmpresa.Taxa_Multa = Convert.ToDecimal(mskTaxa_Multa_Dia.Text);
            if (!string.IsNullOrEmpty(mskTaxa_Juros.Text)) dadosEmpresa.Taxa_Juros = Convert.ToDecimal(mskTaxa_Juros.Text);
            if (!string.IsNullOrEmpty(mskTaxa_Juros.Text)) dadosEmpresa.Lim_Dias_Multa = Convert.ToInt16(txtLim_Dia_Multa.Text);

            Dados_EmpresaNegocios dadosEmpresaNegocio = new Dados_EmpresaNegocios();
            string retorno = dadosEmpresaNegocio.Alterar(dadosEmpresa);
            

            try
            {

                int idEmp = Convert.ToInt32(retorno);
                MessageBox.Show("Dados da empresa alterados com sucesso");
                consultarEmpresa();

            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (!ValidaForm()) return;
            inserirEmpresa();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        
            this.Close();
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir os dados da empresa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            DadosEmpresa dadosEmpresa = new DadosEmpresa();

            if (string.IsNullOrEmpty(txtCod_Empresa.Text))
            {
                MessageBox.Show("Empresa não cadastrada", "Verfique esta situação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dadosEmpresa.Cod_Empresa = Convert.ToInt32(txtCod_Empresa.Text);
            Dados_EmpresaNegocios EmpNegocio = new Dados_EmpresaNegocios();
            string retorno = EmpNegocio.Excluir(dadosEmpresa);

            try
            {
                int codEmpresa = Convert.ToInt32(retorno);
                MessageBox.Show("Dados excluídos com sucesso!");
                LimpaControles limpaControles = new LimpaControles();
                limpaControles.ClearControls(this);
                btnAlterar.Enabled = false;
                btnInserir.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir os dados da empresa." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!ValidaForm()) return;
            alterarEmpresa();
        }
        
        private void mskTaxa_Multa_Dia_Leave(object sender, EventArgs e)
        {
            try
            {
                mskTaxa_Multa_Dia.Text = Convert.ToDecimal(mskTaxa_Multa_Dia.Text).ToString("F");
            }
            catch
            {
                MessageBox.Show("Favor digite um valor decimal no formato 0,00");
                mskTaxa_Multa_Dia.Focus();
            }
        }

        private void mskTaxa_Juros_Leave(object sender, EventArgs e)
        {
            try
            {
                mskTaxa_Juros.Text = Convert.ToDecimal(mskTaxa_Juros.Text).ToString("F");
            }
            catch
            {
                MessageBox.Show("Favor digite um valor decimal no formato 0,00");
                mskTaxa_Juros.Focus();
            }
        }

        private void mskCNPJ_Leave(object sender, EventArgs e)
        {
            string valor = mskCNPJ.Text;

            if (!Validacao.IsCnpj(valor))
            {
                MessageBox.Show("CNPJ inválido!","ERRO", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                mskCNPJ.Focus();
            }
        }

        private bool ValidaForm()
        {
            lblNome_Empresa.ForeColor = System.Drawing.SystemColors.ControlText;
            lblEnd_Rua.ForeColor = System.Drawing.SystemColors.Control;
            lblCNPJ.ForeColor = System.Drawing.SystemColors.Control;
            lblEnd_Nr.ForeColor = System.Drawing.SystemColors.Control;
            lblEnd_Bairro.ForeColor = System.Drawing.SystemColors.Control;
            lblEnd_Cidade.ForeColor = System.Drawing.SystemColors.Control;
            lblEnd_UF.ForeColor = System.Drawing.SystemColors.Control;
            lblEnd_CEP.ForeColor = System.Drawing.SystemColors.Control;
            lblNome_Diretora.ForeColor = System.Drawing.SystemColors.Control;
            lblNome_Pedagoga.ForeColor = System.Drawing.SystemColors.Control;
            lblTxMultaDia.ForeColor = System.Drawing.SystemColors.Control;
            lblTaxa_Juros.ForeColor = System.Drawing.SystemColors.Control;
            lblLim_Dia_Multa.ForeColor = System.Drawing.SystemColors.Control;

            if (string.IsNullOrEmpty(txtNome_Empresa.Text))
            {
                MessageBox.Show("Nome da empresa é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome_Empresa.Focus();
                lblNome_Empresa.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(txtEnd_Rua.Text))
            {
                MessageBox.Show("Nome da Rua é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnd_Rua.Focus();
                lblEnd_Rua.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(mskCNPJ.Text))
            {
                MessageBox.Show("CNPJ é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCNPJ.Focus();
                lblCNPJ.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(Txt_End_Nr.Text))
            {
                MessageBox.Show("Número é obrigatório. Caso Não haja número dogite: s/n", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_End_Nr.Focus();
                lblEnd_Nr.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(txtEnd_Bairro.Text))
            {
                MessageBox.Show("Nome do bairro é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnd_Bairro.Focus();
                lblEnd_Bairro.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(txtEnd_Cidade.Text))
            {
                MessageBox.Show("Nome da cidade é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnd_Cidade.Focus();
                lblEnd_Cidade.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(txt_Emp_UF.Text))
            {
                MessageBox.Show("UF é obrigatória", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Emp_UF.Focus();
                lblEnd_UF.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(mskEnd_Cep.Text))
            {
                MessageBox.Show("CEP é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskEnd_Cep.Focus();
                lblEnd_CEP.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(txtNome_Diretora.Text))
            {
                MessageBox.Show("Nome da Diretora é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome_Diretora.Focus();
                lblNome_Diretora.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(txtNome_Pedagoga.Text))
            {
                MessageBox.Show("Nome da Pedagoga é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome_Pedagoga.Focus();
                lblNome_Pedagoga.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(mskTaxa_Multa_Dia.Text))
            {
                MessageBox.Show("Taxa Multa é obrigatória", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTaxa_Multa_Dia.Focus();
                lblTxMultaDia.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(mskTaxa_Juros.Text))
            {
                MessageBox.Show("Taxa de juros é obrigatória", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTaxa_Juros.Focus();
                lblTaxa_Juros.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(txtLim_Dia_Multa.Text))
            {
                MessageBox.Show("Taxa Multa é obrigatória", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLim_Dia_Multa.Focus();
                lblLim_Dia_Multa.ForeColor = System.Drawing.Color.Red;
                return false;
            }


            return true;
        }

        private void FrmDadosEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

                        
    }

    
}
