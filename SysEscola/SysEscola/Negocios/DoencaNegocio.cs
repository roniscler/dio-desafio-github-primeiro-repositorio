using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessoDados;
using ObjetoTrasnferencia;
using System.Data;

namespace Negocios
{
    public class DoencaNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Doenca doenca)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Nome_doenca", doenca.Nome_Doenca);
                string idDoenca = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterDoenca").ToString();
                return idDoenca;
            }

            catch (Exception excessao)
            {
                return excessao.Message;
            }

        }

        public string Alterar(Doenca doenca)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Doenca", doenca.Cod_Doenca);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Doenca", doenca.Nome_Doenca);
                string IdDoenca = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterDoenca").ToString();
                return IdDoenca;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public DoencaColecao Consultar()
        {
            try
            {
                DoencaColecao doencaColecao = new DoencaColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable DataTableDoenca = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDoencaConsultar");
                foreach (DataRow linha in DataTableDoenca.Rows)
                {
                    Doenca doenca = new Doenca();
                    doenca.Cod_Doenca = Convert.ToInt32(linha["Cod_Doenca"]);
                    doenca.Nome_Doenca = Convert.ToString(linha["Nome_Doenca"]);
                    doencaColecao.Add(doenca);
                }

                return doencaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a doença. Detalhes: " + ex.Message);
            }

        }

        public string Excluir(Doenca doenca)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Doenca", doenca.Cod_Doenca);
                string Cod_Doenca = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterDoenca").ToString();
                return Cod_Doenca;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public DoencaColecao ConsultarGrid(String nomeDoenca)
        {
            try
            {
                DoencaColecao doencaColecao = new DoencaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome_doenca", nomeDoenca);
                DataTable DataTableDoenca = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDoencaConsultarGird");
                foreach (DataRow linha in DataTableDoenca.Rows)
                {
                    Doenca doenca = new Doenca();
                    doenca.Cod_Doenca = Convert.ToInt32(linha["Cod_Doenca"]);
                    doenca.Nome_Doenca = Convert.ToString(linha["Nome_Doenca"]);
                    doencaColecao.Add(doenca);
                }

                return doencaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a doença. Detalhes: " + ex.Message);
            }

        }

        public DoencaColecao ConsultarRelatorio(int codAluno)
        {
            try
            {
                DoencaColecao doencaColecao = new DoencaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                DataTable DataTableDoenca = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDoencaConsultarRelatorio");
                foreach (DataRow linha in DataTableDoenca.Rows)
                {
                    Doenca doenca = new Doenca();
                    doenca.Nome_Doenca = Convert.ToString(linha["Nome_Doenca"]);
                    doencaColecao.Add(doenca);
                }

                return doencaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a doença. Detalhes: " + ex.Message);
            }

        }

    }
}
