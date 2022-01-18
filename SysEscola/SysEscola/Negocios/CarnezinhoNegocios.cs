using ObjetoTrasnferencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessoDados;
using System.Data;

namespace Negocios
{
    public class CarnezinhoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Carnezinho carnezinho)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Parcela", carnezinho.Parcela);
                acessoDadosSqlServer.AdicionarParametros("@Data_Vcto", carnezinho.Data_Vcto);
                acessoDadosSqlServer.AdicionarParametros("@Valor", carnezinho.Valor);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", carnezinho.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Titulo", carnezinho.Titulo);
                string idCarnezinho = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCarnezinho").ToString();
                return idCarnezinho;
            }

            catch (Exception excessao)
            {
                return excessao.Message;
            }

        }

        public string Alterar(Carnezinho carnezinho)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Parcela", carnezinho.Parcela);
                acessoDadosSqlServer.AdicionarParametros("@Data_Vcto", carnezinho.Data_Vcto);
                acessoDadosSqlServer.AdicionarParametros("@Valor", carnezinho.Valor);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", carnezinho.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Titulo", carnezinho.Titulo);
                string idCarnezinho = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCarnezinho").ToString();
                return idCarnezinho;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public CarnezinhoColecao ConsultarPorAlunoTitulo(int CodAluno, string Titulo)
        {
            try
            {
                CarnezinhoColecao carnezinhoColecao = new CarnezinhoColecao();
                
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", CodAluno);
                acessoDadosSqlServer.AdicionarParametros("@Titulo", Titulo);

                DataTable DataTableCarnezinho = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCarnezinhoConsultarPorAlunoeTitulo");
                foreach (DataRow linha in DataTableCarnezinho.Rows)
                {
                    Carnezinho carnezinho = new Carnezinho();
                    carnezinho.Cod_Coarnezinho = Convert.ToInt32(linha["Cod_Carnezinho"]);
                    carnezinho.Parcela = Convert.ToString(linha["Parcela"]);
                    carnezinho.Data_Vcto = Convert.ToDateTime(linha["Data_Vcto"]);
                    carnezinho.Valor = Convert.ToDecimal(linha["Valor"]);
                    carnezinho.aluno = new Aluno();
                    carnezinho.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    carnezinho.Titulo = Convert.ToString(linha["Titulo"]);
                    carnezinhoColecao.Add(carnezinho);
                }

                return carnezinhoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados. Detalhes: " + ex.Message);
            }

        }

        public CarnezinhoColecao ConsultarPorTitulo(string Titulo)
        {
            try
            {
                CarnezinhoColecao carnezinhoColecao = new CarnezinhoColecao();
                
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Titulo", Titulo);

                DataTable DataTableCarnezinho = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCarnezinhoConsultarPorTitulo");
                foreach (DataRow linha in DataTableCarnezinho.Rows)
                {
                    Carnezinho carnezinho = new Carnezinho();
                    carnezinho.Cod_Coarnezinho = Convert.ToInt32(linha["Cod_Carnezinho"]);
                    carnezinho.Parcela = Convert.ToString(linha["Parcela"]);
                    carnezinho.Data_Vcto = Convert.ToDateTime(linha["Data_Vcto"]);
                    carnezinho.Valor = Convert.ToDecimal(linha["Valor"]);
                    carnezinho.aluno = new Aluno();
                    carnezinho.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    carnezinho.Titulo = Convert.ToString(linha["Titulo"]);
                    carnezinhoColecao.Add(carnezinho);
                }

                return carnezinhoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados. Detalhes: " + ex.Message);
            }

        }

        public CarnezinhoColecao ConsultarPorCodigo(int CodCarnezinho)
        {
            try
            {
                CarnezinhoColecao carnezinhoColecao = new CarnezinhoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Carnezinho", CodCarnezinho);
                
                DataTable DataTableCarnezinho = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCarnezinhoConsultarPorCodigo");
                foreach (DataRow linha in DataTableCarnezinho.Rows)
                {
                    Carnezinho carnezinho = new Carnezinho();
                    carnezinho.Cod_Coarnezinho = Convert.ToInt32(linha["Cod_Carnezinho"]);
                    carnezinho.Parcela = Convert.ToString(linha["Parcela"]);
                    carnezinho.Data_Vcto = Convert.ToDateTime(linha["Data_Vcto"]);
                    carnezinho.Valor = Convert.ToDecimal(linha["Valor"]);
                    carnezinho.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    carnezinho.Titulo = Convert.ToString(linha["Titulo"]);
                    carnezinhoColecao.Add(carnezinho);
                }

                return carnezinhoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados. Detalhes: " + ex.Message);
            }

        }

        public string Excluir(Carnezinho carnezinho)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Carnezinho", carnezinho.Cod_Coarnezinho);
                string Cod_Carnet = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCarnezinho").ToString();
                return Cod_Carnet;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string ExcluirPorAlunoTitulo(Int32 codigo, string nome)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 3);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Titulo", nome);

                string Cod_Aluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCarnezinho").ToString();
                return Cod_Aluno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string ExcluirTodos()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 4);
                string Cod_Carnet = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCarnezinho").ToString();
                return Cod_Carnet;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string ConsultarExistenciaTitulo(string Titulo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Titulo", Titulo);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCarnezinhoConsultarQtdeRegistrosPorAssunto").ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


                
            
        }

        public CarnezinhoColecao ConsultarTitulo(string Titulo)
        {
            try
            {
                CarnezinhoColecao carnezinhoColecao = new CarnezinhoColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Titulo", Titulo);

                DataTable DataTableCarnezinho = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCarnezinhoConsultarMensalidade");
                foreach (DataRow linha in DataTableCarnezinho.Rows)
                {
                    Carnezinho carnezinho = new Carnezinho();
                    carnezinho.Cod_Coarnezinho = Convert.ToInt32(linha["Cod_Carnezinho"]);
                    carnezinho.Parcela = Convert.ToString(linha["Parcela"]);
                    carnezinho.Data_Vcto = Convert.ToDateTime(linha["Data_Vcto"]);
                    carnezinho.Valor = Convert.ToDecimal(linha["Valor"]);
                    carnezinho.aluno = new Aluno();
                    carnezinho.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    carnezinho.aluno.Nome_Aluno = Convert.ToString(linha["Nome_Aluno"]);
                    carnezinho.Titulo = Convert.ToString(linha["Titulo"]);
                    carnezinhoColecao.Add(carnezinho);
                }

                return carnezinhoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados. Detalhes: " + ex.Message);
            }

        }

        public CarnezinhoColecao ConsultarPorTituloAgrupado()
        {
            try
            {
                CarnezinhoColecao carnezinhoColecao = new CarnezinhoColecao();

                acessoDadosSqlServer.LimparParametros();

                DataTable DataTableCarnezinho = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCarnezinhoConsultarPorTituloAgrupado");
                foreach (DataRow linha in DataTableCarnezinho.Rows)
                {
                    Carnezinho carnezinho = new Carnezinho();
                    carnezinho.Titulo = Convert.ToString(linha["Titulo"]);
                    carnezinhoColecao.Add(carnezinho);
                }

                return carnezinhoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados. Detalhes: " + ex.Message);
            }

        }


    }
}
