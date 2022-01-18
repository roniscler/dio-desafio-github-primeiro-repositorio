using Microsoft.Reporting.WinForms;
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

namespace Apresentacao.Relatorios
{
    public partial class FrmFichaAluno : Form
    {
        public FrmFichaAluno()
        {
            InitializeComponent();
            
        }

        private void CarregaAlunos()
        {
            AlunoNegocios alunoNegocios = new AlunoNegocios();
            AlunoColecao alunoColecao = alunoNegocios.ConsultarCombo();

            Aluno aluno = new Aluno();
            aluno.Cod_Aluno = 0;
            aluno.Nome_Aluno = "";
            alunoColecao.Insert(0, aluno);
            this.cmbAluno.DataSource = alunoColecao;
            this.cmbAluno.ValueMember = "Cod_Aluno";
            this.cmbAluno.DisplayMember = "Nome_Aluno";
            this.cmbAluno.SelectedIndex = 0;

        }

        private void CarregaTurmas()
        {
            TurmaNegocios turmaNegocios = new TurmaNegocios();
            TurmaColecao turmaColecao = turmaNegocios.ConsultarComboRelatorio(Convert.ToInt32(cmbAluno.SelectedValue));

            Turma turma = new Turma();
            turma.Cod_Turma = 0;
            turma.Nome_Turma = "";
            turmaColecao.Insert(0, turma);
            this.cmbTurma.DataSource = turmaColecao;
            this.cmbTurma.ValueMember = "Cod_Turma";
            this.cmbTurma.DisplayMember = "Nome_Turma";
            this.cmbTurma.SelectedIndex = 0;

        }

        private void btnGeraFicha_Click(object sender, EventArgs e)
        {
            if ((cmbAluno.SelectedIndex == 0) || (cmbTurma.SelectedIndex == 0))
            {
                MessageBox.Show("Selecione um aluno e uma turma nas respectivas listas para prosseguir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
        
        }

        private void frmFichaAluno_Load(object sender, EventArgs e)
        {
            //rpwFichaAluno.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing); 
            //this.rpwFichaAluno.LocalReport.EnableExternalImages = true;
            //this.rpwFichaAluno.RefreshReport();
            CarregaAlunos();
        }

        private void cmbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAluno.SelectedIndex == 0) return;
            CarregaTurmas();
        }

        private void btnGerarFicha_Click(object sender, EventArgs e)
        {
            if ((cmbAluno.SelectedIndex == 0) || (cmbTurma.SelectedIndex == 0))
            {
                MessageBox.Show("Selecione um aluno e uma turma nas respectivas listas para prosseguir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            ppViewFicha.Document = Documento;
            ppViewFicha.ShowDialog();
        }

        private void Documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font letra16 = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Pixel);
            Brush cor = new SolidBrush(Color.Black);
            Rectangle rect1 = new Rectangle(50, 50, 750, 20);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            //========================================================================================
            //PREPARAÇÃO DO CABEÇALHO DA FICHA
            
            DTOFichaAlunoColecao dtoFichaAlunoColecao = new DTOFichaAlunoColecao();
            AlunoNegocios alunoNegocios = new AlunoNegocios();
            dtoFichaAlunoColecao = alunoNegocios.Consultar(Convert.ToInt32(cmbAluno.SelectedValue));

            DadosEmpresaColecao dadosEmpresaColecao = new DadosEmpresaColecao();
            Dados_EmpresaNegocios dados_EmpresaNegocios = new Dados_EmpresaNegocios();
            dadosEmpresaColecao = dados_EmpresaNegocios.ConsultarRelatorio();

            TurmaColecao turmaColecao = new TurmaColecao();
            TurmaNegocios turmaNegocios = new TurmaNegocios();
            turmaColecao = turmaNegocios.ConsultarComboRelatorio(Convert.ToInt32(cmbAluno.SelectedValue));

            int CodSerie = Convert.ToInt32(turmaColecao[0].Cod_Serie);

            SerieEstudantilColecao serieEstudantilColecao = new SerieEstudantilColecao();
            SerieNegocios serieNegocios = new SerieNegocios();
            serieEstudantilColecao = serieNegocios.ConsultarRelatorio(Convert.ToInt32(CodSerie));

            HabitoColecao habitoColecao = new HabitoColecao();
            HabitosNegocios habitosNegocios = new HabitosNegocios();
            habitoColecao = habitosNegocios.ConsultarRelatorio(Convert.ToInt32(cmbAluno.SelectedValue));

            ConvivenciaFamiliarColecao convivenciaFamiliarColecao = new ConvivenciaFamiliarColecao();
            Conv_FamiliarNegocio conv_FamiliarNegocio = new Conv_FamiliarNegocio();
            convivenciaFamiliarColecao = conv_FamiliarNegocio.ConsultarRelatorio(Convert.ToInt32(cmbAluno.SelectedValue));

            HorarioRegularColecao horarioRegularColecao = new HorarioRegularColecao();
            HorarioRegularNegocios horarioRegularNegocios = new HorarioRegularNegocios();
            horarioRegularColecao = horarioRegularNegocios.ConsultarRelatorio(Convert.ToInt32(cmbAluno.SelectedValue));

            FazSozinhaColecao fazSozinhaColecao = new FazSozinhaColecao();
            FazSozinhaNegocios fazSozinhaNegocios = new FazSozinhaNegocios();
            fazSozinhaColecao = fazSozinhaNegocios.ConsultarRelatorio(Convert.ToInt32(cmbAluno.SelectedValue));

            CondicoesSonoColecao condicoesSonoColecao = new CondicoesSonoColecao();
            CondicoesSonoNegocios condicoesSonoNegocios = new CondicoesSonoNegocios();
            condicoesSonoColecao = condicoesSonoNegocios.ConsultarRelatorio(Convert.ToInt32(cmbAluno.SelectedValue));

            DoencaColecao doencaColecao = new DoencaColecao();
            DoencaNegocio doencaNegocio = new DoencaNegocio();
            doencaColecao = doencaNegocio.ConsultarRelatorio(Convert.ToInt32(cmbAluno.SelectedValue));

            ResponsavelColecao responsavelColecao = new ResponsavelColecao();
            ResponsavelNegocios responsavelNegocios = new ResponsavelNegocios();
            responsavelColecao = responsavelNegocios.ConsultarRelatorio(Convert.ToInt32(cmbAluno.SelectedValue));

            if (dadosEmpresaColecao.Count == 0)
            {
                ppViewFicha.Close();
                MessageBox.Show("Erro ao acessar dados da emrpesa", "Empresa não cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nmEmp = (from p1 in dadosEmpresaColecao select p1.Nome_Empresa).First();
            e.Graphics.DrawString(nmEmp, letra16, cor, rect1, formato);
            rect1.Y = 70;
            string endereco = String.Format("{0}, {1} - {2}", (from p1 in dadosEmpresaColecao select p1.End_Rua).First(), (from p1 in dadosEmpresaColecao select p1.End_Nr).First(), (from p1 in dadosEmpresaColecao select p1.End_Comp).First());
            e.Graphics.DrawString(endereco, letra16, cor, rect1, formato);
            rect1.Y = 90;
            string endereco1 = String.Format("{0} - {1} / {2} - ({3}){4}-{5}", (from p1 in dadosEmpresaColecao select p1.Bairro).First(), (from p1 in dadosEmpresaColecao select p1.End_Cidade).First(), (from p1 in dadosEmpresaColecao select p1.Emp_UF).First(), (from p1 in dadosEmpresaColecao select p1.Emp_Telefone).First().Substring(0, 2), (from p1 in dadosEmpresaColecao select p1.Emp_Telefone).First().Substring(2, 4), (from p1 in dadosEmpresaColecao select p1.Emp_Telefone).First().Substring(6, 4));
            e.Graphics.DrawString(endereco1, letra16, cor, rect1, formato);

            rect1.Y = 110;
            string nmDiretora = (from p1 in dadosEmpresaColecao select p1.Nome_Diretora).First();
            e.Graphics.DrawString(nmDiretora, letra16, cor, rect1, formato);

            rect1.Y = 130;
            string nmTurma = String.Format("{0} / {1}", (from p1 in turmaColecao select p1.Nome_Turma).First(), (from p1 in serieEstudantilColecao select p1.Nome_Serie).First());
            e.Graphics.DrawString(nmTurma, letra16, cor, rect1, formato);
            e.Graphics.DrawLine(new Pen(cor), 70, 150, 770, 150);


            string caminho = (from p1 in dtoFichaAlunoColecao select p1.Local_Foto).First().ToString();

            try
            {
                Image imagem = Image.FromFile(caminho);
                e.Graphics.DrawImage(imagem,
                            new Rectangle(70, 160, 120, 170),
                            new Rectangle(70, 160, imagem.Width, imagem.Height),
                            GraphicsUnit.Pixel);

            }
            catch (Exception)
            {
                
            }

            Font ftLabel = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);

            //====================================================================================================================
            // definiçãodo label e do campo nome do aluno
            formato.Alignment = StringAlignment.Near;
            rect1.Y = 160;
            rect1.X = 190;
            rect1.Width = 110;
            e.Graphics.DrawString("Código", ftLabel, cor, rect1, formato);
            rect1.Y = 180; 
            string codigoAluno = (from p1 in dtoFichaAlunoColecao select p1.Cod_Aluno).First().ToString();
            e.Graphics.DrawString(codigoAluno, letra16, cor, rect1, formato);

            //====================================================================================================================
            // definição do label e do campo nome do aluno

            rect1.Y = 160;
            rect1.X = 270;
            rect1.Width = 300;
            e.Graphics.DrawString("Nome", ftLabel, cor, rect1, formato);
            rect1.Y = 180;
            string nmAluno = (from p1 in dtoFichaAlunoColecao select p1.Nome_Aluno).First().ToString();
            e.Graphics.DrawString(nmAluno, letra16, cor, rect1, formato);

            //====================================================================================================================
            // definição do label e do campo nome do aluno

            rect1.Y = 160;
            rect1.X = 520;
            rect1.Width = 110;
            e.Graphics.DrawString("Nascimento", ftLabel, cor, rect1, formato);
            rect1.Y = 180;
            string dtNascto = (from p1 in dtoFichaAlunoColecao select p1.Data_Nascto).First().ToString("dd/MM/yyyy");
            e.Graphics.DrawString(dtNascto, letra16, cor, rect1, formato);

            //====================================================================================================================
            // definição do label e do campo nacionalidade do aluno

            rect1.Y = 210;
            rect1.X = 190;
            rect1.Width = 150;
            e.Graphics.DrawString("Nacionalidade", ftLabel, cor, rect1, formato);
            rect1.Y = 230;
            rect1.Width = 180;
            string nacionalidade = (from p1 in dtoFichaAlunoColecao select p1.Nacionalidade).First().ToString();
            e.Graphics.DrawString(nacionalidade, letra16, cor, rect1, formato);

            //====================================================================================================================
            // definição do label e do campo naturalidade do aluno

            rect1.Y = 210;
            rect1.X = 340;
            rect1.Width = 150;
            e.Graphics.DrawString("Naturalidade", ftLabel, cor, rect1, formato);
            rect1.Y = 230;
            rect1.Width = 180;
            string naturalidade = string.Format("{0} - {1}", (from p1 in dtoFichaAlunoColecao select p1.Naturalidade).First().ToString(), (from p1 in dtoFichaAlunoColecao select p1.UF_Naturalidade).First().ToString());
            e.Graphics.DrawString(naturalidade, letra16, cor, rect1, formato);

            //====================================================================================================================
            // definição do label e do campo naturalidade do aluno

            rect1.Y = 250;
            rect1.X = 190;
            rect1.Width = 150;
            e.Graphics.DrawString("Endereço", ftLabel, cor, rect1, formato);
            rect1.Y = 270;
            rect1.Width = 650;
            string enderecoAluno = string.Format("{0}, {1} - {2} {3}", (from p1 in dtoFichaAlunoColecao select p1.End_Rua).First().ToString(), (from p1 in dtoFichaAlunoColecao select p1.End_Nr).First().ToString(), (from p1 in dtoFichaAlunoColecao select p1.Nome_Bairro).First().ToString(), (from p1 in dtoFichaAlunoColecao select p1.End_Comp).First().ToString());
            e.Graphics.DrawString(enderecoAluno, letra16, cor, rect1, formato);
 
            //====================================================================================================================
            // definição do label e do campo idade que andou do aluno

            rect1.Y = 290;
            rect1.X = 190;
            rect1.Width = 150;
            e.Graphics.DrawString("Idade que andou:", ftLabel, cor, rect1, formato);
            rect1.X = 340;
            rect1.Width = 50;
            string idadeAndou = (from p1 in dtoFichaAlunoColecao select p1.Idade_Andou).First().ToString();
            e.Graphics.DrawString(idadeAndou, letra16, cor, rect1, formato);

            //====================================================================================================================
            // definição do label e do campo idade que falou do aluno

            rect1.Y = 290;
            rect1.X = 390;
            rect1.Width = 150;
            e.Graphics.DrawString("Idade que falou:", ftLabel, cor, rect1, formato);
            rect1.X = 540;
            rect1.Width = 50;
            string idadeFalou = (from p1 in dtoFichaAlunoColecao select p1.Idade_Andou).First().ToString();
            e.Graphics.DrawString(idadeFalou, letra16, cor, rect1, formato);

            //====================================================================================================================
            // definição do label e do campo idade que falou do aluno

            rect1.Y = 290;
            rect1.X = 590;
            rect1.Width = 150;
            e.Graphics.DrawString("Idade que irmãos:", ftLabel, cor, rect1, formato);
            rect1.X = 740;
            rect1.Width = 50;
            string qtdeIrmaos = (from p1 in dtoFichaAlunoColecao select p1.Qtde_irmaos).First().ToString();
            e.Graphics.DrawString(qtdeIrmaos, letra16, cor, rect1, formato);
            e.Graphics.DrawLine(new Pen(cor), 70, 330, 770, 330);
           
            //====================================================================================================================
            // definição da manifestação alérgica do aluno
           
            formato.LineAlignment = StringAlignment.Near;
            formato.Alignment = StringAlignment.Center;
            rect1.Y = 340;
            rect1.X = 70;
            rect1.Width = 130;
            rect1.Height = 130;
            bool manal = (from p1 in dtoFichaAlunoColecao select p1.Manif_Alergica).First();
            
            string simnao = "\nManifestação \nAlérgica: \n\nSIM";
            
            if (manal == false)
            {
                simnao = "\nManifestação \nAlérgica: \n\nNÃO";
            }

            e.Graphics.DrawString(simnao, ftLabel, cor, rect1, formato);
            e.Graphics.DrawRectangle(new Pen(cor), rect1);

            //====================================================================================================================
            // definição do label e do campo nome do pai do aluno
            rect1.Height = 20;
            rect1.Y = 340;
            rect1.X = 190;
            rect1.Width = 150;
            formato.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("Nome do Pai:", ftLabel, cor, rect1, formato);
            rect1.X = 340;
            rect1.Width = 380;
            formato.LineAlignment = StringAlignment.Near;
            formato.Alignment = StringAlignment.Near;
            string nomePai = (from p1 in dtoFichaAlunoColecao select p1.Nome_Pai).First().ToString();
            e.Graphics.DrawString(nomePai, letra16, cor, rect1, formato);

            //====================================================================================================================
            // definição do label e do campo nome da mae do aluno

            rect1.Y = 390;
            rect1.X = 190;
            rect1.Width = 150;
            formato.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("Nome da mãe:", ftLabel, cor, rect1, formato);
            rect1.X = 340;
            rect1.Width = 380;
            formato.LineAlignment = StringAlignment.Near;
            formato.Alignment = StringAlignment.Near;
            string nomeMae = (from p1 in dtoFichaAlunoColecao select p1.Nome_Mae).First().ToString();
            e.Graphics.DrawString(nomeMae, letra16, cor, rect1, formato);

            //====================================================================================================================
            // definição do label e do campo religião do aluno

            rect1.Y = 440;
            rect1.X = 190;
            rect1.Width = 150;
            formato.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("Religião:", ftLabel, cor, rect1, formato);
            rect1.X = 340;
            rect1.Width = 380;
            formato.LineAlignment = StringAlignment.Near;
            formato.Alignment = StringAlignment.Near;
            string religiao = (from p1 in dtoFichaAlunoColecao select p1.Des_Religiao).First().ToString();
            e.Graphics.DrawString(religiao, letra16, cor, rect1, formato);
            e.Graphics.DrawLine(new Pen(cor), 70, 500, 770, 500);

            //====================================================================================================================
            // definição do label e do campo resposvel perante ocontrato

            rect1.Y = 510;
            rect1.X = 70;
            rect1.Width = 300;
            e.Graphics.DrawString("Responsavel perante o contrato:", ftLabel, cor, rect1, formato);
            rect1.X = 370;
            rect1.Width = 350;
            formato.LineAlignment = StringAlignment.Near;
            formato.Alignment = StringAlignment.Near;
            string respCont = (from p1 in dtoFichaAlunoColecao select p1.NomeRepLegal).First().ToString();
            e.Graphics.DrawString(respCont, letra16, cor, rect1, formato);
            e.Graphics.DrawLine(new Pen(cor), 70, 540, 770, 540);

            //====================================================================================================================
            // definição dos itens de convivencia familiar
            int Yparametro = rect1.Y;

            formato.LineAlignment = StringAlignment.Center;
            formato.Alignment = StringAlignment.Center;
            rect1.Y = 560;
            rect1.X = 70;
            rect1.Width = 215;
            e.Graphics.DrawString("CONVIVÊNCIA FAMILIAR", ftLabel, cor, rect1, formato);
            for (int i = 0; i < convivenciaFamiliarColecao.Count; i++)
            {
                rect1.Y += 20;
                string convf = convivenciaFamiliarColecao[i].Desc_Conv;
                e.Graphics.DrawString(convf, letra16, cor, rect1, formato);
                
                if (Yparametro <= rect1.Y)
                {
                    Yparametro = rect1.Y;
                }
            }

            //====================================================================================================================
            // definição dos itens de horario regular

            rect1.Y = 560;
            rect1.X = 285;
            rect1.Width = 215;
            e.Graphics.DrawString("HORÁRIO REGULAR", ftLabel, cor, rect1, formato);
            for (int i = 0; i < horarioRegularColecao.Count; i++)
            {
                rect1.Y += 20;
                string horareg = horarioRegularColecao[i].Desc_Horario;
                e.Graphics.DrawString(horareg, letra16, cor, rect1, formato);

                if (Yparametro <= rect1.Y)
                {
                    Yparametro = rect1.Y;
                }

            }


            //====================================================================================================================
            // definição dos ihabitos do aluno

            rect1.Y = 560;
            rect1.X = 500;
            rect1.Width = 215;
            e.Graphics.DrawString("HÁBITOS", ftLabel, cor, rect1, formato);
            for (int i = 0; i < habitoColecao.Count; i++)
            {
                rect1.Y += 20;
                string habito = habitoColecao[i].Desc_Habito;
                e.Graphics.DrawString(habito, letra16, cor, rect1, formato);

                if (Yparametro <= rect1.Y)
                {
                    Yparametro = rect1.Y;
                }

            }

            //====================================================================================================================
            // definição que o launo faz sozinho
            formato.LineAlignment = StringAlignment.Center;
            formato.Alignment = StringAlignment.Center;
            int yparEst = Yparametro + 40;
            if (rect1.Y == 560)
            {
                yparEst = 600;
            }

            rect1.Y = yparEst;
            rect1.X = 70;
            rect1.Width = 215;
            e.Graphics.DrawString("FAZ SOZINHA", ftLabel, cor, rect1, formato);
            for (int i = 0; i < fazSozinhaColecao.Count; i++)
            {
                rect1.Y += 20;
                string descfaz = fazSozinhaColecao[i].Desc_FazSozinha;
                e.Graphics.DrawString(descfaz, letra16, cor, rect1, formato);

                if (Yparametro <= rect1.Y)
                {
                    Yparametro = rect1.Y;
                }
            }

            //====================================================================================================================
            // definição condiçoes de sono do aluno

            rect1.Y = yparEst;
            rect1.X = 285;
            rect1.Width = 215;
            e.Graphics.DrawString("CONDIÇÕES DE SONO", ftLabel, cor, rect1, formato);
            for (int i = 0; i < condicoesSonoColecao.Count; i++)
            {
                rect1.Y += 20;
                string codSon = condicoesSonoColecao[i].Desc_Cond_Sono;
                e.Graphics.DrawString(codSon, letra16, cor, rect1, formato);

                if (Yparametro <= rect1.Y)
                {
                    Yparametro = rect1.Y;
                }

            }
            
            //====================================================================================================================
            // definição das doencas

            rect1.Y = yparEst;
            rect1.X = 500;
            rect1.Width = 215;
            e.Graphics.DrawString("DOENÇAS", ftLabel, cor, rect1, formato);
            for (int i = 0; i < doencaColecao.Count; i++)
            {
                rect1.Y += 20;
                string nmdoe = doencaColecao[i].Nome_Doenca;
                e.Graphics.DrawString(nmdoe, letra16, cor, rect1, formato);

                if (Yparametro <= rect1.Y)
                {
                    Yparametro = rect1.Y;

                }

            }

            if (Yparametro == 510) e.Graphics.DrawLine(new Pen(cor), 70, 630, 770, 630);
            
            yparEst = Yparametro + 30;

            e.Graphics.DrawLine(new Pen(cor), 70, yparEst, 770, yparEst);

            //====================================================================================================================
            // definição dos responsaveis por buscar o aluno na escola
            Font letra8 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel);

            rect1.Y = yparEst + 20;
            if (rect1.Y == 560)
            {
                rect1.Y = 640;
            }
            rect1.X = 70;
            rect1.Width = 215;
            e.Graphics.DrawString("Nome do Responsável", ftLabel, cor, rect1, formato);
            rect1.X = 285;
            e.Graphics.DrawString("Endereço", ftLabel, cor, rect1, formato);
            rect1.X = 500;
            e.Graphics.DrawString("Telefones", ftLabel, cor, rect1, formato);
            
            for (int i = 0; i < condicoesSonoColecao.Count; i++)
            {
                rect1.Y += 20;
                rect1.X = 70;
                string nmResp = responsavelColecao[i].Nome_Responsavel;
                e.Graphics.DrawString(nmResp, letra8, cor, rect1, formato);

                rect1.X = 285;

                string endResp = String.Format("{0}, {1} - {2}",responsavelColecao[i].End_Rua, responsavelColecao[i].End_Nr, responsavelColecao[i].End_Comp);
                e.Graphics.DrawString(endResp, letra8, cor, rect1, formato);

                rect1.X = 500;

                string tels = String.Format("{0}/{1}/{2}", responsavelColecao[i].Tel_Celular, responsavelColecao[i].Tel_Favor, responsavelColecao[i].Tel_Res);
                e.Graphics.DrawString(tels, letra8, cor, rect1, formato);

                if (Yparametro <= rect1.Y)
                {
                    Yparametro = rect1.Y;
                }

            }

            rect1.X = 70;
            rect1.Width = 720;
            rect1.Y += 80;
            e.Graphics.DrawString("_____________________________________________________", letra16, cor, rect1, formato);
            rect1.Y += 20;
            e.Graphics.DrawString("ASSINATURA DO RESPONSÁVEL PELA MATRÍCULA", letra16, cor, rect1, formato);
            rect1.Y += 40;
            e.Graphics.DrawString("MATRÍCULA CANCELADA EM _____/_____/_____ POR : ____________________________________________________", letra16, cor, rect1, formato);
            rect1.Y += 40;
            e.Graphics.DrawString("_____________________________________________________", letra16, cor, rect1, formato);
            rect1.Y += 20;
            e.Graphics.DrawString("ASSINATURA DO RESPONSÁVEL", letra16, cor, rect1, formato);

        }
                
    }
}
