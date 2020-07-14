using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cambios.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        //PANTALLAS PORTAL//
        public ActionResult Pantusuario()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Pantadmin()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Panttec()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //PANTALLAS GESTION CAMBIOS//

        public ActionResult Cambios()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Regusers()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Aprobaciones()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Catalogos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Acciones()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
