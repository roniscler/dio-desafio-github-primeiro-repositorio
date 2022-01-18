using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class Carnezinho
    {
        public int Cod_Coarnezinho { get; set; }
        public String  Parcela { get; set; }
        public DateTime Data_Vcto { get; set; }
        public Decimal Valor { get; set; }
        public String Titulo { get; set; }
        public Aluno aluno { get; set; }
    }
}
