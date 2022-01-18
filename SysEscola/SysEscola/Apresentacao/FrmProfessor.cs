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

using System.IO;

namespace Apresentacao
{
    public partial class FrmProfessor : Form
    {
        int codEscolaridade, codEstadoCivil, codProfessor;
        Professor transProfessor = new Professor();
        
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmProfessor(AcaoNaTela acaoNaTela, Professor professor)
        {
            InitializeComponent();
            transProfessor = professor;
            acaoNaTelaSelecionada = acaoNaTela;
            if (acaoNaTelaSelecionada != AcaoNaTela.Inserir)
            {
                codProfessor = Convert.ToInt32(professor.Cod_Professor);   
            }
                        
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Professor";
                CarregacmbEst_Civil();
                CarregacmbEscolaridade();

            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar dados do Professor";

                CarregaProfessor();
                DesabilitaControles desabilitaControles = new DesabilitaControles();
                desabilitaControles.ClearControls(this);
                CarregaFoto();
                btnSalvar.Visible = false;
                btnCancelar.Visible = false;
            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar dados do Professor";
                btnSalvar.Text = "Alterar";
                btnInserir_Foto.Text = "Alterar Foto";
                CarregaProfessor();
                CarregaFoto();
            }

        }

        private void CarregacmbEst_Civil()
        {
            Est_CivilNegocios est_CivilNegocios = new Est_CivilNegocios();
            EstadoCivilColecao Est_CivilColecao = est_CivilNegocios.Consultar();
            EstadoCivil estadoCivil = new EstadoCivil();
            estadoCivil.Cod_EstadoCivil = 0;
            estadoCivil.Desc_EstadoCivil = "";
            Est_CivilColecao.Insert(0, estadoCivil);

            this.cmbEst_Civil.DataSource = Est_CivilColecao;
            this.cmbEst_Civil.ValueMember = "Cod_EstadoCivil";
            this.cmbEst_Civil.DisplayMember = "Desc_EstadoCivil";
            this.cmbEst_Civil.SelectedValue = codEstadoCivil;
        }

        private void CarregacmbEscolaridade()
        {
            EscolaridadeNegocios escolaridadeNegocios = new EscolaridadeNegocios();
            EscolaridadeColecao escolaridadeColecao = escolaridadeNegocios.Consultar();
            Escolaridade escolaridade = new Escolaridade();
            escolaridade.Cod_Escolaride = 0;
            escolaridade.Descricao = "";
            escolaridadeColecao.Insert(0, escolaridade);

            this.cmbEscolridade.DataSource = escolaridadeColecao;
            this.cmbEscolridade.ValueMember = "Cod_Escolaride";
            this.cmbEscolridade.DisplayMember = "Descricao";
            this.cmbEscolridade.SelectedValue = codEscolaridade;


        }

        private void CarregaProfessor()
        {
            txtLocal_Foto.Text = Convert.ToString(transProfessor.basePessoa.Local_Foto);
            txtNomeProfessor.Text = transProfessor.Nome_Professor;
            dtpDataNascto.Value = Convert.ToDateTime(transProfessor.basePessoa.Data_Nascto);
            txtEndRua.Text = transProfessor.basePessoa.End_Rua;
            TxtEndNumero.Text = transProfessor.basePessoa.End_Nr;
            txtEndComplemento.Text = transProfessor.basePessoa.End_Comp;
            txtEndBairro.Text = transProfessor.End_Bairro;
            txtEndCidade.Text = transProfessor.basePessoa.End_Cidade;
            txtEndUF.Text = transProfessor.basePessoa.UF_Residencia;
            mskEndCep.Text = transProfessor.basePessoa.End_Cep;
            mskTelefone.Text = transProfessor.Tel_Residencial;
            txtEndReferencia.Text = transProfessor.basePessoa.End_Referencia;
            txtIdentidade.Text = transProfessor.Cart_Identidade;
            txtOrgaoExp.Text = transProfessor.Orgao_Expedidor;
            mskCpf.Text = transProfessor.CPF;
            codEstadoCivil = transProfessor.Cod_Est_Civil;
            codEscolaridade = transProfessor.Cod_Escolaridade;
            txtNaturalidade.Text = transProfessor.basePessoa.Naturalidade;
            txtUFNaturalidade.Text = transProfessor.basePessoa.UF_Naturalidade;
            mskTel_Celular.Text = transProfessor.Tel_Celular;
            mskTel_Favor.Text = transProfessor.Tel_Favor;
            dtpData_Cadastro.Value = Convert.ToDateTime(transProfessor.Data_Cadastro);

            
        }

        private void SalvarAlterarProfessor()
        {
            Professor professor = new Professor();
            professor.basePessoa = new BasePessoa();

            professor.Cod_Professor = Convert.ToInt32(codProfessor);
            professor.basePessoa.Local_Foto = txtLocal_Foto.Text;
            professor.Nome_Professor = txtNomeProfessor.Text;
            professor.basePessoa.Data_Nascto = Convert.ToDateTime(dtpDataNascto.Value);
            professor.basePessoa.End_Rua = txtEndRua.Text;
            professor.basePessoa.End_Nr = TxtEndNumero.Text;
            professor.basePessoa.End_Comp = txtEndComplemento.Text;
            professor.End_Bairro = txtEndBairro.Text;
            professor.basePessoa.End_Cidade = txtEndCidade.Text;
            professor.basePessoa.UF_Residencia = txtEndUF.Text;
            professor.basePessoa.End_Cep = mskEndCep.Text;
            professor.Tel_Residencial = mskTelefone.Text;
            professor.basePessoa.End_Referencia = txtEndReferencia.Text;
            professor.Cart_Identidade = txtIdentidade.Text;
            professor.Orgao_Expedidor = txtOrgaoExp.Text;
            professor.CPF = mskCpf.Text;
            professor.Cod_Est_Civil = Convert.ToInt32(cmbEst_Civil.SelectedValue);
            professor.Cod_Escolaridade = Convert.ToInt32(cmbEscolridade.SelectedValue);
            professor.basePessoa.Naturalidade = txtNaturalidade.Text;
            professor.basePessoa.UF_Naturalidade = txtUFNaturalidade.Text;
            professor.Tel_Celular = mskTel_Celular.Text;
            professor.Tel_Favor = mskTel_Favor.Text;
            professor.Data_Cadastro = Convert.ToDateTime(dtpData_Cadastro.Value);

            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                ProfessorNegocios professorNegocios = new ProfessorNegocios();
                string retorno = professorNegocios.Inserir(professor);

                try
                {
                    int idProfessor = Convert.ToInt32(retorno);
                    MessageBox.Show("Professor inserido com sucesso. Código: " + idProfessor);
                    btnSalvar.Enabled = false;
                    this.DialogResult = DialogResult.Yes;

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir o professor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                professor.Cod_Professor = codProfessor;
                ProfessorNegocios professorNegocios = new ProfessorNegocios();
                string retorno = professorNegocios.Alterar(professor);

                try
                {
                    int idProfessor = Convert.ToInt32(retorno);
                    MessageBox.Show("Professor alterado com sucesso.");
                    this.DialogResult = DialogResult.Yes;

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados do professor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void CarregaFoto()
        {
            try
            {
                if (txtLocal_Foto.Text != "")
                {
                    picFotoProfessor.ImageLocation = txtLocal_Foto.Text;

                    picFotoProfessor.Load();
                }

            }
            catch
            {
                MessageBox.Show("Não foi possivel carregar a foto do professor");
            }
        }

        private string ConverteMaiscula(string saida)
        {
            saida = saida.ToUpper();

            return saida;
        }

        private void btnInserir_Foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfdAbrirFoto = new OpenFileDialog();
            
            if (opfdAbrirFoto.ShowDialog() == DialogResult.OK)
            {
                txtLocal_Foto.Text = opfdAbrirFoto.FileName;

                picFotoProfessor.ImageLocation = opfdAbrirFoto.FileName;
                try
                {
                    picFotoProfessor.Load();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                

            }
        }

        private void btnApagar_Foto_Click(object sender, EventArgs e)
        {
            txtLocal_Foto.Text = "";
            picFotoProfessor.ImageLocation = "";

            picFotoProfessor.Refresh();
        }

        private void FrmProfessor_Load(object sender, EventArgs e)
        {
            CarregacmbEscolaridade();
            CarregacmbEst_Civil();
            int? result = null;
            result = codProfessor;
            if (result != null)
            {
                if (acaoNaTelaSelecionada != AcaoNaTela.Consultar)
                {
                    btnAfastamento.Enabled = true;
                    btnHabilitacaoProfissional.Enabled = true;
                    btnInserir_Foto.Enabled = true;
                }
            }
             
        }

        private void txtOrgaoExp_Leave(object sender, EventArgs e)
        {
            txtOrgaoExp.Text = ConverteMaiscula(txtOrgaoExp.Text);
        }
        
        private void mskcpf_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(mskCpf.Text))
            {
                MessageBox.Show("O campo CPF é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCpf.Focus();
            }

            else
            {
                if (mskCpf.TextLength == 14)
                {
                    bool cpfValido = Validacao.VerifyCpf(mskCpf.Text);
                    if (cpfValido == false)
                    {
                        MessageBox.Show("CPF inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mskCpf.Focus();
                    }

                    ProfessorNegocios dupCPF = new ProfessorNegocios();
                    if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
                    {
                        bool vercpf = dupCPF.ConsultarPorCPF(mskCpf.Text);
                        if (vercpf == true)
                        {
                            MessageBox.Show("Já existe um Professor cadastrado com este CPF", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            mskCpf.Focus();
                        }
                    }


                }
            }
        }

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!validaForm()) return;
            SalvarAlterarProfessor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProfessor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        //Metodo que valida o formulario para salvar no banco de dados
        //===================================================================================================
        private bool validaForm()
        {

            lblNomeProfessor.ForeColor = System.Drawing.SystemColors.ControlText;
            lblDataNascimento.ForeColor = System.Drawing.SystemColors.Control;
            lblEndRua.ForeColor = System.Drawing.SystemColors.Control;
            lblEndNumero.ForeColor = System.Drawing.SystemColors.Control;
            lblEndBairro.ForeColor = System.Drawing.SystemColors.Control;
            lblEndCep.ForeColor = System.Drawing.SystemColors.Control;
            lblEst_Civil.ForeColor = System.Drawing.SystemColors.Control;
            lblEscolaridade.ForeColor = System.Drawing.SystemColors.Control;
            lblEndCidade.ForeColor = System.Drawing.SystemColors.Control;
            lblEndUF.ForeColor = System.Drawing.SystemColors.Control;
            lblNaturalidade.ForeColor = System.Drawing.SystemColors.Control;
            lblUFNaturalidade.ForeColor = System.Drawing.SystemColors.Control;
            
            //===============================================================================================
            if (string.IsNullOrEmpty(txtNomeProfessor.Text))
            {
                MessageBox.Show("Nome do Professor é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeProfessor.Focus();
                lblNomeProfessor.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtEndRua.Text))
            {
                MessageBox.Show("Nome da Rua é obrigátório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndRua.Focus();
                lblEndRua.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(TxtEndNumero.Text))
            {
                MessageBox.Show("Número é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEndNumero.Focus();
                lblEndNumero.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtEndBairro.Text))
            {
                MessageBox.Show("Bairro é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndBairro.Focus();
                lblEndBairro.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(mskEndCep.Text))
            {
                MessageBox.Show("CEP Inválido", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskEndCep.Focus();
                lblEndCep.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            else
            {
                string cep = mskEndCep.Text;

                if (cep.Length != 8)
                {
                    MessageBox.Show("CEP Inválido", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskEndCep.Focus();
                    lblEndCep.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
            }
            //===============================================================================================
            if (cmbEst_Civil.SelectedIndex == 0)
            {
                MessageBox.Show("Estado Civil é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEst_Civil.Focus();
                lblEst_Civil.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (cmbEscolridade.SelectedIndex == 0)
            {
                MessageBox.Show("Escolaridade é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEscolridade.Focus();
                lblEscolaridade.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtEndCidade.Text))
            {
                MessageBox.Show("Nome da Cidade é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndCidade.Focus();
                lblEndCidade.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtEndUF.Text))
            {
                MessageBox.Show("UF é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndUF.Focus();
                lblEndUF.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtNaturalidade.Text))
            {
                MessageBox.Show("Naturalidade é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNaturalidade.Focus();
                lblNaturalidade.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtUFNaturalidade.Text))
            {
                MessageBox.Show("UF da Naturalidade é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUFNaturalidade.Focus();
                lblUFNaturalidade.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            return true;


        }

        private void BtnAfastamento_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(codProfessor);
                FrmProfessorAfastamento frmProfessorAfastamento = new FrmProfessorAfastamento(acaoNaTelaSelecionada, transProfessor);
                frmProfessorAfastamento.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Não Existe professor selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void FrmProfessor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {


                try
                {
                    Convert.ToInt32(codProfessor);
                    FrmProfessorAfastamento frmProfessorAfastamento = new FrmProfessorAfastamento(acaoNaTelaSelecionada, transProfessor);
                    frmProfessorAfastamento.ShowDialog();
                }
                catch (Exception)
                {                    
                    MessageBox.Show("Não Existe professor selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

            if (e.KeyCode == Keys.F6)
            {


                try
                {
                    Convert.ToInt32(codProfessor);
                    FrmProfessorHabillitacaoProfissional frmProfessorHabillitacaoProfissional = new FrmProfessorHabillitacaoProfissional(acaoNaTelaSelecionada, codProfessor);
                    frmProfessorHabillitacaoProfissional.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não Existe professor selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

        }

        private void btnHabilitacaoProfissional_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(codProfessor);
                FrmProfessorHabillitacaoProfissional frmProfessorHabillitacaoProfissional = new FrmProfessorHabillitacaoProfissional(acaoNaTelaSelecionada, codProfessor);
                frmProfessorHabillitacaoProfissional.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Não Existe professor selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }                        
       

    }
}
