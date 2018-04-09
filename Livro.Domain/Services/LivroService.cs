using System.Collections.Generic;
using Livro.Domain.Entities;
using Livro.Domain.Interfaces;
using Livro.Domain.Interfaces.Services;

namespace Livro.Domain.Services
{
    public class LivroService : ServiceBase<Entities.Livro>, ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
            :base(livroRepository)
        {
            this._livroRepository = livroRepository;
        }

        public IEnumerable<Entities.Livro> BuscarPorNomeDoAutor(string nomeAutor)
        {
            return _livroRepository.BuscarPorNomeDoAutor(nomeAutor);
        }

        public IEnumerable<Entities.Livro> BuscarPorNomeDoLivro(string nomeLivro)
        {
            return _livroRepository.BuscarPorNomeDoLivro(nomeLivro);
        }

        public IEnumerable<Entities.Livro> LivrosOrdenadosAscendentePorNome()
        {
            return _livroRepository.LivrosOrdenadosAscendentePorNome();
        }
    }
}
