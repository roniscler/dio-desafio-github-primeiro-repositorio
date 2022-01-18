using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;


namespace Negocios
{
    public class ResponsavelNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Responsavel responsavel)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", responsavel.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", responsavel.Cod_Item);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Responsavel", responsavel.Nome_Responsavel);
                acessoDadosSqlServer.AdicionarParametros("@End_Rua", responsavel.End_Rua);
                acessoDadosSqlServer.AdicionarParametros("@End_Nr", responsavel.End_Nr);
                acessoDadosSqlServer.AdicionarParametros("@End_Comp", responsavel.End_Comp);
                acessoDadosSqlServer.AdicionarParametros("@End_Bairro", responsavel.End_Bairro);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Res", responsavel.Tel_Res);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Celular", responsavel.Tel_Celular);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Favor", responsavel.Tel_Favor);
                string idResponsavel = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterResponsavel").ToString();
                return idResponsavel;
            }

            catch (Exception excessao)
            {
                return excessao.Message;
            }

        }

        public string Alterar(Responsavel responsavel)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", responsavel.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", responsavel.Cod_Item);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Responsavel", responsavel.Nome_Responsavel);
                acessoDadosSqlServer.AdicionarParametros("@End_Rua", responsavel.End_Rua);
                acessoDadosSqlServer.AdicionarParametros("@End_Nr", responsavel.End_Nr);
                acessoDadosSqlServer.AdicionarParametros("@End_Comp", responsavel.End_Comp);
                acessoDadosSqlServer.AdicionarParametros("@End_Bairro", responsavel.End_Bairro);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Res", responsavel.Tel_Res);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Celular", responsavel.Tel_Celular);
                acessoDadosSqlServer.AdicionarParametros("@Tel_Favor", responsavel.Tel_Favor);
                string idResponsavel = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterResponsavel").ToString();
                return idResponsavel;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Excluir(Responsavel responsavel)
        {
            try
            {
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", responsavel.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", responsavel.Cod_Item);
                string idResponsavel = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterResponsavel").ToString();
                return idResponsavel;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public ResponsavelColecao Consultar(int codAluno, int coditem)
        {
            try
            {
                ResponsavelColecao responsavelColecao = new ResponsavelColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Item", coditem);
                DataTable DataTableResponsavel = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspResponsavelConsultarIndividual");
                foreach (DataRow linha in DataTableResponsavel.Rows)
                {
                    Responsavel responsavel = new Responsavel();
                    responsavel.aluno = new Aluno();
                    responsavel.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    responsavel.Cod_Item = Convert.ToInt32(linha["Cod_Item"]);
                    responsavel.Nome_Responsavel = Convert.ToString(linha["Nome_Responsavel"]);
                    responsavel.End_Rua = Convert.ToString(linha["End_Rua"]);
                    responsavel.End_Nr = Convert.ToString(linha["End_Nr"]);
                    responsavel.End_Comp = Convert.ToString(linha["End_Comp"]);
                    responsavel.End_Bairro = Convert.ToString(linha["End_Bairro"]);
                    responsavel.Tel_Res = Convert.ToString(linha["Tel_Res"]);
                    responsavel.Tel_Celular = Convert.ToString(linha["Tel_Celular"]);
                    responsavel.Tel_Favor = Convert.ToString(linha["Tel_Favor"]);
                    responsavelColecao.Add(responsavel);
                }

                return responsavelColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os responsaveis por esse aluno. Detalhes: " + ex.Message);
            }

        }

        public ResponsavelColecao ConsultarGrid(int codAluno)
        {
            try
            {
                ResponsavelColecao responsavelColecao = new ResponsavelColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                DataTable DataTableResponsavel = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspResponsavelConsultarGrid");
                foreach (DataRow linha in DataTableResponsavel.Rows)
                {
                    Responsavel responsavel = new Responsavel();
                    responsavel.aluno = new Aluno();
                    responsavel.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    responsavel.Cod_Item = Convert.ToInt32(linha["Cod_Item"]);
                    responsavel.Nome_Responsavel = Convert.ToString(linha["Nome_Responsavel"]);
                    responsavel.End_Rua = Convert.ToString(linha["End_Rua"]);
                    responsavel.End_Nr = Convert.ToString(linha["End_Nr"]);
                    responsavel.End_Comp = Convert.ToString(linha["End_Comp"]);
                    responsavel.End_Bairro = Convert.ToString(linha["End_Bairro"]);
                    responsavel.Tel_Res = Convert.ToString(linha["Tel_Res"]);
                    responsavel.Tel_Celular = Convert.ToString(linha["Tel_Celular"]);
                    responsavel.Tel_Favor = Convert.ToString(linha["Tel_Favor"]);
                    responsavelColecao.Add(responsavel);
                }

                return responsavelColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os responsaveis por esse aluno. Detalhes: " + ex.Message);
            }

        }

        public ResponsavelColecao ConsultarRelatorio(int codAluno)
        {
            try
            {
                ResponsavelColecao responsavelColecao = new ResponsavelColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                DataTable DataTableResponsavel = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspResponsavelConsultarRelatorio");
                foreach (DataRow linha in DataTableResponsavel.Rows)
                {
                    Responsavel responsavel = new Responsavel();
                    responsavel.Nome_Responsavel = Convert.ToString(linha["Nome_Responsavel"]);
                    responsavel.End_Rua = Convert.ToString(linha["End_Rua"]);
                    responsavel.End_Nr = Convert.ToString(linha["End_Nr"]);
                    responsavel.End_Comp = Convert.ToString(linha["End_Comp"]);
                    responsavel.End_Bairro = Convert.ToString(linha["End_Bairro"]);
                    responsavel.Tel_Res = Convert.ToString(linha["Tel_Res"]);
                    responsavel.Tel_Celular = Convert.ToString(linha["Tel_Celular"]);
                    responsavel.Tel_Favor = Convert.ToString(linha["Tel_Favor"]);

                    responsavelColecao.Add(responsavel);
                }

                return responsavelColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os responsaveis por esse aluno. Detalhes: " + ex.Message);
            }

        }

    }
}
