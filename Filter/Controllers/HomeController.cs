﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            var result = filterContext.Result;
            base.OnActionExecuted(filterContext);
        }
    }
}