using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;


namespace Negocios
{
    public class TurmaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Turma turma)
        {

            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Turma", turma.Nome_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Ano_Letivo", turma.Ano_Letivo);
                acessoDadosSqlServer.AdicionarParametros("@Nr_Sala", turma.Nr_Sala);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Serie", turma.Cod_Serie);
                acessoDadosSqlServer.AdicionarParametros("@Observacao", turma.Observacao);
                acessoDadosSqlServer.AdicionarParametros("@Desativada", turma.Desativada);

                string idTurma = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterTurma").ToString();
                return idTurma;
            }
            catch (Exception excessao)
            {

                return excessao.Message;
            }

        }

        public string Alterar(Turma turma)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", turma.Cod_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Turma", turma.Nome_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Ano_Letivo", turma.Ano_Letivo);
                acessoDadosSqlServer.AdicionarParametros("@Nr_Sala", turma.Nr_Sala);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Serie", turma.Cod_Serie);
                acessoDadosSqlServer.AdicionarParametros("@Observacao", turma.Observacao);
                acessoDadosSqlServer.AdicionarParametros("@Desativada", turma.Desativada);

                string idTurma = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterTurma").ToString();
                return idTurma;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Excluir(Turma turma)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", turma.Cod_Turma);
                string cod_Turma = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterTurma").ToString();
                return cod_Turma;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public TurmaColecao ConsultarPorNome(string nomeTurma)
        {
            try
            {
                TurmaColecao turmaColecao = new TurmaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome_Turma", nomeTurma);
                DataTable datatableTurma = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaConsultarPorNome");
                foreach (DataRow linha in datatableTurma.Rows)
                {
                    Turma turma = new Turma();
                    turma.Cod_Turma = Convert.ToInt32(linha["Cod_Turma"]);
                    turma.Nome_Turma = Convert.ToString(linha["Nome_Turma"]);
                    turma.Ano_Letivo = Convert.ToString(linha["Ano_Letivo"]);
                    turma.Nr_Sala = Convert.ToString(linha["Nr_Sala"]);
                    turma.Cod_Serie = Convert.ToInt32(linha["Cod_Serie"]);
                    turma.Observacao = Convert.ToString(linha["Observacao"]);
                    turma.Desativada = Convert.ToBoolean(linha["Desativada"]);
                    turmaColecao.Add(turma);
                }

                return turmaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar as turmas. Detalhes: " + ex.Message);
            }
        }

        public TurmaColecao ConsultarCombo()
        {
            try
            {
                TurmaColecao turmaColecao = new TurmaColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable datatableTurma = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaConsultarCombo");
                foreach (DataRow linha in datatableTurma.Rows)
                {
                    Turma turma = new Turma();
                    turma.Cod_Turma = Convert.ToInt32(linha["Cod_Turma"]);
                    turma.Nome_Turma = Convert.ToString(linha["Nome_Turma"]);
                    turmaColecao.Add(turma);
                }

                return turmaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar as turmas. Detalhes: " + ex.Message);
            }
        }

        public TurmaColecao ConsultarComboRelatorio(int codAluno)
        {
            try
            {
                TurmaColecao turmaColecao = new TurmaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                DataTable datatableTurma = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaComboAlunoRelatorio");
                foreach (DataRow linha in datatableTurma.Rows)
                {
                    Turma turma = new Turma();
                    turma.Cod_Turma = Convert.ToInt32(linha["Cod_Turma"]);
                    turma.Nome_Turma = Convert.ToString(linha["Nome_Turma"]);
                    turma.Cod_Serie = Convert.ToInt32(linha["Cod_Serie"]);
                    turma.Ano_Letivo = Convert.ToString(linha["Ano_Letivo"]);
                    turmaColecao.Add(turma);
                }

                return turmaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar as turmas. Detalhes: " + ex.Message);
            }
        }

        public TurmaColecao ConsultarComboContrato(int codTurma)
        {
            try
            {
                TurmaColecao turmaColecao = new TurmaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", codTurma);
                DataTable datatableTurma = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaComboContrato");
                foreach (DataRow linha in datatableTurma.Rows)
                {
                    Turma turma = new Turma();
                    turma.Cod_Turma = Convert.ToInt32(linha["Cod_Turma"]);
                    turma.Ano_Letivo = Convert.ToString(linha["Ano_Letivo"]);
                    turmaColecao.Add(turma);
                }

                return turmaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar as turmas. Detalhes: " + ex.Message);
            }
        }

        public TurmaColecao ConsultarCompleto(int codTurma)
        {
            try
            {
                TurmaColecao turmaColecao = new TurmaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", codTurma);
                DataTable datatableTurma = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaConsultarDados");
                foreach (DataRow linha in datatableTurma.Rows)
                {
                    Turma turma = new Turma();
                    turma.Cod_Turma = Convert.ToInt32(linha["Cod_Turma"]);
                    turma.Nome_Turma = Convert.ToString(linha["Nome_Turma"]);
                    turma.Ano_Letivo = Convert.ToString(linha["Ano_Letivo"]);
                    turma.Nr_Sala = Convert.ToString(linha["Nr_Sala"]);
                    turma.Cod_Serie = Convert.ToInt32(linha["Cod_Serie"]);
                    turma.Observacao = Convert.ToString(linha["Observacao"]);
                    turma.Desativada = Convert.ToBoolean(linha["Desativada"]);

                    turmaColecao.Add(turma);
                }

                return turmaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar as turmas. Detalhes: " + ex.Message);
            }
        }

        public DTOTurmAlunoColecao ConsultarRelatorioTurma(int codTurma)
        {
            try
            {
                DTOTurmAlunoColecao dTOTurmAlunoColecao = new DTOTurmAlunoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", codTurma);
                DataTable datatableTurma = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunosPorTurmaRelatorio");
                foreach (DataRow linha in datatableTurma.Rows)
                {
                    DTOTurmAluno turma = new DTOTurmAluno();
                    turma.Cod_Turma = Convert.ToInt32(linha["Cod_Turma"]);
                    turma.Nome_Turma = Convert.ToString(linha["Nome_Turma"]);
                    turma.Ano_Letivo = Convert.ToString(linha["Ano_Letivo"]);
                    turma.Nr_Sala = Convert.ToString(linha["Nr_Sala"]);
                    turma.Nome_Serie = Convert.ToString(linha["Nome_serie"]);
                    turma.Nome_Aluno = Convert.ToString(linha["Nome_Aluno"]);
                    turma.Data_Nascto = Convert.ToDateTime(linha["Data_Nascto"]);
                    turma.Nome_Professor = Convert.ToString(linha["Nome_Professor"]);

                    dTOTurmAlunoColecao.Add(turma);
                }

                return dTOTurmAlunoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados. Detalhes: " + ex.Message);
            }
        }

    }
}
