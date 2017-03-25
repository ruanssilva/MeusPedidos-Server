using RS.MeusPedidos.Application.Interfaces;
using RS.MeusPedidos.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RS.MeusPedidos.Presentation.Controllers
{
    public class ConhecimentoController : Controller
    {
        private readonly IConhecimentoAppService _conhecimentoAppService;

        public ConhecimentoController(IConhecimentoAppService conhecimentoAppService)
        {
            _conhecimentoAppService = conhecimentoAppService;
        }

        // GET: Conhecimento
        public ActionResult Index()
        {
            return View(_conhecimentoAppService.Todos());
        }

        // GET: Conhecimento/Details/5
        public ActionResult Details(Guid id)
        {
            var model = _conhecimentoAppService.ObterPorId(id);
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // GET: Conhecimento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conhecimento/Create
        [HttpPost]
        public ActionResult Create(ConhecimentoViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                model.Id = Guid.NewGuid();
                                
                _conhecimentoAppService.Incluir(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Conhecimento/Edit/5
        public ActionResult Edit(Guid id)
        {
            var model = _conhecimentoAppService.ObterPorId(id);
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // POST: Conhecimento/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, ConhecimentoViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                _conhecimentoAppService.Atualizar(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Conhecimento/Delete/5
        public ActionResult Delete(Guid id)
        {
            var model = _conhecimentoAppService.ObterPorId(id);
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // POST: Conhecimento/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, ConhecimentoViewModel model)
        {
            try
            {
                _conhecimentoAppService.Remover(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
