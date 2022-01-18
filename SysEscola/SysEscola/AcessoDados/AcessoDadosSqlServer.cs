using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// namespace's que contêm as classes que manipulam dados

using System.Data;
using System.Data.SqlClient;
using AcessoDados.Properties;


namespace AcessoDados
{
    public class AcessoDadosSqlServer
    {
        //cria a conexão com o banco de dados

        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.StrCon);
        }

        //parâmentros que vão para o banco de dados

        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter (nomeParametro, valorParametro));
        }

        public object ExecutarManipulacao(CommandType commandType, string NomeStoradeProcedureOuTextoSql)
        {

            try
            {
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = NomeStoradeProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable ExecutarConsulta(CommandType commandType, string NomeStoradeProcedureOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = NomeStoradeProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
