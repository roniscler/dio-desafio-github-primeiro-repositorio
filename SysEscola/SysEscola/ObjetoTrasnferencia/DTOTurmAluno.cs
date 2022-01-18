using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class DTOTurmAluno
    {
        public int Cod_Turma { get; set; }
        public string Nome_Turma { get; set; }
        public string Ano_Letivo { get; set; }
        public string Nr_Sala { get; set; }
        public string Nome_Serie { get; set; }
        public string Nome_Aluno { get; set; }
        public DateTime Data_Nascto { get; set; }
        public string Nome_Professor { get; set; }
    }
}
