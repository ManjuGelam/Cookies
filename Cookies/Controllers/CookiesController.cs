using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookies.Controllers
{
    public class CookiesController : Controller
    {
        public ViewResult Index1(int? Id, string Name, double? Price)
        {
            HttpCookie cookie = new HttpCookie("ProductCookie");
            cookie["Id"] = Id.ToString();
            cookie["Name"] = Name;
            cookie["Price"] = Price.ToString();
            cookie.Expires = DateTime.Now.AddDays(3);
            Response.Cookies.Add(cookie);
            return View();
        }
        public ViewResult Index2()
        {
            return View();
        }


    }
}