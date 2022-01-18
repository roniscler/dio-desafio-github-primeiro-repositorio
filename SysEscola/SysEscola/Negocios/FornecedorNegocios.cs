using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class FornecedorNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Fornecedor fornecedor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Fornec", fornecedor.Nome_Fornec);
                acessoDadosSqlServer.AdicionarParametros("@End_Rua", fornecedor.End_Rua);
                acessoDadosSqlServer.AdicionarParametros("@End_Nr", fornecedor.End_Nr);
                acessoDadosSqlServer.AdicionarParametros("@End_Comp", fornecedor.End_Comp);
                acessoDadosSqlServer.AdicionarParametros("@End_Bairro", fornecedor.End_Bairro);
                acessoDadosSqlServer.AdicionarParametros("@End_Cidade", fornecedor.End_Cidade);
                acessoDadosSqlServer.AdicionarParametros("@End_UF", fornecedor.End_UF);
                acessoDadosSqlServer.AdicionarParametros("@End_Cep", fornecedor.End_Cep);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", fornecedor.Telefone);
                acessoDadosSqlServer.AdicionarParametros("@Telefone2", fornecedor.Telefone2);
                acessoDadosSqlServer.AdicionarParametros("@Contato", fornecedor.Contato);
                acessoDadosSqlServer.AdicionarParametros("@CNPJ", fornecedor.CNPJ);
                acessoDadosSqlServer.AdicionarParametros("@Insc_Est", fornecedor.Insc_Est);
                acessoDadosSqlServer.AdicionarParametros("@Insc_Mun", fornecedor.Insc_Mun);

                string idFornecedor = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterFornecedor").ToString();
                return idFornecedor;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(Fornecedor fornecedor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Fornecedor", fornecedor.Cod_Fornecedor);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Fornec", fornecedor.Nome_Fornec);
                acessoDadosSqlServer.AdicionarParametros("@End_Rua", fornecedor.End_Rua);
                acessoDadosSqlServer.AdicionarParametros("@End_Nr", fornecedor.End_Nr);
                acessoDadosSqlServer.AdicionarParametros("@End_Comp", fornecedor.End_Comp);
                acessoDadosSqlServer.AdicionarParametros("@End_Bairro", fornecedor.End_Bairro);
                acessoDadosSqlServer.AdicionarParametros("@End_Cidade", fornecedor.End_Cidade);
                acessoDadosSqlServer.AdicionarParametros("@End_UF", fornecedor.End_UF);
                acessoDadosSqlServer.AdicionarParametros("@End_Cep", fornecedor.End_Cep);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", fornecedor.Telefone);
                acessoDadosSqlServer.AdicionarParametros("@Telefone2", fornecedor.Telefone2);
                acessoDadosSqlServer.AdicionarParametros("@Contato", fornecedor.Contato);
                acessoDadosSqlServer.AdicionarParametros("@CNPJ", fornecedor.CNPJ);
                acessoDadosSqlServer.AdicionarParametros("@Insc_Est", fornecedor.Insc_Est);
                acessoDadosSqlServer.AdicionarParametros("@Insc_Mun", fornecedor.Insc_Mun);

                string idEmpresa = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterFornecedor").ToString();
                return idEmpresa;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(Fornecedor fornecedor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Fornecedor", fornecedor.Cod_Fornecedor);
                string idEmpresa = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterFornecedor").ToString();
                return idEmpresa;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public FornecedorColecao Consultar(string nomeFornecedor)
        {
            try
            {
                FornecedorColecao fornecedorColecao = new FornecedorColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome_Fornec", nomeFornecedor);
                DataTable datatableFornecedor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspForncedorCopnsultarPorNome");
                foreach (DataRow linha in datatableFornecedor.Rows)
                {
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.Cod_Fornecedor = Convert.ToInt32(linha["Cod_Fornecedor"]);
                    fornecedor.Nome_Fornec = Convert.ToString(linha["Nome_Fornec"]);
                    fornecedor.End_Rua = Convert.ToString(linha["End_Rua"]);
                    fornecedor.End_Nr = Convert.ToString(linha["End_Nr"]);
                    fornecedor.End_Comp = Convert.ToString(linha["End_Comp"]);
                    fornecedor.End_Bairro = Convert.ToString(linha["End_Bairro"]);
                    fornecedor.End_Cidade = Convert.ToString(linha["End_Cidade"]);
                    fornecedor.End_UF = Convert.ToString(linha["End_UF"]);
                    fornecedor.End_Cep = Convert.ToString(linha["End_Cep"]);
                    fornecedor.Telefone = Convert.ToString(linha["Telefone"]);
                    fornecedor.Telefone2 = Convert.ToString(linha["Telefone2"]);
                    fornecedor.Contato = Convert.ToString(linha["Contato"]);
                    fornecedor.CNPJ = Convert.ToString(linha["CNPJ"]);
                    fornecedor.Insc_Est = Convert.ToString(linha["Insc_Est"]);
                    fornecedor.Insc_Mun = Convert.ToString(linha["Insc_Mun"]);
                    fornecedorColecao.Add(fornecedor);
                }

                return fornecedorColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o Fornecedor. Detalhes: " + ex.Message);
            }

        }


    }
}
