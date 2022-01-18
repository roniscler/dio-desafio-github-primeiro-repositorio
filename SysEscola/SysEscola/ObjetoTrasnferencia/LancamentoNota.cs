using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class LancamentoNota
    {
        public int Cod_Lancamento { get; set; }
        public Aluno aluno { get; set; }
        public Turma turma { get; set; }
        public Materia materia { get; set; }
        public Bimestres bimestres { get; set; }
        public decimal Nota { get; set; }
    }
}
