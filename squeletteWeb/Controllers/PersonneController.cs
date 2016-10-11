using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace squeletteWeb.Controllers
{
    public class PersonneController : Controller
    {
        // GET: Personne
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ajouter()
        {
            return View();
        }

        public ActionResult Modifier()
        {
            return View();
        }

        public ActionResult Supprimer()
        {
            return View();
        }

        public ActionResult Lister()
        {
            return View();
        }
    }
}