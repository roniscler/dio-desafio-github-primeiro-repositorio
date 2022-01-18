using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AcessoDados;
using ObjetoTrasnferencia;
using System.Data;


namespace Negocios
{
    public class Dados_EmpresaNegocios
    {

        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(DadosEmpresa dadosEmpresa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Empresa", dadosEmpresa.Nome_Empresa);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Fantasia", dadosEmpresa.Nome_Fantasia);
                acessoDadosSqlServer.AdicionarParametros("@CNPJ", dadosEmpresa.CNPJ);
                acessoDadosSqlServer.AdicionarParametros("@Emp_End_Rua", dadosEmpresa.End_Rua);
                acessoDadosSqlServer.AdicionarParametros("@Emp_End_Nr", dadosEmpresa.End_Nr);
                acessoDadosSqlServer.AdicionarParametros("@Emp_End_Comp", dadosEmpresa.End_Comp);
                acessoDadosSqlServer.AdicionarParametros("@Emp_End_Bairro", dadosEmpresa.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@Emp_End_Cidade", dadosEmpresa.End_Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Emp_End_Cep", dadosEmpresa.End_Cep);
                acessoDadosSqlServer.AdicionarParametros("@Emp_UF", dadosEmpresa.Emp_UF);
                acessoDadosSqlServer.AdicionarParametros("@Insc_Estadual", dadosEmpresa.Insc_Estadual);
                acessoDadosSqlServer.AdicionarParametros("@Emp_telefone", dadosEmpresa.Emp_Telefone);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Diretora", dadosEmpresa.Nome_Diretora);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Pedagoga", dadosEmpresa.Nome_Pedagoda);
                acessoDadosSqlServer.AdicionarParametros("@Taxa_Multa_Dia", dadosEmpresa.Taxa_Multa);
                acessoDadosSqlServer.AdicionarParametros("@Taxa_Juros", dadosEmpresa.Taxa_Juros);
                acessoDadosSqlServer.AdicionarParametros("@Lim_Dias_Multa", dadosEmpresa.Lim_Dias_Multa);
                acessoDadosSqlServer.AdicionarParametros("@Insc_Municipal", dadosEmpresa.Insc_Municipal);



                string idEmpresa = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterDadosEmpresa").ToString();
                return idEmpresa;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(DadosEmpresa dadosEmpresa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Empresa", dadosEmpresa.Cod_Empresa);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Empresa", dadosEmpresa.Nome_Empresa);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Fantasia", dadosEmpresa.Nome_Fantasia);
                acessoDadosSqlServer.AdicionarParametros("@CNPJ", dadosEmpresa.CNPJ);
                acessoDadosSqlServer.AdicionarParametros("@Emp_End_Rua", dadosEmpresa.End_Rua);
                acessoDadosSqlServer.AdicionarParametros("@Emp_End_Nr", dadosEmpresa.End_Nr);
                acessoDadosSqlServer.AdicionarParametros("@Emp_End_Comp", dadosEmpresa.End_Comp);
                acessoDadosSqlServer.AdicionarParametros("@Emp_End_Bairro", dadosEmpresa.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@Emp_End_Cidade", dadosEmpresa.End_Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Emp_End_Cep", dadosEmpresa.End_Cep);
                acessoDadosSqlServer.AdicionarParametros("@Emp_UF", dadosEmpresa.Emp_UF);
                acessoDadosSqlServer.AdicionarParametros("@Insc_Estadual", dadosEmpresa.Insc_Estadual);
                acessoDadosSqlServer.AdicionarParametros("@Emp_telefone", dadosEmpresa.Emp_Telefone);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Diretora", dadosEmpresa.Nome_Diretora);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Pedagoga", dadosEmpresa.Nome_Pedagoda);
                acessoDadosSqlServer.AdicionarParametros("@Taxa_Multa_Dia", dadosEmpresa.Taxa_Multa);
                acessoDadosSqlServer.AdicionarParametros("@Taxa_Juros", dadosEmpresa.Taxa_Juros);
                acessoDadosSqlServer.AdicionarParametros("@Lim_Dias_Multa", dadosEmpresa.Lim_Dias_Multa);
                acessoDadosSqlServer.AdicionarParametros("@Insc_Municipal", dadosEmpresa.Insc_Municipal);

                string idEmpresa = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterDadosEmpresa").ToString();
                return idEmpresa;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(DadosEmpresa dadosEmpresa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Empresa", dadosEmpresa.Cod_Empresa);
                string idEmpresa = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterDadosEmpresa").ToString();
                return idEmpresa;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable Consultar()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                
                DataTable dataTableEmpresa = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDadosEmpresaConsultar");
                return dataTableEmpresa;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados da empresa. Detalhes: " + ex.Message);
            }

        }

        public DadosEmpresaColecao ConsultarRelatorio()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                DadosEmpresaColecao dadosEmpresaColecao = new DadosEmpresaColecao();
                DataTable dataTableEmpresa = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDadosEmpresaConsultar");

                foreach (DataRow linha in dataTableEmpresa.Rows)
                {
                    DadosEmpresa dadosEmpresa = new DadosEmpresa();

                    dadosEmpresa.Cod_Empresa = Convert.ToInt32(dataTableEmpresa.Rows[0]["Cod_Empresa"]);
                    dadosEmpresa.Nome_Empresa = Convert.ToString(dataTableEmpresa.Rows[0]["Nome_Empresa"]);
                    dadosEmpresa.Nome_Fantasia = Convert.ToString(dataTableEmpresa.Rows[0]["Nome_Fantasia"]);
                    dadosEmpresa.CNPJ = Convert.ToString(dataTableEmpresa.Rows[0]["CNPJ"]);
                    dadosEmpresa.End_Rua = Convert.ToString(dataTableEmpresa.Rows[0]["Emp_End_Rua"]);
                    dadosEmpresa.End_Nr = Convert.ToString(dataTableEmpresa.Rows[0]["Emp_End_Nr"]);
                    dadosEmpresa.End_Comp = Convert.ToString(dataTableEmpresa.Rows[0]["Emp_End_Comp"]);
                    dadosEmpresa.Bairro = Convert.ToString(dataTableEmpresa.Rows[0]["Emp_End_Bairro"]);
                    dadosEmpresa.End_Cidade = Convert.ToString(dataTableEmpresa.Rows[0]["Emp_End_Cidade"]);
                    dadosEmpresa.End_Cep = Convert.ToString(dataTableEmpresa.Rows[0]["Emp_End_Cep"]);
                    dadosEmpresa.Emp_UF = Convert.ToString(dataTableEmpresa.Rows[0]["Emp_UF"]);
                    dadosEmpresa.Insc_Estadual = Convert.ToString(dataTableEmpresa.Rows[0]["Insc_Estadual"]);
                    dadosEmpresa.Emp_Telefone = Convert.ToString(dataTableEmpresa.Rows[0]["Emp_Telefone"]);
                    dadosEmpresa.Nome_Diretora = Convert.ToString(dataTableEmpresa.Rows[0]["Nome_Diretora"]);
                    dadosEmpresa.Nome_Pedagoda = Convert.ToString(dataTableEmpresa.Rows[0]["Nome_Pedagoga"]);
                    dadosEmpresa.Taxa_Multa = Convert.ToDecimal(dataTableEmpresa.Rows[0]["Taxa_Multa_Dia"]);
                    dadosEmpresa.Taxa_Juros = Convert.ToDecimal(dataTableEmpresa.Rows[0]["Taxa_Juros"]);
                    dadosEmpresa.Lim_Dias_Multa = Convert.ToInt16(dataTableEmpresa.Rows[0]["Lim_Dias_Multa"]);
                    dadosEmpresa.Insc_Municipal = Convert.ToString(dataTableEmpresa.Rows[0]["Insc_Municipal"]);

                    dadosEmpresaColecao.Add(dadosEmpresa);
                }

                return dadosEmpresaColecao;
                                
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os dados da empresa. Detalhes: " + ex.Message);
            }

        }
    }
}
