using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class Materia
    {
        public int Cod_Materia { get; set; }
        public String Nome_Materia { get; set; }
        public Professor professor { get; set; }
    }
}
