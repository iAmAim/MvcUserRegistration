using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRegistrationApplication.Models;

namespace UserRegistrationApplication.Controllers
{
    public class UserRegisterController : Controller
    {


        // GET: /UserRegister/
        public ActionResult UserRegister()
        {
            UserRegisterModel model = new UserRegisterModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult UserRegister(UserRegisterModel model)
        {

            if (ModelState.IsValid)
            {
                System.Text.StringBuilder sbMessage = new System.Text.StringBuilder();
                sbMessage.Append("Your Name is : " + model.Name + "</br/>");
                sbMessage.Append("Your Password is : " + model.Password + "</br/>");
                sbMessage.Append("Your Email is : " + model.Email + "</br/>");
                return Content(sbMessage.ToString());
            }
            else
            {
                return View(model);
            }
        }



    }
}
