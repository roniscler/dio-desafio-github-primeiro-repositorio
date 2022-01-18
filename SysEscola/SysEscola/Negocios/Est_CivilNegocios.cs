using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;

namespace Negocios
{
    public class Est_CivilNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(EstadoCivil est_Civil)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Desc_EstadoCivil", est_Civil.Desc_EstadoCivil);
                string idElemento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEstado_Civil").ToString();
                return idElemento;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(EstadoCivil est_Civil)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_EstadoCivil", est_Civil.Cod_EstadoCivil);
                acessoDadosSqlServer.AdicionarParametros("@Desc_EstadoCivil", est_Civil.Desc_EstadoCivil);
                string idElemento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEstado_Civil").ToString();
                return idElemento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(EstadoCivil est_Civil)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_EstadoCivil", est_Civil.Cod_EstadoCivil);
                string idElemento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEstado_Civil").ToString();
                return idElemento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        
        public EstadoCivilColecao Consultar()
        {
            try
            {

                EstadoCivilColecao EstCivilColecao = new EstadoCivilColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable dataTableEstCivil = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEstadoCivilConsultar");
                foreach (DataRow linha in dataTableEstCivil.Rows)
                {
                    EstadoCivil Est_Civil = new EstadoCivil();
                    Est_Civil.Cod_EstadoCivil = Convert.ToInt32(linha["Cod_EstadoCivil"]);
                    Est_Civil.Desc_EstadoCivil = Convert.ToString(linha["Desc_EstadoCivil"]);
                    EstCivilColecao.Add(Est_Civil);
                }
                return EstCivilColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o Estado Civil. Detalhes: " + ex.Message);
            }

        }
        
    }
}
