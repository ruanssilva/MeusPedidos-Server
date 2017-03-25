using RS.MeusPedidos.Application.Interfaces;
using RS.MeusPedidos.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RS.MeusPedidos.Presentation.Controllers
{
    public class PerfilController : Controller
    {
        private readonly IPerfilAppService _perfilAppService;
        private readonly IConhecimentoAppService _conhecimentoAppService;
        private readonly IEmailAppService _emailAppService;

        public PerfilController(IPerfilAppService perfilAppService, IConhecimentoAppService conhecimentoAppService, IEmailAppService emailAppService)
        {
            _perfilAppService = perfilAppService;
            _conhecimentoAppService = conhecimentoAppService;
            _emailAppService = emailAppService;
        }

        // GET: Perfil
        public ActionResult Index()
        {
            return View(_perfilAppService.Todos());
        }

        // GET: Perfil/Details/5
        public ActionResult Details(Guid id)
        {
            var model = _perfilAppService.ObterPorId(id);
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // GET: Perfil/Create
        public ActionResult Create()
        {


            var conhecimentos = _conhecimentoAppService.Todos();

            PerfilViewModel perfil = new PerfilViewModel
            {
                CondicaoSet = conhecimentos.Select(s => new CondicaoViewModel
                {
                    ConhecimentoId = s.Id,
                    Conhecimento = s.Nome,
                    Pontos = 0
                })
            };

            ViewBag.EmailSet = _emailAppService.Todos();

            return View(perfil);
        }

        // POST: Perfil/Create
        [HttpPost]
        public ActionResult Create(PerfilViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.EmailSet = _emailAppService.Todos();
                    return View(model);
                }

                model.Id = Guid.NewGuid();

                _perfilAppService.Incluir(model);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Perfil/Edit/5
        public ActionResult Edit(Guid id)
        {
            var model = _perfilAppService.ObterPorId(id);
            if (model == null)
                return HttpNotFound();

            Guid[] ids = model.CondicaoSet.Select(s => s.ConhecimentoId).ToArray();

            var conhecimentos = _conhecimentoAppService.Filtrar(f => !ids.Contains(f.Id));
            if (conhecimentos.Count() > 0)
            {
                var condicoes = conhecimentos.Select(s => new CondicaoViewModel
                {
                    ConhecimentoId = s.Id,
                    Conhecimento = s.Nome,
                    Pontos = 0
                }).ToList();

                condicoes.AddRange(model.CondicaoSet);
                model.CondicaoSet = condicoes;
            }

            ViewBag.EmailSet = _emailAppService.Todos();

            return View(model);
        }

        // POST: Perfil/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, PerfilViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.EmailSet = _emailAppService.Todos();
                    return View(model);
                }

                _perfilAppService.Atualizar(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Perfil/Delete/5
        public ActionResult Delete(Guid id)
        {
            var model = _perfilAppService.ObterPorId(id);
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // POST: Perfil/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, PerfilViewModel model)
        {
            try
            {
                _perfilAppService.Remover(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
