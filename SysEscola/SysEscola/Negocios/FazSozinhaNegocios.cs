using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class FazSozinhaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(FazSozinha FazSozinha)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Desc_FazSozinha", FazSozinha.Desc_FazSozinha);
                string idElemento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterFazSozinha").ToString();
                return idElemento;
            }

            catch (Exception excessao)
            {
                return excessao.Message;
            }

        }

        public string Alterar(FazSozinha FazSozinha)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_FazSozinha", FazSozinha.Cod_FazSozinha);
                acessoDadosSqlServer.AdicionarParametros("@Desc_FazSozinha", FazSozinha.Desc_FazSozinha);
                string codElemento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterFazSozinha").ToString();
                return codElemento;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Excluir(FazSozinha FazSozinha)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_FazSozinha", FazSozinha.Cod_FazSozinha);
                string codElemento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterFazSozinha").ToString();
                return codElemento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public FazSozinhaColecao Consultar(String descFazSo)
        {
            try
            {
                FazSozinhaColecao habitosColecao = new FazSozinhaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Desc_FazSozinha", descFazSo);
                DataTable DataTableHabitos = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFazSozinhaConsultar");
                foreach (DataRow linha in DataTableHabitos.Rows)
                {
                    FazSozinha fazSozinha = new FazSozinha();
                    fazSozinha.Cod_FazSozinha = Convert.ToInt32(linha["Cod_FazSozinha"]);
                    fazSozinha.Desc_FazSozinha = Convert.ToString(linha["Desc_FazSozinha"]);
                    habitosColecao.Add(fazSozinha);
                }

                return habitosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar Faz Sozinha. Detalhes: " + ex.Message);
            }

        }

        public FazSozinhaColecao ConsultarRelatorio(int codAluno)
        {
            try
            {
                FazSozinhaColecao habitosColecao = new FazSozinhaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                DataTable DataTableHabitos = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFazSozinhaConsultarRelatorio");
                foreach (DataRow linha in DataTableHabitos.Rows)
                {
                    FazSozinha fazSozinha = new FazSozinha();
                    fazSozinha.Desc_FazSozinha = Convert.ToString(linha["Desc_FazSozinha"]);
                    habitosColecao.Add(fazSozinha);
                }

                return habitosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar Faz Sozinha. Detalhes: " + ex.Message);
            }

        }


    }
}
