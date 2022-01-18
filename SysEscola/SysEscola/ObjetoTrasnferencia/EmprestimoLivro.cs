using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class EmprestimoLivro
    {
        public int Cod_Emprestimo { get; set; }
        public Aluno aluno { get; set; }
        public LivroDidatico livroDidatico { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public int QtdeDias { get; set; }
        public DateTime? DataDevolucao { get; set; }

    }
}
