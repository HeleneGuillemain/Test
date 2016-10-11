using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassingData.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info
        public ActionResult Index()
        {
            return View();
        }

        //Passage de paramètres avec ViewData
        public ActionResult MyViewData()
        {
            //le nom du ViewData n'a pas de rapport avec le nom de l'ActionResult
            ViewData["MyViewData"] = "My View Data";
            return View();
        }

        //Passage de paramètres avec ViewBag
        public ActionResult MyViewBag()
        {
            ViewBag.MyViewBag = "My View Bag";
            return View();
        }

        //Passage de paramètres avec TempData
        public ActionResult FirstAction()
        {
            TempData["MyTempData"] = "My Temp Data";
            return RedirectToAction("SecondAction");
        }

        public ActionResult SecondAction()
        {
            return View();
        }

        //Passage de paramètres avec Session
        public ActionResult MySessionVariable()
        {
            int mySessionCounter = 0;
            if(Session["MySessionVariable"] != null)
            {
                mySessionCounter = int.Parse(Session["MySessionVariable"].ToString());
            }
            mySessionCounter++;
            Session["MySessionVariable"] = mySessionCounter;
            return View();
        }

    }
}