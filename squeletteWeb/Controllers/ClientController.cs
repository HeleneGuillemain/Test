using squeletteWeb.Métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace squeletteWeb.Controllers
{
    public class ClientController : Controller
    {
        IMetier imetier = new MetierImpl();
        // GET: Client
        public ActionResult IndexClient()
        {
            ICollection<Client> res = imetier.listerClients();
            return View(res);
        }

        

        public ActionResult AjouterClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjouterClient(Client c)
        {
            if (ModelState.IsValid)
            {
                imetier.AjouterClient(c);
                return RedirectToAction("IndexClient");
            }
            else
            {
                return View(c);
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Client c)
        {
                var monUser = imetier.loginUser(c);
                if(monUser != null)
                {
                    Session["ClientId"] = monUser.ClientId;
                    Session["Prenom"] = monUser.Surname;

                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Utilisateur ou mot de passe incorrect");
                    return View();
                }
           

        }

        public ActionResult LoggedIn()
        {
            if (Session["ClientId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            Session["ClientId"] = null;
            Session["Prenom"] = null;
            return RedirectToAction("Login");
        }
    }

        
}