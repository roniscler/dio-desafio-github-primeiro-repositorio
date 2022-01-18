using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ObjetoTrasnferencia;
using AcessoDados;
using System.Data;

namespace Negocios
{
    public class Conv_FamiliarNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(ConvivenciaFamiliar convivenciaFamiliar)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Conv", convivenciaFamiliar.Desc_Conv);
                string idConFam = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterConvivenciaFamiliar").ToString();
                return idConFam;
            }

            catch (Exception excessao)
            {
                return excessao.Message;
            }

        }

        public string Alterar(ConvivenciaFamiliar convivenciaFamiliar)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Conv", convivenciaFamiliar.Cod_Conv);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Conv", convivenciaFamiliar.Desc_Conv);
                string idConFam = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterConvivenciaFamiliar").ToString();
                return idConFam;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Excluir(ConvivenciaFamiliar convivenciaFamiliar)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Conv", convivenciaFamiliar.Cod_Conv);
                string Cod_Conv = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterConvivenciaFamiliar").ToString();
                return Cod_Conv;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public ConvivenciaFamiliarColecao Consultar()
        {
            try
            {
                ConvivenciaFamiliarColecao convivenciaFamiliarColecao = new ConvivenciaFamiliarColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable DataTableConvFam = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConv_FamiliarConsultar");
                foreach (DataRow linha in DataTableConvFam.Rows)
                {
                    ConvivenciaFamiliar convivenciaFamiliar = new ConvivenciaFamiliar();
                    convivenciaFamiliar.Cod_Conv = Convert.ToInt32(linha["Cod_Conv"]);
                    convivenciaFamiliar.Desc_Conv = Convert.ToString(linha["Desc_Conv"]);
                    convivenciaFamiliarColecao.Add(convivenciaFamiliar);
                }

                return convivenciaFamiliarColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o item da Convivência Familiar. Detalhes: " + ex.Message);
            }

        }

        public ConvivenciaFamiliarColecao ConsultarGrid(String desc_conv)
        {
            try
            {
                ConvivenciaFamiliarColecao convivenciaFamiliarColecao = new ConvivenciaFamiliarColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Desc_Conv", desc_conv);
                DataTable DataTableConvFam = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConv_FamiliarCOnsultarGrid");
                foreach (DataRow linha in DataTableConvFam.Rows)
                {
                    ConvivenciaFamiliar convivenciaFamiliar = new ConvivenciaFamiliar();
                    convivenciaFamiliar.Cod_Conv = Convert.ToInt32(linha["Cod_Conv"]);
                    convivenciaFamiliar.Desc_Conv = Convert.ToString(linha["Desc_Conv"]);
                    convivenciaFamiliarColecao.Add(convivenciaFamiliar);
                }

                return convivenciaFamiliarColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os ítens da Convivência Familiar. Detalhes: " + ex.Message);
            }

        }

                public ConvivenciaFamiliarColecao ConsultarRelatorio(int codAluno)
        {
            try
            {
                ConvivenciaFamiliarColecao convivenciaFamiliarColecao = new ConvivenciaFamiliarColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                DataTable DataTableConvFam = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConvivenciaFamiliarConsultarRelatorio");
                foreach (DataRow linha in DataTableConvFam.Rows)
                {
                    ConvivenciaFamiliar convivenciaFamiliar = new ConvivenciaFamiliar();
                    convivenciaFamiliar.Desc_Conv = Convert.ToString(linha["Desc_Conv"]);
                    convivenciaFamiliarColecao.Add(convivenciaFamiliar);
                }

                return convivenciaFamiliarColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os ítens da Convivência Familiar. Detalhes: " + ex.Message);
            }

        }



        
    }
}
