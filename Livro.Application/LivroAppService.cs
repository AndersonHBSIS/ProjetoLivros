using System.Collections.Generic;
using Livro.Application.Interfaces;
using Livro.Domain.Entities;
using Livro.Domain.Interfaces.Services;

namespace Livro.Application
{
    public class LivroAppService : AppServiceBase<Domain.Entities.Livro>, ILivroAppService
    {
        private readonly ILivroService _livroService;

        public LivroAppService(ILivroService livroService)
            :base(livroService)
        {
            this._livroService = livroService;
        }

        public IEnumerable<Domain.Entities.Livro> BuscarPorNomeDoAutor(string nomeAutor)
        {
            return _livroService.BuscarPorNomeDoAutor(nomeAutor);
        }

        public IEnumerable<Domain.Entities.Livro> BuscarPorNomeDoLivro(string nomeLivro)
        {
            return _livroService.BuscarPorNomeDoLivro(nomeLivro);
        }

        public IEnumerable<Domain.Entities.Livro> LivrosOrdenadosAscendentePorNome()
        {
            return _livroService.LivrosOrdenadosAscendentePorNome();
        }
    }
}
