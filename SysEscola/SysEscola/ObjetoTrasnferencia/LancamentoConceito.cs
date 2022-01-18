using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class LancamentoConceito
    {
        public int Cod_Lancamento { get; set; }
        public Aluno aluno { get; set; }
        public Turma turma { get; set; }
        public SubItensAvaliacaoPedagogica subItensAvaliacaoPedagogica { get; set; }
        public Bimestres bimestres { get; set; }
        public TipoConceito tipoConceito { get; set; }
    }
}
