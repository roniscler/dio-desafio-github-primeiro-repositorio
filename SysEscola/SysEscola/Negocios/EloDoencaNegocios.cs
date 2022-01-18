using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;

namespace Negocios
{
    public class EloDoencaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(EloDoenca eloDoenca)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloDoenca.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Doenca", eloDoenca.doenca.Cod_Doenca);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloDoenca").ToString();
                return CodElo;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string Alterar(EloDoenca eloDoenca)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloDoenca.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Doenca", eloDoenca.doenca.Cod_Doenca);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloDoenca").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string Excluir(EloDoenca eloDoenca)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloDoenca.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Doenca", eloDoenca.doenca.Cod_Doenca);

                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloDoenca").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
     
        public EloDoencaColecao ConsultarGrid(int Cod_Aluno)
        {
            try
            {
                EloDoencaColecao eloDoencaColecaoGrid = new EloDoencaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", Cod_Aluno);
                DataTable dataTableEloDoencaColecao = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEloDoencaConsultar");


               foreach (DataRow linha in dataTableEloDoencaColecao.Rows)
                   {
                        EloDoenca eloDoencaGrid = new EloDoenca();
                        eloDoencaGrid.aluno = new Aluno();
                        eloDoencaGrid.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                        eloDoencaGrid.doenca = new Doenca();
                        eloDoencaGrid.doenca.Cod_Doenca = Convert.ToInt32(linha["Cod_Doenca"]);
                        eloDoencaGrid.doenca.Nome_Doenca = Convert.ToString(linha["Nome_Doenca"]);
                        eloDoencaColecaoGrid.Add(eloDoencaGrid);
                    }

               return eloDoencaColecaoGrid;
                }

               
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os Bairros. Detalhes: " + ex.Message);
            }

        }


    }
}
