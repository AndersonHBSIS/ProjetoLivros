using System;
using System.Web.Http;
using System.Web.Http.Results;

namespace Livro.Api.Controllers
{
    public class HealthController : ApiController
    {
        [HttpGet]
        [Route("health/get")]
        public string Get()
        {
            return "... is live at " + DateTime.Now;
        }
    }
}
