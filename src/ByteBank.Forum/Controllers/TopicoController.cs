using ByteBank.Forum.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ByteBank.Forum.Controllers
{
    public class TopicoController : Controller
    {
        [Authorize]
        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Criar(TopicoCriarViewModel modelo)
        {
            return View();
        }
    }
}