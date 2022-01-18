using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class ProfessorNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Professor professor)
        {

            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Professor", professor.Nome_Professor);
                acessoDadosSqlServer.AdicionarParametros("@Data_Nascto", professor.basePessoa.Data_Nascto);
                acessoDadosSqlServer.AdicionarParametros("@End_Rua", professor.basePessoa.End_Rua);
                acessoDadosSqlServer.AdicionarParametros("@End_Nr", professor.basePessoa.End_Nr);
                acessoDadosSqlServer.AdicionarParametros("@End_Comp", professor.basePessoa.End_Comp);
                acessoDadosSqlServer.AdicionarParametros("@End_Bairro", professor.End_Bairro);
                acessoDadosSqlServer.AdicionarParametros("@End_Cep", professor.basePessoa.End_Cep);
                acessoDadosSqlServer.AdicionarParametros("@End_Cidade", professor.basePessoa.End_Cidade);
                acessoDadosSqlServer.AdicionarParametros("@UF_Residencia", professor.basePessoa.UF_Residencia);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Residencial", professor.Tel_Residencial);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Favor", professor.Tel_Favor);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Celular", professor.Tel_Celular);
                acessoDadosSqlServer.AdicionarParametros("@Referencia", professor.basePessoa.End_Referencia);
                acessoDadosSqlServer.AdicionarParametros("@Cart_Ident", professor.Cart_Identidade);
                acessoDadosSqlServer.AdicionarParametros("@Org_Exped", professor.Orgao_Expedidor);
                acessoDadosSqlServer.AdicionarParametros("@CPF", professor.CPF);
                acessoDadosSqlServer.AdicionarParametros("@Naturalidade", professor.basePessoa.Naturalidade);
                acessoDadosSqlServer.AdicionarParametros("@UF_Naturalidade", professor.basePessoa.UF_Naturalidade);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Escolaridade", professor.Cod_Escolaridade);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Est_Civil", professor.Cod_Est_Civil);
                acessoDadosSqlServer.AdicionarParametros("@Local_Foto", professor.basePessoa.Local_Foto);
                acessoDadosSqlServer.AdicionarParametros("@Data_Cadastro", professor.Data_Cadastro);


                string idProfessor = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterProfessor").ToString();
                return idProfessor;
            }
            catch (Exception excessao)
            {

                return excessao.Message;
            }

        }

        public string Alterar(Professor professor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", professor.Cod_Professor);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Professor", professor.Nome_Professor);
                acessoDadosSqlServer.AdicionarParametros("@Data_Nascto", professor.basePessoa.Data_Nascto);
                acessoDadosSqlServer.AdicionarParametros("@End_Rua", professor.basePessoa.End_Rua);
                acessoDadosSqlServer.AdicionarParametros("@End_Nr", professor.basePessoa.End_Nr);
                acessoDadosSqlServer.AdicionarParametros("@End_Comp", professor.basePessoa.End_Comp);
                acessoDadosSqlServer.AdicionarParametros("@End_Bairro", professor.End_Bairro);
                acessoDadosSqlServer.AdicionarParametros("@End_Cep", professor.basePessoa.End_Cep);
                acessoDadosSqlServer.AdicionarParametros("@End_Cidade", professor.basePessoa.End_Cidade);
                acessoDadosSqlServer.AdicionarParametros("@UF_Residencia", professor.basePessoa.UF_Residencia);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Residencial", professor.Tel_Residencial);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Favor", professor.Tel_Favor);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Celular", professor.Tel_Celular);
                acessoDadosSqlServer.AdicionarParametros("@Referencia", professor.basePessoa.End_Referencia);
                acessoDadosSqlServer.AdicionarParametros("@Cart_Ident", professor.Cart_Identidade);
                acessoDadosSqlServer.AdicionarParametros("@Org_Exped", professor.Orgao_Expedidor);
                acessoDadosSqlServer.AdicionarParametros("@CPF", professor.CPF);
                acessoDadosSqlServer.AdicionarParametros("@Naturalidade", professor.basePessoa.Naturalidade);
                acessoDadosSqlServer.AdicionarParametros("@UF_Naturalidade", professor.basePessoa.UF_Naturalidade);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Escolaridade", professor.Cod_Escolaridade);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Est_Civil", professor.Cod_Est_Civil);
                acessoDadosSqlServer.AdicionarParametros("@Local_Foto", professor.basePessoa.Local_Foto);
                acessoDadosSqlServer.AdicionarParametros("@Data_Cadastro", professor.Data_Cadastro);


                string idAluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterProfessor").ToString();
                return idAluno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Excluir(Professor professor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", professor.Cod_Professor);
                string cod_Aluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterProfessor").ToString();
                return cod_Aluno;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public ProfessorColecao ConsultarPorNome(string nomeProfessor)
        {
            try
            {
                ProfessorColecao professorColecao = new ProfessorColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome_Professor", nomeProfessor);
                DataTable datatableProfessor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorConsultarGrid");
                foreach (DataRow linha in datatableProfessor.Rows)
                {
                    Professor professor = new Professor();
                    professor.Cod_Professor = Convert.ToInt32(linha["Cod_Professor"]);
                    professor.Nome_Professor = Convert.ToString(linha["Nome_Professor"]);
                    //professor.Data_Nascto = Convert.ToDateTime(linha["Data_Nascto"]);
                    //professor.End_Rua = Convert.ToString(linha["End_Rua"]);
                    //professor.End_Nr = Convert.ToString(linha["End_Nr"]);
                    //professor.End_Comp = Convert.ToString(linha["End_Comp"]);
                    //professor.End_Bairro = Convert.ToString(linha["End_Bairro"]);
                    //professor.End_Cep = Convert.ToString(linha["End_Cep"]);
                    //professor.End_Cidade = Convert.ToString(linha["End_Cidade"]);
                    //professor.UF_Residencia = Convert.ToString(linha["UF_Residencia"]);
                    //professor.Tel_Residencial = Convert.ToString(linha["Tel_Residencial"]);
                    //professor.Tel_Favor = Convert.ToString(linha["Tel_Favor"]);
                    //professor.Tel_Celular = Convert.ToString(linha["Tel_Celular"]);
                    //professor.End_Referencia = Convert.ToString(linha["Referencia"]);
                    //professor.Cart_Identidade = Convert.ToString(linha["Cart_Ident"]);
                    //professor.Orgao_Expedidor = Convert.ToString(linha["Org_Exped"]);
                    //professor.CPF = Convert.ToString(linha["CPF"]);
                    //professor.Naturalidade = Convert.ToString(linha["Naturalidade"]);
                    //professor.UF_Naturalidade = Convert.ToString(linha["UF_Naturalidade"]);
                    //professor.Cod_Escolaridade = Convert.ToInt32(linha["Cod_Escolaridade"]);
                    //professor.Cod_Est_Civil = Convert.ToInt32(linha["Cod_Est_Civil"]);
                    //professor.Local_Foto = Convert.ToString(linha["Local_Foto"]);
                    //professor.Data_Cadastro = Convert.ToDateTime(linha["Data_Cadastro"]);

                    professorColecao.Add(professor);
                }

                return professorColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o professor por nome. Detalhes: " + ex.Message);
            }
        }

        public Professor ConsultarPorCodigo(int codProfessor)
        {
            Professor professor = new Professor();
            professor.basePessoa = new BasePessoa();

            try
            {
                //ProfessorColecao professorColecao = new ProfessorColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", codProfessor);

                DataTable datatableProfessor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorConsultarCodigo");
                foreach (DataRow linha in datatableProfessor.Rows)
                {
                   
                    professor.Cod_Professor = Convert.ToInt32(linha["Cod_Professor"]);
                    professor.Nome_Professor = Convert.ToString(linha["Nome_Professor"]);
                    professor.basePessoa.Data_Nascto = Convert.ToDateTime(linha["Data_Nascto"]);
                    professor.basePessoa.End_Rua = Convert.ToString(linha["End_Rua"]);
                    professor.basePessoa.End_Nr = Convert.ToString(linha["End_Nr"]);
                    professor.basePessoa.End_Comp = Convert.ToString(linha["End_Comp"]);
                    professor.End_Bairro = Convert.ToString(linha["End_Bairro"]);
                    professor.basePessoa.End_Cep = Convert.ToString(linha["End_Cep"]);
                    professor.basePessoa.End_Cidade = Convert.ToString(linha["End_Cidade"]);
                    professor.basePessoa.UF_Residencia = Convert.ToString(linha["UF_Residencia"]);
                    professor.Tel_Residencial = Convert.ToString(linha["Tel_Residencial"]);
                    professor.Tel_Favor = Convert.ToString(linha["Tel_Favor"]);
                    professor.Tel_Celular = Convert.ToString(linha["Tel_Celular"]);
                    professor.basePessoa.End_Referencia = Convert.ToString(linha["End_Referencia"]);
                    professor.Cart_Identidade = Convert.ToString(linha["Cart_Ident"]);
                    professor.Orgao_Expedidor = Convert.ToString(linha["Org_Exped"]);
                    professor.CPF = Convert.ToString(linha["CPF"]);
                    professor.basePessoa.Naturalidade = Convert.ToString(linha["Naturalidade"]);
                    professor.basePessoa.UF_Naturalidade = Convert.ToString(linha["UF_Naturalidade"]);
                    professor.Cod_Escolaridade = Convert.ToInt32(linha["Cod_Escolaridade"]);
                    professor.Cod_Est_Civil = Convert.ToInt32(linha["Cod_Est_Civil"]);
                    professor.basePessoa.Local_Foto = Convert.ToString(linha["Local_Foto"]);
                    professor.Data_Cadastro = Convert.ToDateTime(linha["Data_Cadastro"]);
                     
                    
                    //professorColecao.Add(professor);

                }

                return professor;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o professor por código. Detalhes: " + ex.Message);
            }
        }

        public Boolean ConsultarPorCPF(string cpf)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CPF", cpf);
                DataTable datatableProfessor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorConsultarPorCPF");
                int qtde = datatableProfessor.Rows.Count;
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
                throw new Exception("Não foi possível consultar o Professor por CPF. Detalhes: " + ex.Message);
            }


        }

        public ProfessorColecao ConsultarCombo()
        {
            try
            {
                ProfessorColecao ProfessorColecao = new ProfessorColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable datatableProfessor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorConsultarCombo");
                foreach (DataRow linha in datatableProfessor.Rows)
                {
                    Professor professor = new Professor();
                    professor.Cod_Professor = Convert.ToInt32(linha["Cod_Professor"]);
                    professor.Nome_Professor = Convert.ToString(linha["Nome_Professor"]);
                    ProfessorColecao.Add(professor);
                }

                return ProfessorColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os professores do sistema. Detalhes: " + ex.Message);
            }
        }

        public ProfessorColecao ConsultarRelatorioTurma(int codProfessor)
        {
    
            try
            {
                ProfessorColecao ProfessorColecao = new ProfessorColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", codProfessor);
                DataTable datatableProfessor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorConsultarRelatorioTurma");
                foreach (DataRow linha in datatableProfessor.Rows)
                {
                    Professor professor = new Professor();
                    professor.Cod_Professor = Convert.ToInt32(linha["Cod_Professor"]);
                    professor.Nome_Professor = Convert.ToString(linha["Nome_Professor"]);
                    ProfessorColecao.Add(professor);
                }

                return ProfessorColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os professores do sistema. Detalhes: " + ex.Message);
            }
        }

        public ProfessorColecao ConsultarLista(int codProfessor)
        {
            Professor professor = new Professor();
            professor.basePessoa = new BasePessoa();

            try
            {
                ProfessorColecao professorColecao = new ProfessorColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", codProfessor);

                DataTable datatableProfessor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorConsultarLista");
                foreach (DataRow linha in datatableProfessor.Rows)
                {

                    professor.Cod_Professor = Convert.ToInt32(linha["Cod_Professor"]);
                    professor.Nome_Professor = Convert.ToString(linha["Nome_Professor"]);
                    professor.basePessoa.Data_Nascto = Convert.ToDateTime(linha["Data_Nascto"]);
                    professor.basePessoa.End_Rua = Convert.ToString(linha["End_Rua"]);
                    professor.basePessoa.End_Nr = Convert.ToString(linha["End_Nr"]);
                    professor.basePessoa.End_Comp = Convert.ToString(linha["End_Comp"]);
                    professor.End_Bairro = Convert.ToString(linha["End_Bairro"]);
                    professor.basePessoa.End_Cep = Convert.ToString(linha["End_Cep"]);
                    professor.basePessoa.End_Cidade = Convert.ToString(linha["End_Cidade"]);
                    professor.basePessoa.UF_Residencia = Convert.ToString(linha["UF_Residencia"]);
                    professor.Tel_Residencial = Convert.ToString(linha["Tel_Residencial"]);
                    professor.Tel_Favor = Convert.ToString(linha["Tel_Favor"]);
                    professor.Tel_Celular = Convert.ToString(linha["Tel_Celular"]);
                    professor.basePessoa.End_Referencia = Convert.ToString(linha["End_Referencia"]);
                    professor.Cart_Identidade = Convert.ToString(linha["Cart_Ident"]);
                    professor.Orgao_Expedidor = Convert.ToString(linha["Org_Exped"]);
                    professor.CPF = Convert.ToString(linha["CPF"]);
                    professor.basePessoa.Naturalidade = Convert.ToString(linha["Naturalidade"]);
                    professor.basePessoa.UF_Naturalidade = Convert.ToString(linha["UF_Naturalidade"]);
                    professor.Cod_Escolaridade = Convert.ToInt32(linha["Cod_Escolaridade"]);
                    professor.Cod_Est_Civil = Convert.ToInt32(linha["Cod_Est_Civil"]);
                    professor.basePessoa.Local_Foto = Convert.ToString(linha["Local_Foto"]);
                    professor.Data_Cadastro = Convert.ToDateTime(linha["Data_Cadastro"]);


                    professorColecao.Add(professor);

                }

                return professorColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os professores. Detalhes: " + ex.Message);
            }
        }


    }
}
