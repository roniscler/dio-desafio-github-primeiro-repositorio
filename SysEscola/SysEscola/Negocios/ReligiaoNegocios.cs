using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class ReligiaoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Religiao religiao)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Religiao", religiao.Nome_Religiao);
                string idReligiao = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterReligiao").ToString();
                return idReligiao;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(Religiao religiao)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Religiao", religiao.Cod_religiao);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Religiao", religiao.Nome_Religiao);
                string idReligiao = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterReligiao").ToString();
                return idReligiao;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(Religiao religiao)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Religiao", religiao.Cod_religiao);
                string CodReligiao = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterReligiao").ToString();
                return CodReligiao;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ReligiaoColecao Consultar(string nomeReligiao)
        {
            try
            {

                ReligiaoColecao religiaoColecao = new ReligiaoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome_Religiao", nomeReligiao);
                DataTable dataTableReligiao = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspReligiaoConsultar");
                foreach (DataRow linha in dataTableReligiao.Rows)
                {
                    Religiao religiao = new Religiao();
                    religiao.Cod_religiao = Convert.ToInt32(linha["Cod_Religiao"]);
                    religiao.Nome_Religiao = Convert.ToString(linha["Nome_Religiao"]);
                    religiaoColecao.Add(religiao);
                }
                return religiaoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a Religião. Detalhes: " + ex.Message);
            }

        }
    }
}
