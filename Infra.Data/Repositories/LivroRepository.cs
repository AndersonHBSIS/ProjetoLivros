using System.Collections.Generic;
using System.Linq;
using Livro.Domain.Entities;
using Livro.Domain.Interfaces;

namespace Infra.Data.Repositories
{
    public class LivroRepository : RepositoryBase<Livro.Domain.Entities.Livro>, ILivroRepository
    {
        public IEnumerable<Livro.Domain.Entities.Livro> BuscarPorNomeDoAutor(string nomeAutor)
        {
            return Db.Livros.Where(_ => _.NomeAutor == nomeAutor);
        }

        public IEnumerable<Livro.Domain.Entities.Livro> BuscarPorNomeDoLivro(string nomeLivro)
        {
            return Db.Livros.Where(_ => _.Nome == nomeLivro);
        }

        public IEnumerable<Livro.Domain.Entities.Livro> LivrosOrdenadosAscendentePorNome()
        {
            return Db.Livros.OrderBy(_ => _.Nome);
        }
    }
}
