using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter
{
    public class CustomActoinFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p>Danny all up on your OnActionExcution</p>");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var user = filterContext.HttpContext.User.Identity.Name;
            var ipAddress = filterContext.HttpContext.Request.UserHostAddress;
            var timeRequested = DateTime.UtcNow;
            var url = filterContext.HttpContext.Request.RawUrl;

            var result = String.Format("<p>OnActionExecuting: {0} - {1} - {3}<p/>");

            filterContext.HttpContext.Response.Write(result);

            // We can write this to a log file, database, etc


        }
    }


    public class CustomResultFilter: FilterAttribute, IResultFilter
    {

    }
}