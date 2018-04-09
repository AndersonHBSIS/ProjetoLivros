using System.Collections.Generic;

namespace Livro.Application.Interfaces
{
    public interface ILivroAppService : IAppServiceBase<Domain.Entities.Livro>
    {
        IEnumerable<Domain.Entities.Livro> BuscarPorNomeDoLivro(string nomeLivro);
        IEnumerable<Domain.Entities.Livro> BuscarPorNomeDoAutor(string nomeAutor);
        IEnumerable<Domain.Entities.Livro> LivrosOrdenadosAscendentePorNome();
    }
}
