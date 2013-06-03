using FluentSecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FluentSecurityDemo.Utilities.Helper
{
    /// <summary>
    /// 如果不是Admin，把它轉向Admin的登入頁面
    /// </summary>
    public class AdminPolicyViolationHandler : IPolicyViolationHandler
    {
        public ActionResult Handle(PolicyViolationException exception)
        {
            RouteValueDictionary rvd = new RouteValueDictionary();
            rvd["controller"] = "AdminAccount";
            rvd["Action"] = "Index";
            rvd["Area"] = "Admin";

            return new RedirectToRouteResult(rvd);
        }
    }
}