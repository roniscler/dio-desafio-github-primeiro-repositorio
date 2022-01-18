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
    public partial class FrmAluno : Form
    //====================================================================================
    //DECLARAÇAO DAS VARIAVEIS DA CLASSE
    {
        int codCorALuno, codBairro, codReligiao, codPlano, codRespLegal, cod_Aluno;
        bool TpSexo, editar;
        Aluno trasnpAluno;
        AcaoNaTela acaoNaTelaSelecionada;

        //====================================================================================
        //REGIAO DA CLASSE DO FORM ALUNO
        public FrmAluno(AcaoNaTela acaoNaTela, Aluno aluno)
        {

            InitializeComponent();
            DgvEloDoenca.AutoGenerateColumns = false;
            dgvConvFamiliar.AutoGenerateColumns = false;
            dgvHabitos.AutoGenerateColumns = false;
            dgvCondicaoSono.AutoGenerateColumns = false;
            dgvHOrarioRegular.AutoGenerateColumns = false;
            dgvFazSo.AutoGenerateColumns = false;
            dgvAfastamento.AutoGenerateColumns = false;
            dgvDadosResponsavel.AutoGenerateColumns = false;


            // ATRIBUI A ACAO PASSADA PELO USUARIO NA LISTA DE ALUNOS E JOGA NA VARIAVEL PARA USA-LA EM TODO O FORM ALUNO
            acaoNaTelaSelecionada = acaoNaTela;
            trasnpAluno = aluno;

            // CONDICOES PARA A ACAO QUE SERÁ REALIZADA DENTRO DO FORM DE ACORDO COM OS PARAMETROS PASSADOS PELO FORM SELECIONAR
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Aluno";
            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar dados do Aluno";

                CarrregaAluno();
                DesabilitaControles desabilitaControles = new DesabilitaControles();
                desabilitaControles.ClearControls(this);

                btnSalvar.Visible = false;
                btnCancelar.Visible = false;

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar dados do Aluno";
                btnSalvar.Text = "Alterar";
                btnInserir_Foto.Text = "Alterar Foto";
                CarrregaAluno();

            }

        }

        //====================================================================================
        //Evento Load do Formulario Aluno que carrega os datagrids da primeira TabPage
        private void FrmAluno_Load(object sender, EventArgs e)
        {
            CarregaCmbSexo();
            CarregaCmbBairro();
            CarregaCmbCorAluno();
            CarregaCmbReligiao();
            CarregaCmbPlano();
            carregaFoto();
            if (txtCod_Aluno.Text != "")
            {
                pnlAfastamento.Enabled = true;
                ListarAfastamento();
            }
            CarregaCmbResp_Legal();

           // btnResp_Legal.Enabled = false;
        }

        //====================================================================================
        //Carrega um aluno para ser transferido para o formulario.

        private void CarrregaAluno()
        {
            txtLocal_Foto.Text = trasnpAluno.Local_Foto;
            txtCod_Aluno.Text = trasnpAluno.Cod_Aluno.ToString();
            txtNome_Aluno.Text = trasnpAluno.Nome_Aluno.ToString();
            TpSexo = trasnpAluno.Sexo;
            DtpDt_Nascto.Value = trasnpAluno.Data_Nascto;
            DtpDt_Cadastro.Value = trasnpAluno.Data_Cadastro;
            txtEnd_Rua.Text = trasnpAluno.End_Rua.ToString();
            txtEnd_Nr.Text = trasnpAluno.End_Nr.ToString();
            txtEnd_Comp.Text = trasnpAluno.End_Comp.ToString();
            codBairro = trasnpAluno.bairros.Cod_Bairro;
            mskEnd_CEP.Text = trasnpAluno.End_Cep.ToString();
            txtEnd_Cidade.Text = trasnpAluno.End_Cidade.ToString();
            txtUF_Residencia.Text = trasnpAluno.UF_Residencia.ToString();
            codCorALuno = trasnpAluno.corAluno.Cod_CorAluno;
            codRespLegal = trasnpAluno.respLegal.Cod_rep_legal;
            codReligiao = trasnpAluno.religiao.Cod_religiao;

            if (trasnpAluno.Ativo_Inativo == true)
            {
                rdbAtivo.Checked = true;
            }
            else
            {
                rdbInativo.Checked = true;
            }

            txtNacionalidade.Text = trasnpAluno.Nacionalidade.ToString();
            txtNaturalidade.Text = trasnpAluno.Naturalidade.ToString();
            txtUF_Naturalidade.Text = trasnpAluno.UF_Naturalidade.ToString();
            txt_Qtde_irmaos.Text = trasnpAluno.Qtde_irmaos.ToString();
            txtIdade_andou.Text = trasnpAluno.Qtde_irmaos.ToString();
            txtIdade_Falou.Text = trasnpAluno.Idade_Falou.ToString();

            if (trasnpAluno.Manif_Alergica == true)
            {
                rdbManifSim.Checked = true;
            }
            else
            {
                rdbManifNao.Checked = true;
            }

            codPlano = trasnpAluno.planos.Cod_Plano;
            DtpDt_Cont_Ini.Value = trasnpAluno.Data_Ini_Contrato;
            DtpDt_Cont_Fim.Value = trasnpAluno.Data_Fim_Contrato;
            txtNome_Pai.Text = trasnpAluno.Nome_Pai.ToString();
            txtNome_Mae.Text = trasnpAluno.Nome_Mae.ToString();
            txtProf_Pai.Text = trasnpAluno.Prof_Pai.ToString();
            txtProf_Mae.Text = trasnpAluno.Prof_Mae.ToString();
        }

        //====================================================================================
        //Preenche a Comobox de Sexo 
        private void CarregaCmbSexo()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Codigo", typeof(bool));
            tb.Columns.Add("Tp_Sexo", typeof(string));

            DataRow novalinha = tb.NewRow();

            novalinha["Codigo"] = false;
            novalinha["Tp_Sexo"] = "Feminino";
            tb.Rows.Add(novalinha);

            novalinha = tb.NewRow();
            novalinha["Codigo"] = true;
            novalinha["Tp_Sexo"] = "Masculino";
            tb.Rows.Add(novalinha);

            this.cmbSexo.DataSource = tb;
            this.cmbSexo.ValueMember = "Codigo";
            this.cmbSexo.DisplayMember = "Tp_Sexo";
            this.cmbSexo.SelectedValue = TpSexo;



        }

        //====================================================================================
        //Metodo que ira carregar a combo CorAluno
        private void CarregaCmbCorAluno()
        {

            //instancia uma coleção de alunos com base na procedure do Banco de Dados
            CorAlunoNegocios corAlunoNegocios = new CorAlunoNegocios();
            CorAlunoColecao corAlunoColecao = corAlunoNegocios.Consultar();
            this.cmbCod_CorAluno.DataSource = corAlunoColecao;
            this.cmbCod_CorAluno.ValueMember = "Cod_CorAluno";
            this.cmbCod_CorAluno.DisplayMember = "Desc_CorAluno";
            this.cmbCod_CorAluno.SelectedValue = codCorALuno;
            
        }

        private void CarregaCmbHabitos()
        {
            //instancia uma coleção de habitos com base na procedure do Banco de Dados
            HabitosNegocios habitosNegocios = new HabitosNegocios();
            HabitoColecao habitosColecao = habitosNegocios.Consultar("");

            Habito habitos = new Habito();
            habitos.Cod_Habito = 0;
            habitos.Desc_Habito = "";
            habitosColecao.Insert(0, habitos);
            this.cmbHabitos.DataSource = habitosColecao;
            this.cmbHabitos.ValueMember = "Cod_Habito";
            this.cmbHabitos.DisplayMember = "Desc_Habito";
            this.cmbHabitos.SelectedIndex = 0;
        }

        private void CarregaCmbFazSo()
        {
            FazSozinhaNegocios fazSozinhaNegocios = new FazSozinhaNegocios();
            FazSozinhaColecao FazSozinhaColecao = fazSozinhaNegocios.Consultar("");

            FazSozinha FazSo = new FazSozinha();
            FazSo.Cod_FazSozinha = 0;
            FazSo.Desc_FazSozinha = "";
            FazSozinhaColecao.Insert(0, FazSo);
            this.cmbFazSo.DataSource = FazSozinhaColecao;
            this.cmbFazSo.ValueMember = "Cod_FazSozinha";
            this.cmbFazSo.DisplayMember = "Desc_FazSozinha";
            this.cmbFazSo.SelectedIndex = 0;
        }
                
        //====================================================================================
        //Evento Click do botao cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //fecha o formulario 
            this.Close();
        }
        //====================================================================================
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaForm()) return;
            salvaAlterarAluno();
        }

        //====================================================================================
        //Metodo que salva ou altera o Aluno
        private void salvaAlterarAluno()
        {
            Aluno novoAluno = new Aluno();


            novoAluno.Local_Foto = txtLocal_Foto.Text;
            novoAluno.Nome_Aluno = txtNome_Aluno.Text;
            novoAluno.Sexo = TpSexo;
            novoAluno.Data_Nascto = DtpDt_Nascto.Value;
            novoAluno.Data_Cadastro = DtpDt_Cadastro.Value;
            novoAluno.End_Rua = txtEnd_Rua.Text;
            novoAluno.End_Nr = txtEnd_Nr.Text;
            novoAluno.End_Comp = txtEnd_Comp.Text;
            novoAluno.bairros = new Bairros();
            novoAluno.bairros.Cod_Bairro = Convert.ToInt32(cmbCod_Bairro.SelectedValue);
            novoAluno.End_Cep = mskEnd_CEP.Text;
            novoAluno.End_Cidade = txtEnd_Cidade.Text;
            novoAluno.UF_Residencia = txtUF_Residencia.Text;
            novoAluno.End_Referencia = TxtEnd_Referencia.Text;
            novoAluno.Nacionalidade = txtNacionalidade.Text;
            novoAluno.Naturalidade = txtNaturalidade.Text;
            novoAluno.UF_Naturalidade = txtUF_Naturalidade.Text;
            novoAluno.religiao = new Religiao();
            novoAluno.religiao.Cod_religiao = Convert.ToInt32(cmb_Cod_Religiao.SelectedValue);

            if (rdbAtivo.Checked == true)
            {
                novoAluno.Ativo_Inativo = true;
            }
            else if (rdbInativo.Checked == true)
            {
                novoAluno.Ativo_Inativo = false;
            }

            novoAluno.Qtde_irmaos = Convert.ToInt16(txt_Qtde_irmaos.Text);
            novoAluno.Qtde_irmaos = Convert.ToInt16(txtIdade_andou.Text);
            novoAluno.Idade_Falou = Convert.ToInt16(txtIdade_Falou.Text);

            if (rdbManifSim.Checked == true)
            {
                novoAluno.Manif_Alergica = true;
            }
            else if (rdbManifNao.Checked == true)
            {
                novoAluno.Manif_Alergica = false;
            }

            novoAluno.planos = new Planos();
            novoAluno.planos.Cod_Plano = Convert.ToInt32(cmbCod_Plano.SelectedValue);
            novoAluno.Data_Ini_Contrato = DtpDt_Cont_Ini.Value;
            novoAluno.Data_Fim_Contrato = DtpDt_Cont_Fim.Value;
            novoAluno.Nome_Pai = txtNome_Pai.Text;
            novoAluno.Nome_Mae = txtNome_Mae.Text;
            novoAluno.Prof_Pai = txtProf_Pai.Text;
            novoAluno.Prof_Mae = txtProf_Mae.Text;
            novoAluno.corAluno = new CorAluno();
            novoAluno.corAluno.Cod_CorAluno = Convert.ToInt32(cmbCod_CorAluno.SelectedValue);
            novoAluno.respLegal = new RespLegal();
            novoAluno.respLegal.Cod_rep_legal = Convert.ToInt32(cmbResplegal.SelectedValue);

            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                AlunoNegocios alunoNegocios = new AlunoNegocios();
                string retorno = alunoNegocios.Inserir(novoAluno);

                try
                {
                    int idAluno = Convert.ToInt32(retorno);
                    MessageBox.Show("Aluno inserido com sucesso. Código: " + idAluno);
                    txtCod_Aluno.Text = idAluno.ToString();
                    TbcPrincipal.SelectedTab = TbpDadosAdicionais;
                    btnSalvar.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir o Aluno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                novoAluno.Cod_Aluno = Convert.ToInt32(txtCod_Aluno.Text);
                AlunoNegocios alunoNegocios = new AlunoNegocios();
                string retorno = alunoNegocios.Alterar(novoAluno);

                try
                {
                    int identAluno = Convert.ToInt32(retorno);
                    MessageBox.Show("Aluno alterado com sucesso.");
                    this.DialogResult = DialogResult.Yes;

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados do Aluno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            //Limpa o Formulario inteiro
            //limpaControles limpa = new limpaControles();
            //limpa.ClearControls(this);

        }
        //====================================================================================
        //Metodo que Preenche a combo Bairro
        private void CarregaCmbBairro()
        {
            BairrosNegocios bairrosNegocios = new BairrosNegocios();
            BairrosColecao bairrosColecao = bairrosNegocios.Consultar("");
            Bairros bairro = new Bairros();
            bairro.Cod_Bairro = 0;
            bairro.Nome_Bairro = "";
            bairrosColecao.Insert(0, bairro);

            this.cmbCod_Bairro.DataSource = bairrosColecao;
            this.cmbCod_Bairro.ValueMember = "Cod_Bairro";
            this.cmbCod_Bairro.DisplayMember = "Nome_Bairro";
            this.cmbCod_Bairro.SelectedValue = codBairro;
        }
        //====================================================================================
        //Metodo que carrega a foto do aluno caso o txtLocal_Foto esteja diferente de nulo
        private void carregaFoto()
        {
            try
            {
                if (txtLocal_Foto.Text != "")
                {
                    picFotoAluno.ImageLocation = txtLocal_Foto.Text;

                    picFotoAluno.Load();
                }

            }
            catch
            {
                MessageBox.Show("Não foi possivel carregar a foto do Aluno");
            }

        }
        //====================================================================================
        //Metodo que Preenche a combo Plano
        private void CarregaCmbPlano()
        {

            //instancia uma coleção de alunos com base na procedure do Banco de Dados
            PlanosNegocios planosNegocios = new PlanosNegocios();
            PlanosColecao planosColecao = planosNegocios.Consultar();

            this.cmbCod_Plano.DataSource = planosColecao;
            this.cmbCod_Plano.ValueMember = "Cod_Plano";
            this.cmbCod_Plano.DisplayMember = "Desc_Plano";
            this.cmbCod_Plano.SelectedValue = codPlano;

        }
        //====================================================================================
        //Metodo que Preenche a combo Religiao
        private void CarregaCmbReligiao()
        {
            ReligiaoNegocios religiaoNegocios = new ReligiaoNegocios();
            ReligiaoColecao religiaoColecao = religiaoNegocios.Consultar("");

            this.cmb_Cod_Religiao.DataSource = religiaoColecao;
            this.cmb_Cod_Religiao.ValueMember = "Cod_Religiao";
            this.cmb_Cod_Religiao.DisplayMember = "Nome_Religiao";
            this.cmb_Cod_Religiao.SelectedValue = codReligiao;

        }

        private void CarregaCmbCondSono()
        {

            CondicoesSonoNegocios condicoeSonoNegocios = new CondicoesSonoNegocios();
            CondicoesSonoColecao condicoesSonoColecao = condicoeSonoNegocios.Consultar("");
            CondicoesSono condicoesSono = new CondicoesSono();
            condicoesSono.Cod_Cond_Sono = 0;
            condicoesSono.Desc_Cond_Sono = "";
            condicoesSonoColecao.Insert(0, condicoesSono);

            this.cmbCondicaoSono.DataSource = condicoesSonoColecao;
            this.cmbCondicaoSono.ValueMember = "Cod_Cond_Sono";
            this.cmbCondicaoSono.DisplayMember = "Desc_Cond_Sono";
            this.cmbCondicaoSono.SelectedValue = 0;

        }

        //====================================================================================
        //Metodo que Preenche a combo Doencas e linka o Datgrid na base de dados
        private void CaregaComoDoenca()
        {

            DoencaNegocio doencaNegocio = new DoencaNegocio();
            DoencaColecao doencaColecao = doencaNegocio.Consultar();
            Doenca doenca = new Doenca();
            doenca.Cod_Doenca = 0;
            doenca.Nome_Doenca = "";
            doencaColecao.Insert(0, doenca);
            this.cmbDoenca.DataSource = doencaColecao;
            this.cmbDoenca.ValueMember = "Cod_Doenca";
            this.cmbDoenca.DisplayMember = "Nome_Doenca";
            this.cmbDoenca.SelectedIndex = 0;

            }

        private void carregaCmbConvFam()
        {
            Conv_FamiliarNegocio convfam = new Conv_FamiliarNegocio();
            ConvivenciaFamiliarColecao convivenciaFamiliarColecao = convfam.Consultar();
            ConvivenciaFamiliar convivenciaFamiliar = new ConvivenciaFamiliar();
            convivenciaFamiliar.Cod_Conv = 0;
            convivenciaFamiliar.Desc_Conv = "";
            convivenciaFamiliarColecao.Insert(0, convivenciaFamiliar);
            this.cmbConvFamiliar.DataSource = convivenciaFamiliarColecao;
            this.cmbConvFamiliar.ValueMember = "Cod_Conv";
            this.cmbConvFamiliar.DisplayMember = "Desc_Conv";
            this.cmbConvFamiliar.SelectedIndex = 0;


        }

        private void CarregaCmbHoraRegular()
        {
            HorarioRegularNegocios horaRegular = new HorarioRegularNegocios();
            HorarioRegularColecao horaRegularColecao = horaRegular.Consultar("");
            HorarioRegular Hora_Regular = new HorarioRegular();
            Hora_Regular.Cod_Horario = 0;
            Hora_Regular.Desc_Horario = "";
            horaRegularColecao.Insert(0, Hora_Regular);
            this.cmbHorarioRegular.DataSource = horaRegularColecao;
            this.cmbHorarioRegular.ValueMember = "Cod_Horario";
            this.cmbHorarioRegular.DisplayMember = "Desc_Horario";
            this.cmbHorarioRegular.SelectedIndex = 0;
        }
        //====================================================================================
        //Evento do Boatao que insere foto da PictureBox
        private void btnInserir_Foto_Click(object sender, EventArgs e)
        {

            if (opfdAbrirFoto.ShowDialog() == DialogResult.OK)
            {
                txtLocal_Foto.Text = opfdAbrirFoto.FileName;

                picFotoAluno.ImageLocation = opfdAbrirFoto.FileName;

                picFotoAluno.Load();

            }

        }

        //====================================================================================
        //Evento do Boatao que remove a foto da PictureBox
        private void btnApagar_Foto_Click(object sender, EventArgs e)
        {
            txtLocal_Foto.Text = "";
            picFotoAluno.ImageLocation = "";

            picFotoAluno.Refresh();

        }

        private void DtpDt_Nascto_ValueChanged(object sender, EventArgs e)
        {
            DtpDt_Nascto.Format = DateTimePickerFormat.Short;
        }
       
        private void TbpDadosAdicionais_Enter(object sender, EventArgs e)
        {
            CaregaComoDoenca();
            CarregaDoencas();
            carregaCmbConvFam();
            CarregaConvFamiliar();
            CarregaCmbHabitos();
            CarregaHabitos();
            CarregaCmbCondSono();
            CarregaCondSono();
            CarregaCmbHoraRegular();
            CarregaHoraRegular();
            CarregaCmbFazSo();
            CarregaFazSo();
        }

        //Metodo que vai carregar as doenças cadastradas para o Aulno
        private void CarregaDoencas()
        {
            EloDoencaNegocios eloDoencaNegocios = new EloDoencaNegocios();
            EloDoencaColecao eloDoencaColecaoGrid = new EloDoencaColecao();
            if (txtCod_Aluno.Text == "") return;
            eloDoencaColecaoGrid = eloDoencaNegocios.ConsultarGrid(Convert.ToInt32(txtCod_Aluno.Text));
            DgvEloDoenca.DataSource = null;

            DgvEloDoenca.DataSource = eloDoencaColecaoGrid.Select(s => new
            {   s.aluno.Cod_Aluno,
                s.doenca.Cod_Doenca,
                s.doenca.Nome_Doenca
            }).ToArray();

            ;
            DgvEloDoenca.Update();
            DgvEloDoenca.Refresh();
         
        }
        
        private void CarregaConvFamiliar()
        {
            EloConv_FamiliarNegocios eloConvFam = new EloConv_FamiliarNegocios();
            EloConvivenciaFamiliarColecao eloConvivenciaFamiliarColecao = new EloConvivenciaFamiliarColecao();
            if (txtCod_Aluno.Text == "") return;
            eloConvivenciaFamiliarColecao = eloConvFam.ConsultarGrid(Convert.ToInt32(txtCod_Aluno.Text));

            dgvConvFamiliar.DataSource = null;
            dgvConvFamiliar.DataSource = eloConvivenciaFamiliarColecao.Select(s => new
            {
                s.aluno.Cod_Aluno,
                s.convivenciaFamiliar.Cod_Conv,
                s.convivenciaFamiliar.Desc_Conv
            }).ToArray();
                ;
            dgvConvFamiliar.Update();
            dgvConvFamiliar.Refresh();

        }

        private void CarregaHabitos()
        {
            EloHabitosNegocios eloHabitos = new EloHabitosNegocios();
            EloHabitoColecao eloHabitoGrid = new EloHabitoColecao();
            if (txtCod_Aluno.Text == "") return;
            eloHabitoGrid = eloHabitos.ConsultarGrid(Convert.ToInt32(txtCod_Aluno.Text));

            dgvHabitos.DataSource = null;
            dgvHabitos.DataSource = eloHabitoGrid.Select(s => new
            {s.aluno.Cod_Aluno,
             s.habito.Cod_Habito,
             s.habito.Desc_Habito
            }).ToArray();
            dgvHabitos.Update();
            dgvHabitos.Refresh();
        }

        private void CarregaCondSono()
        {
            EloCondSonoNegocios eloCondSono = new EloCondSonoNegocios();
            EloCondicoesSonoColecao eloCondicoesSonoColecao = new EloCondicoesSonoColecao();
            if (txtCod_Aluno.Text == "") return;
            eloCondicoesSonoColecao = eloCondSono.ConsultarGrid(Convert.ToInt32(txtCod_Aluno.Text));

            dgvCondicaoSono.DataSource = null;
            dgvCondicaoSono.DataSource = eloCondicoesSonoColecao.Select(s => new
            {
                s.aluno.Cod_Aluno,
                s.condicoesSono.Cod_Cond_Sono,
                s.condicoesSono.Desc_Cond_Sono
            }).ToArray();
            dgvCondicaoSono.Update();
            dgvCondicaoSono.Refresh();
        }

        private void CarregaHoraRegular()
        {
            EloHorarioRegularNegocios eloHoraRegular = new EloHorarioRegularNegocios();
            EloHorarioRegularColecao eloHoraRegularGrid = new EloHorarioRegularColecao();
            if (txtCod_Aluno.Text == "") return;
            eloHoraRegularGrid = eloHoraRegular.ConsultarGrid(Convert.ToInt32(txtCod_Aluno.Text));

            dgvHOrarioRegular.DataSource = null;
            dgvHOrarioRegular.DataSource = eloHoraRegularGrid.Select(s => new
            {   s.aluno.Cod_Aluno,
                s.horarioRegular.Cod_Horario,
                s.horarioRegular.Desc_Horario
            }).ToArray();
            dgvHOrarioRegular.Update();
            dgvHOrarioRegular.Refresh();
        }

        private void CarregaFazSo()
        {
            EloFazSozinhaNegocios eloFazSo = new EloFazSozinhaNegocios();
            EloFazSozinhaColecao eloFazSoGrid = new EloFazSozinhaColecao();
            if (txtCod_Aluno.Text == "") return;
            eloFazSoGrid = eloFazSo.ConsultarGrid(Convert.ToInt32(txtCod_Aluno.Text));

            dgvFazSo.DataSource = null;
            dgvFazSo.DataSource = eloFazSoGrid.Select(s => new
            {
                s.aluno.Cod_Aluno,
                s.fazSozinha.Cod_FazSozinha,
                s.fazSozinha.Desc_FazSozinha
            }).ToArray();
           
            dgvFazSo.Update();
            dgvFazSo.Refresh();
        }
                
        private void TbcPrincipal_Enter(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtCod_Aluno.Text))
            {
                cod_Aluno = Convert.ToInt32(txtCod_Aluno.Text);  
            }

        }

        private void btnExcluirDoencaLista_Click(object sender, EventArgs e)
        {
            if (DgvEloDoenca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado.");
                return;
            }

            EloDoenca eloDoencaSelecionado = new EloDoenca();
            EloDoencaNegocios eloDoencaNegocios = new EloDoencaNegocios();
            eloDoencaSelecionado.doenca = new Doenca();
            eloDoencaSelecionado.doenca.Cod_Doenca = Convert.ToInt32(DgvEloDoenca.CurrentRow.Cells[1].Value);
            eloDoencaSelecionado.aluno = new Aluno();
            eloDoencaSelecionado.aluno.Cod_Aluno = Convert.ToInt32(DgvEloDoenca.CurrentRow.Cells[0].Value);
            String retorno = eloDoencaNegocios.Excluir(eloDoencaSelecionado);
            try
            {
                int Cod_Aluno = Convert.ToInt32(retorno);
                MessageBox.Show("Item excluído com sucesso da lista de Doenças", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaDoencas();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInserirDoenca_Click(object sender, EventArgs e)
        {
            if (cmbDoenca.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um item da lista para inserir na grade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < DgvEloDoenca.Rows.Count; i++)
            {
                if (cmbDoenca.SelectedValue.ToString().ToUpper() == DgvEloDoenca[1,i].Value.ToString().ToUpper())
                {
                    MessageBox.Show("Doença já consta na lista. Selecione outra","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
            }


            EloDoenca eloDoenca = new EloDoenca();
            if (txtCod_Aluno.Text == "") return;
            eloDoenca.aluno = new Aluno();
            eloDoenca.aluno.Cod_Aluno = Convert.ToInt32(txtCod_Aluno.Text);
            eloDoenca.doenca = new Doenca();
            eloDoenca.doenca.Cod_Doenca = Convert.ToInt32(cmbDoenca.SelectedValue);
            EloDoencaNegocios eloDoencaNegocios = new EloDoencaNegocios();
            string retorno = eloDoencaNegocios.Inserir(eloDoenca);
            try
            {
                int idElo = Convert.ToInt32(retorno);
                MessageBox.Show("Doença inserida com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaDoencas();
            }
            catch
            {
                MessageBox.Show("Não foi possivel inserir uma Doença para este aluno." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bntNovaDoenca_Click(object sender, EventArgs e)
        {
            Form frmDoenca = new FrmDoenca("VindoAluno");
            frmDoenca.ShowDialog();
            if (frmDoenca.DialogResult == DialogResult.Yes) CaregaComoDoenca();

        }

        private void btnInserirConvFamiliar_Click(object sender, EventArgs e)
        {
            if (cmbConvFamiliar.SelectedIndex == 0)
            {
                
                MessageBox.Show("Selecione um item da lista para inserir na grade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dgvConvFamiliar.Rows.Count; i++)
            {
                if (cmbConvFamiliar.SelectedValue.ToString().ToUpper() == dgvConvFamiliar[1, i].Value.ToString().ToUpper())
                {
                    MessageBox.Show("Ítem da Convivência Familiar já consta na lista. Selecione outra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (txtCod_Aluno.Text == "") return;
            EloConvivenciaFamiliar eloConvivenciaFamiliar = new EloConvivenciaFamiliar();
            eloConvivenciaFamiliar.aluno = new Aluno();
            eloConvivenciaFamiliar.aluno.Cod_Aluno = Convert.ToInt32(txtCod_Aluno.Text);
            eloConvivenciaFamiliar.convivenciaFamiliar = new ConvivenciaFamiliar();
            eloConvivenciaFamiliar.convivenciaFamiliar.Cod_Conv = Convert.ToInt32(cmbConvFamiliar.SelectedValue);
            EloConv_FamiliarNegocios eloConvNeg = new EloConv_FamiliarNegocios();
            string retorno = eloConvNeg.Inserir(eloConvivenciaFamiliar);
            try
            {
                int idElo = Convert.ToInt32(retorno);
                MessageBox.Show("Convivência Familiar inserida com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaConvFamiliar();
            }
            catch
            {
                MessageBox.Show("Não foi possivel inserir um item de Convivência Familiar para este aluno." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnExcluirConvFamiliar_Click(object sender, EventArgs e)
        {
            if (dgvConvFamiliar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado.");
                return;
            }

            EloConvivenciaFamiliar eloConvFamiliar = new EloConvivenciaFamiliar();
            EloConv_FamiliarNegocios eloConvFamNeg = new EloConv_FamiliarNegocios();
            eloConvFamiliar.convivenciaFamiliar = new ConvivenciaFamiliar();
            eloConvFamiliar.convivenciaFamiliar.Cod_Conv = Convert.ToInt32(dgvConvFamiliar.CurrentRow.Cells[1].Value);
            eloConvFamiliar.aluno = new Aluno();
            eloConvFamiliar.aluno.Cod_Aluno = Convert.ToInt32(dgvConvFamiliar.CurrentRow.Cells[0].Value);
            String retorno = eloConvFamNeg.Excluir(eloConvFamiliar);
            try
            {
                int Cod_Aluno = Convert.ToInt32(retorno);
                MessageBox.Show("Item excluído com sucesso da lista de Convivência Familiar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaConvFamiliar();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovaConvFamiliar_Click(object sender, EventArgs e)
        {
            Form FrmConvFam = new FrmConv_Familiar("VindoAluno");
            FrmConvFam.ShowDialog();
            if (FrmConvFam.DialogResult == DialogResult.Yes) carregaCmbConvFam();
        }

        private void btnInserirHabitos_Click(object sender, EventArgs e)
        {

            if (cmbHabitos.SelectedIndex == 0)
            {

                MessageBox.Show("Selecione um item da lista para inserir na grade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dgvHabitos.Rows.Count; i++)
            {
                if (cmbHabitos.SelectedValue.ToString().ToUpper() == dgvHabitos[1, i].Value.ToString().ToUpper())
                {
                    MessageBox.Show("Hábito já consta na lista. Selecione outra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (txtCod_Aluno.Text == "") return;
            EloHabitos eloHAbito = new EloHabitos();
            eloHAbito.aluno = new Aluno();
            eloHAbito.aluno.Cod_Aluno = Convert.ToInt32(txtCod_Aluno.Text);
            eloHAbito.habito = new Habito();
            eloHAbito.habito.Cod_Habito = Convert.ToInt32(cmbHabitos.SelectedValue);
            EloHabitosNegocios eloHabitos = new EloHabitosNegocios();
            string retorno = eloHabitos.Inserir(eloHAbito);
            try
            {
                int idElo = Convert.ToInt32(retorno);
                MessageBox.Show("Hábito inserida com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaHabitos();
            }
            catch
            {
                MessageBox.Show("Não foi possivel inserir um hábito na grade para este aluno." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnExcluirHabitos_Click(object sender, EventArgs e)
        {

            if (dgvHabitos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado.");
                return;
            }

            EloHabitos eloHabitos = new EloHabitos();
            EloHabitosNegocios eloConvFamNeg = new EloHabitosNegocios();
            eloHabitos.habito = new Habito();
            eloHabitos.habito.Cod_Habito = Convert.ToInt32(dgvHabitos.CurrentRow.Cells[1].Value);
            eloHabitos.aluno = new Aluno();
            eloHabitos.aluno.Cod_Aluno = Convert.ToInt32(dgvHabitos.CurrentRow.Cells[0].Value);
            String retorno = eloConvFamNeg.Excluir(eloHabitos);
            try
            {
                int Cod_Aluno = Convert.ToInt32(retorno);
                MessageBox.Show("Item excluído com sucesso da lista de Hábitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaHabitos();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovoHAbito_Click(object sender, EventArgs e)
        {
            Form formHabitos = new FrmHabitos("VindoAluno");
            formHabitos.ShowDialog();
            if (formHabitos.DialogResult == DialogResult.Yes)CarregaCmbHabitos();
            
        }

        private void btnNovoHorario_Click(object sender, EventArgs e)
        {
            Form frmHoraRegular = new FrmHoraRegular("VindoAluno");
            frmHoraRegular.ShowDialog();
            if (frmHoraRegular.DialogResult == DialogResult.Yes) CarregaCmbHoraRegular();

        }

        private void btnNovaCondicao_Click(object sender, EventArgs e)
        {
            Form frmCondSono = new FrmCondSono("VindoAluno");
            frmCondSono.ShowDialog();
            if (frmCondSono.DialogResult == DialogResult.Yes) CarregaCmbCondSono();
        }

        private void btnInserirHorarioRegular_Click(object sender, EventArgs e)
        {

            if (cmbHorarioRegular.SelectedIndex == 0)
            {

                MessageBox.Show("Selecione um item da lista para inserir na grade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dgvHOrarioRegular.Rows.Count; i++)
            {
                if (cmbHorarioRegular.SelectedValue.ToString().ToUpper() == dgvHOrarioRegular[1, i].Value.ToString().ToUpper())
                {
                    MessageBox.Show("Horário Regular já consta na lista. Selecione outra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (txtCod_Aluno.Text == "") return;
            EloHorarioRegular eloHoraRegular = new EloHorarioRegular();
            eloHoraRegular.aluno = new Aluno();
            eloHoraRegular.aluno.Cod_Aluno = Convert.ToInt32(txtCod_Aluno.Text);
            eloHoraRegular.horarioRegular = new HorarioRegular();
            eloHoraRegular.horarioRegular.Cod_Horario = Convert.ToInt32(cmbHorarioRegular.SelectedValue);
            EloHorarioRegularNegocios eloHorarioRegularNegocios = new EloHorarioRegularNegocios();
            string retorno = eloHorarioRegularNegocios.Inserir(eloHoraRegular);
            try
            {
                int idElo = Convert.ToInt32(retorno);
                MessageBox.Show("Hora Regular inserida com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaHoraRegular();
            }
            catch
            {
                MessageBox.Show("Não foi possivel inserir um ítem na grade para este aluno." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnInserirCondicaoSono_Click(object sender, EventArgs e)
        {

            if (cmbCondicaoSono.SelectedIndex == 0)
            {

                MessageBox.Show("Selecione um item da lista para inserir na grade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dgvCondicaoSono.Rows.Count; i++)
            {
                if (cmbCondicaoSono.SelectedValue.ToString().ToUpper() == dgvCondicaoSono[1, i].Value.ToString().ToUpper())
                {
                    MessageBox.Show("Condição de Sono já consta na lista. Selecione outra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (txtCod_Aluno.Text == "") return;
            EloCondicoesSono eloCondSono = new EloCondicoesSono();
            eloCondSono.aluno = new Aluno();
            eloCondSono.aluno.Cod_Aluno = Convert.ToInt32(txtCod_Aluno.Text);
            eloCondSono.condicoesSono = new CondicoesSono();
            eloCondSono.condicoesSono.Cod_Cond_Sono = Convert.ToInt32(cmbCondicaoSono.SelectedValue);
            EloCondSonoNegocios eloCondSonoNegocio = new EloCondSonoNegocios();
            string retorno = eloCondSonoNegocio.Inserir(eloCondSono);
            try
            {
                int idElo = Convert.ToInt32(retorno);
                MessageBox.Show("Condições de Sono inserida com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaCondSono();
            }
            catch
            {
                MessageBox.Show("Não foi possivel inserir um ítem na grade para este aluno." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnExcluirHorarioLista_Click(object sender, EventArgs e)
        {
            if (dgvHOrarioRegular.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado.");
                return;
            }

            EloHorarioRegular eloHoraRegular = new EloHorarioRegular();
            EloHorarioRegularNegocios eloHorarioRegularNegocios = new EloHorarioRegularNegocios();
            eloHoraRegular.horarioRegular = new HorarioRegular();
            eloHoraRegular.horarioRegular.Cod_Horario = Convert.ToInt32(dgvHOrarioRegular.CurrentRow.Cells[1].Value);
            eloHoraRegular.aluno = new Aluno();
            eloHoraRegular.aluno.Cod_Aluno = Convert.ToInt32(dgvHOrarioRegular.CurrentRow.Cells[0].Value);
            String retorno = eloHorarioRegularNegocios.Excluir(eloHoraRegular);
            try
            {
                int codElemento = Convert.ToInt32(retorno);
                MessageBox.Show("Item excluído com sucesso da lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaHoraRegular();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirCondicaoLista_Click(object sender, EventArgs e)
        {

            if (dgvCondicaoSono.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado.");
                return;
            }

            EloCondicoesSono eloCondSono = new EloCondicoesSono();
            EloCondSonoNegocios eloCondSonoNEgocio = new EloCondSonoNegocios();
            eloCondSono.condicoesSono = new CondicoesSono();
            eloCondSono.condicoesSono.Cod_Cond_Sono = Convert.ToInt32(dgvCondicaoSono.CurrentRow.Cells[1].Value);
            eloCondSono.aluno = new Aluno();
            eloCondSono.aluno.Cod_Aluno = Convert.ToInt32(dgvCondicaoSono.CurrentRow.Cells[0].Value);
            String retorno = eloCondSonoNEgocio.Excluir(eloCondSono);
            try
            {
                int Cod_Sono = Convert.ToInt32(retorno);
                MessageBox.Show("Item excluído com sucesso da lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaCondSono();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (cmbFazSo.SelectedIndex == 0)
            {

                MessageBox.Show("Selecione um item da lista para inserir na grade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dgvFazSo.Rows.Count; i++)
            {
                if (cmbFazSo.SelectedValue.ToString().ToUpper() == dgvFazSo[1, i].Value.ToString().ToUpper())
                {
                    MessageBox.Show("Item já consta na lista. Selecione outra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (txtCod_Aluno.Text == "") return;
            EloFazSozinha eloFazSo = new EloFazSozinha();
            eloFazSo.aluno = new Aluno();
            eloFazSo.aluno.Cod_Aluno = Convert.ToInt32(txtCod_Aluno.Text);
            eloFazSo.fazSozinha = new FazSozinha();
            eloFazSo.fazSozinha.Cod_FazSozinha = Convert.ToInt32(cmbFazSo.SelectedValue);
            EloFazSozinhaNegocios eloFazSoNegocio = new EloFazSozinhaNegocios();
            string retorno = eloFazSoNegocio.Inserir(eloFazSo);
            try
            {
                int idElo = Convert.ToInt32(retorno);
                MessageBox.Show("Item inserido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaFazSo();
            }
            catch
            {
                MessageBox.Show("Não foi possivel inserir um ítem na grade para este aluno." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dgvFazSo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado.");
                return;
            }

            EloFazSozinha eloFazSo = new EloFazSozinha();
            EloFazSozinhaNegocios eloFazSoNegocio = new EloFazSozinhaNegocios();
            eloFazSo.fazSozinha = new FazSozinha();
            eloFazSo.fazSozinha.Cod_FazSozinha = Convert.ToInt32(dgvFazSo.CurrentRow.Cells[1].Value);
            eloFazSo.aluno = new Aluno();
            eloFazSo.aluno.Cod_Aluno = Convert.ToInt32(dgvFazSo.CurrentRow.Cells[0].Value);
            String retorno = eloFazSoNegocio.Excluir(eloFazSo);
            try
            {
                int Cod_FazSo = Convert.ToInt32(retorno);
                MessageBox.Show("Item excluído com sucesso da lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaFazSo();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovaFazSo_Click(object sender, EventArgs e)
        {
            Form frmFazSo = new FrmFazSozinha("VindoAluno");
            frmFazSo.ShowDialog();
            if (frmFazSo.DialogResult == DialogResult.Yes) CarregaCmbFazSo();
        }
             
        private void InserirAfastamento()
        {

            if (txtCod_Aluno.Text == "") return;
            if (mskAfastamento.Text == "" || txtAfastamento.Text == "")
            {
                MessageBox.Show("Data e motivo inválidos");
                return;
            }

            for (int i = 0; i < dgvAfastamento.Rows.Count; i++)
            {
                if (DateTime.Parse(mskAfastamento.Text) == Convert.ToDateTime(dgvAfastamento[2, i].Value))
                {
                    MessageBox.Show("Afastamento já consta na lista. Altere o afastamento da data existente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            
            AlunoAfastamento afastamento = new AlunoAfastamento();
            AlunoAfastamentoNegocios aluProAfNegocios = new AlunoAfastamentoNegocios();

            afastamento.Cod_Aluno = Convert.ToInt32(txtCod_Aluno.Text);
            afastamento.Cod_Item = Convert.ToInt32(dgvAfastamento.Rows.Count + 1);
            afastamento.Data_Afastamento = Convert.ToDateTime(mskAfastamento.Text);
            afastamento.Motivo = txtAfastamento.Text;
            string retornoAfast = aluProAfNegocios.Inserir(afastamento);
            try
            {
                int idAfastamento = Convert.ToInt32(retornoAfast);
                MessageBox.Show("Afastamento inserido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarAfastamento();
            }
            catch
            {
                MessageBox.Show("Não foi possivel inserir o afastamento para este aluno." + retornoAfast, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
        }

        private void ListarAfastamento()
        {
            AlunoAfastamentoColecao AfasColecao = new AlunoAfastamentoColecao();
            AlunoAfastamentoNegocios aluProAfNegocios = new AlunoAfastamentoNegocios();
            AfasColecao = aluProAfNegocios.Consultar(Convert.ToInt32(txtCod_Aluno.Text));
            dgvAfastamento.DataSource = null;
            dgvAfastamento.DataSource = AfasColecao;
            dgvAfastamento.Update();
            dgvAfastamento.Refresh();
            mskAfastamento.Text = "";
            txtAfastamento.Text = "";
        }

        private void ExcluirAfastamento()
        {

            if (dgvAfastamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe afastamento selecionado.");
                return;
            }
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o Afastamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;

            }

            AlunoAfastamento AluProAfSelecionado = (dgvAfastamento.SelectedRows[0].DataBoundItem as AlunoAfastamento);
            AlunoAfastamentoNegocios aluProAfNegocios = new AlunoAfastamentoNegocios();
            string retorno = aluProAfNegocios.Excluir(AluProAfSelecionado);
            try
            {
                int codAluno = Convert.ToInt32(retorno);
                //MessageBox.Show("Afastamento excluido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarAfastamento();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        
        private void btnInserirAfast_Click(object sender, EventArgs e)
        {
            InserirAfastamento();
        }

        private void btnExcluirAfast_Click(object sender, EventArgs e)
        {
            ExcluirAfastamento();
        }

        private void btnAlterarAfast_Click(object sender, EventArgs e)
        {
            if (dgvAfastamento.Rows.Count == 0)
            {
                btnAlterarAfast.Text = "Alterar";
                return;
            }
            
            if (btnAlterarAfast.Text == "Alterar")
            {
                btnAlterarAfast.Text = "Gravar";
                mskAfastamento.Text = (dgvAfastamento.CurrentRow.Cells[2].Value).ToString();
                txtAfastamento.Text = Convert.ToString(dgvAfastamento.CurrentRow.Cells[3].Value);
                dgvAfastamento.Enabled = false;
            }

            else if (btnAlterarAfast.Text == "Gravar")
            {
                if (mskAfastamento.Text == null || txtAfastamento.Text == "")
                {
                    btnAlterarAfast.Text = "Alterar";
                    return;
                }

                AlunoAfastamento afastamento = new AlunoAfastamento();
                
                afastamento.Cod_Aluno = Convert.ToInt32(dgvAfastamento.CurrentRow.Cells[0].Value);
                afastamento.Cod_Item = Convert.ToInt32(dgvAfastamento.CurrentRow.Cells[1].Value);
                afastamento.Data_Afastamento = Convert.ToDateTime(mskAfastamento.Text);
                afastamento.Motivo = Convert.ToString(txtAfastamento.Text);
                AlunoAfastamentoNegocios aluProAfNegocios = new AlunoAfastamentoNegocios();
                string retorno = aluProAfNegocios.Alterar(afastamento);
                try
                {
                    int CodAfast = Convert.ToInt32(retorno);
                    MessageBox.Show("Item alterado com sucesso.");
                    btnAlterarAfast.Text = "Alterar";
                    dgvAfastamento.Enabled = true;
                    ListarAfastamento();
                    
                    
                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados do item.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private bool ValidaForm()
        {
            lblNome_Aluno.ForeColor = System.Drawing.SystemColors.ControlText;
            lblEnd_Rua.ForeColor = System.Drawing.SystemColors.Control;
            lblEnd_nr.ForeColor = System.Drawing.SystemColors.Control;
            lblEnd_Bairro.ForeColor = System.Drawing.SystemColors.Control;
            lblEnd_Cep.ForeColor = System.Drawing.SystemColors.Control;
            lblEnd_Cidade.ForeColor = System.Drawing.SystemColors.Control;
            lblUF_Residencia.ForeColor = System.Drawing.SystemColors.Control;
            lblNaturalidade.ForeColor = System.Drawing.SystemColors.ControlText;
            lblNaturalidade.ForeColor = System.Drawing.SystemColors.ControlText;
            lblReligiao.ForeColor = System.Drawing.SystemColors.ControlText;
            lblQtde_Irmaos.ForeColor = System.Drawing.SystemColors.Control;
            lblIdade_andou.ForeColor = System.Drawing.SystemColors.Control;
            lblIdade_Falou.ForeColor = System.Drawing.SystemColors.Control;
            lblPlanoContratual.ForeColor = System.Drawing.SystemColors.Control;
            lblNome_Mae.ForeColor = System.Drawing.SystemColors.Control;
            lblProf_mae.ForeColor = System.Drawing.SystemColors.Control;

            //===============================================================================================
            if (string.IsNullOrEmpty(txtNome_Aluno.Text))
            {
                MessageBox.Show("Nome é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome_Aluno.Focus();
                lblNome_Aluno.ForeColor = System.Drawing.Color.Red;
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
                lblEnd_nr.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (cmbCod_Bairro.SelectedIndex == 0)
            {
                MessageBox.Show("Bairro é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCod_Bairro.Focus();
                lblEnd_Bairro.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(mskEnd_CEP.Text))
            {
                MessageBox.Show("CEP Inválido", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskEnd_CEP.Focus();
                lblEnd_Cep.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            else
            {
                string cep = mskEnd_CEP.Text;

                if (cep.Length != 8)
                {
                    MessageBox.Show("CEP Inválido", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskEnd_CEP.Focus();
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
            if (string.IsNullOrEmpty(txtNaturalidade.Text))
            {
                MessageBox.Show("Naturalidade é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNaturalidade.Focus();
                lblNaturalidade.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtUF_Naturalidade.Text))
            {
                MessageBox.Show("UF da Naturalidade é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUF_Naturalidade.Focus();
                lblNaturalidade.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (cmb_Cod_Religiao.SelectedValue == null)
            {
                MessageBox.Show("Religião é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_Cod_Religiao.Focus();
                lblReligiao.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txt_Qtde_irmaos.Text))
            {
                MessageBox.Show("Campo obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Qtde_irmaos.Focus();
                lblQtde_Irmaos.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtIdade_andou.Text))
            {
                MessageBox.Show("Campo obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdade_andou.Focus();
                lblIdade_andou.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtIdade_Falou.Text))
            {
                MessageBox.Show("Campo obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdade_Falou.Focus();
                lblIdade_Falou.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            if (cmbCod_Plano.SelectedValue == null)
            {
                MessageBox.Show("Plano Contratual é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCod_Plano.Focus();
                lblPlanoContratual.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtNome_Mae.Text))
            {
                MessageBox.Show("Nome da mãe é obrigátório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome_Mae.Focus();
                lblNome_Mae.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //===============================================================================================
            if (string.IsNullOrEmpty(txtProf_Mae.Text))
            {
                MessageBox.Show("Profissão da mãe é obrigatório", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProf_Mae.Focus();
                lblProf_mae.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            return true;
           
        }

        private void btnnovaReligiao_Click(object sender, EventArgs e)
        {
            Form frmReligiao = new FrmReligiao("VindoAluno");
            frmReligiao.ShowDialog();
            if (frmReligiao.DialogResult == DialogResult.Yes) CarregaCmbReligiao();
        }

        private void btnBairros_Click(object sender, EventArgs e)
        {
            Form frmBairros = new FrmBairros("VindoAluno");
            frmBairros.ShowDialog();
            if (frmBairros.DialogResult == DialogResult.Yes) CarregaCmbBairro();
        }

        private void btnResp_Legal_Click(object sender, EventArgs e)
        {
            Form frmResp_Legal = new FrmRespLegal("VindoAluno");
            frmResp_Legal.ShowDialog();
            if (frmResp_Legal.DialogResult == DialogResult.Yes) CarregaCmbResp_Legal();
        }

        private void CarregaCmbResp_Legal()
        {
            Resp_LegalNegocios resp_LegalNegocios = new Resp_LegalNegocios();
            RespLegalColecao respLegalColecao = resp_LegalNegocios.ConsultarCombo();
            this.cmbResplegal.DataSource = respLegalColecao;
            this.cmbResplegal.ValueMember = "Cod_rep_legal";
            this.cmbResplegal.DisplayMember = "NomeRep_Legal";
            if (acaoNaTelaSelecionada == AcaoNaTela.Consultar || acaoNaTelaSelecionada == AcaoNaTela.Excluir || acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                this.cmbResplegal.SelectedValue = codRespLegal;
            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                this.cmbResplegal.SelectedIndex = -1;
            }

                       
        }

        private void FrmAluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnPlanoContratual_Click(object sender, EventArgs e)
        {
            FrmPlanos frmPlanos = new FrmPlanos("VindoAluno");
            frmPlanos.ShowDialog();
            if (frmPlanos.DialogResult == DialogResult.Yes) CarregaCmbPlano();

        }

        private void carregaResponsavel()
        {
            ResponsavelNegocios responsavelNegocios = new ResponsavelNegocios();
            ResponsavelColecao ResponsavelColecao = responsavelNegocios.ConsultarGrid(cod_Aluno);
            dgvDadosResponsavel.DataSource = null;
            dgvDadosResponsavel.DataSource = ResponsavelColecao.Select(s => new
            {
                s.aluno.Cod_Aluno,
                s.Cod_Item,
                s.Nome_Responsavel,
                s.End_Rua,
                s.End_Nr,
                s.End_Comp,
                s.End_Bairro,
                s.Tel_Res,
                s.Tel_Celular,
                s.Tel_Favor
            }).ToArray();

            dgvDadosResponsavel.Update();
            dgvDadosResponsavel.Refresh();
        }

        private void tbpDadosResponsavel_Enter(object sender, EventArgs e)
        {
            carregaResponsavel();
        }

        private void SalvaAlteraResponsavel()
        {
            
            Responsavel responsavel = new Responsavel();
            responsavel.Nome_Responsavel = txtNome.Text;
            responsavel.End_Rua = txtRua.Text;
            responsavel.End_Nr = txtNr.Text;
            responsavel.End_Comp = txtComplemento.Text;
            responsavel.End_Bairro= txtBairro.Text;
            responsavel.End_Comp = txtEnd_Comp.Text;
            responsavel.Tel_Res = mskTel_Residencial.Text;
            responsavel.Tel_Celular = mskCelular.Text;
            responsavel.Tel_Favor = mskTel_Favor.Text;

            if (editar == true)
            {
                responsavel.aluno = new Aluno();
                responsavel.aluno.Cod_Aluno = Convert.ToInt32(cod_Aluno);
                responsavel.Cod_Item = Convert.ToInt32(txtCodItem.Text);
                ResponsavelNegocios responsavelNegocios = new ResponsavelNegocios();
                string retorno = responsavelNegocios.Alterar(responsavel);

                try
                {
                    int idResponsavel = Convert.ToInt32(retorno);
                    MessageBox.Show("Responsável alterado com sucesso.");

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel alterar os dados do Responsável pelo aluno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (editar == false)
            {
                responsavel.aluno = new Aluno();
                responsavel.aluno.Cod_Aluno = Convert.ToInt32(cod_Aluno);
                responsavel.Cod_Item = Convert.ToInt32(dgvDadosResponsavel.Rows.Count) + 1 ;
                ResponsavelNegocios responsavelNegocios = new ResponsavelNegocios();
                string retorno = responsavelNegocios.Inserir(responsavel);

                try
                {
                    int idResponsavel = Convert.ToInt32(retorno);
                    MessageBox.Show("Responsável inserido com sucesso.");
                    btnInserir.Text = "Salvar";
                    carregaResponsavel();

                }
                catch
                {
                    MessageBox.Show("Não Foi possivel inserir o Responsável pelo aluno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            txtNome.Text = "";
            txtRua.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtNr.Text = "";
            mskTel_Residencial.Text = "";
            mskCelular.Text = "";
            mskTel_Favor.Text = "";
            txtCodItem.Text = "";
        }

        private void BtnInserirResponsavel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCod_Aluno.Text))
            {
                editar = false;
                //if (!validaForm()) return;
                SalvaAlteraResponsavel();
                LimpaCamposResponsavel();
                carregaResponsavel();
            }
            else
            {
                MessageBox.Show("Selecione um Aluno para poder inserir dados nesta seção", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnExcluirResponsavel_Click(object sender, EventArgs e)
        {


            if (dgvDadosResponsavel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Tem certeza que deseja excluir o Representante Legal da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Responsavel responsavel = new Responsavel();
            responsavel.aluno = new Aluno();
            responsavel.aluno.Cod_Aluno = Convert.ToInt32(dgvDadosResponsavel.CurrentRow.Cells[0].Value);
            responsavel.Cod_Item = Convert.ToInt16(dgvDadosResponsavel.CurrentRow.Cells[1].Value);
            ResponsavelNegocios responsavelNegocios = new ResponsavelNegocios();
            string retorno = responsavelNegocios.Excluir(responsavel);

            try
            {
                int codResp = Convert.ToInt32(retorno);
                txtNome.Focus();
                carregaResponsavel();

            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir o responsável." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAlterarResponsavel_Click(object sender, EventArgs e)
        {
            if (btnAlterarResponsavel.Text == "Alterar")
            {
                if (!string.IsNullOrEmpty(txtCod_Aluno.Text))
                {
                    editar = true;
                    btnInserir.Enabled = false;
                    btnExcluirResponsavel.Enabled = false;
                    btnInserirResponsavel.Enabled = false;
                    btnNovoResponsavel.Enabled = false;
                    dgvDadosResponsavel.Enabled = false;
                    btnAlterarResponsavel.Text = "Salvar";
                    txtCodItem.Text = Convert.ToString(dgvDadosResponsavel.CurrentRow.Cells[1].Value);
                    txtNome.Text = Convert.ToString(dgvDadosResponsavel.CurrentRow.Cells[2].Value);
                    txtRua.Text = Convert.ToString(dgvDadosResponsavel.CurrentRow.Cells[3].Value);
                    txtNr.Text = Convert.ToString(dgvDadosResponsavel.CurrentRow.Cells[4].Value);
                    txtComplemento.Text = Convert.ToString(dgvDadosResponsavel.CurrentRow.Cells[5].Value);
                    txtBairro.Text = Convert.ToString(dgvDadosResponsavel.CurrentRow.Cells[6].Value);
                    mskTel_Residencial.Text = Convert.ToString(dgvDadosResponsavel.CurrentRow.Cells[7].Value);
                    mskCelular.Text = Convert.ToString(dgvDadosResponsavel.CurrentRow.Cells[8].Value);
                    mskTel_Favor.Text = Convert.ToString(dgvDadosResponsavel.CurrentRow.Cells[9].Value);
                    txtNome.Focus();
                 
                } 
                else
                {
                    MessageBox.Show("Selecione um Aluno para poder inserir dados nesta seção", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                }

        
            }
            else if (btnAlterarResponsavel.Text == "Salvar")
            {
                //if (!validaForm()) return;
                btnInserir.Enabled = true;
                btnExcluirResponsavel.Enabled = true;
                btnNovoResponsavel.Enabled = true;
                btnInserirResponsavel.Enabled = true;

                btnAlterarResponsavel.Text = "Alterar";
                SalvaAlteraResponsavel();
                dgvDadosResponsavel.Enabled = true;
                carregaResponsavel();
                LimpaCamposResponsavel();
                txtNome.Focus();
            }
        }

        private void btnNovoResponsavel_Click(object sender, EventArgs e)
        {
            LimpaControles lc = new LimpaControles();
            lc.ClearControls(this);
            txtNome.Focus();
        }

        private void LimpaCamposResponsavel()
        {
            txtNome.Text = "";
            txtRua.Text = "";
            txtNr.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            mskTel_Residencial.Text = "";
            mskCelular.Text = "";
            mskTel_Favor.Text = "";
        }

        private void btnPuxarResponsavelLegal_Click(object sender, EventArgs e)
        {
            if (cmbResplegal.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Responsável Legal", "Viso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 
            {
                RespLegal resp_Legal = new RespLegal();
                Resp_LegalNegocios resp_LegalNegocios = new Resp_LegalNegocios();
                resp_Legal = resp_LegalNegocios.ConsultarCodigo(Convert.ToInt32(cmbResplegal.SelectedValue));
                txtNome.Text = resp_Legal.NomeRep_Legal;
                txtRua.Text = resp_Legal.End_Rua;
                txtNr.Text = resp_Legal.End_Nr;
                txtComplemento.Text = resp_Legal.End_Comp;
                txtBairro.Text = cmbCod_Bairro.Text.ToString();
                mskTel_Residencial.Text = resp_Legal.Tel_Residencial;
                mskCelular.Text = resp_Legal.Celular;
                mskTel_Favor.Text = resp_Legal.Telefone_Favor;
            }
        }

    }


}
