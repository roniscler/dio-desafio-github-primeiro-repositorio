using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;


namespace Negocios
{
    public class EloHorarioRegularNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Excluir(EloHorarioRegular eloHorarioRegular)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloHorarioRegular.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Horario", eloHorarioRegular.horarioRegular.Cod_Horario);

                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloHorarioRegular").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Inserir(EloHorarioRegular eloHorarioRegular)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloHorarioRegular.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Horario", eloHorarioRegular.horarioRegular.Cod_Horario);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloHorarioRegular").ToString();
                return CodElo;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(EloHorarioRegular eloHorarioRegular)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", eloHorarioRegular.aluno.Cod_Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Horario", eloHorarioRegular.horarioRegular.Cod_Horario);
                string CodElo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEloHorarioRegular").ToString();
                return CodElo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public EloHorarioRegularColecao ConsultarGrid(int Cod_Aluno)
        {
            try
            {
                EloHorarioRegularColecao eloHoraRegularColecao = new EloHorarioRegularColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", Cod_Aluno);
                DataTable dataTableElHoraRegular = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEloHoraraioregularConsultar");


                foreach (DataRow linha in dataTableElHoraRegular.Rows)
                {
                    EloHorarioRegular EloHoraRegularGrid = new EloHorarioRegular();
                    EloHoraRegularGrid.aluno = new Aluno();
                    EloHoraRegularGrid.aluno.Cod_Aluno = Convert.ToInt32(linha["Cod_Aluno"]);
                    EloHoraRegularGrid.horarioRegular = new HorarioRegular();
                    EloHoraRegularGrid.horarioRegular.Cod_Horario = Convert.ToInt32(linha["Cod_Horario"]);
                    EloHoraRegularGrid.horarioRegular.Desc_Horario = Convert.ToString(linha["Desc_HorarioRegular"]);
                    eloHoraRegularColecao.Add(EloHoraRegularGrid);
                }

                return eloHoraRegularColecao;
            }


            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os Horários Regulares. Detalhes: " + ex.Message);
            }

        }
    }
}
