using System.Collections.Generic;

namespace Livro.Domain.Interfaces.Services
{
    public interface ILivroService : IServiceBase<Livro.Domain.Entities.Livro>
    {
        IEnumerable<Entities.Livro> BuscarPorNomeDoLivro(string nomeLivro);
        IEnumerable<Entities.Livro> BuscarPorNomeDoAutor(string nomeAutor);
        IEnumerable<Entities.Livro> LivrosOrdenadosAscendentePorNome();
    }
}
