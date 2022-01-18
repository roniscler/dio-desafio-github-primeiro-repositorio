using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;

namespace Negocios
{
    public class TipoConceitoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(TipoConceito tipoConceito)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Sigla_Conceito", tipoConceito.Sigla_Conceito);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Conceito", tipoConceito.Desc_Conceito);
                string idConceito = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterTipoConceito").ToString();
                return idConceito;
            }

            catch (Exception excessao)
            {
                return excessao.Message;
            }

        }

        public string Alterar(TipoConceito tipoConceito)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Cod_Conceito", tipoConceito.Cod_Conceito);
                acessoDadosSqlServer.AdicionarParametros("@Sigla_Conceito", tipoConceito.Sigla_Conceito);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Conceito", tipoConceito.Desc_Conceito);
                string idConceito = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterTipoConceito").ToString();
                return idConceito;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Excluir(TipoConceito tipoConceito)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Conceito", tipoConceito.Cod_Conceito);
                string idConceito = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterTipoConceito").ToString();
                return idConceito;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public TipoConceitoColecao Consultar()
        {
            try
            {
                TipoConceitoColecao tipoConceitoColecao = new TipoConceitoColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable DataTableTipoConceito = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTipoConceitoConsultarCombo");
                foreach (DataRow linha in DataTableTipoConceito.Rows)
                {
                    TipoConceito tipoConceito = new TipoConceito();
                    tipoConceito.Cod_Conceito = Convert.ToInt32(linha["Cod_Conceito"]);
                    tipoConceito.Desc_Conceito = Convert.ToString(linha["Desc_Conceito"]);
                    tipoConceitoColecao.Add(tipoConceito);
                }

                return tipoConceitoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os ítens. Detalhes: " + ex.Message);
            }

        }


    }
}
