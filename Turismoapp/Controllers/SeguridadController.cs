﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Turismoapp.Controllers
{
    public class SeguridadController : Controller
    {
        // GET: Seguridad
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }

    }
}