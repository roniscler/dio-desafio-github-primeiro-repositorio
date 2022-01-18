using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class BairrosNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Bairros bairros)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Bairro", bairros.Nome_Bairro);
                string idBairro = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterBairros").ToString();
                return idBairro;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(Bairros bairros)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Bairro", bairros.Cod_Bairro);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Bairro", bairros.Nome_Bairro);
                string idBairro = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterBairros").ToString();
                return idBairro;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(Bairros bairros)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Bairro", bairros.Cod_Bairro);
                string CodBairro = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterBairros").ToString();
                return CodBairro;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public BairrosColecao Consultar(string nomeBairro)
        {
            try
            {
                BairrosColecao bairrosColecao = new BairrosColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome_Bairro", nomeBairro);
                DataTable dataTableBairros = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspBairroConsultar");
                foreach (DataRow linha in dataTableBairros.Rows)
                {
                    Bairros bairro = new Bairros();
                    bairro.Cod_Bairro = Convert.ToInt32(linha["Cod_Bairro"]);
                    bairro.Nome_Bairro = Convert.ToString(linha["Nome_Bairro"]);
                    bairrosColecao.Add(bairro);
                }
                return bairrosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os Bairros. Detalhes: " + ex.Message);
            }

        }

    }
   
}
