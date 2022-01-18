using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ObjetoTrasnferencia;
using AcessoDados;
using System.Data;

namespace Negocios
{
    public class EloConv_FamiliarNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(EloConvivenciaFamiliar eloConvivenciaFamiliar)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloConvivenciaFamiliar.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Conv", eloConvivenciaFamiliar.convivenciaFamiliar.Cod_Conv);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloConvivenciaFamiliar").ToString();
                return CodElo;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(EloConvivenciaFamiliar eloConvivenciaFamiliar)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloConvivenciaFamiliar.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Conv", eloConvivenciaFamiliar.convivenciaFamiliar.Cod_Conv);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloConvivenciaFamiliar").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        
        public string Excluir(EloConvivenciaFamiliar eloConv_familiar)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloConv_familiar.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Conv", eloConv_familiar.convivenciaFamiliar.Cod_Conv);

                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloConvivenciaFamiliar").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public EloConvivenciaFamiliarColecao ConsultarGrid(int Cod_Aluno)
        {
            try
            {
                EloConvivenciaFamiliarColecao EloConvivenciaFamiliarColecaoGrid = new EloConvivenciaFamiliarColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", Cod_Aluno);
                DataTable dataTableEloConv_FamColecao = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "UspEloConvFamiliarConsultar");


                foreach (DataRow linha in dataTableEloConv_FamColecao.Rows)
                {
                    EloConvivenciaFamiliar eloConvivenciaFamiliar = new EloConvivenciaFamiliar();
                    eloConvivenciaFamiliar.aluno = new Aluno();
                    eloConvivenciaFamiliar.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    eloConvivenciaFamiliar.convivenciaFamiliar = new ConvivenciaFamiliar();
                    eloConvivenciaFamiliar.convivenciaFamiliar.Cod_Conv = Convert.ToInt32(linha["Cod_Conv"]);
                    eloConvivenciaFamiliar.convivenciaFamiliar.Desc_Conv = Convert.ToString(linha["Desc_Conv"]);
                    EloConvivenciaFamiliarColecaoGrid.Add(eloConvivenciaFamiliar);
                }

                return EloConvivenciaFamiliarColecaoGrid;
            }


            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os Bairros. Detalhes: " + ex.Message);
            }

        }

    }
}
