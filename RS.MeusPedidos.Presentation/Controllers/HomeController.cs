using RS.MeusPedidos.Application.Interfaces;
using RS.MeusPedidos.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RS.MeusPedidos.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPerfilAppService _perfilAppService;

        public HomeController(IPerfilAppService perfilAppService)
        {
            _perfilAppService = perfilAppService;
        }

        public ActionResult Index()
        {
            return View(_perfilAppService.Todos().Select(s => s.Nome).Distinct());
        }
    }
}