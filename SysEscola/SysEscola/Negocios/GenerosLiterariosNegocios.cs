using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;

namespace Negocios
{
    public class GenerosLiterariosNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(GenerosLiterarios generosLiterarios)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Genero", generosLiterarios.Desc_Genero);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterGeneroLiterario").ToString();
                return idItem;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(GenerosLiterarios generosLiterarios)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Genero", generosLiterarios.Cod_Genero);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Genero", generosLiterarios.Desc_Genero);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterGeneroLiterario").ToString();
                return idItem;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(GenerosLiterarios generosLiterarios)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Genero", generosLiterarios.Cod_Genero);
                string idItem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterGeneroLiterario").ToString();
                return idItem;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public GenerosLiterariosColecao Consultar(string nomeItem)
        {
            try
            {
                GenerosLiterariosColecao generosLiterariosColecao = new GenerosLiterariosColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Desc_Genero", nomeItem);
                DataTable DataTableItens = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspGeneroLiterarioConsultar");
                foreach (DataRow linha in DataTableItens.Rows)
                {
                    GenerosLiterarios generosLiterarios = new GenerosLiterarios();
                    generosLiterarios.Cod_Genero = Convert.ToInt32(linha["Cod_Genero"]);
                    generosLiterarios.Desc_Genero = Convert.ToString(linha["Desc_Genero"]);
                    generosLiterariosColecao.Add(generosLiterarios);
                }

                return generosLiterariosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os Gêneros Literarios: " + ex.Message);
            }

        }

        public GenerosLiterariosColecao ConsultarCombo()
        {
            try
            {
                GenerosLiterariosColecao generosLiterariosColecao = new GenerosLiterariosColecao();
                DataTable DataTableItens = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspGeneroLiterarioConsultarCombo");
                foreach (DataRow linha in DataTableItens.Rows)
                {
                    GenerosLiterarios generosLiterarios = new GenerosLiterarios();
                    generosLiterarios.Cod_Genero = Convert.ToInt32(linha["Cod_Genero"]);
                    generosLiterarios.Desc_Genero = Convert.ToString(linha["Desc_Genero"]);
                    generosLiterariosColecao.Add(generosLiterarios);
                }

                return generosLiterariosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os Gêneros Literarios: " + ex.Message);
            }

        }


    }
}
