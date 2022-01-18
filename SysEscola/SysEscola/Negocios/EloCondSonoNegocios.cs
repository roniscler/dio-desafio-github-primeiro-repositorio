using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;

namespace Negocios
{
    public class EloCondSonoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Excluir(EloCondicoesSono eloCondicoesSono)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloCondicoesSono.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Cond_Sono", eloCondicoesSono.condicoesSono.Cod_Cond_Sono);

                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloCondicoesSono").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Inserir(EloCondicoesSono eloCondicoesSono)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloCondicoesSono.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Cond_Sono", eloCondicoesSono.condicoesSono.Cod_Cond_Sono);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloCondicoesSono").ToString();
                return CodElo;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(EloCondicoesSono eloCondicoesSono)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloCondicoesSono.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Cond_Sono", eloCondicoesSono.condicoesSono.Cod_Cond_Sono);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloCondicoesSono").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public EloCondicoesSonoColecao ConsultarGrid(int Cod_Aluno)
        {
            try
            {
                EloCondicoesSonoColecao eloCondSonoColecao = new EloCondicoesSonoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", Cod_Aluno);
                DataTable dataTableeloCondSonoColecao = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEloCondicaoSonoConsultar");


                foreach (DataRow linha in dataTableeloCondSonoColecao.Rows)
                {
                    EloCondicoesSono eloCondicoesSono = new EloCondicoesSono();
                    eloCondicoesSono.aluno = new Aluno();
                    eloCondicoesSono.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    eloCondicoesSono.condicoesSono = new CondicoesSono();
                    eloCondicoesSono.condicoesSono.Cod_Cond_Sono = Convert.ToInt32(linha["Cod_Cond_Sono"]);
                    eloCondicoesSono.condicoesSono.Desc_Cond_Sono = Convert.ToString(linha["Desc_Cond_Sono"]);
                    eloCondSonoColecao.Add(eloCondicoesSono);
                }

                return eloCondSonoColecao;
            }


            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar as Condições de Sono. Detalhes: " + ex.Message);
            }

        }
    }
}
