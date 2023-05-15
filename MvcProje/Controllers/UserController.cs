using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class UserController : Controller
    {
        UserProfileManager userProfile = new UserProfileManager();
        // GET: User
        public ActionResult Index(string p)
        {
            p = "murat@gmail.com";
            var profilevalues = userProfile.GetAuthorByMail(p);
            return View(profilevalues);
        }
    }
}