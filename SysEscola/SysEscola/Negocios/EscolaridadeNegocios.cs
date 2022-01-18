using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;

namespace Negocios
{
    public class EscolaridadeNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Escolaridade escolaridade)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Descricao", escolaridade.Descricao);
                string idElemento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEscolaridade").ToString();
                return idElemento;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(Escolaridade escolaridade)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Ecolaridade", escolaridade.Cod_Escolaride);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", escolaridade.Descricao);
                string idElemento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEscolaridade").ToString();
                return idElemento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(Escolaridade escolaridade)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Escolaridade", escolaridade.Cod_Escolaride);
                string idElemento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEscolaridade").ToString();
                return idElemento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public EscolaridadeColecao Consultar()
        {
            try
            {

                EscolaridadeColecao escolaridadeColecao = new EscolaridadeColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable dataTableEscolaridade = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEscolaridadeConsultar");
                foreach (DataRow linha in dataTableEscolaridade.Rows)
                {
                    Escolaridade escolaridade = new Escolaridade();
                    escolaridade.Cod_Escolaride = Convert.ToInt32(linha["Cod_Escolaridade"]);
                    escolaridade.Descricao = Convert.ToString(linha["Descricao"]);
                    escolaridadeColecao.Add(escolaridade);
                }
                return escolaridadeColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a escolaridade. Detalhes: " + ex.Message);
            }

        }

    }
}
