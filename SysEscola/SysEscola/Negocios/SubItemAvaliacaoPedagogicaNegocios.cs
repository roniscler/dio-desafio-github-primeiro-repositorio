using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;

namespace Negocios
{
    public class SubItemAvaliacaoPedagogicaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(SubItensAvaliacaoPedagogica subItensAvaliacaoPedagogica)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aval_Pedag", subItensAvaliacaoPedagogica.Cod_Aval_Pedag);
                acessoDadosSqlServer.AdicionarParametros("@Desc_SI_Aval_Pedag", subItensAvaliacaoPedagogica.Desc_SI_Aval_Pedag);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterSubItensAvaliacaoPedagogica").ToString();
                return idItem;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(SubItensAvaliacaoPedagogica subItensAvaliacaoPedagogica)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_SI_Aval_Pedag", subItensAvaliacaoPedagogica.Cod_SI_Aval_Pedag);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aval_Pedag", subItensAvaliacaoPedagogica.Cod_Aval_Pedag);
                acessoDadosSqlServer.AdicionarParametros("@Desc_SI_Aval_Pedag", subItensAvaliacaoPedagogica.Desc_SI_Aval_Pedag);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterSubItensAvaliacaoPedagogica").ToString();
                return idItem;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(SubItensAvaliacaoPedagogica subItensAvaliacaoPedagogica)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_SI_Aval_Pedag", subItensAvaliacaoPedagogica.Cod_SI_Aval_Pedag);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterSubItensAvaliacaoPedagogica").ToString();
                return idItem;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public SubItensAvaliacaoPedagogicaColecao Consultar(string nomeItem, int CodAvalPEdag)
        {
            try
            {
                SubItensAvaliacaoPedagogicaColecao SubItensAvalColecao = new SubItensAvaliacaoPedagogicaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aval_Pedag", CodAvalPEdag);
                acessoDadosSqlServer.AdicionarParametros("@Desc_SI_Aval_Pedag", nomeItem);
                DataTable DataTableItens = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspSubItemAvalliacaoPedagogicaConsultarGrid");
                foreach (DataRow linha in DataTableItens.Rows)
                {
                    SubItensAvaliacaoPedagogica subItensAvaliacaoPedagogica = new SubItensAvaliacaoPedagogica();

                    subItensAvaliacaoPedagogica.Cod_SI_Aval_Pedag = Convert.ToInt32(linha["Cod_SI_Aval_Pedag"]);
                    subItensAvaliacaoPedagogica.Cod_Aval_Pedag = Convert.ToInt32(linha["Cod_Aval_Pedag"]);
                    subItensAvaliacaoPedagogica.Desc_SI_Aval_Pedag = Convert.ToString(linha["Desc_SI_Aval_Pedag"]);
                    SubItensAvalColecao.Add(subItensAvaliacaoPedagogica);
                }

                return SubItensAvalColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os ítens de Avaliação Pedagógica: " + ex.Message);
            }

        }

        public SubItensAvaliacaoPedagogicaColecao ConsultarCombo()
        {
            try
            {
                SubItensAvaliacaoPedagogicaColecao SubItensAvalColecao = new SubItensAvaliacaoPedagogicaColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable DataTableItens = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspSubItemAvalPedagConsultarCombo");
                foreach (DataRow linha in DataTableItens.Rows)
                {
                    SubItensAvaliacaoPedagogica SubItensAvalPedagogica = new SubItensAvaliacaoPedagogica();

                    SubItensAvalPedagogica.Cod_SI_Aval_Pedag = Convert.ToInt32(linha["Cod_SI_Aval_Pedag"]);
                    SubItensAvalPedagogica.Desc_SI_Aval_Pedag = Convert.ToString(linha["Desc_SI_Aval_Pedag"]);
                    SubItensAvalColecao.Add(SubItensAvalPedagogica);
                }

                return SubItensAvalColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os ítens de Avaliação Pedagógica: " + ex.Message);
            }

        }


    }
}
