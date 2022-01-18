using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;


namespace Negocios
{
    public class Resp_LegalNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(RespLegal respLegal)
        {

            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@NomeRep_Legal", respLegal.NomeRep_Legal);
                acessoDadosSqlServer.AdicionarParametros("@Data_Nascto", respLegal.Data_Nascto);
                acessoDadosSqlServer.AdicionarParametros("@Cod_est_Civil", respLegal.Cod_Est_Civil);
                acessoDadosSqlServer.AdicionarParametros("@End_Rua", respLegal.End_Rua);
                acessoDadosSqlServer.AdicionarParametros("@End_Nr", respLegal.End_Nr);
                acessoDadosSqlServer.AdicionarParametros("@End_Comp", respLegal.End_Comp);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Bairro", respLegal.Cod_Bairro);
                acessoDadosSqlServer.AdicionarParametros("@End_Cep", respLegal.End_Cep);
                acessoDadosSqlServer.AdicionarParametros("@End_Cidade", respLegal.End_Cidade);
                acessoDadosSqlServer.AdicionarParametros("@UF_Residencia", respLegal.UF_Residencia);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Residencial", respLegal.Tel_Residencial);
                acessoDadosSqlServer.AdicionarParametros("@Celular", respLegal.Celular);
                acessoDadosSqlServer.AdicionarParametros("@Telefone_Favor", respLegal.Telefone_Favor);
                acessoDadosSqlServer.AdicionarParametros("@End_Referencia", respLegal.End_Referencia);
                acessoDadosSqlServer.AdicionarParametros("@Cart_Ident", respLegal.Cart_Ident);
                acessoDadosSqlServer.AdicionarParametros("@Org_Exped", respLegal.Org_Exped);
                acessoDadosSqlServer.AdicionarParametros("@CPF", respLegal.CPF);
                acessoDadosSqlServer.AdicionarParametros("@Nacionalidade", respLegal.Nacionalidade);
                acessoDadosSqlServer.AdicionarParametros("@Naturalidade", respLegal.Naturalidade);
                acessoDadosSqlServer.AdicionarParametros("@UF_Naturalidade", respLegal.UF_Naturalidade);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Escolaridade", respLegal.Cod_Escolaridade);
                acessoDadosSqlServer.AdicionarParametros("@Condicao", respLegal.Condicao);
                acessoDadosSqlServer.AdicionarParametros("@Profissao", respLegal.Profissao);
                string idEntidade = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterRespLegal").ToString();
                return idEntidade;
            }
            catch (Exception excessao)
            {

                return excessao.Message;
            }

        }

        public string Alterar(RespLegal respLegal)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_rep_legal", respLegal.Cod_rep_legal);
                acessoDadosSqlServer.AdicionarParametros("@NomeRep_Legal", respLegal.NomeRep_Legal);
                acessoDadosSqlServer.AdicionarParametros("@Data_Nascto", respLegal.Data_Nascto);
                acessoDadosSqlServer.AdicionarParametros("@Cod_est_Civil", respLegal.Cod_Est_Civil);
                acessoDadosSqlServer.AdicionarParametros("@End_Rua", respLegal.End_Rua);
                acessoDadosSqlServer.AdicionarParametros("@End_Nr", respLegal.End_Nr);
                acessoDadosSqlServer.AdicionarParametros("@End_Comp", respLegal.End_Comp);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Bairro", respLegal.Cod_Bairro);
                acessoDadosSqlServer.AdicionarParametros("@End_Cep", respLegal.End_Cep);
                acessoDadosSqlServer.AdicionarParametros("@End_Cidade", respLegal.End_Cidade);
                acessoDadosSqlServer.AdicionarParametros("@UF_Residencia", respLegal.UF_Residencia);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Residencial", respLegal.Tel_Residencial);
                acessoDadosSqlServer.AdicionarParametros("@Celular", respLegal.Celular);
                acessoDadosSqlServer.AdicionarParametros("@Telefone_Favor", respLegal.Telefone_Favor);
                acessoDadosSqlServer.AdicionarParametros("@End_Referencia", respLegal.End_Referencia);
                acessoDadosSqlServer.AdicionarParametros("@Cart_Ident", respLegal.Cart_Ident);
                acessoDadosSqlServer.AdicionarParametros("@Org_Exped", respLegal.Org_Exped);
                acessoDadosSqlServer.AdicionarParametros("@CPF", respLegal.CPF);
                acessoDadosSqlServer.AdicionarParametros("@Nacionalidade", respLegal.Nacionalidade);
                acessoDadosSqlServer.AdicionarParametros("@Naturalidade", respLegal.Naturalidade);
                acessoDadosSqlServer.AdicionarParametros("@UF_Naturalidade", respLegal.UF_Naturalidade);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Escolaridade", respLegal.Cod_Escolaridade);
                acessoDadosSqlServer.AdicionarParametros("@Condicao", respLegal.Condicao);
                acessoDadosSqlServer.AdicionarParametros("@Profissao", respLegal.Profissao);
                string idEntidade = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterRespLegal").ToString();
                return idEntidade;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Excluir(RespLegal respLegal)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_rep_legal", respLegal.Cod_rep_legal);
                string idEntidade = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterRespLegal").ToString();
                return idEntidade;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public RespLegalColecao ConsultarPorNome(string nomeRespLegal)
        {
            try
            {
                RespLegalColecao respLegalColecao = new RespLegalColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@NomeRep_Legal", nomeRespLegal);
                DataTable datatableRespLegal = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspResp_LegalConsultarPorNome");
                foreach (DataRow linha in datatableRespLegal.Rows)
                {
                    RespLegal respLegal = new RespLegal();
                    respLegal.Cod_rep_legal = Convert.ToInt32(linha["Cod_rep_legal"]);
                    respLegal.NomeRep_Legal = Convert.ToString(linha["NomeRep_Legal"]);
                    respLegal.Data_Nascto = Convert.ToDateTime(linha["Data_Nascto"]);
                    respLegal.Cod_Est_Civil = Convert.ToInt32(linha["Cod_est_Civil"]);
                    respLegal.End_Rua = Convert.ToString(linha["End_Rua"]);
                    respLegal.End_Nr = Convert.ToString(linha["End_Nr"]);
                    respLegal.End_Comp = Convert.ToString(linha["End_Comp"]);
                    respLegal.Cod_Bairro = Convert.ToInt32(linha["Cod_Bairro"]);
                    respLegal.End_Cep = Convert.ToString(linha["End_Cep"]);
                    respLegal.End_Cidade = Convert.ToString(linha["End_Cidade"]);
                    respLegal.UF_Residencia = Convert.ToString(linha["UF_Residencia"]);
                    respLegal.Tel_Residencial = Convert.ToString(linha["Tel_Residencial"]);
                    respLegal.Celular = Convert.ToString(linha["Celular"]);
                    respLegal.Telefone_Favor = Convert.ToString(linha["Telefone_Favor"]);
                    respLegal.End_Referencia = Convert.ToString(linha["End_Referencia"]);
                    respLegal.Cart_Ident = Convert.ToString(linha["Cart_Ident"]);
                    respLegal.Org_Exped = Convert.ToString(linha["Org_Exped"]);
                    respLegal.CPF = Convert.ToString(linha["CPF"]);
                    respLegal.Nacionalidade = Convert.ToString(linha["Nacionalidade"]);
                    respLegal.Naturalidade = Convert.ToString(linha["Naturalidade"]);
                    respLegal.UF_Naturalidade = Convert.ToString(linha["UF_Naturalidade"]);
                    respLegal.Cod_Escolaridade = Convert.ToInt32(linha["Cod_Escolaridade"]);
                    respLegal.Condicao = Convert.ToString(linha["Condicao"]);
                    respLegal.Profissao = Convert.ToString(linha["Profissao"]);
                    respLegalColecao.Add(respLegal);
                }

                return respLegalColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o Responsável Legal por nome. Detalhes: " + ex.Message);
            }


        }

        public Boolean ConsultarPorCPF(string cpf)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CPF", cpf);
                DataTable datatableRespLegal = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspResp_LegalConsultarPorCPF");
                int qtde = datatableRespLegal.Rows.Count;
                if (qtde == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o Responsável Legal por CPF. Detalhes: " + ex.Message);
            }


        }

        public RespLegalColecao ConsultarCombo()
        {
            try
            {
                RespLegalColecao respLegalColecao = new RespLegalColecao();
                DataTable datatableRespLegal = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspResp_LegalCombo");
                foreach (DataRow linha in datatableRespLegal.Rows)
                {
                    RespLegal respLegal = new RespLegal();
                    respLegal.Cod_rep_legal = Convert.ToInt32(linha["Cod_rep_legal"]);
                    respLegal.NomeRep_Legal = Convert.ToString(linha["NomeRep_Legal"]);
                    respLegalColecao.Add(respLegal);
                }

                return respLegalColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o Responsável Legal por nome. Detalhes: " + ex.Message);
            }
            
        }

        public RespLegal ConsultarCodigo(int Cod_rep_legal)
        {
            RespLegal repel = new RespLegal();
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_rep_legal", Cod_rep_legal);
                DataTable datatableRespLegal = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspResp_LegalConsultarPorCodigo");
                foreach (DataRow linha in datatableRespLegal.Rows)
                {
                    RespLegal respLegal = new RespLegal();
                    respLegal.Cod_rep_legal = Convert.ToInt32(linha["Cod_rep_legal"]);
                    respLegal.NomeRep_Legal = Convert.ToString(linha["NomeRep_Legal"]);
                    respLegal.Data_Nascto = Convert.ToDateTime(linha["Data_Nascto"]);
                    respLegal.Cod_Est_Civil = Convert.ToInt32(linha["Cod_est_Civil"]);
                    respLegal.End_Rua = Convert.ToString(linha["End_Rua"]);
                    respLegal.End_Nr = Convert.ToString(linha["End_Nr"]);
                    respLegal.End_Comp = Convert.ToString(linha["End_Comp"]);
                    respLegal.Cod_Bairro = Convert.ToInt32(linha["Cod_Bairro"]);
                    respLegal.End_Cep = Convert.ToString(linha["End_Cep"]);
                    respLegal.End_Cidade = Convert.ToString(linha["End_Cidade"]);
                    respLegal.UF_Residencia = Convert.ToString(linha["UF_Residencia"]);
                    respLegal.Tel_Residencial = Convert.ToString(linha["Tel_Residencial"]);
                    respLegal.Celular = Convert.ToString(linha["Celular"]);
                    respLegal.Telefone_Favor = Convert.ToString(linha["Telefone_Favor"]);
                    respLegal.End_Referencia = Convert.ToString(linha["End_Referencia"]);
                    respLegal.Cart_Ident = Convert.ToString(linha["Cart_Ident"]);
                    respLegal.Org_Exped = Convert.ToString(linha["Org_Exped"]);
                    respLegal.CPF = Convert.ToString(linha["CPF"]);
                    respLegal.Nacionalidade = Convert.ToString(linha["Nacionalidade"]);
                    respLegal.Naturalidade = Convert.ToString(linha["Naturalidade"]);
                    respLegal.UF_Naturalidade = Convert.ToString(linha["UF_Naturalidade"]);
                    respLegal.Cod_Escolaridade = Convert.ToInt32(linha["Cod_Escolaridade"]);
                    respLegal.Condicao = Convert.ToString(linha["Condicao"]);
                    respLegal.Profissao = Convert.ToString(linha["Profissao"]);
                    repel = respLegal;
                }

                return repel;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o Responsável Legal por nome. Detalhes: " + ex.Message);
            }


        }

        public DTORespLegalColecao ConsultarContrato(int codRepLegal)
        {
            try
            {
                DTORespLegalColecao respLegalColecao = new DTORespLegalColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_rep_legal", codRepLegal);
                DataTable datatableRespLegal = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspResp_LegalConsultarContrato");
                foreach (DataRow linha in datatableRespLegal.Rows)
                {
                    DTORespLegal respLegal = new DTORespLegal();
                    respLegal.Cod_rep_legal = Convert.ToInt32(linha["Cod_rep_legal"]);
                    respLegal.NomeRep_Legal = Convert.ToString(linha["NomeRep_Legal"]);
                    respLegal.Data_Nascto = Convert.ToDateTime(linha["Data_Nascto"]);
                    respLegal.Estado_Civil = Convert.ToString(linha["Desc_EstadoCivil"]);
                    respLegal.End_Rua = Convert.ToString(linha["End_Rua"]);
                    respLegal.End_Nr = Convert.ToString(linha["End_Nr"]);
                    respLegal.End_Comp = Convert.ToString(linha["End_Comp"]);
                    respLegal.Bairro = Convert.ToString(linha["Nome_Bairro"]);
                    respLegal.End_Cep = Convert.ToString(linha["End_Cep"]);
                    respLegal.End_Cidade = Convert.ToString(linha["End_Cidade"]);
                    respLegal.UF_Residencia = Convert.ToString(linha["UF_Residencia"]);
                    respLegal.Tel_Residencial = Convert.ToString(linha["Tel_Residencial"]);
                    respLegal.Celular = Convert.ToString(linha["Celular"]);
                    respLegal.Telefone_Favor = Convert.ToString(linha["Telefone_Favor"]);
                    respLegal.End_Referencia = Convert.ToString(linha["End_Referencia"]);
                    respLegal.Cart_Ident = Convert.ToString(linha["Cart_Ident"]);
                    respLegal.Org_Exped = Convert.ToString(linha["Org_Exped"]);
                    respLegal.CPF = Convert.ToString(linha["CPF"]);
                    respLegal.Nacionalidade = Convert.ToString(linha["Nacionalidade"]);
                    respLegal.Naturalidade = Convert.ToString(linha["Naturalidade"]);
                    respLegal.UF_Naturalidade = Convert.ToString(linha["UF_Naturalidade"]);
                    respLegal.Escolaridade = Convert.ToString(linha["Descricao"]);
                    respLegal.Condicao = Convert.ToString(linha["Condicao"]);
                    respLegal.Profissao = Convert.ToString(linha["Profissao"]);
                    respLegalColecao.Add(respLegal);
                }

                return respLegalColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o Responsável Legal. Detalhes: " + ex.Message);
            }


        }


    }
}
