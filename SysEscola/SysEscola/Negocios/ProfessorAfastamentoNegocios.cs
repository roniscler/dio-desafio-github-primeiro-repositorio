using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class ProfessorAfastamentoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(ProfessorAfastamento professorAfastamento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", professorAfastamento.Cod_Professor);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", professorAfastamento.Cod_Item);
                acessoDadosSqlServer.AdicionarParametros("@Dt_Afast", professorAfastamento.Dt_afast);
                acessoDadosSqlServer.AdicionarParametros("@Dias", professorAfastamento.Dias);
                acessoDadosSqlServer.AdicionarParametros("@Motivo", professorAfastamento.Motivo);
                string idProfAfast = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterProfessorAfastamento").ToString();
                return idProfAfast;
            }

            catch (Exception excessao)
            {
                return excessao.Message;
            }

        }

        public string Alterar(ProfessorAfastamento professorAfastamento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", professorAfastamento.Cod_Professor);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", professorAfastamento.Cod_Item);
                acessoDadosSqlServer.AdicionarParametros("@Dt_Afast", professorAfastamento.Dt_afast);
                acessoDadosSqlServer.AdicionarParametros("@Dias", professorAfastamento.Dias);
                acessoDadosSqlServer.AdicionarParametros("@Motivo", professorAfastamento.Motivo);
                string idHabilitacao = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterProfessorAfastamento").ToString();
                return idHabilitacao;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Excluir(ProfessorAfastamento professorAfastamento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", professorAfastamento.Cod_Professor);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", professorAfastamento.Cod_Item);
                string idHabilitacao = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterProfessorAfastamento").ToString();
                return idHabilitacao;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }


        public ProfessorAfastamentoColecao ConsultarGrid(int CodProfessor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", CodProfessor);

                ProfessorAfastamentoColecao professorAfastamentoColecao = new ProfessorAfastamentoColecao();

                DataTable DataTableProfessor_Afast = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorAfast_ConsultarGrid");
                foreach (DataRow linha in DataTableProfessor_Afast.Rows)
                {
                    ProfessorAfastamento professorAfastamento = new ProfessorAfastamento();
                    
                    professorAfastamento.Cod_Professor = Convert.ToInt32(linha["Cod_Professor"]);
                    professorAfastamento.Cod_Item = Convert.ToInt16(linha["Cod_Item"]);
                    professorAfastamento.Dt_afast = Convert.ToDateTime(linha["Dt_Afast"]);
                    professorAfastamento.Dias = Convert.ToInt16(linha["Dias"]);
                    professorAfastamento.Motivo = Convert.ToString(linha["Motivo"]);
                    professorAfastamentoColecao.Add(professorAfastamento);
                }

                return professorAfastamentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os afastamentos para este Professor. Detalhes: " + ex.Message);
            }

        }

        public ProfessorAfastamentoColecao ConsultarIndividual(int CodProfessor, int CodigoItem)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", CodProfessor);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", CodigoItem);

                ProfessorAfastamentoColecao professorAfastamentoColecao = new ProfessorAfastamentoColecao();

                DataTable DataTableProfessor_Afast = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorAfast_Consultar");
                foreach (DataRow linha in DataTableProfessor_Afast.Rows)
                {
                    ProfessorAfastamento professorAfastamento = new ProfessorAfastamento();

                    professorAfastamento.Cod_Professor = Convert.ToInt32(linha["Cod_Professor"]);
                    professorAfastamento.Cod_Item = Convert.ToInt16(linha["Cod_Item"]);
                    professorAfastamento.Dt_afast = Convert.ToDateTime(linha["Dt_Afast"]);
                    professorAfastamento.Dias = Convert.ToInt16(linha["Dias"]);
                    professorAfastamento.Motivo = Convert.ToString(linha["Motivo"]);
                    professorAfastamentoColecao.Add(professorAfastamento);
                }

                return professorAfastamentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os afastamentos para este Professor. Detalhes: " + ex.Message);
            }

        }


    }
}
