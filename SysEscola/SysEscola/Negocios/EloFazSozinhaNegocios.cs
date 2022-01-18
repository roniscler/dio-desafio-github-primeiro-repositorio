using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;


namespace Negocios
{
    public class EloFazSozinhaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Excluir(EloFazSozinha eloFazSozinha)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloFazSozinha.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_FazSo", eloFazSozinha.fazSozinha.Cod_FazSozinha);

                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloFazSozinha").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Inserir(EloFazSozinha eloFazSozinha)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloFazSozinha.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_FazSo", eloFazSozinha.fazSozinha.Cod_FazSozinha);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloFazSozinha").ToString();
                return CodElo;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(EloFazSozinha eloFazSozinha)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloFazSozinha.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_FazSo", eloFazSozinha.fazSozinha.Cod_FazSozinha);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloFazSozinha").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public EloFazSozinhaColecao ConsultarGrid(int Cod_Aluno)
        {
            try
            {
                EloFazSozinhaColecao eloFazSozinhaColecao = new EloFazSozinhaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", Cod_Aluno);
                DataTable dataTableeloFazSoColecao = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEloFazSozinhaConsultar");


                foreach (DataRow linha in dataTableeloFazSoColecao.Rows)
                {
                    EloFazSozinha eloFazSoGrid = new EloFazSozinha();
                    eloFazSoGrid.aluno = new Aluno();
                    eloFazSoGrid.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    eloFazSoGrid.fazSozinha = new FazSozinha();
                    eloFazSoGrid.fazSozinha.Cod_FazSozinha = Convert.ToInt32(linha["Cod_Faz_So"]);
                    eloFazSoGrid.fazSozinha.Desc_FazSozinha = Convert.ToString(linha["Desc_FazSozinha"]);
                    eloFazSozinhaColecao.Add(eloFazSoGrid);
                }

                return eloFazSozinhaColecao;
            }


            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar. Detalhes: " + ex.Message);
            }

        }
    }
}
