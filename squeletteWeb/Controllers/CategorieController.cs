using squeletteWeb.Métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace squeletteWeb.Controllers
{
    public class CategorieController : Controller
    {
        // GET: Categorie
        IMetier imetier = new MetierImpl();

        public ActionResult IndexCategorie()
        {
            ICollection<Categorie> res = imetier.listerCategories();
            return View(res);
        }

        public ActionResult AjouterCategorie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjouterCategorie(Categorie c)
        {
            imetier.AjouterCategorie(c);
            return RedirectToAction("IndexCategorie");
        }

        public ActionResult EditerCategorie(int id)
        {
            Categorie c = imetier.trouverCategorie(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult EditerCategorie(Categorie c)
        {
            imetier.EditerCategorie(c);
            return RedirectToAction("IndexCategorie");
        }

        public ActionResult DeleteCategorie(int id)
        {
            imetier.DeleteCategorie(id);
            return RedirectToAction("IndexCategorie");
        }
    }
}