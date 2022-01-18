using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class ItensAvaliacaoPedagNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(ItensAvaliacaoPedagogica itensAvaliacaoPedagogica)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Aval_Pedag", itensAvaliacaoPedagogica.Desc_Aval_Pedag);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterItensAvaliacaoPedagogica").ToString();
                return idItem;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(ItensAvaliacaoPedagogica itensAvaliacaoPedagogica)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aval_Pedag", itensAvaliacaoPedagogica.Cod_Aval_Pedag);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Aval_Pedag", itensAvaliacaoPedagogica.Desc_Aval_Pedag);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterItensAvaliacaoPedagogica").ToString();
                return idItem;
                
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public ItensAvaliacaoPedagogicaColecao Consultar(string nomeItem)
        {
            try
            {
                ItensAvaliacaoPedagogicaColecao iTensAvalColecao = new ItensAvaliacaoPedagogicaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Desc_Aval_Pedag", nomeItem);
                DataTable DataTableItens = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspI_Aval_Pedag_Consultar");
                foreach (DataRow linha in DataTableItens.Rows)
                {
                    ItensAvaliacaoPedagogica itensAvaliacaoPedagogica = new ItensAvaliacaoPedagogica();
                    itensAvaliacaoPedagogica.Cod_Aval_Pedag = Convert.ToInt32(linha["Cod_Aval_Pedag"]);
                    itensAvaliacaoPedagogica.Desc_Aval_Pedag = Convert.ToString(linha["Desc_Aval_Pedag"]);
                    iTensAvalColecao.Add(itensAvaliacaoPedagogica);
                }

                return iTensAvalColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os ítens de Avaliação Pedagógica: " + ex.Message);
            }

        }

        public string Excluir(ItensAvaliacaoPedagogica itensAvaliacaoPedagogica)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aval_Pedag", itensAvaliacaoPedagogica.Cod_Aval_Pedag);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Aval_Pedag", itensAvaliacaoPedagogica.Desc_Aval_Pedag);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterItensAvaliacaoPedagogica").ToString();
                return idItem;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
