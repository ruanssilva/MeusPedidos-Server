using RS.MeusPedidos.Application.Interfaces;
using RS.MeusPedidos.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RS.MeusPedidos.Presentation.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailAppService _emailAppService;

        public EmailController(IEmailAppService emailAppService)
        {
            _emailAppService = emailAppService;
        }

        // GET: Email
        public ActionResult Index()
        {
            return View(_emailAppService.Todos());
        }

        // GET: Email/Details/5
        public ActionResult Details(Guid id)
        {
            var model = _emailAppService.ObterPorId(id);
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // GET: Email/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Email/Create
        [HttpPost]
        public ActionResult Create(EmailViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                model.Id = Guid.NewGuid();

                _emailAppService.Incluir(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Email/Edit/5
        public ActionResult Edit(Guid id)
        {
            var model = _emailAppService.ObterPorId(id);
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // POST: Email/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, EmailViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                _emailAppService.Atualizar(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Email/Delete/5
        public ActionResult Delete(Guid id)
        {
            var model = _emailAppService.ObterPorId(id);
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // POST: Email/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, EmailViewModel model)
        {
            try
            {
                _emailAppService.Remover(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
