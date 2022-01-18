using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessoDados;
using ObjetoTrasnferencia;
using System.Data;


namespace Negocios
{
    public class MensalidadeNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Mensalidade mensalidade)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", mensalidade.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_turma", mensalidade.turma.Cod_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Num_Mensalidade", mensalidade.Num_Mensalidade);
                acessoDadosSqlServer.AdicionarParametros("@Valor", mensalidade.Valor);
                acessoDadosSqlServer.AdicionarParametros("@DataVencimento", mensalidade.DataVencimento);
                acessoDadosSqlServer.AdicionarParametros("@ValorJuros", mensalidade.ValorJuros);
                acessoDadosSqlServer.AdicionarParametros("ValorMulta", mensalidade.ValorMulta);

                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterMensalidade").ToString();
                return idLancamento;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(Mensalidade mensalidade)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Mensalidade", mensalidade.Cod_Mensalidade);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", mensalidade.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_turma", mensalidade.turma.Cod_Turma);
                acessoDadosSqlServer.AdicionarParametros("@Num_Mensalidade", mensalidade.Num_Mensalidade);
                acessoDadosSqlServer.AdicionarParametros("@Valor", mensalidade.Valor);
                acessoDadosSqlServer.AdicionarParametros("@DataVencimento", mensalidade.DataVencimento);
                acessoDadosSqlServer.AdicionarParametros("@ValorJuros", mensalidade.ValorJuros);
                acessoDadosSqlServer.AdicionarParametros("ValorMulta", mensalidade.ValorMulta);
                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterMensalidade").ToString();
                return idLancamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(Mensalidade mensalidade)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Mensalidade", mensalidade.Cod_Mensalidade);

                string idLancamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterMensalidade").ToString();
                return idLancamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public MensalidadeColecao ConsultarGrid(int codAluno, int codTumra)
        {
            try
            {
                MensalidadeColecao mensalidadeColecaoGrid = new MensalidadeColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", codTumra);
                DataTable datatableMensalidade = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspMensalidadeConsultar");
                foreach (DataRow linha in datatableMensalidade.Rows)
                {
                    Mensalidade mensalidade = new Mensalidade();

                    mensalidade.Cod_Mensalidade = Convert.ToInt32(linha["Cod_Mensalidade"]);
                    mensalidade.turma = new Turma();
                    mensalidade.turma.Cod_Turma = Convert.ToInt32(linha["Cod_Turma"]);

                    mensalidade.aluno = new Aluno();
                    mensalidade.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    
                    mensalidade.Num_Mensalidade = Convert.ToString(linha["Num_Mensalidade"]);
                    mensalidade.Valor = Convert.ToDecimal(linha["Valor"]);
                    mensalidade.DataVencimento = Convert.ToDateTime(linha["DataVencimento"]);
                    mensalidade.ValorJuros = Convert.ToDecimal(linha["ValorJuros"]);
                    mensalidade.ValorMulta = Convert.ToDecimal(linha["ValorMulta"]);
                    mensalidadeColecaoGrid.Add(mensalidade);
                }

                return mensalidadeColecaoGrid;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar as mensalidades. Detalhes: " + ex.Message);
            }

        }

        public DTOMensalidadeCarnetColecao ConsultarCarnet(int codAluno, int codTurma)
        {
            try
            {
                DTOMensalidadeCarnetColecao dTOMensalidadeCarnetColecao = new DTOMensalidadeCarnetColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Turma", codTurma);
                DataTable datatableMensalidade = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspMensalidadeConsultarCarnet");
                foreach (DataRow linha in datatableMensalidade.Rows)
                {

                    DTOMensalidadeCarnet dTOMensalidadeCarnet = new DTOMensalidadeCarnet();

                    dTOMensalidadeCarnet.Cod_ALuno = Convert.ToInt32(linha["Cod_Aluno"]);
                    dTOMensalidadeCarnet.Nome_Aluno = Convert.ToString(linha["Nome_Aluno"]);
                    dTOMensalidadeCarnet.Cod_Mensalidade = Convert.ToInt32(linha["Cod_Mensalidade"]);
                    dTOMensalidadeCarnet.Nome_Turma = Convert.ToString(linha["Nome_Turma"]);
                    dTOMensalidadeCarnet.DataVencimento = Convert.ToDateTime(linha["DataVencimento"]);
                    dTOMensalidadeCarnet.Num_Mensalidade = Convert.ToString(linha["Num_Mensalidade"]);
                    dTOMensalidadeCarnet.Valor = Convert.ToDecimal(linha["Valor"]);
                    dTOMensalidadeCarnetColecao.Add(dTOMensalidadeCarnet);
                }

                return dTOMensalidadeCarnetColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados para geração do carnet. Detalhes: " + ex.Message);
            }

        }

    }
}
