using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using AcessoDados;
using ObjetoTrasnferencia;

namespace Negocios
{
    public class MateriaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Materia materia)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Materia", materia.Nome_Materia);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", materia.professor.Cod_Professor);
                string idMateria = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterMateria").ToString();
                return idMateria;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(Materia materia)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Materia", materia.Cod_Materia);
                acessoDadosSqlServer.AdicionarParametros("@Nome_Materia", materia.Nome_Materia);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Professor", materia.professor.Cod_Professor);
                string idMateria = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterMateria").ToString();
                return idMateria;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(Materia materia)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Acao", 0);
                acessoDadosSqlServer.AdicionarParametros("@Cod_Materia", materia.Cod_Materia);
                string idMateria = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterMateria").ToString();
                return idMateria;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public MateriaColecao ConsultarGrid(string nomeMateria)
        {
            try
            {

                MateriaColecao materiaColecaoGrid = new MateriaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome_Materia", nomeMateria);
                DataTable dataTableMateria = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspMateriaConsultarGrid");
                foreach (DataRow linha in dataTableMateria.Rows)
                {
                    Materia materiaGrid = new Materia();
                    materiaGrid.Cod_Materia = Convert.ToInt32(linha["Cod_Materia"]);
                    materiaGrid.Nome_Materia = Convert.ToString(linha["Nome_Materia"]);

                    materiaGrid.professor = new Professor();
                    materiaGrid.professor.Nome_Professor = Convert.ToString(linha["Nome_Professor"]);
                    
                    materiaColecaoGrid.Add(materiaGrid);
                }
                return materiaColecaoGrid;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a Matéria. Detalhes: " + ex.Message);
            }

        }

        public MateriaColecao ConsultarCombo()
        {
            try
            {

                MateriaColecao materiaColecao = new MateriaColecao();
                acessoDadosSqlServer.LimparParametros();
                DataTable dataTableMateria = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspMateriaConsultarCombo");
                foreach (DataRow linha in dataTableMateria.Rows)
                {
                    Materia materia = new Materia();
                    materia.Cod_Materia = Convert.ToInt32(linha["Cod_Materia"]);
                    materia.Nome_Materia = Convert.ToString(linha["Nome_Materia"]);
                    materiaColecao.Add(materia);
                }
                return materiaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a Matéria. Detalhes: " + ex.Message);
            }



        }
    }
}
