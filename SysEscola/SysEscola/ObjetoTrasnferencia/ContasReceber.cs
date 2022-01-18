﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class ContasReceber
    {
        public int CodContasPagRec { get; set; }
        public Decimal Valor { get; set; }
        public Decimal Juros { get; set; }
        public Decimal Nulta { get; set; }
        public DateTime Data_Vcto { get; set; }
        public DateTime Data_Pgto { get; set; }
        public Boolean Quitado { get; set; }
        public PlanoDeContas PlanoDeContas { get; set; }
        public String Historico { get; set; }
        public FormaDePagto FormaDePagto { get; set; }
        public CentroDeCusto CentroDeCusto { get; set; }
    }
}
