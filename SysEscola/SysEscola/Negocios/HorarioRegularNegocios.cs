using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ObjetoTrasnferencia;
using AcessoDados;


namespace Negocios
{
    public class HorarioRegularNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(HorarioRegular horarioRegular)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Desc_HorarioRegular", horarioRegular.Desc_Horario);
                string idElemento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterHorarioRegular").ToString();
                return idElemento;
            }

            catch (Exception excessao)
            {
                return excessao.Message;
            }

        }

        public string Alterar(HorarioRegular horarioRegular)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Horario", horarioRegular.Cod_Horario);
                acessoDadosSqlServer.AdicionarParametros("@Desc_HorarioRegular", horarioRegular.Desc_Horario);
                string codElemento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterHorarioRegular").ToString();
                return codElemento;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Excluir(HorarioRegular HorarioRegular)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Horario", HorarioRegular.Cod_Horario);
                string codElemento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterHorarioRegular").ToString();
                return codElemento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public HorarioRegularColecao Consultar(String descHabito)
        {
            try
            {
                HorarioRegularColecao HoraRegularColecao = new HorarioRegularColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Desc_HorarioRegular", descHabito);
                DataTable DataTableHoraRegular = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspHorarioRegularConsultar");
                foreach (DataRow linha in DataTableHoraRegular.Rows)
                {
                    HorarioRegular horaRegular = new HorarioRegular();
                    horaRegular.Cod_Horario = Convert.ToInt32(linha["Cod_Horario"]);
                    horaRegular.Desc_Horario = Convert.ToString(linha["Desc_HorarioRegular"]);
                    HoraRegularColecao.Add(horaRegular);
                }

                return HoraRegularColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os Horários Regulares do aluno. Detalhes: " + ex.Message);
            }

        }

        public HorarioRegularColecao ConsultarRelatorio(int codAluno)
        {
            try
            {
                HorarioRegularColecao HoraRegularColecao = new HorarioRegularColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Cod_Aluno", codAluno);
                DataTable DataTableHoraRegular = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspHorarioRegularConsultarRelatorio");
                foreach (DataRow linha in DataTableHoraRegular.Rows)
                {
                    HorarioRegular horaRegular = new HorarioRegular();
                    horaRegular.Desc_Horario = Convert.ToString(linha["Desc_HorarioRegular"]);
                    HoraRegularColecao.Add(horaRegular);
                }

                return HoraRegularColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar os Horários Regulares do aluno. Detalhes: " + ex.Message);
            }

        }

    }
}
