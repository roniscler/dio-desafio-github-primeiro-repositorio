using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;


namespace Negocios
{
    public class BimestreNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public BimestresColecao Consultar()
        {
            try
            {
                BimestresColecao bimestresColecao = new BimestresColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable DataTableBimestres = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspBimestreConsultarCombo");
                foreach (DataRow linha in DataTableBimestres.Rows)
                {
                    Bimestres bimestres = new Bimestres();
                    bimestres.Cod_Bimestre = Convert.ToInt32(linha["Cod_Bimestre"]);
                    bimestres.Nome_Bim = Convert.ToString(linha["Nome_Bimestre"]);
                    bimestresColecao.Add(bimestres);
                }

                return bimestresColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os bimestres. Detalhes: " + ex.Message);
            }

        }

    }
}
