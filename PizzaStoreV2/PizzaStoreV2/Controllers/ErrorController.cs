using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreV2.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Erro
        [HandleError]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Opps()
        {
            return View();
        }
    }
}