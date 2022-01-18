using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class EloTurmaProfessor 
    {
        public Professor professor { get; set; }
        public Turma turma { get; set; }
        public Int16 Cod_Item { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}
