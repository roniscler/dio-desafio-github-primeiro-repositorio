using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class AlunoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Aluno aluno)
        {
            
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Local_Foto", aluno.Local_Foto);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Aluno", aluno.Nome_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", aluno.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@Data_Nascto", aluno.Data_Nascto);
                acessoDadosSqlServer.AdicionarParametros("@Data_Cadastro", aluno.Data_Cadastro);
                acessoDadosSqlServer.AdicionarParametros("@End_Rua", aluno.End_Rua);
                acessoDadosSqlServer.AdicionarParametros("@End_Nr", aluno.End_Nr);
                acessoDadosSqlServer.AdicionarParametros("@End_Comp", aluno.End_Comp);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Bairro", aluno.bairros.Cod_Bairro);
                acessoDadosSqlServer.AdicionarParametros("@End_Cep", aluno.End_Cep);
                acessoDadosSqlServer.AdicionarParametros("@End_Cidade", aluno.End_Cidade);
                acessoDadosSqlServer.AdicionarParametros("@UF_Residencia", aluno.UF_Residencia);
                acessoDadosSqlServer.AdicionarParametros("@End_Referencia", aluno.End_Referencia);
                acessoDadosSqlServer.AdicionarParametros("@Nacionalidade", aluno.Nacionalidade);
                acessoDadosSqlServer.AdicionarParametros("@Naturalidade", aluno.Naturalidade);
                acessoDadosSqlServer.AdicionarParametros("@UF_Naturalidade", aluno.UF_Naturalidade);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Religiao", aluno.religiao.Cod_religiao);
                acessoDadosSqlServer.AdicionarParametros("@Ativo_Inativo", aluno.Ativo_Inativo);
                acessoDadosSqlServer.AdicionarParametros("@Qtde_Irmaos", aluno.Qtde_irmaos);
                acessoDadosSqlServer.AdicionarParametros("@Idade_Andou", aluno.Idade_Andou);
                acessoDadosSqlServer.AdicionarParametros("@Idade_Falou", aluno.Idade_Falou);
                acessoDadosSqlServer.AdicionarParametros("@Manif_Alergica", aluno.Manif_Alergica);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Plano", aluno.planos.Cod_Plano);
                acessoDadosSqlServer.AdicionarParametros("@Data_Ini_Contrato", aluno.Data_Ini_Contrato);
                acessoDadosSqlServer.AdicionarParametros("@Data_Fim_Contrato", aluno.Data_Fim_Contrato);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Pai", aluno.Nome_Pai);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Mae", aluno.Nome_Mae);
                acessoDadosSqlServer.AdicionarParametros("@Prof_Pai", aluno.Prof_Pai);
                acessoDadosSqlServer.AdicionarParametros("@Prof_mae", aluno.Prof_Mae);
                acessoDadosSqlServer.AdicionarParametros("@Cod_CorAluno", aluno.corAluno.Cod_CorAluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_RepLegal", aluno.respLegal.Cod_rep_legal);
                string idAluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterAluno").ToString();
                return idAluno;
            }
            catch (Exception excessao)
            {

                return excessao.Message;
            }
        
        }

        public string Alterar(Aluno aluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("Local_Foto", aluno.Local_Foto);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Aluno", aluno.Nome_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", aluno.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@Data_Nascto", aluno.Data_Nascto);
                acessoDadosSqlServer.AdicionarParametros("@Data_Cadastro", aluno.Data_Cadastro);
                acessoDadosSqlServer.AdicionarParametros("@End_Rua", aluno.End_Rua);
                acessoDadosSqlServer.AdicionarParametros("@End_Nr", aluno.End_Nr);
                acessoDadosSqlServer.AdicionarParametros("@End_Comp", aluno.End_Comp);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Bairro", aluno.bairros.Cod_Bairro);
                acessoDadosSqlServer.AdicionarParametros("@End_Cep", aluno.End_Cep);
                acessoDadosSqlServer.AdicionarParametros("@End_Cidade", aluno.End_Cidade);
                acessoDadosSqlServer.AdicionarParametros("@UF_Residencia", aluno.UF_Residencia);
                acessoDadosSqlServer.AdicionarParametros("@End_Referencia", aluno.End_Referencia);
                acessoDadosSqlServer.AdicionarParametros("@Nacionalidade", aluno.Nacionalidade);
                acessoDadosSqlServer.AdicionarParametros("@Naturalidade", aluno.Naturalidade);
                acessoDadosSqlServer.AdicionarParametros("@UF_Naturalidade", aluno.UF_Naturalidade);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Religiao", aluno.religiao.Cod_religiao);
                acessoDadosSqlServer.AdicionarParametros("@Ativo_Inativo", aluno.Ativo_Inativo);
                acessoDadosSqlServer.AdicionarParametros("@Qtde_Irmaos", aluno.Qtde_irmaos);
                acessoDadosSqlServer.AdicionarParametros("@Idade_Andou", aluno.Idade_Andou);
                acessoDadosSqlServer.AdicionarParametros("@Idade_Falou", aluno.Idade_Falou);
                acessoDadosSqlServer.AdicionarParametros("@Manif_Alergica", aluno.Manif_Alergica);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Plano", aluno.planos.Cod_Plano);
                acessoDadosSqlServer.AdicionarParametros("@Data_Ini_Contrato", aluno.Data_Ini_Contrato);
                acessoDadosSqlServer.AdicionarParametros("@Data_Fim_Contrato", aluno.Data_Fim_Contrato);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Pai", aluno.Nome_Pai);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Mae", aluno.Nome_Mae);
                acessoDadosSqlServer.AdicionarParametros("@Prof_Pai", aluno.Prof_Pai);
                acessoDadosSqlServer.AdicionarParametros("@Prof_Mae", aluno.Prof_Mae);
                acessoDadosSqlServer.AdicionarParametros("@Cod_CorAluno", aluno.corAluno.Cod_CorAluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_RepLegal", aluno.respLegal.Cod_rep_legal);
                string idAluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterAluno").ToString();
                return idAluno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Excluir(Aluno aluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", aluno.Cod_Aluno);
                string cod_Aluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterAluno").ToString();
                return cod_Aluno;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public AlunoColecao ConsultarPorNome (string nomeAluno)
        {
            try
            {
                AlunoColecao alunoColecao = new AlunoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome_Aluno", nomeAluno);
                DataTable datatableAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunoConsultarPorNome");
                foreach (DataRow linha in datatableAluno.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    aluno.Local_Foto = Convert.ToString(linha["Local_Foto"]);
                    aluno.Nome_Aluno = Convert.ToString(linha["Nome_Aluno"]);
                    aluno.Sexo = Convert.ToBoolean(linha["Sexo"]);
                    aluno.Data_Nascto = Convert.ToDateTime(linha["Data_Nascto"]);
                    aluno.Data_Cadastro = Convert.ToDateTime(linha["Data_Cadastro"]);
                    aluno.End_Rua = Convert.ToString(linha["End_Rua"]);
                    aluno.End_Nr = Convert.ToString(linha["End_Nr"]);
                    aluno.End_Comp = Convert.ToString(linha["End_Comp"]);

                    aluno.bairros = new Bairros();
                    aluno.bairros.Cod_Bairro = Convert.ToInt32(linha["Cod_Bairro"]);
                    aluno.End_Cep= Convert.ToString(linha["End_Cep"]);
                    aluno.End_Cidade= Convert.ToString(linha["End_Cidade"]);
                    aluno.UF_Residencia= Convert.ToString(linha["UF_Residencia"]);
                    aluno.End_Referencia= Convert.ToString(linha["End_Referencia"]);
                    aluno.Nacionalidade= Convert.ToString(linha["Nacionalidade"]);
                    aluno.Naturalidade= Convert.ToString(linha["Naturalidade"]);
                    aluno.UF_Naturalidade= Convert.ToString(linha["UF_Naturalidade"]);
                    aluno.religiao = new Religiao();
                    aluno.religiao.Cod_religiao = Convert.ToInt32(linha["Cod_Religiao"]);
                    aluno.Ativo_Inativo= Convert.ToBoolean(linha["Ativo_Inativo"]);
                    aluno.Qtde_irmaos = Convert.ToInt32(linha["Qtde_Irmaos"]);
                    aluno.Idade_Andou= Convert.ToInt32(linha["Idade_andou"]);
                    aluno.Idade_Falou= Convert.ToInt32(linha["Idade_falou"]);
                    aluno.Manif_Alergica= Convert.ToBoolean(linha["Manif_Alergica"]);
                    
                    aluno.planos = new Planos();
                    aluno.planos.Cod_Plano= Convert.ToInt32(linha["Cod_Plano"]);
                    aluno.Data_Ini_Contrato = Convert.ToDateTime(linha["Data_Ini_Contrato"]);
                    aluno.Data_Fim_Contrato = Convert.ToDateTime(linha["Data_Fim_Contrato"]);
                    aluno.Nome_Pai= Convert.ToString(linha["Nome_Pai"]);
                    aluno.Nome_Mae = Convert.ToString(linha["Nome_Mae"]);
                    aluno.Prof_Pai= Convert.ToString(linha["Prof_Pai"]);
                    aluno.Prof_Mae = Convert.ToString(linha["Prof_Mae"]);

                    aluno.corAluno = new CorAluno();
                    aluno.corAluno.Cod_CorAluno = Convert.ToInt32(linha["Cod_CorAluno"]);

                    aluno.respLegal = new RespLegal();
                    aluno.respLegal.Cod_rep_legal = Convert.ToInt32(linha["Cod_RepLegal"]);
                    alunoColecao.Add(aluno);
                }

                return alunoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o aluno por nome. Detalhes: " + ex.Message);
            }            
        }

        public AlunoColecao ConsultarPorCodigo (int CodAluno)
        {
            try
            {
                AlunoColecao alunoColecao = new AlunoColecao();
                
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", CodAluno);
               
                DataTable datatableAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunoConsultarPorCodigo");
                foreach (DataRow linha in datatableAluno.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    aluno.Local_Foto = Convert.ToString(linha["Local_Foto"]);
                    aluno.Nome_Aluno = Convert.ToString(linha["Nome_Aluno"]);
                    aluno.Sexo = Convert.ToBoolean(linha["Sexo"]);
                    aluno.Data_Nascto = Convert.ToDateTime(linha["Data_Nascto"]);
                    aluno.Data_Cadastro = Convert.ToDateTime(linha["Data_Cadastro"]);
                    aluno.End_Rua = Convert.ToString(linha["End_Rua"]);
                    aluno.End_Nr = Convert.ToString(linha["End_Nr"]);
                    aluno.End_Comp = Convert.ToString(linha["End_Comp"]);

                    aluno.bairros = new Bairros();
                    aluno.bairros.Cod_Bairro = Convert.ToInt32(linha["Cod_Bairro"]);
                    aluno.End_Cep = Convert.ToString(linha["End_Cep"]);
                    aluno.End_Cidade = Convert.ToString(linha["End_Cidade"]);
                    aluno.UF_Residencia = Convert.ToString(linha["UF_Residencia"]);
                    aluno.End_Referencia = Convert.ToString(linha["End_Referencia"]);
                    aluno.Nacionalidade = Convert.ToString(linha["Nacionalidade"]);
                    aluno.Naturalidade = Convert.ToString(linha["Naturalidade"]);
                    aluno.UF_Naturalidade = Convert.ToString(linha["UF_Naturalidade"]);
                    aluno.religiao = new Religiao();
                    aluno.religiao.Cod_religiao = Convert.ToInt32(linha["Cod_Religiao"]);
                    aluno.Ativo_Inativo = Convert.ToBoolean(linha["Ativo_Inativo"]);
                    aluno.Qtde_irmaos = Convert.ToInt32(linha["Qtde_Irmaos"]);
                    aluno.Idade_Andou = Convert.ToInt32(linha["Idade_andou"]);
                    aluno.Idade_Falou = Convert.ToInt32(linha["Idade_falou"]);
                    aluno.Manif_Alergica = Convert.ToBoolean(linha["Manif_Alergica"]);

                    aluno.planos = new Planos();
                    aluno.planos.Cod_Plano = Convert.ToInt32(linha["Cod_Plano"]);
                    aluno.Data_Ini_Contrato = Convert.ToDateTime(linha["Data_Ini_Contrato"]);
                    aluno.Data_Fim_Contrato = Convert.ToDateTime(linha["Data_Fim_Contrato"]);
                    aluno.Nome_Pai = Convert.ToString(linha["Nome_Pai"]);
                    aluno.Nome_Mae = Convert.ToString(linha["Nome_Mae"]);
                    aluno.Prof_Pai = Convert.ToString(linha["Prof_Pai"]);
                    aluno.Prof_Mae = Convert.ToString(linha["Prof_Mae"]);

                    aluno.corAluno = new CorAluno();
                    aluno.corAluno.Cod_CorAluno = Convert.ToInt32(linha["Cod_CorAluno"]);

                    aluno.respLegal = new RespLegal();
                    aluno.respLegal.Cod_rep_legal = Convert.ToInt32(linha["Cod_RepLegal"]);
                    alunoColecao.Add(aluno);
                }

                return alunoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o aluno por código. Detalhes: " + ex.Message);
            }
        }

        public AlunoColecao ConsultarCombo()
        {
            try
            {
                AlunoColecao alunoColecao = new AlunoColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable datatableAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunosConsultarCombo");
                foreach (DataRow linha in datatableAluno.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    aluno.Nome_Aluno = Convert.ToString(linha["Nome_Aluno"]);
                    alunoColecao.Add(aluno);
                }

                return alunoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os alunos ativos do sistema. Detalhes: " + ex.Message);
            }
        }

        public DTOFichaAlunoColecao Consultar(int CodAluno)
        {
            try
            {
                DTOFichaAlunoColecao alunoColecao = new DTOFichaAlunoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", CodAluno);
                DataTable datatableAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFichaAlunoConsultar");
                foreach (DataRow linha in datatableAluno.Rows)
                {
                    DTOFichaAluno aluno = new DTOFichaAluno();
                    aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    aluno.Local_Foto = Convert.ToString(linha["Local_Foto"]);
                    aluno.Nome_Aluno = Convert.ToString(linha["Nome_Aluno"]);
                    aluno.Sexo = Convert.ToBoolean(linha["Sexo"]);
                    aluno.Data_Nascto = Convert.ToDateTime(linha["Data_Nascto"]);
                    aluno.Data_Cadastro = Convert.ToDateTime(linha["Data_Cadastro"]);
                    aluno.End_Rua = Convert.ToString(linha["End_Rua"]);
                    aluno.End_Nr = Convert.ToString(linha["End_Nr"]);
                    aluno.End_Comp = Convert.ToString(linha["End_Comp"]);
                    aluno.Nome_Bairro = Convert.ToString(linha["Nome_Bairro"]);
                    aluno.End_Cep = Convert.ToString(linha["End_Cep"]);
                    aluno.End_Cidade = Convert.ToString(linha["End_Cidade"]);
                    aluno.UF_Residencia = Convert.ToString(linha["UF_Residencia"]);
                    aluno.End_Referencia = Convert.ToString(linha["End_Referencia"]);
                    aluno.Nacionalidade = Convert.ToString(linha["Nacionalidade"]);
                    aluno.Naturalidade = Convert.ToString(linha["Naturalidade"]);
                    aluno.UF_Naturalidade = Convert.ToString(linha["UF_Naturalidade"]);
                    aluno.Des_Religiao = Convert.ToString(linha["Nome_religiao"]);
                    aluno.Ativo_Inativo = Convert.ToBoolean(linha["Ativo_Inativo"]);
                    aluno.Qtde_irmaos = Convert.ToInt32(linha["Qtde_Irmaos"]);
                    aluno.Idade_Andou = Convert.ToInt32(linha["Idade_andou"]);
                    aluno.Idade_Falou = Convert.ToInt32(linha["Idade_falou"]);
                    aluno.Manif_Alergica = Convert.ToBoolean(linha["Manif_Alergica"]);
                    aluno.Cod_Plano = Convert.ToInt32(linha["Cod_Plano"]);
                    aluno.Desc_Plano = Convert.ToString(linha["Desc_Plano"]);
                    aluno.Data_Ini_Contrato = Convert.ToDateTime(linha["Data_Ini_Contrato"]);
                    aluno.Data_Fim_Contrato = Convert.ToDateTime(linha["Data_Fim_Contrato"]);
                    aluno.Nome_Pai = Convert.ToString(linha["Nome_Pai"]);
                    aluno.Nome_Mae = Convert.ToString(linha["Nome_Mae"]);
                    aluno.Prof_Pai = Convert.ToString(linha["Prof_Pai"]);
                    aluno.Prof_Mae = Convert.ToString(linha["Prof_Mae"]);
                    aluno.Desc_CoraAluno = Convert.ToString(linha["Desc_CorAluno"]);
                    aluno.NomeRepLegal = Convert.ToString(linha["NomeRep_Legal"]);
                    aluno.Cod_RepLegal = Convert.ToInt32(linha["Cod_RepLegal"]);

                    alunoColecao.Add(aluno);
                }

                return alunoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o aluno por nome. Detalhes: " + ex.Message);
            }
        }

        public AlunoColecao ConsultarAtivo()
        {
            try
            {
                AlunoColecao alunoColecao = new AlunoColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable datatableAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunoConsultarAtivo");
                foreach (DataRow linha in datatableAluno.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    aluno.Nome_Aluno = Convert.ToString(linha["Nome_Aluno"]);
                    alunoColecao.Add(aluno);
                }

                return alunoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os alunos ativos do sistema. Detalhes: " + ex.Message);
            }
        }





    }
}
