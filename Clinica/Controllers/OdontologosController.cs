﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Controllers
{
    public class OdontologosController : Controller
    {
        // GET: Odontologo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult View(int id)
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}