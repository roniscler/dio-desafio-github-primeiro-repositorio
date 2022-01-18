using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class LancamentoConceitoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(LancamentoConceito lancamentoConceito)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", lancamentoConceito.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_turma", lancamentoConceito.turma.Cod_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Cod_SI_Aval_Pedag", lancamentoConceito.subItensAvaliacaoPedagogica.Cod_SI_Aval_Pedag);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Bim", lancamentoConceito.bimestres.Cod_Bimestre);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Conceito", lancamentoConceito.tipoConceito.Cod_Conceito);
                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterLancamentoConceitos").ToString();
                return idLancamento;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(LancamentoConceito lancamentoConceito)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Lancamento", lancamentoConceito.Cod_Lancamento);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", lancamentoConceito.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_turma", lancamentoConceito.turma.Cod_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Cod_SI_Aval_Pedag", lancamentoConceito.subItensAvaliacaoPedagogica.Cod_SI_Aval_Pedag);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Bim", lancamentoConceito.bimestres.Cod_Bimestre);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Conceito", lancamentoConceito.tipoConceito.Cod_Conceito);
                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterLancamentoConceitos").ToString();
                return idLancamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(LancamentoConceito lancamentoConceito)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Lancamento", lancamentoConceito.Cod_Lancamento);
                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterLancamentoConceitos").ToString();
                return idLancamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public LancamentoConceitoColecao ConsultarGrid(int codAluno, int codTurma)
        {
            try
            {

                LancamentoConceitoColecao lancamentoConceitoColecaoGrid = new LancamentoConceitoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", codTurma);

                DataTable dataTableLancamentoConceito = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspLancamentoConceitoConsultarGrid");
                foreach (DataRow linha in dataTableLancamentoConceito.Rows)
                {
                    LancamentoConceito lancamentoConceitoGrid = new LancamentoConceito();
                    lancamentoConceitoGrid.Cod_Lancamento = Convert.ToInt32(linha["Cod_Lancamento"]);

                    lancamentoConceitoGrid.aluno = new Aluno();
                    lancamentoConceitoGrid.aluno.Nome_Aluno = Convert.ToString(linha["Nome_Aluno"]);

                    lancamentoConceitoGrid.turma = new Turma(); 
                    lancamentoConceitoGrid.turma.Nome_Turma = Convert.ToString(linha["Nome_Turma"]);

                    lancamentoConceitoGrid.subItensAvaliacaoPedagogica = new SubItensAvaliacaoPedagogica();
                    lancamentoConceitoGrid.subItensAvaliacaoPedagogica.Desc_SI_Aval_Pedag = Convert.ToString(linha["Desc_SI_Aval_Pedag"]);

                    lancamentoConceitoGrid.bimestres = new Bimestres();
                    lancamentoConceitoGrid.bimestres.Nome_Bim = Convert.ToString(linha["Nome_Bimestre"]);

                    lancamentoConceitoGrid.tipoConceito = new TipoConceito();
                    lancamentoConceitoGrid.tipoConceito.Desc_Conceito = Convert.ToString(linha["Desc_Conceito"]);
                    
                    lancamentoConceitoColecaoGrid.Add(lancamentoConceitoGrid);
                }
                return lancamentoConceitoColecaoGrid;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o conceito. Detalhes: " + ex.Message);
            }

        }


    }
}
