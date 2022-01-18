using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class AlunoAfastamento
    {
        public int Cod_Aluno { get; set; }
        public int Cod_Item { get; set; }
        public DateTime Data_Afastamento { get; set; }
        public string Motivo { get; set; }
    }
}
