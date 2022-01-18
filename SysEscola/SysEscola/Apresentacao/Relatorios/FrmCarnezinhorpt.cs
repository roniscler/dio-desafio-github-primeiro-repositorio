using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObjetoTrasnferencia;
using Utilitario;
using Negocios;

namespace Apresentacao.Relatorios
{
    public partial class FrmCarnezinhorpt : Form
    {
        CarnezinhoColecao CarnezinhoColecaoTransf = new CarnezinhoColecao(); 
        public FrmCarnezinhorpt(CarnezinhoColecao carnezinhoColecao)
        {
            InitializeComponent();
            CarnezinhoColecaoTransf = carnezinhoColecao;
        }
        private void FrmCarnezinho_Load(object sender, EventArgs e)
        {

            var novaListUsuario = CarnezinhoColecaoTransf.Select(usuario => new
            {
                Cod_Carnezinho = usuario.Cod_Coarnezinho,
                Parcela = usuario.Parcela,
                Data_Vcto = usuario.Data_Vcto,
                Valor = usuario.Valor,
                Nome_Aluno = usuario.aluno.Nome_Aluno,
                Titulo = usuario.Titulo,
                Cod_Aluno = usuario.aluno.Cod_Aluno
            }).ToList();

            ConvertListToDatatable ls = new ConvertListToDatatable();
            DataTable dtCarnezinho = ls.ConvertToDataTable(novaListUsuario);

            dsCarnezinho dsCarnezinhoMensal = new Relatorios.dsCarnezinho();
            dsCarnezinhoMensal.Tables.Add(dtCarnezinho);

            rptCarnezinho rptCarnezinhoMensal = new rptCarnezinho();
            rptCarnezinhoMensal.SetDataSource(dtCarnezinho);

            DadosEmpresaColecao dadosEmpresaColecao = new DadosEmpresaColecao();
            Dados_EmpresaNegocios dados_EmpresaNegocios = new Dados_EmpresaNegocios();
            dadosEmpresaColecao = dados_EmpresaNegocios.ConsultarRelatorio();
            DataTable dadosEmpresa = ls.ConvertToDataTable(dadosEmpresaColecao);
            rptCarnezinhoMensal.Subreports[0].SetDataSource(dadosEmpresa);

            rpvwCarnezinho.ReportSource = rptCarnezinhoMensal;
            rptCarnezinhoMensal.Refresh();
        }
    }
}
