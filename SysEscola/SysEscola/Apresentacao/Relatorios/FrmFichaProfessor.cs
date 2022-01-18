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
using Utilitario;

namespace Apresentacao.Relatorios
{
    public partial class FrmFichaProfessor : Form
    {
        public FrmFichaProfessor()
        {
            InitializeComponent();
        }

        private void frmFichaProfessorcs_Load(object sender, EventArgs e)
        {
            CarregaCmbProfessor();
        }
        private void CarregaCmbProfessor()
        {
            ProfessorNegocios professorNegocios = new ProfessorNegocios();
            ProfessorColecao professorColecao = professorNegocios.ConsultarCombo();

            cmbProfessor.DataSource = null;
            cmbProfessor.DataSource = professorColecao;
            cmbProfessor.ValueMember = "Cod_Professor";
            cmbProfessor.DisplayMember = "Nome_Professor";
            cmbProfessor.SelectedIndex = -1;
            cmbProfessor.Refresh();
        }

        private void btnFichaProfessor_Click(object sender, EventArgs e)
        {
            if (cmbProfessor.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um aluno e uma turma nas respectivas listas para prosseguir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }

            ProfessorNegocios professorNegocios = new ProfessorNegocios();
            ProfessorColecao professorColecao = new ProfessorColecao();
            professorColecao = professorNegocios.ConsultarLista(Convert.ToInt32(cmbProfessor.SelectedValue));

            var novaListaProfessor = professorColecao.Select(professor => new
            {
                Nome_Professor = professor.Nome_Professor,
                Data_Nascto = professor.basePessoa.Data_Nascto,
                Naturalidade = professor.basePessoa.Naturalidade,
                UF_Naturalidade = professor.basePessoa.UF_Naturalidade,
                End_Rua = professor.basePessoa.End_Rua,
                End_Nr = professor.basePessoa.End_Nr,
                End_Complemento = professor.basePessoa.End_Comp,
                End_Cep = professor.basePessoa.End_Cep,
                End_Bairro = professor.End_Bairro,
                End_Cidade = professor.End_Bairro,
                UF_Residencia = professor.basePessoa.UF_Residencia,
                Cart_Identidade = professor.Cart_Identidade,
                Orgao_Expedidor = professor.Orgao_Expedidor,
                CPF = professor.CPF,
                Data_Cadastro = professor.Data_Cadastro,
                Tel_Residencial = professor.Tel_Residencial,
                Tel_Celular = professor.Tel_Celular,
                Tel_Favor = professor.Tel_Favor,
                Cod_Professor = professor.Cod_Professor

            }).ToList();

            ConvertListToDatatable ls = new ConvertListToDatatable();
            DataTable dadosProfessor = ls.ConvertToDataTable(novaListaProfessor);
            dsFichaProfessor dsFicha = new dsFichaProfessor();
            dsFicha.Tables.Add(dadosProfessor);

            rptFichaProfessor rpt = new rptFichaProfessor();
            rpt.SetDataSource(dadosProfessor);
 
            DadosEmpresaColecao dadosEmpresaColecao = new DadosEmpresaColecao();
            Dados_EmpresaNegocios dados_EmpresaNegocios = new Dados_EmpresaNegocios();
            dadosEmpresaColecao = dados_EmpresaNegocios.ConsultarRelatorio();
            DataTable dadosEmpresa = ls.ConvertToDataTable(dadosEmpresaColecao);
            rpt.Subreports[0].SetDataSource(dadosEmpresa);

            Habilit_ProfissionaolColecao habilit_ProfissionaolColecao = new Habilit_ProfissionaolColecao();
            Habilt_ProfissionalNegocios habilt_ProfissionalNegocios = new Habilt_ProfissionalNegocios();
            habilit_ProfissionaolColecao = habilt_ProfissionalNegocios.Consultar(Convert.ToInt32(cmbProfessor.SelectedValue));
            DataTable Habilit_Profissional = ls.ConvertToDataTable(habilit_ProfissionaolColecao);
            dsFicha.Tables.Add(Habilit_Profissional);
            rpt.Subreports[2].SetDataSource(Habilit_Profissional);

            ProfessorAfastamentoColecao professorAfastamentoColecao = new ProfessorAfastamentoColecao();
            ProfessorAfastamentoNegocios professorAfastamentoNegocios  = new ProfessorAfastamentoNegocios();
            professorAfastamentoColecao = professorAfastamentoNegocios.ConsultarGrid(Convert.ToInt32(cmbProfessor.SelectedValue));
            DataTable ProfessorAfastamento = ls.ConvertToDataTable(professorAfastamentoColecao);
            dsFicha.Tables.Add(ProfessorAfastamento);
            rpt.Subreports[1].SetDataSource(professorAfastamentoColecao);


            
            
            rpvwFichaProfessor.ReportSource = rpt;
            rpvwFichaProfessor.Refresh();
            
        }

    }
}
