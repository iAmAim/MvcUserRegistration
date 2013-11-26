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
        //
        // GET: /UserRegister/

        public ActionResult UserRegister()
        {
            UserRegisterModel model = new UserRegisterModel();
            return View(model);
        }

    }
}
