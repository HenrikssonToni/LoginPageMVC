using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginPageWithDataBase.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home


        //This controller is made for the view you see after succesfull login!!!
        //GET IT?!?!?!!?
        public ActionResult Index()
        {
            return View();
        }
    }
}