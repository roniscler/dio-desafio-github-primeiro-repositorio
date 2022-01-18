using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class Mensalidade
    {
        public int Cod_Mensalidade { get; set; }
        public Turma turma { get; set; }
        public Aluno aluno { get; set; }
        public string Num_Mensalidade { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorJuros { get; set; }
        public decimal ValorMulta { get; set; }

    }
}
