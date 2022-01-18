using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class Turma
    {
        public int Cod_Turma { get; set; }
        public string Nome_Turma { get; set; }
        public string Ano_Letivo { get; set; }
        public string Nr_Sala { get; set; }
        public int Cod_Serie { get; set; }
        public string Observacao { get; set; }
        public bool Desativada { get; set; }
        public int Turno { get; set; }
    }
}
