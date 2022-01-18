using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;


namespace Negocios
{
    public class HabitosNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Habito habitos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Habito", habitos.Desc_Habito);
                string idHabito = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterHabitos").ToString();
                return idHabito;
            }

            catch (Exception excessao)
            {
                return excessao.Message;
            }

        }

        public string Alterar(Habito habitos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Habito", habitos.Cod_Habito);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Habito", habitos.Desc_Habito);
                string codHabito = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterHabitos").ToString();
                return codHabito;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Excluir(Habito habitos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Habito", habitos.Cod_Habito);
                string codHabito = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterHabitos").ToString();
                return codHabito;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public HabitoColecao Consultar(String descHabito)
        {
            try
            {
                HabitoColecao habitosColecao = new HabitoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Desc_Habito", descHabito);
                DataTable DataTableHabitos = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspHabitosConsultar");
                foreach (DataRow linha in DataTableHabitos.Rows)
                {
                    Habito habitos = new Habito();
                    habitos.Cod_Habito = Convert.ToInt32(linha["Cod_Habito"]);
                    habitos.Desc_Habito= Convert.ToString(linha["Desc_Habito"]);
                    habitosColecao.Add(habitos);
                }

                return habitosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os hábitos do aluno. Detalhes: " + ex.Message);
            }

        }

        public HabitoColecao ConsultarRelatorio(int codAluno)
        {
            try
            {
                HabitoColecao habitosColecao = new HabitoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                DataTable DataTableHabitos = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspHabitosConsultarRelatorio");
                foreach (DataRow linha in DataTableHabitos.Rows)
                {
                    Habito habitos = new Habito();
                    habitos.Desc_Habito = Convert.ToString(linha["Desc_Habito"]);
                    habitosColecao.Add(habitos);
                }

                return habitosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os hábitos do aluno. Detalhes: " + ex.Message);
            }

        }

    }
}
