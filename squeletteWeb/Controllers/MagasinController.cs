using squeletteWeb.Métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace squeletteWeb.Controllers
{
    public class MagasinController : Controller
    {
        // GET: Magasin
        IMetier imetier = new MetierImpl();

        public ActionResult IndexMagasin()
        {
            ICollection<Magasin> res = imetier.listerMagasins();
            return View(res);
        }

        public ActionResult AjouterMagasin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjouterMagasin(Magasin m)
        {
            imetier.AjouterMagasin(m);
            return RedirectToAction("IndexMagasin");
        }

        public ActionResult DeleteMagasin(int id)
        {
            imetier.DeleteMagasin(id);
            return RedirectToAction("IndexMagasin");
        }

        public ActionResult EditerMagasin(int id)
        {
            Magasin m = imetier.trouverMagasin(id);
            return View(m);
        }

        [HttpPost]
        public ActionResult EditerMagasin(Magasin m)
        {
            imetier.EditerMagasin(m);
            return RedirectToAction("IndexMagasin");
        }
    }
}