using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class ProfessorAfastamento
    {
        public int Cod_Professor { get; set; }
        public int Cod_Item { get; set; }
        public DateTime Dt_afast { get; set; }
        public Int16 Dias { get; set; }
        public  string Motivo { get; set; }
    }
}
