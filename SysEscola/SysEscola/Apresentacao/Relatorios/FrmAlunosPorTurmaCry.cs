using System;
using System.Data;
using System.Windows.Forms;
using Negocios;
using ObjetoTrasnferencia;
using Utilitario;


namespace Apresentacao.Relatorios
{
    public partial class FrmAlunosPorTurmaCry : Form
    {
        public FrmAlunosPorTurmaCry()
        {
            InitializeComponent();
        }

        private void FrmAlunosPorTurmaCry_Load(object sender, EventArgs e)
        {
            CarregaTurma();
        }

        private void CarregaTurma()
        {
            TurmaNegocios turmaNegocios = new TurmaNegocios();
            TurmaColecao turmaColecao = turmaNegocios.ConsultarCombo();

            Turma turma = new Turma();
            turma.Cod_Turma = 0;
            turma.Nome_Turma = "";
            turmaColecao.Insert(0, turma);
            this.cmbTurmas.DataSource = turmaColecao;
            this.cmbTurmas.ValueMember = "Cod_Turma";
            this.cmbTurmas.DisplayMember = "Nome_Turma";
            this.cmbTurmas.SelectedIndex = 0;

        }

        private void btnGerarRelatorioTurma_Click(object sender, EventArgs e)
        {
            if (cmbTurmas.SelectedIndex == 0)
            {
                MessageBox.Show("Selcione uma Turma para imprimir. ", "Turma não selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }

            TurmaNegocios turmaNegocios = new TurmaNegocios();
            DTOTurmAlunoColecao dTOTurmAlunoColecao = new DTOTurmAlunoColecao();
            dTOTurmAlunoColecao = turmaNegocios.ConsultarRelatorioTurma(Convert.ToInt32(cmbTurmas.SelectedValue));

            DadosEmpresaColecao dadosEmpresaColecao = new DadosEmpresaColecao();
            Dados_EmpresaNegocios dados_EmpresaNegocios = new Dados_EmpresaNegocios();
            dadosEmpresaColecao = dados_EmpresaNegocios.ConsultarRelatorio();

            rptAlunosPorTurma rpt = new rptAlunosPorTurma();
            DsAlunosPorTurma ds = new DsAlunosPorTurma();
            DsDadosEmpresa dse = new DsDadosEmpresa();
            
            ConvertListToDatatable ls = new ConvertListToDatatable();

            DataTable dadosEmpresa = ls.ConvertToDataTable(dadosEmpresaColecao);

            DataTable aluno = ls.ConvertToDataTable(dTOTurmAlunoColecao);
            
            ds.Tables.Add(aluno);
            dse.Tables.Add(dadosEmpresa);
            rpt.SetDataSource(dTOTurmAlunoColecao);
            rpt.Subreports[0].SetDataSource(dadosEmpresa);
            rpvwAlunosPorTurma.ReportSource = rpt;
            rpvwAlunosPorTurma.Refresh();
            
        }
    }
}
