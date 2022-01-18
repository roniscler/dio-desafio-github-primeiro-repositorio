using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


using AcessoDados;
using ObjetoTrasnferencia;
using System.Dynamic;

namespace Negocios
{
    public class EmprestimoLivroNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(EmprestimoLivro emprestimoLivro)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", emprestimoLivro.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Livro", emprestimoLivro.livroDidatico.Cod_Livro);
                acessoDadosSqlServer.AdicionarParametros("@Data_Emprestimo", emprestimoLivro.DataEmprestimo);
                acessoDadosSqlServer.AdicionarParametros("@Qtde_Dias", emprestimoLivro.QtdeDias);
                acessoDadosSqlServer.AdicionarParametros("@Data_Devolucao", emprestimoLivro.DataDevolucao);
                string idEmprestimo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEmprestimoLivro").ToString();
                return idEmprestimo;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(EmprestimoLivro emprestimoLivro)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Emprestimo", emprestimoLivro.Cod_Emprestimo);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", emprestimoLivro.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Livro", emprestimoLivro.livroDidatico.Cod_Livro);
                acessoDadosSqlServer.AdicionarParametros("@Data_Emprestimo", emprestimoLivro.DataEmprestimo);
                acessoDadosSqlServer.AdicionarParametros("@Qtde_Dias", emprestimoLivro.QtdeDias);
                acessoDadosSqlServer.AdicionarParametros("@Data_Devolucao", emprestimoLivro.DataDevolucao);

                string idEmprestimo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEmprestimoLivro").ToString();
                return idEmprestimo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string DatarDevolucao(EmprestimoLivro emprestimoLivro)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Emprestimo", emprestimoLivro.Cod_Emprestimo);
                acessoDadosSqlServer.AdicionarParametros("@Data_Devolucao", emprestimoLivro.DataDevolucao);
                string idEmprestimo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDatarDevolucaoLivroDidatico").ToString();
                return idEmprestimo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(EmprestimoLivro emprestimoLivro)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Empr", emprestimoLivro.Cod_Emprestimo);
                string idEmprestimo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEmprestimoLivro").ToString();
                return idEmprestimo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public EmprestimoLivroColecao Consultar(int codLivro)
        {
            try
            {
                EmprestimoLivroColecao emprestimoLivroColecao = new EmprestimoLivroColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Livro", codLivro);
                DataTable datatableFornecedor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEmprestimoLivroConsultar");
                foreach (DataRow linha in datatableFornecedor.Rows)
                {
                    EmprestimoLivro emprestimoLivro = new EmprestimoLivro();
                    emprestimoLivro.Cod_Emprestimo = Convert.ToInt32(linha["Cod_Emprestimo"]);

                    emprestimoLivro.aluno = new Aluno();
                    emprestimoLivro.aluno.Cod_Aluno= Convert.ToInt32(linha["Cod_Aluno"]);

                    emprestimoLivro.livroDidatico = new LivroDidatico();
                    emprestimoLivro.livroDidatico.Cod_Livro = Convert.ToInt32(linha["Cod_Livro"]);

                    emprestimoLivro.DataEmprestimo = Convert.ToDateTime(linha["Data_Emprestimo"]);
                    emprestimoLivro.QtdeDias = Convert.ToInt16(linha["QtdeDias"]);
                    emprestimoLivro.DataDevolucao = Convert.ToDateTime(linha["Data_Devolucao"]);
                    emprestimoLivroColecao.Add(emprestimoLivro);
                }

                return emprestimoLivroColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados de empréstimos deste livro. Detalhes: " + ex.Message);
            }

        }

        public EmprestimoLivroColecao ConsultarGrid(int codLivro)
        {
            try
            {
                EmprestimoLivroColecao emprestimoLivroColecaoGrid = new EmprestimoLivroColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Livro", codLivro);
                DataTable datatableEmprestimoLivro = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEmprestimoLivroConsultarGrid");
                foreach (DataRow linha in datatableEmprestimoLivro.Rows)
                {
                    EmprestimoLivro emprestimoLivroGird = new EmprestimoLivro();
                    emprestimoLivroGird.Cod_Emprestimo = Convert.ToInt32(linha["Cod_Emprestimo"]);

                    emprestimoLivroGird.aluno = new Aluno();
                    emprestimoLivroGird.aluno.Nome_Aluno = Convert.ToString(linha["Nome_Aluno"]);
                    emprestimoLivroGird.livroDidatico = new LivroDidatico();
                    emprestimoLivroGird.livroDidatico.Cod_Livro = Convert.ToInt32(linha["Cod_Livro"]);
                    emprestimoLivroGird.DataEmprestimo = Convert.ToDateTime(linha["Data_Emprestimo"]);
                    emprestimoLivroGird.QtdeDias = Convert.ToInt16(linha["QtdeDias"]);
                    if (linha["Data_Devolucao"] == null)
                    {
                        emprestimoLivroGird.DataDevolucao = Convert.ToDateTime(linha["DataDevolucao"]);
                    }
                    else
                    {
                        emprestimoLivroGird.DataDevolucao = null;

                    }
                    emprestimoLivroColecaoGrid.Add(emprestimoLivroGird);
                }

                return emprestimoLivroColecaoGrid;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados de empréstimos deste livro. Detalhes: " + ex.Message);
            }

        }

        public DataTable ConsultarGridDt(int codLivro)
        {
            try
            {
                EmprestimoLivroColecao emprestimoLivroColecaoGrid = new EmprestimoLivroColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Livro", codLivro);
                DataTable datatableEmprestimoLivro = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEmprestimoLivroConsultarGrid");
                
                return datatableEmprestimoLivro;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados de empréstimos deste livro. Detalhes: " + ex.Message);
            }

        }

    }
}
