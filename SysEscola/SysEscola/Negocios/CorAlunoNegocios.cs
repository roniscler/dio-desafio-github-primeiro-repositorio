using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;


namespace Negocios
{
    public class CorAlunoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
 
        public string Inserir(CorAluno corAluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao",1);
                acessoDadosSqlServer.AdicionarParametros("@Desc_CorAluno", corAluno.Desc_CorAluno);
                string idCorAluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCorAluno").ToString();
                return idCorAluno;
            }

            catch (Exception excessao)
            {
                return excessao.Message;
            }

        }

        public string Alterar(CorAluno corAluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_CorAluno", corAluno.Cod_CorAluno);
                acessoDadosSqlServer.AdicionarParametros("@Desc_CorAluno", corAluno.Desc_CorAluno);
                string IdCorAluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCorAluno").ToString();
                return IdCorAluno;
            }
            catch (Exception ex)
            {
                
                return ex.Message;
            }

        }

        public string Excluir(CorAluno corAluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_CorAluno", corAluno.Cod_CorAluno);
                string Cod_CorAluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCorAluno").ToString();
                return Cod_CorAluno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public CorAlunoColecao Consultar()
        {
            try
            {
                CorAlunoColecao corAlunoColecao = new CorAlunoColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable DataTableCorAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCorAlunoConsultar");
                foreach (DataRow linha in DataTableCorAluno.Rows)
                {
                    CorAluno corAluno = new CorAluno();
                    corAluno.Cod_CorAluno = Convert.ToInt32(linha["Cod_CorAluno"]);
                    corAluno.Desc_CorAluno = Convert.ToString(linha["Desc_CorAluno"]);
                    corAlunoColecao.Add(corAluno);
                }

                return corAlunoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a Cor do Aluno. Detalhes: " + ex.Message);
            }

        }

    }

}
