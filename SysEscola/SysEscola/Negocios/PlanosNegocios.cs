using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;
using Utilitario;

namespace Negocios
{
    public class PlanosNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Planos planos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Plano", planos.Desc_Plano);
                acessoDadosSqlServer.AdicionarParametros("@Valor", planos.Valor);
                string idPlano = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPlanos").ToString();
                return idPlano;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(Planos planos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Plano", planos.Cod_Plano);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Plano", planos.Desc_Plano);
                acessoDadosSqlServer.AdicionarParametros("@Valor", planos.Valor);
                string idPlano = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPlanos").ToString();
                return idPlano;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(Planos planos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Plano", planos.Cod_Plano);
                string CodPlano = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPlanos").ToString();
                return CodPlano;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public PlanosColecao ConsultarNome(string nomePlano)
        {
            try
            {

                PlanosColecao planosColecao = new PlanosColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Desc_Plano", nomePlano);
                DataTable dataTablePlanos = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPlanosConsultarGrid");
                foreach (DataRow linha in dataTablePlanos.Rows)
                {
                    Planos planos = new Planos();
                    planos.Cod_Plano = Convert.ToInt32(linha["Cod_Plano"]);
                    planos.Desc_Plano = Convert.ToString(linha["Desc_Plano"]);
                    planos.Valor = Convert.ToDecimal(linha["Valor"]);
                    planosColecao.Add(planos);
                }
                return planosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o plano de pagamento. Detalhes: " + ex.Message);
            }

        }

        public PlanosColecao Consultar()
        {
            try
            {

                PlanosColecao planosColecao = new PlanosColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable dataTablePlanos = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPlanosConsultar");
                foreach (DataRow linha in dataTablePlanos.Rows)
                {
                    Planos planos = new Planos();
                    planos.Cod_Plano = Convert.ToInt32(linha["Cod_Plano"]);
                    planos.Desc_Plano = Convert.ToString(linha["Desc_Plano"]);
                    planos.Valor = Convert.ToDecimal(linha["Valor"]);

                    planosColecao.Add(planos);
                }
                return planosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o plano de pagamento. Detalhes: " + ex.Message);
            }

        }

        public Planos ConsultarValor(int codPlano)
        {
            try
            {

                //PlanosColecao planosColecao = new PlanosColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Plano", codPlano);
                DataTable dataTablePlanos = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPlanosConsultarValor");
                Planos planos = new Planos();
                foreach (DataRow linha in dataTablePlanos.Rows)
                {                    
                    planos.Cod_Plano = Convert.ToInt32(linha["Cod_Plano"]);
                    planos.Valor = Convert.ToDecimal(linha["Valor"]);

                    //planosColecao.Add(planos);
                }
                return planos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o valor do plano de pagamento. Detalhes: " + ex.Message);
            }

        }

        public DTOPLanoEstudantilColecao ConsultarPorCodigo(int codPlano)
        {
            try
            {

                DTOPLanoEstudantilColecao planosColecao = new DTOPLanoEstudantilColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Plano", codPlano);
                DataTable dataTablePlanos = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPlanosConsultarPorCodigo");
                foreach (DataRow linha in dataTablePlanos.Rows)
                {
                    DTOPlanoEstudantil planos = new DTOPlanoEstudantil();
                    planos.Cod_Plano = Convert.ToInt32(linha["Cod_Plano"]);
                    planos.Desc_plano = Convert.ToString(linha["Desc_Plano"]);
                    planos.Valor = Convert.ToDecimal(linha["Valor"]);
                    planos.Extenso = Extenso.toExtenso(Convert.ToDecimal(linha["Valor"]), Extenso.TipoValorExtenso.Monetario); 
               
            
                    planosColecao.Add(planos);
                }
                return planosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o plano de pagamento. Detalhes: " + ex.Message);
            }

        }




    }
}
