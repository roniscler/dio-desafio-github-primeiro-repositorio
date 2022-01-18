using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;

namespace Negocios
{
    public class EloAlunoTurmaNegocios
    {

        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Excluir(EloAlunoTurma eloAlunoTurma)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", eloAlunoTurma.Cod_Item);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", eloAlunoTurma.turma.Cod_Turma);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloAlunoTurma").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Inserir(EloAlunoTurma eloAlunoTurma)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloAlunoTurma.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", eloAlunoTurma.turma.Cod_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", eloAlunoTurma.Cod_Item);
                acessoDadosSqlServer.AdicionarParametros("@Data_Matricula", eloAlunoTurma.Data_Matricula);

                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloAlunoTurma").ToString();
                return CodElo;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(EloAlunoTurma eloAlunoTurma)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloAlunoTurma.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", eloAlunoTurma.turma.Cod_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", eloAlunoTurma.Cod_Item);
                acessoDadosSqlServer.AdicionarParametros("@Data_Matricula", eloAlunoTurma.Data_Matricula);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloAlunoTurma").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public EloAlunoTurmaColecao ConsultarGrid(int Cod_Turma)
        {
            try
            {
                EloAlunoTurmaColecao eloAlunoTurmaColecaoGrid = new EloAlunoTurmaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", Cod_Turma);
                DataTable dataTableEloAlunoTurma = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEloAlunoTurmaConsultar");


                foreach (DataRow linha in dataTableEloAlunoTurma.Rows)
                {
                    EloAlunoTurma eloAlunoTurma = new EloAlunoTurma();
                    eloAlunoTurma.aluno = new Aluno();
                    eloAlunoTurma.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    eloAlunoTurma.aluno.Nome_Aluno = Convert.ToString(linha["Nome_Aluno"]);
                    eloAlunoTurma.turma = new Turma();
                    eloAlunoTurma.turma.Cod_Turma = Convert.ToInt32(linha["Cod_Turma"]);
                    eloAlunoTurma.Cod_Item = Convert.ToInt16(linha["Cod_Item"]);
                    eloAlunoTurma.Data_Matricula = Convert.ToDateTime(linha["Data_Matricula"]);
                    eloAlunoTurmaColecaoGrid.Add(eloAlunoTurma);


                }

                return eloAlunoTurmaColecaoGrid;
            }


            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os alunos desta turma. Detalhes: " + ex.Message);
            }

        }

        public DTOEloAlunoTurmaColecao ConsultarRelatorioTurma(int Cod_Turma)
        {
            try
            {
                DTOEloAlunoTurmaColecao dTOEloAlunoTurmaColecao = new DTOEloAlunoTurmaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", Cod_Turma);
                DataTable dataTableDTOEloAlunoTurmaColecao = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEloAlunoTurmaConsultar");


                foreach (DataRow linha in dataTableDTOEloAlunoTurmaColecao.Rows)
                {
                    DTOEloAlunoTurma dTOEloAlunoTurma = new DTOEloAlunoTurma();
                    
                    dTOEloAlunoTurma.Nome_Aluno = Convert.ToString(linha["Nome_Aluno"]);
                    dTOEloAlunoTurma.Data_Nascto = Convert.ToDateTime(linha["Data_Nascto"]);
                    dTOEloAlunoTurmaColecao.Add(dTOEloAlunoTurma);


                }

                return dTOEloAlunoTurmaColecao;
            }


            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os alunos desta turma. Detalhes: " + ex.Message);
            }

        }

    }
}
