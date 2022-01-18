using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class EloTurmaProfessorNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Excluir(EloTurmaProfessor eloTurmaProfessor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", eloTurmaProfessor.turma.Cod_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", eloTurmaProfessor.Cod_Item);

                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloTurmaProfessor").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Inserir(EloTurmaProfessor eloTurmaProfessor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", eloTurmaProfessor.professor.Cod_Professor);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", eloTurmaProfessor.turma.Cod_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", eloTurmaProfessor.Cod_Item);
                acessoDadosSqlServer.AdicionarParametros("@DataEntrada", eloTurmaProfessor.DataEntrada);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloTurmaProfessor").ToString();
                return CodElo;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(EloTurmaProfessor eloTurmaProfessor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", eloTurmaProfessor.professor.Cod_Professor);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", eloTurmaProfessor.turma.Cod_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", eloTurmaProfessor.Cod_Item);
                acessoDadosSqlServer.AdicionarParametros("@DataEntrada", eloTurmaProfessor.DataEntrada);

                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloTurmaProfessor").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public EloTurmaProfessorColecao ConsultarGrid(int Cod_Turma)
        {
            try
            {
                EloTurmaProfessorColecao eloTurmaProfessorColecaoGrid = new EloTurmaProfessorColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", Cod_Turma);
                DataTable dataTableeloTurmaProfessor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEloTurmaProfessorConsultar");


                foreach (DataRow linha in dataTableeloTurmaProfessor.Rows)
                {
                    EloTurmaProfessor eloTurmaProfessorGrid = new EloTurmaProfessor();
                    eloTurmaProfessorGrid.turma = new Turma();
                    eloTurmaProfessorGrid.turma.Cod_Turma = Convert.ToInt32(linha["Cod_Turma"]);
                    eloTurmaProfessorGrid.professor = new Professor();
                    eloTurmaProfessorGrid.professor.Cod_Professor = Convert.ToInt32(linha["Cod_Professor"]);
                    eloTurmaProfessorGrid.professor.Nome_Professor = Convert.ToString(linha["Nome_Professor"]);
                    eloTurmaProfessorGrid.Cod_Item = Convert.ToInt16(linha["Cod_Item"]);
                    eloTurmaProfessorGrid.DataEntrada = Convert.ToDateTime(linha["DataEntrada"]);

                    eloTurmaProfessorColecaoGrid.Add(eloTurmaProfessorGrid);
                }

                return eloTurmaProfessorColecaoGrid;
            }


            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os professores desta turma. Detalhes: " + ex.Message);
            }

        }

        public DTOEloTurmaProfessorColecao ConsultarRelatorioTurmas(int Cod_Turma)
        {
            try
            {
                DTOEloTurmaProfessorColecao dTOEloAlunoTurmaProfessorColecao = new DTOEloTurmaProfessorColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", Cod_Turma);
                DataTable dataTableDTOEloAlunoTurmaProfessorColecao = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEloTurmaProfessorConsultarRelatorioTurmas");


                foreach (DataRow linha in dataTableDTOEloAlunoTurmaProfessorColecao.Rows)
                {
                    DTOEloTurmaProfessor dTOEloAlunoTurmaProfessor = new DTOEloTurmaProfessor();
                    dTOEloAlunoTurmaProfessor.Cod_Professor = Convert.ToInt32(linha["Cod_Professor"]);
                    dTOEloAlunoTurmaProfessor.Nome_Professor = Convert.ToString(linha["Nome_Professor"]);

                    dTOEloAlunoTurmaProfessorColecao.Add(dTOEloAlunoTurmaProfessor);
                }

                return dTOEloAlunoTurmaProfessorColecao;
            }


            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o professor desta turma. Detalhes: " + ex.Message);
            }

        }

    }
}
