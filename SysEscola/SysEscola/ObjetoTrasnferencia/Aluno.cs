using System;

namespace ObjetoTrasnferencia
{
    public class Aluno : BasePessoa

    {
        public int Cod_Aluno { get; set; }
        public string Nome_Aluno { get; set; }
        public bool Sexo{ get; set; }
        public DateTime Data_Cadastro{ get; set; }
        public Bairros bairros { get; set; }
        public string Nacionalidade{ get; set; }
        public Religiao religiao{ get; set; }
        public bool Ativo_Inativo{ get; set; }
        public int Qtde_irmaos{ get; set; }
        public int Idade_Andou{ get; set; }
        public int Idade_Falou{ get; set; }
        public bool Manif_Alergica{ get; set; }
        public Planos planos{ get; set; }
        public DateTime Data_Ini_Contrato{ get; set; }
        public DateTime Data_Fim_Contrato{ get; set; }
        public string Nome_Pai{ get; set; }
        public string Nome_Mae{ get; set; }
        public string Prof_Pai { get; set; }
        public string Prof_Mae { get; set; }
        public CorAluno corAluno { get; set; }
        public RespLegal respLegal { get; set; }
    }
}
