using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class DTOFichaAluno
    {
        public DateTime Data_Nascto { get; set; }
        public string End_Rua { get; set; }
        public string End_Nr { get; set; }
        public string End_Comp { get; set; }
        public string End_Cep { get; set; }
        public string End_Cidade { get; set; }
        public string UF_Residencia { get; set; }
        public string End_Referencia { get; set; }
        public string Naturalidade { get; set; }
        public string UF_Naturalidade { get; set; }
        public string Local_Foto { get; set; }
        public int Cod_Aluno { get; set; }
        public string Nome_Aluno { get; set; }
        public bool Sexo { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public string Nome_Bairro { get; set; }
        public string Nacionalidade { get; set; }
        public string Des_Religiao { get; set; }
        public bool Ativo_Inativo { get; set; }
        public int Qtde_irmaos { get; set; }
        public int Idade_Andou { get; set; }
        public int Idade_Falou { get; set; }
        public bool Manif_Alergica { get; set; }
        public int Cod_Plano { get; set; }
        public string Desc_Plano { get; set; }
        public DateTime Data_Ini_Contrato { get; set; }
        public DateTime Data_Fim_Contrato { get; set; }
        public string Nome_Pai { get; set; }
        public string Nome_Mae { get; set; }
        public string Prof_Pai { get; set; }
        public string Prof_Mae { get; set; }
        public string Desc_CoraAluno { get; set; }
        public string NomeRepLegal {get; set;}
        public int Cod_RepLegal { get; set; }

    }
}
