using squeletteWeb.Métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace squeletteWeb.Controllers
{
    public class MagasinProduitController : Controller
    {
        IMetier imetier = new MetierImpl();
        // GET: MagasinProduit
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ajouterProduitMagasin()
        {
            ViewBag.MagasinId = new SelectList(imetier.listerMagasins(), "MagasinId", "NomMagasin");
            ViewBag.ProduitId = new SelectList(imetier.listerProduits(), "ProduitId", "Nom");
            return View();
        }

        [HttpPost]
        public ActionResult ajouterProduitMagasin(MagasinProduit mp)
        {
            imetier.AjouterMagasinProduit(mp);
            ViewBag.MagasinId = new SelectList(imetier.listerMagasins(), "MagasinId", "NomMagasin");
            ViewBag.ProduitId = new SelectList(imetier.listerProduits(), "ProduitId", "Nom");
            return View();
        }

        public ActionResult listerMagasinProduit()
        {
            var res = imetier.listerMagasinProduit();
            return View(res);
        }
    }
}