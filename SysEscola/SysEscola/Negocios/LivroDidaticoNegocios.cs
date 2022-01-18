using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class LivroDidaticoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(LivroDidatico livroDidatico)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Livro", livroDidatico.Nome_Livro);
                acessoDadosSqlServer.AdicionarParametros("@Editora", livroDidatico.Editora);
                acessoDadosSqlServer.AdicionarParametros("@Autor", livroDidatico.Autor);
                acessoDadosSqlServer.AdicionarParametros("@Edicao", livroDidatico.Editora);
                acessoDadosSqlServer.AdicionarParametros("@Materia", livroDidatico.Materia);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Genero", livroDidatico.generosLiterarios.Cod_Genero);
                acessoDadosSqlServer.AdicionarParametros("@Emprestado", livroDidatico.Emprestado);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", livroDidatico.Ativo);
                acessoDadosSqlServer.AdicionarParametros("@Data_Cadastro", livroDidatico.Data_Cadastro);
                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterLivroDidatico").ToString();
                return idLancamento;
            }
            
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(LivroDidatico livroDidatico)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Livro", livroDidatico.Cod_Livro);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Livro", livroDidatico.Nome_Livro);
                acessoDadosSqlServer.AdicionarParametros("@Editora", livroDidatico.Editora);
                acessoDadosSqlServer.AdicionarParametros("@Autor", livroDidatico.Autor);
                acessoDadosSqlServer.AdicionarParametros("@Edicao", livroDidatico.Edicao);
                acessoDadosSqlServer.AdicionarParametros("@Materia", livroDidatico.Materia);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Genero", livroDidatico.generosLiterarios.Cod_Genero);
                acessoDadosSqlServer.AdicionarParametros("@Emprestado", livroDidatico.Emprestado);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", livroDidatico.Ativo);
                acessoDadosSqlServer.AdicionarParametros("@Data_Cadastro", livroDidatico.Data_Cadastro);
                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterLivroDidatico").ToString();
                return idLancamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string MarcarEmprestimo(LivroDidatico livroDidatico)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Livro", livroDidatico.Cod_Livro);
                acessoDadosSqlServer.AdicionarParametros("@Emprestado", 1);
                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMovimentarLivroDidatico").ToString();
                return idLancamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string desmarcarEmprestimo(LivroDidatico livroDidatico)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Livro", livroDidatico.Cod_Livro);
                acessoDadosSqlServer.AdicionarParametros("@Emprestado", 0);
                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMovimentarLivroDidatico").ToString();
                return idLancamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(LivroDidatico livroDidatico)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Livro", livroDidatico.Cod_Livro);
                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterLivroDidatico").ToString();
                return idLancamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public LivroDidaticoColecao ConsultarGrid(string nomeLivro)
        {
            try
            {

                LivroDidaticoColecao livroDidaticoColecaoGrid = new LivroDidaticoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome_Livro", nomeLivro);
                DataTable dataTableLivroDidatico = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspLivroDidaticoConsultar");
                foreach (DataRow linha in dataTableLivroDidatico.Rows)
                {
                    LivroDidatico livroDidaticoGrid = new LivroDidatico();
                    livroDidaticoGrid.Cod_Livro = Convert.ToInt32(linha["Cod_Livro"]);
                    livroDidaticoGrid.Nome_Livro = Convert.ToString(linha["Nome_Livro"]);
                    livroDidaticoGrid.Editora = Convert.ToString(linha["Editora"]);
                    livroDidaticoGrid.Autor = Convert.ToString(linha["Autor"]);
                    livroDidaticoGrid.Edicao = Convert.ToString(linha["Edicao"]);
                    livroDidaticoGrid.Materia = Convert.ToString(linha["Materia"]);
                    
                    livroDidaticoGrid.generosLiterarios = new GenerosLiterarios();
                    livroDidaticoGrid.generosLiterarios.Desc_Genero = Convert.ToString(linha["Desc_Genero"]);
                    
                    livroDidaticoGrid.Emprestado = Convert.ToBoolean(linha["Emprestado"]);
                    livroDidaticoGrid.Ativo = Convert.ToBoolean(linha["Ativo"]);
                    livroDidaticoGrid.Data_Cadastro = Convert.ToDateTime(linha["Data_Cadastro"]);
                    livroDidaticoColecaoGrid.Add(livroDidaticoGrid);
                }
                return livroDidaticoColecaoGrid;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados do livro. Detalhes: " + ex.Message);
            }

        }

        public LivroDidaticoColecao ConsultarCombo()
        {
            try
            {

                LivroDidaticoColecao livroDidaticoColecao = new LivroDidaticoColecao();
                DataTable dataTableLivroDidatico = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspLivroDidaticoConsultarCombo");
                foreach (DataRow linha in dataTableLivroDidatico.Rows)
                {
                    LivroDidatico livroDidatico = new LivroDidatico();
                    livroDidatico.Cod_Livro = Convert.ToInt32(linha["Cod_Livro"]);
                    livroDidatico.Nome_Livro = Convert.ToString(linha["Nome_Livro"]);
                    livroDidaticoColecao.Add(livroDidatico);
                }
                return livroDidaticoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados do livro. Detalhes: " + ex.Message);
            }

        }

        public LivroDidaticoColecao ConsultarCodigo(int codLivro)
        {
            try
            {

                LivroDidaticoColecao livroDidaticoColecao = new LivroDidaticoColecao();
                DataTable dataTableLivroDidatico = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspLivroDidaticoConsultarCodigo");
                foreach (DataRow linha in dataTableLivroDidatico.Rows)
                {
                    LivroDidatico livroDidaticoGrid = new LivroDidatico();
                    livroDidaticoGrid.Cod_Livro = Convert.ToInt32(linha["Cod_Livro"]);
                    livroDidaticoGrid.Nome_Livro = Convert.ToString(linha["Nome_Livro"]);
                    livroDidaticoGrid.Editora = Convert.ToString(linha["Editora"]);
                    livroDidaticoGrid.Autor = Convert.ToString(linha["Autor"]);
                    livroDidaticoGrid.Edicao = Convert.ToString(linha["Edicao"]);
                    livroDidaticoGrid.Materia = Convert.ToString(linha["Materia"]);

                    livroDidaticoGrid.generosLiterarios = new GenerosLiterarios();
                    livroDidaticoGrid.generosLiterarios.Desc_Genero = Convert.ToString(linha["Desc_Genero"]);

                    livroDidaticoGrid.Emprestado = Convert.ToBoolean(linha["Emprestado"]);
                    livroDidaticoGrid.Ativo = Convert.ToBoolean(linha["Ativo"]);
                    livroDidaticoGrid.Data_Cadastro = Convert.ToDateTime(linha["Data_Cadastro"]);
                    livroDidaticoColecao.Add(livroDidaticoGrid);
                }
                return livroDidaticoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados do livro. Detalhes: " + ex.Message);
            }
        }


    }
}
