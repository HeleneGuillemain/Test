﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace squeletteWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Ajouter()
        {
            ViewBag.Message = "La personne xxx a été ajoutée.";

            return View();
        }

        public ActionResult TestLayout()
        {
            return View();
        }

        public ActionResult TestLayout2()
        {
            return View();
        }

        public ActionResult TestLayoutSousMenu()
        {
            return View();
        }
    }
}