using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class DTOMensalidadeCarnet
    {
        public int Cod_ALuno { get; set; }
        public string Nome_Aluno { get; set; }
        public int Cod_Mensalidade { get; set; }
        public string Nome_Turma { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Num_Mensalidade { get; set; }
        public Decimal Valor { get; set; }        
    }
}
