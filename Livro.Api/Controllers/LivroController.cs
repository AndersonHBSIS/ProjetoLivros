using Livro.Application.Interfaces;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Livro.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LivroController : ApiController
    {
        private readonly ILivroAppService _livroAppService;

        public LivroController(ILivroAppService livroAppService)
        {
            this._livroAppService = livroAppService;
        }

        [HttpGet]
        [Route("livro/getallascendingbyname")]
        public HttpResponseMessage GetAllAscendingByName()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, _livroAppService.LivrosOrdenadosAscendentePorNome());
            return response;
        }

        [HttpGet]
        [Route("livro/getAll")]
        public HttpResponseMessage GetAll()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, _livroAppService.GetAll());
            return response;
        }

        [HttpPost]
        [Route("livro/insert")]
        public HttpResponseMessage Insert([FromBody]Domain.Entities.Livro livro)
        {
            _livroAppService.Add(livro);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Inserido com sucesso!");
            return response;
        }

        [HttpPost]
        [Route("livro/update")]
        public HttpResponseMessage Update([FromBody]Domain.Entities.Livro livro)
        {
            _livroAppService.Update(livro);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Inserido com sucesso!");
            return response;
        }

        [HttpPost]
        [Route("livro/delete")]
        public HttpResponseMessage Delete([FromBody]Domain.Entities.Livro livro)
        {
            _livroAppService.Remove(livro);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Inserido com sucesso!");
            return response;
        }

        [HttpPost]
        [Route("livro/getbyid")]
        public HttpResponseMessage GetById([FromBody]int id)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, _livroAppService.GetById(id));
            return response;
        }

        [HttpPost]
        [Route("livro/getbynamebook")]
        public HttpResponseMessage GetByNameBook([FromBody]string nomeLivro)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, _livroAppService.BuscarPorNomeDoLivro(nomeLivro));
            return response;
        }

        [HttpPost]
        [Route("livro/getbynameauthor")]
        public HttpResponseMessage GetByNameAuthor([FromBody]string nomeLivro)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, _livroAppService.BuscarPorNomeDoAutor(nomeLivro));
            return response;
        }
    }
}
