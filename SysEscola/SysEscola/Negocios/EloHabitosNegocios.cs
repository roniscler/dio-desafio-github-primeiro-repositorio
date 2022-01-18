using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;

namespace Negocios
{
    public class EloHabitosNegocios
    {

        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Excluir(EloHabitos eloHabitos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloHabitos.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Habito", eloHabitos.habito.Cod_Habito);

                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloHabito").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Inserir(EloHabitos eloHabitos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloHabitos.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Habito", eloHabitos.habito.Cod_Habito);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloHabito").ToString();
                return CodElo;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(EloHabitos eloHabitos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloHabitos.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Habito", eloHabitos.habito.Cod_Habito);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloHabito").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public EloHabitoColecao ConsultarGrid(int Cod_Aluno)
        {
            try
            {
                EloHabitoColecao eloHabitoColecao = new EloHabitoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", Cod_Aluno);
                DataTable dataTableEloHabitoColecao = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEloHabitosConsultar");


                foreach (DataRow linha in dataTableEloHabitoColecao.Rows)
                {
                    EloHabitos eloHabitosGrid = new EloHabitos();
                    eloHabitosGrid.aluno = new Aluno();
                    eloHabitosGrid.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    eloHabitosGrid.habito = new Habito();
                    eloHabitosGrid.habito.Cod_Habito = Convert.ToInt32(linha["Cod_Habito"]);
                    eloHabitosGrid.habito.Desc_Habito = Convert.ToString(linha["Desc_Habito"]);
                    eloHabitoColecao.Add(eloHabitosGrid);
                }

                return eloHabitoColecao;
            }


            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os Hábitos. Detalhes: " + ex.Message);
            }

        }

        
    }
}
