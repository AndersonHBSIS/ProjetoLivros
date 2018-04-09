using System.Collections.Generic;

namespace Livro.Domain.Interfaces
{
    public interface ILivroRepository : IRepositoryBase<Livro.Domain.Entities.Livro>
    {
        IEnumerable<Entities.Livro> BuscarPorNomeDoLivro(string nomeLivro);
        IEnumerable<Entities.Livro> BuscarPorNomeDoAutor(string nomeAutor);
        IEnumerable<Entities.Livro> LivrosOrdenadosAscendentePorNome();
    }
}
