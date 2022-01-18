using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessoDados;
using ObjetoTrasnferencia;
using System.Data;

namespace Negocios
{
    public class BackupRestoreNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        
        public String Backup(string caminho, string nomeBD)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Caminho", caminho);
                acessoDadosSqlServer.AdicionarParametros("@nomeBD", nomeBD);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspBackupBancodeDados").ToString();
                return retorno;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar o Backup. Detalhes: " + ex.Message);
            }

        }
    }
}
