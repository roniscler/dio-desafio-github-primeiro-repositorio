using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class ContaCorrenteNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(ContaCorrente contaCorrente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", contaCorrente.Descricao);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterContaCorrente").ToString();
                return idItem;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(ContaCorrente contaCorrente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@CodContaCorrente", contaCorrente.CodContaCorrente);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", contaCorrente.Descricao);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterContaCorrente").ToString();
                return idItem;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(ContaCorrente contaCorrente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@CodContaCorrente", contaCorrente.CodContaCorrente);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterContaCorrente").ToString();
                return idItem;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ContaCorrenteColecao Consultar(string descricao)
        {
            try
            {
                ContaCorrenteColecao centroCustoColecao = new ContaCorrenteColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Descricao", descricao);
                DataTable DataTableItens = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspContaCorrenteConsultar");
                foreach (DataRow linha in DataTableItens.Rows)
                {
                    ContaCorrente centroCusto = new ContaCorrente();
                    centroCusto.CodContaCorrente = Convert.ToInt32(linha["CodContaCorrente"]);
                    centroCusto.Descricao = Convert.ToString(linha["Descricao"]);
                    centroCustoColecao.Add(centroCusto);
                }

                return centroCustoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os Centros de Custos cadastrados: " + ex.Message);
            }

        }



    }
}
