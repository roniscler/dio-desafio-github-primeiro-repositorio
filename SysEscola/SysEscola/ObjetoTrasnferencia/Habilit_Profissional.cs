using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class Habilit_Profissional
    {
        public int Cod_Habilitacao { get; set; }
        public string Instituicao {get; set;}
        public int Cod_Professor { get; set; }
        public string Desc_Habilitacao { get; set; }
        public DateTime Data_Conclusao { get; set; }
        public string Duracao { get; set; }
    }
}
