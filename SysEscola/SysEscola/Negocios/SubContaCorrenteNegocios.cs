using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;

namespace Negocios
{
    public class SubContaCorrenteNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(SubContaCorrente subContaCorrente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@CodContaCorrente", subContaCorrente.contaCorrente.CodContaCorrente);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", subContaCorrente.Descricao);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterSubContaCorrente").ToString();
                return idItem;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(SubContaCorrente subContaCorrente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@CodSubConta", subContaCorrente.CodSubConta);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", subContaCorrente.Descricao);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterSubContaCorrente").ToString();
                return idItem;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(SubContaCorrente subContaCorrente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@CodSubConta", subContaCorrente.CodSubConta);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterSubContaCorrente").ToString();
                return idItem;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public SubContaCorrenteColecao Consultar(int codigo, string descricao)
        {
            try
            {
                SubContaCorrenteColecao subContaCorrenteColecao = new SubContaCorrenteColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CodContaCorrente", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", descricao);
                DataTable DataTableItens = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "UspSubCentroCustoConsultar");
                foreach (DataRow linha in DataTableItens.Rows)
                {
                    SubContaCorrente subContaCorrente = new SubContaCorrente();
                    subContaCorrente.CodSubConta = Convert.ToInt32(linha["CodSubConta"]);

                    subContaCorrente.contaCorrente = new ContaCorrente();
                    subContaCorrente.contaCorrente.CodContaCorrente = Convert.ToInt32(linha["CodContaCorrente"]);
                    
                    subContaCorrente.Descricao = Convert.ToString(linha["Descricao"]);
                    subContaCorrenteColecao.Add(subContaCorrente);
                }

                return subContaCorrenteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os sub ítens do Centro de Custos: " + ex.Message);
            }

        }

    }
}
