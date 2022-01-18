using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTrasnferencia
{
    public class LivroDidatico
    {
        public int Cod_Livro { get; set; }
        public string Nome_Livro { get; set; }
        public string Editora { get; set; }
        public string Autor { get; set; }
        public string Edicao { get; set; }
        public String Materia { get; set; }
        public GenerosLiterarios generosLiterarios { get; set; }
        public bool Emprestado { get; set; }
        public bool Ativo { get; set; }
        public DateTime Data_Cadastro { get; set; }
    }
}
