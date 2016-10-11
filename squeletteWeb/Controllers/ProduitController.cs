using squeletteWeb.Métier;
using squeletteWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace squeletteWeb.Controllers
{
    public class ProduitController : Controller
    {
        public IMetier imetier = new MetierImpl();

        // GET: Produit
        public ActionResult Index()
        {
            ICollection<ProduitCatModel> res = imetier.findAllProduitCategorie();
            return View(res);
        }

        public ActionResult AjouterProduit()
        {
            ViewBag.CategorieId = new SelectList(imetier.listerCategories(), "CategorieId","NomCategorie");
            return View();
        }

        [HttpPost]
        public ActionResult AjouterProduit(Produit p)
        {
            imetier.AjouterProduit(p);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            imetier.supprimerProduit(id);
            return RedirectToAction("Index");
        }

        public ActionResult Editer(int id)
        {
            Produit p = imetier.trouverProduit(id);
            ViewBag.CategorieId = new SelectList(imetier.listerCategories(), "CategorieId", "NomCategorie");
            return View(p);
        }

        [HttpPost]
        public ActionResult Editer(Produit p)
        {
            imetier.Editer(p);
            return RedirectToAction("Index");
        }

        public ActionResult TrouverProduitsParNom()
        {
            IEnumerable<Produit> res = imetier.listerProduits();
            return View(res);
        }

        [HttpPost]
        public ActionResult TrouverProduitsParNom(string nom)
        {
            IEnumerable<Produit> res = imetier.findProduitsByName(nom);
            return View(res);
        }


    }
}