using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class AlunoAfastamentoNegocios
    {
            AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

            public string Inserir(AlunoAfastamento alunoAfastamento)
            {
                try
                {
                    acessoDadosSqlServer.LimparParametros();
                    acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                    acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", alunoAfastamento.Cod_Aluno);
                    acessoDadosSqlServer.AdicionarParametros("@Cod_Item", alunoAfastamento.Cod_Item);
                    acessoDadosSqlServer.AdicionarParametros("@Data_Afastamento", alunoAfastamento.Data_Afastamento);
                    acessoDadosSqlServer.AdicionarParametros("@Motivo", alunoAfastamento.Motivo);
                    string idAfast = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterAlunoAfastamento").ToString();
                    return idAfast;
                }

                catch (Exception excessao)
                {
                    return excessao.Message;
                }

            }

            public string Alterar(AlunoAfastamento alunoAfastamento)
            {
                try
                {
                    acessoDadosSqlServer.LimparParametros();

                    acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                    acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", alunoAfastamento.Cod_Aluno);
                    acessoDadosSqlServer.AdicionarParametros("@Cod_Item", alunoAfastamento.Cod_Item);
                    acessoDadosSqlServer.AdicionarParametros("@Data_Afastamento", alunoAfastamento.Data_Afastamento);
                    acessoDadosSqlServer.AdicionarParametros("@Motivo", alunoAfastamento.Motivo);
                    string codAfast = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterAlunoAfastamento").ToString();
                    return codAfast;
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }

            }

            public string Excluir(AlunoAfastamento alunoAfastamento)
            {
                try
                {
                    acessoDadosSqlServer.LimparParametros();
                    acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                    acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", alunoAfastamento.Cod_Aluno);
                    acessoDadosSqlServer.AdicionarParametros("@Cod_Item", alunoAfastamento.Cod_Item);
                    string codAfast = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterAlunoAfastamento").ToString();
                    return codAfast;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }

            }

            public AlunoAfastamentoColecao Consultar(int CodAluno)
            {
                try
                {
                    AlunoAfastamentoColecao AlunoAfastColecao = new AlunoAfastamentoColecao();
                    acessoDadosSqlServer.LimparParametros();
                    acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", CodAluno);
                    DataTable DataTableAlunoAfast = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunoAfastamentoConsultar");
                    foreach (DataRow linha in DataTableAlunoAfast.Rows)
                    {
                        AlunoAfastamento AlunoAfast = new AlunoAfastamento();
                        AlunoAfast.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                        AlunoAfast.Cod_Item = Convert.ToInt32(linha["Cod_Item"]);
                        AlunoAfast.Data_Afastamento = Convert.ToDateTime(linha["Data_Afastamento"]);
                        AlunoAfast.Motivo = Convert.ToString(linha["Motivo"]);
                        AlunoAfastColecao.Add(AlunoAfast);
                    }

                    return AlunoAfastColecao;
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível consultar os afastamentos do aluno. Detalhes: " + ex.Message);
                }

            }

    }
}
