using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using Negocios;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class SerieNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(SerieEstudantil serie)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Serie", serie.Nome_Serie);
                string idSerie = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterSerieEstudantil").ToString();
                return idSerie;
            }

            catch (Exception excessao)
            {
                return excessao.Message;
            }

        }

        public string Alterar(SerieEstudantil serie)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Serie", serie.Cod_Serie);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Serie", serie.Nome_Serie);
                string IdDoenca = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterSerieEstudantil").ToString();
                return IdDoenca;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public SerieEstudantilColecao ConsultarGrid()
        {
            try
            {
                SerieEstudantilColecao serieColecao = new SerieEstudantilColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable DataTablSerie = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspSerieEstudantilConsultarGrid");
                foreach (DataRow linha in DataTablSerie.Rows)
                {
                    SerieEstudantil serie = new SerieEstudantil();
                    serie.Cod_Serie = Convert.ToInt32(linha["Cod_Serie"]);
                    serie.Nome_Serie = Convert.ToString(linha["Nome_Serie"]);
                    serieColecao.Add(serie);
                }

                return serieColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a série estudantil. Detalhes: " + ex.Message);
            }

        }

        public string Excluir(SerieEstudantil serie)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Serie", serie.Cod_Serie);
                string CodSerie = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterSerieEstudantil").ToString();
                return CodSerie;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public SerieEstudantilColecao ConsultarNome(String nomeSerie)
        {
            try
            {
                SerieEstudantilColecao serieCOlecao = new SerieEstudantilColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome_Serie", nomeSerie);
                DataTable DataTableSerie = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspSerieEstudantilConsultar");
                foreach (DataRow linha in DataTableSerie.Rows)
                {
                    SerieEstudantil serieEstudantil = new SerieEstudantil();
                    serieEstudantil.Cod_Serie = Convert.ToInt32(linha["Cod_Serie"]);
                    serieEstudantil.Nome_Serie = Convert.ToString(linha["Nome_Serie"]);
                    serieCOlecao.Add(serieEstudantil);
                }

                return serieCOlecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a série estudantil. Detalhes: " + ex.Message);
            }

        }

        public SerieEstudantilColecao ConsultarRelatorio(int CodSerie)
        {
            try
            {
                SerieEstudantilColecao serieCOlecao = new SerieEstudantilColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Serie", CodSerie);
                DataTable DataTableSerie = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspSerieEstudantilConsultarRelatorio");
                foreach (DataRow linha in DataTableSerie.Rows)
                {
                    SerieEstudantil serieEstudantil = new SerieEstudantil();
                    serieEstudantil.Cod_Serie = Convert.ToInt32(linha["Cod_Serie"]);
                    serieEstudantil.Nome_Serie = Convert.ToString(linha["Nome_Serie"]);
                    serieCOlecao.Add(serieEstudantil);
                }

                return serieCOlecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a série estudantil. Detalhes: " + ex.Message);
            }

        }

    }
}
