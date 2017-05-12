using LoginPageWithDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Autherize(LoginPageWithDataBase.Models.Login userModel)
        {
            using (LoginTestEntities db = new LoginTestEntities())
            {

                var userDetails = db.Login.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();

                //IF THE PASSWORD OR USERNAME DOES NOT MATCH THE ONES STORED IN THE DATABASE, 
                //AN ERROR MESSAGE WILL APPEAR UNDER THE TEXTVIEWS. 
                if (userDetails == null)
                {
                    userModel.LoginErrorMessage = "Wrong username or password.";
                    return View("Index", userModel);
                }

                //IN THIS BLOCK HERE IF THE LOGIN WAS SUCCESFULL WE WILL REDIRECT YOU TO THE 
                //NEXT PAGE  WITCH IS THE MAIN PAGE OF THE WEB APP!
                else
                {
                    Session["userID"] = userDetails.userID;
                    return RedirectToAction("Index", "Home");
                }
            }

        }


    }
}