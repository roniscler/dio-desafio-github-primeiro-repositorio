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
    public partial class FrmRespLegal : Form
    {
        bool editar = false;
        string acaoVinda;

        public FrmRespLegal(string acao)
        {
            InitializeComponent();
            acaoVinda = acao;
        }

        private void SalvaAlteraRespLegal()
        {
            RespLegal respLegal = new RespLegal();
            respLegal.NomeRep_Legal = txtNomeRep_Legal.Text;
            respLegal.Data_Nascto = dtpData_Nascto.Value;
            respLegal.Cod_Est_Civil = Convert.ToInt32(cmbEst_Civil.SelectedValue);
            respLegal.End_Rua = txtEnd_Rua.Text;
            respLegal.End_Nr = txtEnd_Nr.Text;
            respLegal.End_Comp = txtEnd_Comp.Text;
            respLegal.Cod_Bairro = Convert.ToInt32(cmbBairro.SelectedValue);
            respLegal.End_Cep = mskEnd_Cep.Text;
            respLegal.End_Cidade = txtEnd_Cidade.Text;
            respLegal.UF_Residencia = txtUF_Residencia.Text;
            respLegal.Tel_Residencial = mskTel_Residencial.Text;
            respLegal.Celular = mskCelular.Text;
            respLegal.Telefone_Favor = mskTel_Favor.Text;
            respLegal.End_Referencia = txtEnd_Referencia.Text;
            respLegal.Cart_Ident = txtCart_Ident.Text;
            respLegal.Org_Exped = txtOrg_Expedidor.Text;
            respLegal.CPF = mskCpf.Text;
            respLegal.Nacionalidade = Convert.ToString(txtNacionalidade.Text);
            respLegal.Naturalidade = txtNaturalidade.Text;
            respLegal.UF_Naturalidade = txtUf_Naturalidade.Text;
            respLegal.Cod_Escolaridade = Convert.ToInt32(cmbEscolridade.SelectedValue);
            respLegal.Condicao = txtCondicao.Text;
            respLegal.Profissao = TxtProfissao.Text;

            if (editar == true)
            {
                respLegal.Cod_rep_legal = Convert.ToInt32(txtCod_Rep_Legal.Text);
                Resp_LegalNegocios resp_LegalNegocios = new Resp_LegalNegocios();
                string retorno = resp_LegalNegocios.Alterar(respLegal);

                try
                {
                    int idRespLegal = Convert.ToInt32(retorno);
                    MessageBox.Show("Responsável alterado com sucesso.");
                    
                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados do Responsável pelo aluno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (editar == false)
            {
                
                Resp_LegalNegocios resp_LegalNegocios = new Resp_LegalNegocios();
                string retorno = resp_LegalNegocios.Inserir(respLegal);

                try
                {
                    int idRespLegal = Convert.ToInt32(retorno);
                    MessageBox.Show("Responsável inserido com sucesso. Código: " + idRespLegal);
                    txtCod_Rep_Legal.Text = idRespLegal.ToString();
                    btnInserir.Text = "Salvar";
                    CarregaGrid();

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir o Responsável pelo aluno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimpaControles limpaControles = new LimpaControles();
            limpaControles.ClearControls(this);
                        
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            Resp_LegalNegocios resp_LegalNegocios = new Resp_LegalNegocios();
            RespLegalColecao respLegalColecao = resp_LegalNegocios.ConsultarPorNome(txtPEsquisar.Text);

            dgvRespLegal.DataSource = null;
            dgvRespLegal.DataSource = respLegalColecao;

            dgvRespLegal.Update();
            dgvRespLegal.Refresh();

        }

        private void CarregaCmbBairro()
        {
            BairrosNegocios bairrosNegocios = new BairrosNegocios();
            BairrosColecao bairrosColecao = bairrosNegocios.Consultar("");
            Bairros bairros = new Bairros();
            bairros.Cod_Bairro = 0;
            bairros.Nome_Bairro = "";
            bairrosColecao.Insert(0,bairros);

            this.cmbBairro.DataSource = bairrosColecao;
            this.cmbBairro.ValueMember = "Cod_Bairro";
            this.cmbBairro.DisplayMember = "Nome_Bairro";
            this.cmbBairro.SelectedValue = 0;
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
            this.cmbEst_Civil.SelectedValue = 0;
        }
        
        private void bntNovoRepLegal_Click(object sender, EventArgs e)
        {
            LimpaControles limpaControles = new LimpaControles();
            limpaControles.ClearControls(this);
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
            this.cmbEscolridade.SelectedValue = 0;
            

        }
                
        private void btnInserir_Click(object sender, EventArgs e)
        {
            editar = false;
            if (!validaForm())return;
            SalvaAlteraRespLegal();
            LimpaControles lc = new LimpaControles();
            lc.ClearControls(this);
            CarregaGrid();
            this.DialogResult = DialogResult.Yes;

        }

        private void FrmRespLegal_Load(object sender, EventArgs e)
        {
            dgvRespLegal.AutoGenerateColumns = false;
            CarregaCmbBairro();
            CarregacmbEst_Civil();
            CarregacmbEscolaridade();
            CarregaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvRespLegal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            editar = true;
            
            if (btnAlterar.Text == "Alterar")
            {
                CarregaRepLegal();
                btnInserir.Enabled = false;
                btnExcluirRepLegal.Enabled = false;
                btnNovo.Enabled = false;
                dgvRespLegal.Enabled = false;
                btnAlterar.Text = "Salvar";
            }
            else if (btnAlterar.Text == "Salvar")
            {
                if (!validaForm()) return;
                btnInserir.Enabled = true;
                btnExcluirRepLegal.Enabled = true;
                btnNovo.Enabled = true;
                btnAlterar.Text = "Alterar";
                SalvaAlteraRespLegal();
                dgvRespLegal.Enabled = true;
                CarregaGrid();
            }
        }

        private void dgvRespLegal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int numeroColunaCPF = 17;
            if (e.ColumnIndex == numeroColunaCPF && e.Value != null)
            {
                string cpf = e.Value.ToString();

                cpf = string.Format("{0}.{1}.{2}-{3}",
                                    cpf.Substring(0, 3),
                                    cpf.Substring(3, 3),
                                    cpf.Substring(6, 3),
                                    cpf.Substring(9, 2));
                e.Value = cpf;
                e.FormattingApplied = true;
            }
            int numeroColunaCelular = 12;
            if (e.ColumnIndex == numeroColunaCelular && e.Value != "")
            {
                string celular = e.Value.ToString();

                celular = string.Format("({0}){1}-{2}",
                                    celular.Substring(0, 2),
                                    celular.Substring(3, 4),
                                    celular.Substring(6, 4));
                e.Value = celular;
                e.FormattingApplied = true;
            }


        }

        private void mskCpf_Leave(object sender, EventArgs e)
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

                    Resp_LegalNegocios dupCPF = new Resp_LegalNegocios();
                    bool vercpf = dupCPF.ConsultarPorCPF(mskCpf.Text);
                    if (vercpf == true)
                    {
                        MessageBox.Show("Já existe um Responsável cadastrado com este CPF", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mskCpf.Focus();
                    }

                        
                }
            }
        }
        
        //Metodo que valida o formulario para salvar no banco de dados
        //===================================================================================================
        private bool validaForm()
        {
            
            lblNomeRep_Legal.ForeColor = System.Drawing.SystemColors.ControlText;
            lblEst_Civil.ForeColor = System.Drawing.SystemColors.ControlText;
            lblEnd_Rua.ForeColor = System.Drawing.SystemColors.Control;
            lblEnd_Nr.ForeColor = System.Drawing.SystemColors.Control;
            lblBairro.ForeColor = System.Drawing.SystemColors.Control;
            lblEnd_Cep.ForeColor = System.Drawing.SystemColors.Control;
            lblEnd_Cidade.ForeColor = System.Drawing.SystemColors.Control;
            lblUF_Residencia.ForeColor = System.Drawing.SystemColors.Control;
            lblTel_Residencial.ForeColor = System.Drawing.SystemColors.Control;
            lblCelular.ForeColor = System.Drawing.SystemColors.Control;
            lblTel_Favor.ForeColor = System.Drawing.SystemColors.Control;
            lblNaturalidade.ForeColor = System.Drawing.SystemColors.ControlText;
            lblUf_Naturalidade.ForeColor = System.Drawing.SystemColors.ControlText;
            lblCondicao.ForeColor = System.Drawing.SystemColors.ControlText;
            lblProfissao.ForeColor = System.Drawing.SystemColors.ControlText;

            //===============================================================================================
            if (string.IsNullOrEmpty(txtNomeRep_Legal.Text))
            {
                MessageBox.Show("Nome é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeRep_Legal.Focus();
                lblNomeRep_Legal.ForeColor = System.Drawing.Color.Red;
                return false;
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
            if (cmbBairro.SelectedIndex == 0)
            {
                MessageBox.Show("Bairro é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBairro.Focus();
                lblBairro.ForeColor = System.Drawing.Color.Red;
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
            if (string.IsNullOrEmpty(txtEnd_Cidade.Text))
            {
                MessageBox.Show("Nome da Cidade é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnd_Cidade.Focus();
                lblEnd_Cidade.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtUF_Residencia.Text))
            {
                MessageBox.Show("UF é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUF_Residencia.Focus();
                lblUF_Residencia.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            //if (string.IsNullOrEmpty(mskTel_Residencial.Text))
            //{
            //    MessageBox.Show("Telefone Inválido", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    mskTel_Residencial.Focus();
            //    lblTel_Residencial.ForeColor = System.Drawing.Color.Red;
            //    return false;
            //}
            //else
            //{
            //    string telRes = mskTel_Residencial.Text;

            //    if (telRes.Length != 10)
            //    {
            //        MessageBox.Show("Telefone Inválido", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        mskTel_Residencial.Focus();
            //        lblTel_Residencial.ForeColor = System.Drawing.Color.Red;
            //        return false;
            //    }
            //}
            ////===============================================================================================
            //if (string.IsNullOrEmpty(mskCelular.Text))
            //{
            //    MessageBox.Show("Telefone Inválido", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    mskCelular.Focus();
            //    lblCelular.ForeColor = System.Drawing.Color.Red;
            //    return false;
            //}
            //else
            //{
            //    string cel = mskCelular.Text;

            //    if (cel.Length != 10)
            //    {
            //        MessageBox.Show("Telefone Inválido", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        mskCelular.Focus();
            //        lblCelular.ForeColor = System.Drawing.Color.Red;
            //        return false;
            //    }
            //}
            ////===============================================================================================
            //if (string.IsNullOrEmpty(mskTel_Favor.Text))
            //{
            //    MessageBox.Show("Telefone Inválido", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    mskTel_Favor.Focus();
            //    lblTel_Favor.ForeColor = System.Drawing.Color.Red;
            //    return false;
            //}
            //else
            //{
            //    string telFav = mskTel_Favor.Text;

            //    if (telFav.Length != 10)
            //    {
            //        MessageBox.Show("Telefone Inválido", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        mskTel_Favor.Focus();
            //        lblTel_Favor.ForeColor = System.Drawing.Color.Red;
            //        return false;
            //    }
            //}
            //===============================================================================================
            if (string.IsNullOrEmpty(txtNaturalidade.Text))
            {
                MessageBox.Show("Naturalidade é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNaturalidade.Focus();
                lblNaturalidade.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtUf_Naturalidade.Text))
            {
                MessageBox.Show("UF da Naturalidade é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUf_Naturalidade.Focus();
                lblUf_Naturalidade.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtCondicao.Text))
            {
                MessageBox.Show("Condição é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCondicao.Focus();
                lblCondicao.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(TxtProfissao.Text))
            {
                MessageBox.Show("Profissão é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtProfissao.Focus();
                lblProfissao.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            
                return true;
           
            
        }                        

        // Metodo que carrega o Representate legal do aluno para edição
        //================================================================================================
        private void CarregaRepLegal()
        {
            txtCod_Rep_Legal.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[0].Value);
            txtNomeRep_Legal.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[1].Value);
            dtpData_Nascto.Value = Convert.ToDateTime(dgvRespLegal.CurrentRow.Cells[2].Value);
            cmbEst_Civil.SelectedValue = Convert.ToInt32(dgvRespLegal.CurrentRow.Cells[3].Value);
            txtEnd_Rua.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[4].Value);
            txtEnd_Nr.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[5].Value);
            txtEnd_Comp.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[6].Value);
            cmbBairro.SelectedValue = Convert.ToInt32(dgvRespLegal.CurrentRow.Cells[7].Value);
            mskEnd_Cep.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[8].Value);
            txtEnd_Cidade.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[9].Value);
            txtUF_Residencia.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[10].Value);
            txtEnd_Referencia.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[14].Value);
            mskTel_Residencial.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[11].Value);
            mskCelular.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[12].Value);
            mskTel_Favor.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[13].Value);
            mskCpf.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[17].Value);
            txtCart_Ident.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[15].Value);
            txtOrg_Expedidor.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[16].Value);
            txtNaturalidade.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[18].Value);
            txtUf_Naturalidade.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[19].Value);
            cmbEscolridade.SelectedValue = Convert.ToInt32(dgvRespLegal.CurrentRow.Cells[20].Value);
            txtCondicao.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[21].Value);
            TxtProfissao.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[22].Value);
            txtNacionalidade.Text = Convert.ToString(dgvRespLegal.CurrentRow.Cells[23].Value);
        }

        private void btnExcluirRepLegal_Click(object sender, EventArgs e)
        {

            if (dgvRespLegal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Tem certeza que deseja excluir o Representante Legal da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            
            RespLegal respLegal = (dgvRespLegal.SelectedRows[0].DataBoundItem as RespLegal);
            Resp_LegalNegocios resp_LegalNegocios = new Resp_LegalNegocios();
            string retorno = resp_LegalNegocios.Excluir(respLegal);

            try
            {
                int codResp = Convert.ToInt32(retorno);
                txtPEsquisar.Focus();
                CarregaGrid();
                
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o Representante Legal." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        private string ConverteMaiscula(string saida)
        {
            saida = saida.ToUpper();

            return saida;
        }

        private void txtOrg_Expedidor_MouseLeave(object sender, EventArgs e)
        {
            txtOrg_Expedidor.Text = ConverteMaiscula(txtOrg_Expedidor.Text);
        }

        private void FrmRespLegal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

    }

}
