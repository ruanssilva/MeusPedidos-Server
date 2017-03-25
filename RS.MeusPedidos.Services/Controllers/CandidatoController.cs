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
    public class CandidatoController : ApiController
    {
        private readonly ICandidatoAppService _candidatoAppService;

        public CandidatoController(ICandidatoAppService candidatoAppService)
        {
            _candidatoAppService = candidatoAppService;
        }

        // GET: api/Candidato/5
        public HttpResponseMessage Get(string nome, string email)
        {
            CandidatoViewModel candidato = _candidatoAppService.ObterPorEmail(email, nome);
            if (candidato == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Registro não encontrado");

            candidato.AvaliacaoSet = null;

            return Request.CreateResponse(HttpStatusCode.OK, candidato);
        }

        // POST: api/Candidato
        public HttpResponseMessage Post([FromBody]CandidatoViewModel model)
        {
            if (!ModelState.IsValid)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Campos não corretamente preenchidos");

            model.Id = Guid.NewGuid();

            model = _candidatoAppService.Incluir(model);

            return Request.CreateResponse(HttpStatusCode.OK, model);
        }
    }
}
