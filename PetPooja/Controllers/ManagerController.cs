﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetPooja.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult Login()
        {
            return View();
        }
    }
}