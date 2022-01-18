using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ObjetoTrasnferencia;
using AcessoDados;


namespace Negocios
{
    public class Habilt_ProfissionalNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Habilit_Profissional habilit_Profissional)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Habilitacao", habilit_Profissional.Cod_Habilitacao);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", habilit_Profissional.Instituicao);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", habilit_Profissional.Cod_Professor);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Habilitacao", habilit_Profissional.Desc_Habilitacao);
                acessoDadosSqlServer.AdicionarParametros("@Data_Conclusao", habilit_Profissional.Data_Conclusao);
                acessoDadosSqlServer.AdicionarParametros("@Duracao", habilit_Profissional.Duracao);
                string idHabilitacao = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterHabilitacaoProfissional").ToString();
                return idHabilitacao;
            }

            catch (Exception excessao)
            {
                return excessao.Message;
            }

        }

        public string Alterar(Habilit_Profissional habilit_Profissional)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Habilitacao", habilit_Profissional.Cod_Habilitacao);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", habilit_Profissional.Instituicao);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", habilit_Profissional.Cod_Professor);
                acessoDadosSqlServer.AdicionarParametros("@Desc_Habilitacao", habilit_Profissional.Desc_Habilitacao);
                acessoDadosSqlServer.AdicionarParametros("@Data_Conclusao", habilit_Profissional.Data_Conclusao);
                acessoDadosSqlServer.AdicionarParametros("@Duracao", habilit_Profissional.Duracao);
                string idHabilitacao = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterHabilitacaoProfissional").ToString();
                return idHabilitacao;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Excluir(Habilit_Profissional habilit_Profissional)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Habilitacao", habilit_Profissional.Cod_Habilitacao);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", habilit_Profissional.Cod_Professor);
                string idHabilitacao = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterHabilitacaoProfissional").ToString();
                return idHabilitacao;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public Habilit_ProfissionaolColecao Consultar(int CodProfessor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", CodProfessor);

                Habilit_ProfissionaolColecao habilit_ProfissionaolColecao = new Habilit_ProfissionaolColecao();
                
                DataTable DataTableHabilit_Profissional = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspHabilitacaoProfissionalConsultar");
                foreach (DataRow linha in DataTableHabilit_Profissional.Rows)
                {
                    Habilit_Profissional habilit_Profissional = new Habilit_Profissional();
                    habilit_Profissional.Cod_Habilitacao = Convert.ToInt32(linha["Cod_Habilitacao"]);
                    habilit_Profissional.Cod_Professor = Convert.ToInt32(linha["Cod_Professor"]);
                    habilit_Profissional.Desc_Habilitacao = Convert.ToString(linha["Desc_Habilitacao"]);
                    habilit_Profissional.Instituicao = Convert.ToString(linha["Instituicao"]);
                    habilit_Profissional.Data_Conclusao = Convert.ToDateTime(linha["Data_Conclusao"]);
                    habilit_Profissional.Desc_Habilitacao = Convert.ToString(linha["Desc_Habilitacao"]);
                    habilit_Profissional.Duracao = Convert.ToString(linha["Duracao"]);
                    habilit_ProfissionaolColecao.Add(habilit_Profissional);
                }

                return habilit_ProfissionaolColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os ítens para este Professor. Detalhes: " + ex.Message);
            }

        }
    }
}
