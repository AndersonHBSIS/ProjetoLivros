using System;

namespace Livro.Domain.Entities
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Nome { get; set; }
        public string NomeAutor { get; set; }
        public bool Ativo { get; set; }
    }
}
