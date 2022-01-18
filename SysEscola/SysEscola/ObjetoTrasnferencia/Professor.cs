using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class Professor 
    {

        public BasePessoa basePessoa { get; set; }
        public int Cod_Professor { get; set; }
        public string Nome_Professor { get; set; }
        public string End_Bairro { get; set; }
        public string Tel_Residencial { get; set; }
        public string Cart_Identidade { get; set; }
        public string Orgao_Expedidor { get; set; }
        public string CPF { get; set; }
        public Int32 Cod_Escolaridade { get; set; }
        public Int32 Cod_Est_Civil { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public string Tel_Favor { get; set; }
        public string Tel_Celular { get; set; }
    }
}
