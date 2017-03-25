using RS.MeusPedidos.Application.Interfaces;
using RS.MeusPedidos.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RS.MeusPedidos.Presentation.Controllers
{
    public class CandidatoController : Controller
    {
        private readonly IPerfilAppService _perfilAppService;
        private readonly ICandidatoAppService _candidatoAppService;
        private readonly IConhecimentoAppService _conhecimentoAppService;

        public CandidatoController(ICandidatoAppService candidatoAppService, IConhecimentoAppService conhecimentoAppService, IPerfilAppService perfilAppService)
        {
            _candidatoAppService = candidatoAppService;
            _conhecimentoAppService = conhecimentoAppService;
            _perfilAppService = perfilAppService;
        }

        // GET: Candidato
        public ActionResult Index(string id)
        {
            ViewBag.Perfis = _perfilAppService.Todos().Select(s => s.Nome).Distinct();

            if (id == null)
                return View(_candidatoAppService.Todos());

            ViewBag.Perfil = id;
            return View(_candidatoAppService.Filtrar(f => f.Perfil.Contains(id)));
        }

        // GET: Candidato/Details/5
        public ActionResult Details(Guid id)
        {
            var model = _candidatoAppService.ObterPorId(id);
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // GET: Candidato/Details/5
        public ActionResult Plus(Guid id)
        {
            var model = _candidatoAppService.ObterPorId(id);
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // GET: Candidato/Create
        public ActionResult Create()
        {
            var conhecimentos = _conhecimentoAppService.Todos();

            CandidatoViewModel model = new CandidatoViewModel
            {
                RespostaSet = conhecimentos.Select(s => new RespostaViewModel
                {
                    ConhecimentoId = s.Id,
                    Conhecimento = s.Nome,
                    Pontos = 0
                })
            };

            return View(model);
        }

        // POST: Candidato/Create
        [HttpPost]
        public ActionResult Create(CandidatoViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                model.Id = Guid.NewGuid();

                _candidatoAppService.Incluir(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Candidato/Edit/5
        public ActionResult Edit(Guid id)
        {
            var model = _candidatoAppService.ObterPorId(id);
            if (model == null)
                return HttpNotFound();

            Guid[] ids = model.RespostaSet.Select(s => s.ConhecimentoId).ToArray();

            var conhecimentos = _conhecimentoAppService.Filtrar(f => !ids.Contains(f.Id));
            if (conhecimentos.Count() > 0)
            {
                var condicoes = conhecimentos.Select(s => new RespostaViewModel
                {
                    ConhecimentoId = s.Id,
                    Conhecimento = s.Nome,
                    Pontos = 0
                }).ToList();

                condicoes.AddRange(model.RespostaSet);
                model.RespostaSet = condicoes;
            }

            return View(model);
        }

        // POST: Candidato/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, CandidatoViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                _candidatoAppService.Atualizar(model);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Candidato/Delete/5
        public ActionResult Delete(Guid id)
        {
            var model = _candidatoAppService.ObterPorId(id);
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // POST: Candidato/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, CandidatoViewModel model)
        {
            try
            {
                _candidatoAppService.Remover(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
