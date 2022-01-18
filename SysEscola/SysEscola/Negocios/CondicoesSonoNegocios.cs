using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;

namespace Negocios
{
    public class CondicoesSonoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(CondicoesSono condicoesSono)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Cond_Sono", condicoesSono.Desc_Cond_Sono);
                string idCondSono = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCondicoesSono").ToString();
                return idCondSono;
            }

            catch (Exception excessao)
            {
                return excessao.Message;
            }

        }

        public string Alterar(CondicoesSono condicoesSono)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Cond_Sono", condicoesSono.Cod_Cond_Sono);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Cond_Sono", condicoesSono.Desc_Cond_Sono);
                string codSono = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCondicoesSono").ToString();
                return codSono;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Excluir(CondicoesSono condicoesSono)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Cond_Sono", condicoesSono.Cod_Cond_Sono);
                string codSono = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCondicoesSono").ToString();
                return codSono;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public CondicoesSonoColecao Consultar(string descCondSono )
        {
            try
            {
                CondicoesSonoColecao condicoesSonoColecao = new CondicoesSonoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Desc_Cond_Sono", descCondSono);
                DataTable DataTableCondSono = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCondSonoConsultar");
                foreach (DataRow linha in DataTableCondSono.Rows)
                {
                    CondicoesSono condicoesSono = new CondicoesSono();
                    condicoesSono.Cod_Cond_Sono = Convert.ToInt32(linha["Cod_Cond_Sono"]);
                    condicoesSono.Desc_Cond_Sono = Convert.ToString(linha["Desc_Cond_Sono"]);
                    condicoesSonoColecao.Add(condicoesSono);
                }

                return condicoesSonoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar as Condições de Sono do aluno. Detalhes: " + ex.Message);
            }

        }

        public CondicoesSonoColecao ConsultarRelatorio(int codAluno)
        {
            try
            {
                CondicoesSonoColecao condicoesSonoColecao = new CondicoesSonoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                DataTable DataTableCondSono = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCondicoesSonoConsultarRelatorio");
                foreach (DataRow linha in DataTableCondSono.Rows)
                {
                    CondicoesSono condicoesSono = new CondicoesSono();
                    condicoesSono.Desc_Cond_Sono = Convert.ToString(linha["Desc_Cond_Sono"]);
                    condicoesSonoColecao.Add(condicoesSono);
                }

                return condicoesSonoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar as Condições de Sono do aluno. Detalhes: " + ex.Message);
            }

        }


    }
}
