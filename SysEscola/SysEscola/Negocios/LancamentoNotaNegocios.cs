using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class LancamentoNotaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(LancamentoNota lancamentoNota)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", lancamentoNota.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_turma", lancamentoNota.turma.Cod_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Materia", lancamentoNota.materia.Cod_Materia);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Bim", lancamentoNota.bimestres.Cod_Bimestre);
                acessoDadosSqlServer.AdicionarParametros("@Nota", lancamentoNota.Nota);
                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterLancamentoNotas").ToString();
                return idLancamento;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(LancamentoNota lancamentoNota)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Lancamento", lancamentoNota.Cod_Lancamento);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", lancamentoNota.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_turma", lancamentoNota.turma.Cod_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Materia", lancamentoNota.materia.Cod_Materia);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Bim", lancamentoNota.bimestres.Cod_Bimestre);
                acessoDadosSqlServer.AdicionarParametros("@Nota", lancamentoNota.Nota);
                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterLancamentoNotas").ToString();
                return idLancamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(LancamentoNota lancamentoNota)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Lancamento", lancamentoNota.Cod_Lancamento);
                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterLancamentoNotas").ToString();
                return idLancamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public LancamentoNotaColecao ConsultarGrid(int codAluno, int codTurma)
        {
            try
            {

                LancamentoNotaColecao lancamentoNotaColecaoGrid = new LancamentoNotaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", codTurma);


                DataTable dataTableLancamentoNota = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspLancamentoNotaConsultarGrid");
                foreach (DataRow linha in dataTableLancamentoNota.Rows)
                {
                    LancamentoNota lancamentoNotaGrid = new LancamentoNota();
                    lancamentoNotaGrid.Cod_Lancamento = Convert.ToInt32(linha["Cod_Lancamento"]);

                    lancamentoNotaGrid.aluno = new Aluno();
                    lancamentoNotaGrid.aluno.Nome_Aluno = Convert.ToString(linha["Nome_Aluno"]);

                    lancamentoNotaGrid.turma = new Turma();
                    lancamentoNotaGrid.turma.Nome_Turma = Convert.ToString(linha["Nome_Turma"]);

                    lancamentoNotaGrid.materia = new Materia();
                    lancamentoNotaGrid.materia.Nome_Materia = Convert.ToString(linha["Nome_Materia"]);

                    lancamentoNotaGrid.bimestres = new Bimestres();
                    lancamentoNotaGrid.bimestres.Nome_Bim = Convert.ToString(linha["Nome_Bimestre"]);
                    
                    lancamentoNotaGrid.Nota = Convert.ToDecimal(linha["Nota"]);
                    lancamentoNotaColecaoGrid.Add(lancamentoNotaGrid);
                }
                return lancamentoNotaColecaoGrid;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a Matéria. Detalhes: " + ex.Message);
            }

        }

    }
}
