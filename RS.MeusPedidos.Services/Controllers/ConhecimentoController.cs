using RS.MeusPedidos.Application.Interfaces;
using RS.MeusPedidos.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RS.MeusPedidos.Services.Controllers
{
    public class ConhecimentoController : ApiController
    {
        private readonly IConhecimentoAppService _conhecimentoAppService;

        public ConhecimentoController(IConhecimentoAppService conhecimentoAppService)
        {
            _conhecimentoAppService = conhecimentoAppService;
        }

        // GET: api/Conhecimento
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _conhecimentoAppService.Todos());
        }
    }
}
