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
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;
using System.Reflection;
using System.Diagnostics;
using System.Globalization; 


namespace Apresentacao.Relatorios
{
    public partial class FrmContrato : Form
    {
        public FrmContrato()
        {

            InitializeComponent();    

        }

        private void FrmContrato_Load(object sender, EventArgs e)
        {
            CarregaAlunos();
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
        private void btnGeraContrato_Click(object sender, EventArgs e)
        {
            //Process[] processes = Process.GetProcessesByName("Contrato.pdf");
            //foreach (Process process in processes)
            //{
            //    process.Kill();
            //}

            
            if ((cmbAluno.SelectedIndex == 0) || (cmbTurma.SelectedIndex == 0))
            {
                MessageBox.Show("Selecione um aluno e uma turma nas respectivas listas para prosseguir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }

            DTOFichaAlunoColecao dtoFichaAlunoColecao = new DTOFichaAlunoColecao();
            AlunoNegocios alunoNegocios = new AlunoNegocios();
            dtoFichaAlunoColecao = alunoNegocios.Consultar(Convert.ToInt32(cmbAluno.SelectedValue));

            DadosEmpresaColecao dadosEmpresaColecao = new DadosEmpresaColecao();
            Dados_EmpresaNegocios dados_EmpresaNegocios = new Dados_EmpresaNegocios();
            dadosEmpresaColecao = dados_EmpresaNegocios.ConsultarRelatorio();
            
            if (dtoFichaAlunoColecao.Count == 0)
            {
                MessageBox.Show("O Contrato somente será gerado se for cadastrado \n um responsavel e um plano para o aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;    
            }

            int codResp_legal = (from p in dtoFichaAlunoColecao select p.Cod_RepLegal).First();
            DTORespLegalColecao dTORespLegalColecao = new DTORespLegalColecao();
            Resp_LegalNegocios resp_LegalNegocios = new Resp_LegalNegocios();
            dTORespLegalColecao = resp_LegalNegocios.ConsultarContrato(codResp_legal);
                        
            int codPlano = (from p in dtoFichaAlunoColecao select p.Cod_Plano).First();
            
            try
            {
                Convert.ToInt32(codPlano);                
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um plano estudantil no cadastro de aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DTOPLanoEstudantilColecao dTOPLanoEstudantilColecao = new DTOPLanoEstudantilColecao();
            PlanosNegocios planosNegocios = new PlanosNegocios();
            dTOPLanoEstudantilColecao = planosNegocios.ConsultarPorCodigo(codPlano);

            TurmaNegocios turmaNegociosP = new TurmaNegocios();
            TurmaColecao turmaColecaoP = turmaNegociosP.ConsultarComboContrato(Convert.ToInt32(cmbTurma.SelectedValue));

            iTextSharp.text.Font Fontebase = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            Document doc = new Document();

            DateTime dataAtualCompleta = DateTime.Now;

            string ext = string.Format("PDF\\Contrato{0}.pdf", dataAtualCompleta.ToString("fff"));

            String strAppDir = Directory.GetCurrentDirectory();
            String caminhoCompleto = Path.Combine(strAppDir, ext);

            //string[] files = System.IO.Directory.GetFiles(strAppDir, "PDF\\*.pdf");

            //try
            //{
            //    foreach (string file in files)
            //    {
            //        File.Delete(file);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            
           

            PdfWriter.GetInstance(doc, new FileStream(caminhoCompleto, FileMode.Create, FileAccess.ReadWrite, FileShare.Delete));
            
            try
            {

                // PRIMEIRO PARAGRAFO===========================================================
                Paragraph p = new Paragraph("CONTRATO DE PRESTAÇÃO DE SERVIÇOS EDUCACIONAIS", Fontebase);
                p.Alignment = Element.ALIGN_CENTER;

                // SEGUNDO PARAGRAFO===========================================================
                Paragraph p2 = new Paragraph(" ", Fontebase);
                p2.Alignment = Element.ALIGN_CENTER;

                // TERCEIRO PARAGRAFO===========================================================
                Paragraph p3 = new Paragraph("IDENTIFICAÇÃO DAS PARTES CONTRATANTES", Fontebase);
                p3.Alignment = Element.ALIGN_CENTER;

                // QUARTO PARAGRAFO===========================================================
                string nmRespLegal = (from p1 in dTORespLegalColecao select p1.NomeRep_Legal).First();
                string naciona = (from p1 in dTORespLegalColecao select p1.Nacionalidade).First();
                string estCivil = (from p1 in dTORespLegalColecao select p1.Estado_Civil).First();
                string profissao = (from p1 in dTORespLegalColecao select p1.Profissao).First();
                string ciBase = (from p1 in dTORespLegalColecao select p1.Cart_Ident).First();
                string ciOExp = (from p1 in dTORespLegalColecao select p1.Org_Exped).First();
                string ci = string.Format("{0} - {1}",ciBase, ciOExp);
                string CPFbase = (from p1 in dTORespLegalColecao select p1.CPF).First();
                string CPF = string.Format("{0}.{1}.{2}-{3}", CPFbase.Substring(0, 3), CPFbase.Substring(3, 3), CPFbase.Substring(6, 3), CPFbase.Substring(9, 2)); 
                string endRua = (from p1 in dTORespLegalColecao select p1.End_Rua).First();
                string endNr = (from p1 in dTORespLegalColecao select p1.End_Nr).First();
                string endBairro = (from p1 in dTORespLegalColecao select p1.Bairro).First();
                string endCepBase = (from p1 in dTORespLegalColecao select p1.End_Cep).First();
                string endCep = string.Format("{0}-{1}", endCepBase.Substring(0, 5), endCepBase.Substring(5, 3));
                string endCidade = (from p1 in dTORespLegalColecao select p1.End_Cidade).First();
                string endEstado = (from p1 in dTORespLegalColecao select p1.UF_Residencia).First();

                string textop4 = string.Format("CONTRATANTE: {0}, {1} (o), {2} (a), {3}, carteira de identidade nº {4}, C.P.F. nº {5}, residente e domiciliado (a) na {6}, nº {7}, Bairro {8}, CEP {9}, cidade {10}, no Estado de ({11})", nmRespLegal, naciona, estCivil, profissao, ci, CPF, endRua, endNr, endBairro, endCep, endCidade, endEstado);

                Paragraph p4 = new Paragraph(textop4, Fontebase);
                p4.Alignment = Element.ALIGN_JUSTIFIED;

                // QUINTO PARAGRAFO===========================================================
                string nmEmp = (from p1 in dadosEmpresaColecao select p1.Nome_Empresa).First();
                string cidade = (from p1 in dadosEmpresaColecao select p1.End_Cidade).First();
                string endRuaEmp = (from p1 in dadosEmpresaColecao select p1.End_Rua).First();
                string endNrEmp = (from p1 in dadosEmpresaColecao select p1.End_Nr).First();
                string bairroEmp = (from p1 in dadosEmpresaColecao select p1.Bairro).First();
                string cepEmpfim = (from p1 in dadosEmpresaColecao select p1.End_Cep).First();
                string cepEmp = string.Format("{0}-{1}", cepEmpfim.Substring(0, 5), cepEmpfim.Substring(5, 3));
                string ufEmp = (from p1 in dadosEmpresaColecao select p1.Emp_UF).First();
                string cnpj1 = (from p1 in dadosEmpresaColecao select p1.CNPJ).First();
                string cnpj = string.Format("{0}.{1}.{2}/{3}-{4}", cnpj1.Substring(0, 2), cnpj1.Substring(2, 3), cnpj1.Substring(5, 3), cnpj1.Substring(8, 4), cnpj1.Substring(12,2));
                string inscEstEmp = (from p1 in dadosEmpresaColecao select p1.Insc_Estadual).First();
                string nmDiretora = (from p1 in dadosEmpresaColecao select p1.Nome_Diretora).First();

                string textop5 = string.Format("CONTRATADA: {0}, com sede em {1}, na {2}, nº {3}, bairro {4}, Cep. {5}, no Estado de {6}, inscrita no C.N.P.J. sob o nº {7} e no Cadastro Estadual sob o nº {8}, neste ato representada pela diretora {9}", nmEmp, cidade, endRuaEmp, endNrEmp, bairroEmp, cepEmp, ufEmp, cnpj, inscEstEmp, nmDiretora);

                Paragraph p5 = new Paragraph(textop5, Fontebase);
                p5.Alignment = Element.ALIGN_JUSTIFIED;

                // SEXTO PARAGRAFO===========================================================

                string textop6 = string.Format("As partes acima identificadas tem entre si, justo e acertado o presente Contrato de Prestação de Serviços Educacionais, que se regerá pelas cláusulas seguintes e pelas condições de preço, forma e termo de pagamento descritas no presente.");

                Paragraph p6 = new Paragraph(textop6, Fontebase);
                p6.Alignment = Element.ALIGN_JUSTIFIED;

                // SETIMO PARAGRAFO===========================================================

                string textop7 = string.Format("DO OBJETO DO CONTRATO");

                Paragraph p7 = new Paragraph(textop7, Fontebase);
                p7.Alignment = Element.ALIGN_CENTER;

                // OITAVO PARAGRAFO===========================================================
                                
                string nmAluno = (from p1 in dtoFichaAlunoColecao select p1.Nome_Aluno).First();
                string anoletivo = (from p1 in turmaColecaoP select p1.Ano_Letivo).First();


                string textop8 = string.Format("Cláusula 1º. O presente contrato tem como OBJETO, a prestação pela CONTRATADA, de serviços educacionais, a serem realizados na {0}, localizada no endereço supra citado, para o ano letivo de {1} em favor de {2}, representado neste instrumento pelo CONTRATANTE.", nmEmp, anoletivo, nmAluno);

                Paragraph p8 = new Paragraph(textop8, Fontebase);
                p8.Alignment = Element.ALIGN_JUSTIFIED;

                // NONO PARAGRAFO===========================================================

                string textop9 = string.Format("DA OBRIGAÇÃO DA CONTRATADA");

                Paragraph p9 = new Paragraph(textop9, Fontebase);
                p9.Alignment = Element.ALIGN_CENTER;

                // DECIMO PARAGRAFO===========================================================

                string textop10 = string.Format("Cláusula 2º. É obrigatório à CONTRATADA fornecer, gratuitamente, ao aluno, certificado de assiduidade e conclusão.");

                Paragraph p10 = new Paragraph(textop10, Fontebase);
                p10.Alignment = Element.ALIGN_JUSTIFIED;

                // DECIMO PRIMEIRO PARAGRAFO===========================================================

                string textop11 = string.Format("DOS DESCONTOS");

                Paragraph p11 = new Paragraph(textop11, Fontebase);
                p11.Alignment = Element.ALIGN_CENTER;

                // DECIMO SEGUNDO PARAGRAFO===========================================================

                string textop12 = string.Format("Cláusula 3º. A CONTRATADA poderá, por iniciativa própria, fornecer ao aluno, representado pelo CONTRATANTE, descontos na mensalidade, que poderão ser retirados a partir de critérios pré-estabelecidos.");

                Paragraph p12 = new Paragraph(textop12, Fontebase);
                p12.Alignment = Element.ALIGN_JUSTIFIED;

                // DECIMO TERCEIRO PARAGRAFO===========================================================

                string textop13 = string.Format("DO PAGAMENTO");

                Paragraph p13 = new Paragraph(textop13, Fontebase);
                p13.Alignment = Element.ALIGN_CENTER;

                // DECIMO QUARTO PARAGRAFO===========================================================

                Decimal vlr = (from p1 in dTOPLanoEstudantilColecao select p1.Valor).First();
                string vlrExt = (from p1 in dTOPLanoEstudantilColecao select p1.Extenso).First();

                string textop14 = string.Format("Cláusula 4º. Em virtude da prestação dos serviços educacionais, o CONTRATANTE pagará à CONTRATADA a quantia mensal de R$ {0} ({1}).", vlr, vlrExt);

                Paragraph p14 = new Paragraph(textop14, Fontebase);
                p14.Alignment = Element.ALIGN_JUSTIFIED;

                // DECIMO QUINTO PARAGRAFO===========================================================

                String textop15 = string.Format("Cláusula 5º. O pagamento das mensalidades escolares deverá ser realizada na sede da escola, no endereço supra citado até no 5º dia útil do mês subseqüente.");

                Paragraph p15 = new Paragraph(textop15, Fontebase);
                p15.Alignment = Element.ALIGN_JUSTIFIED;

                // DECIMO SEXTO PARAGRAFO===========================================================

                string textop16 = string.Format("DO INADIMPLEMENTO");

                Paragraph p16 = new Paragraph(textop16, Fontebase);
                p16.Alignment = Element.ALIGN_CENTER;

                // DECIMO SETIMO PARAGRAFO===========================================================

                String textop17 = string.Format("Cláusula 6º. Caso o CONTRATANTE não pague a mensalidade dentro do prazo estabelecido, arcará com uma multa de 0,33% (Trinta e Três Milésimos de Por Cento) ao dia após o vencimento ate o limite de 20 % (Vinte Por Cento), mais juros de 1% (Um Por Cento) dentro do primeiro mês do vencimento acumulado com Taxa SELIC mensalmente conforme Art.1º, do Decreto nº 22.626/33.");

                Paragraph p17 = new Paragraph(textop17, Fontebase);
                p17.Alignment = Element.ALIGN_JUSTIFIED;

                // DECIMO OITAVO PARAGRAFO===========================================================

                String textop18 = string.Format("Parágrafo Único: Se o atraso for superior a 90 (Noventa) dias, a CONTRATADA poderá: ");

                Paragraph p18 = new Paragraph(textop18, Fontebase);
                p18.Alignment = Element.ALIGN_JUSTIFIED;

                // DECIMO NONO PARAGRAFO===========================================================

                String textop19 = string.Format("Inscrever o devedor em cadastro ou serviços legalmente constituídos protetores de inadimplemento de pagamentos, após o aviso prévio da dívida.");

                Paragraph p19 = new Paragraph(textop19, Fontebase);
                p19.Alignment = Element.ALIGN_JUSTIFIED;

                // VIGESIMO PARAGRAFO===========================================================

                string textop20 = string.Format("DA RESCISÃO");

                Paragraph p20 = new Paragraph(textop20, Fontebase);
                p20.Alignment = Element.ALIGN_CENTER;


                // VIGESIMO PRIMEIRO PARAGRAFO===========================================================

                string textop21 = string.Format("Cláusula 7º. O presente instrumento poderá ser rescindido por qualquer das partes, sem necessidade de aviso prévio, devendo todas as parcelas estarem pagas até o dia da rescisão.");

                Paragraph p21 = new Paragraph(textop21, Fontebase);
                p21.Alignment = Element.ALIGN_JUSTIFIED;

                // VIGESIMO SEGUNDO PARAGRAFO===========================================================

                string textop22 = string.Format("Cláusula 8º. A CONTRATADA poderá rescindir o contrato, após deliberação interna, por disciplina do aluno representado neste contrato, e por inadimplência do CONTRATANTE, e o qual será previamente avisado do débito e da possível rescisão.");

                Paragraph p22 = new Paragraph(textop22, Fontebase);
                p22.Alignment = Element.ALIGN_JUSTIFIED;

                // VIGESIMO TERCEIRO PARAGRAFO===========================================================

                string textop23 = string.Format("Cláusula 9º. Em ocorrendo a rescisão, o aluno só poderá ser desligado da instituição de ensino após o término do ano letivo, obrigando-se o colégio a fornecer toda a documentação a que o estudante necessite para efetuar a transferência de escola.");

                Paragraph p23 = new Paragraph(textop23, Fontebase);
                p23.Alignment = Element.ALIGN_JUSTIFIED;

                // VIGESIMO QUARTO PARAGRAFO===========================================================

                string textop24 = string.Format("DO PRAZO");

                Paragraph p24 = new Paragraph(textop24, Fontebase);
                p24.Alignment = Element.ALIGN_CENTER;

                // VIGESIMO QUINTO PARAGRAFO===========================================================

                string dtIni = (from p1 in dtoFichaAlunoColecao select p1.Data_Ini_Contrato).First().ToString("dd/MM/yyyy");
                string dtFim = (from p1 in dtoFichaAlunoColecao select p1.Data_Fim_Contrato).First().ToString("dd/MM/yyyy");

                string textop25 = string.Format("Cláusula 10º. O presente contrato terá início em {0} e término no dia {1}.", dtIni, dtFim);

                Paragraph p25 = new Paragraph(textop25, Fontebase);
                p25.Alignment = Element.ALIGN_JUSTIFIED;

                // VIGESIMO SEXTO PARAGRAFO===========================================================

                string textop26 = string.Format("CONDIÇÕES GERAIS");

                Paragraph p26 = new Paragraph(textop26, Fontebase);
                p26.Alignment = Element.ALIGN_CENTER;

                // VIGESIMO SETIMO PARAGRAFO===========================================================

                string textop27 = string.Format("Cláusula 11º. A validade deste instrumento esta condicionada à realização da matrícula do aluno.");

                Paragraph p27 = new Paragraph(textop27, Fontebase);
                p27.Alignment = Element.ALIGN_JUSTIFIED;

                // VIGESIMO OITAVO PARAGRAFO===========================================================

                string textop28 = string.Format("Cláusula 12º. A não freqüência do aluno nas aulas não influi na obrigatoriedade do pagamento das mensalidades.");

                Paragraph p28 = new Paragraph(textop28, Fontebase);
                p28.Alignment = Element.ALIGN_JUSTIFIED;

                // VIGESIMO NONO PARAGRAFO===========================================================

                string textop29 = string.Format("Cláusula 13º. A CONTRATADA não se obriga a fornecer qualquer tipo de material didático, que serão de inteira responsabilidade do CONTRATANTE.");

                Paragraph p29 = new Paragraph(textop29, Fontebase);
                p29.Alignment = Element.ALIGN_JUSTIFIED;

                // TRIGESIMO PARAGRAFO===========================================================

                string textop30 = string.Format("DO FORO");

                Paragraph p30 = new Paragraph(textop30, Fontebase);
                p30.Alignment = Element.ALIGN_CENTER;

                // TRIGESIMO PRIMEIRO PARAGRAFO===========================================================

                string comarca = (from p1 in dadosEmpresaColecao select p1.End_Cidade).First();

                string textop31 = string.Format("Cláusula 14º. Para dirimir quaisquer controvérsias oriundas do CONTRATO, as partes elegem o foro da comarca de {0}", comarca);

                Paragraph p31 = new Paragraph(textop31, Fontebase);
                p31.Alignment = Element.ALIGN_JUSTIFIED;

                // TRIGESIMO SEGUNDO PARAGRAFO===========================================================

                string textop32 = string.Format("Por estarem assim justos e contratados, firmam o presente instrumento, em duas vias de igual teor, juntamente com 2 (duas) testemunhas.");

                Paragraph p32 = new Paragraph(textop32, Fontebase);
                p32.Alignment = Element.ALIGN_JUSTIFIED;

                // TRIGESIMO TERCEIRO PARAGRAFO===========================================================

                CultureInfo culture = new CultureInfo("pt-BR");
                DateTimeFormatInfo dtfi = culture.DateTimeFormat;

                int dia = DateTime.Now.Day;
                int ano = DateTime.Now.Year;
                string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
                string data = dia + " de " + mes + " de " + ano;
                
                string textop33 = string.Format("{0}, {1} de {2} de {3}.", comarca, dia, mes, ano);

                Paragraph p33 = new Paragraph(textop33, Fontebase);
                p33.Alignment = Element.ALIGN_LEFT;

                // TRIGESIMO QUARTO PARAGRAFO===========================================================

                string textop34 = string.Format("_____________________________________________");

                Paragraph p34 = new Paragraph(textop34, Fontebase);
                p34.Alignment = Element.ALIGN_LEFT;

                // TRIGESIMO QUINTO PARAGRAFO===========================================================

                string textop35 = string.Format("CONTRATADA:");

                Paragraph p35 = new Paragraph(textop35, Fontebase);
                p35.Alignment = Element.ALIGN_LEFT;

                // TRIGESIMO SEXTO PARAGRAFO===========================================================

                string textop36 = string.Format("_____________________________________________");

                Paragraph p36 = new Paragraph(textop36, Fontebase);
                p36.Alignment = Element.ALIGN_LEFT;

                // TRIGESIMO SETIMO PARAGRAFO===========================================================

                string textop37 = string.Format("CONTRATANTE:");

                Paragraph p37 = new Paragraph(textop37, Fontebase);
                p37.Alignment = Element.ALIGN_LEFT;

                // TRIGESIMO OITAVO PARAGRAFO===========================================================

                string textop38 = string.Format("_____________________________________________");

                Paragraph p38 = new Paragraph(textop38, Fontebase);
                p38.Alignment = Element.ALIGN_LEFT;

                // TRIGESIMO NONO PARAGRAFO===========================================================

                string textop39 = string.Format("TESTEMUNHAS:");

                Paragraph p39 = new Paragraph(textop39, Fontebase);
                p39.Alignment = Element.ALIGN_LEFT;

                doc.Open();
                doc.Add(p);
                doc.Add(p2);
                doc.Add(p3);
                doc.Add(p4);
                doc.Add(p2);
                doc.Add(p5);
                doc.Add(p2);
                doc.Add(p6);
                doc.Add(p2);
                doc.Add(p7);
                doc.Add(p8);
                doc.Add(p2);
                doc.Add(p9);
                doc.Add(p10);
                doc.Add(p2);
                doc.Add(p11);
                doc.Add(p12);
                doc.Add(p2);
                doc.Add(p13);
                doc.Add(p14);
                doc.Add(p2);
                doc.Add(p15);
                doc.Add(p2);
                doc.Add(p16);
                doc.Add(p17);
                doc.Add(p18);
                doc.Add(p19);
                doc.Add(p2);
                doc.Add(p20);
                doc.Add(p21);
                doc.Add(p2);
                doc.Add(p22);
                doc.Add(p2);
                doc.Add(p23);
                doc.Add(p2);
                doc.Add(p24);
                doc.Add(p25);
                doc.Add(p2);
                doc.Add(p26);
                doc.Add(p27);
                doc.Add(p2);
                doc.Add(p28);
                doc.Add(p2);
                doc.Add(p29);
                doc.Add(p2);
                doc.Add(p30);
                doc.Add(p31);
                doc.Add(p2);
                doc.Add(p32);
                doc.Add(p2);
                doc.Add(p2);
                doc.Add(p33);
                doc.Add(p2);
                doc.Add(p2);
                doc.Add(p34);
                doc.Add(p35);
                doc.Add(p2);
                doc.Add(p2);
                doc.Add(p36);
                doc.Add(p37);
                doc.Add(p2);
                doc.Add(p2);
                doc.Add(p39);
                doc.Add(p2);
                doc.Add(p2);
                doc.Add(p38);
                doc.Add(p2);
                doc.Add(p2);
                doc.Add(p38);
                doc.Add(p2);
                doc.Add(p2);
                

                doc.Close();
                               
                
                System.Diagnostics.Process.Start(caminhoCompleto);


            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.StackTrace);
            }




            //this.rpwContrato.LocalReport.DataSources.Clear();
            //this.rpwContrato.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsAluno", dtoFichaAlunoColecao));
            //this.rpwContrato.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsDadosEmpresa", dadosEmpresaColecao));
            //this.rpwContrato.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRepLegal", dTORespLegalColecao));
            //this.rpwContrato.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsPlano", dTOPLanoEstudantilColecao));
            
            //this.rpwContrato.SetDisplayMode(DisplayMode.PrintLayout);
            //this.rpwContrato.ZoomMode = ZoomMode.Percent;
            //this.rpwContrato.ZoomPercent = 75;
           
            
        }


        private void cmbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAluno.SelectedIndex == 0) return;
            CarregaTurmas();
        }

        private void FrmContrato_FormClosed(object sender, FormClosedEventArgs e)
        {
            String caminho = Directory.GetCurrentDirectory();
            
            string[] files = System.IO.Directory.GetFiles(caminho, "PDF\\*.pdf");

            try
            {
                foreach (string file in files)
                {
                    File.Delete(file);
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
