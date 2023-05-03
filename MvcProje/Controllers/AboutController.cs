using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager();
        // GET: About
        public ActionResult Index()
        {
            var aboutcontent = abm.GetAll();

            return View(aboutcontent);
        }
        public PartialViewResult Footer()
        {
            var aboutcontentlist = abm.GetAll();
            return PartialView(aboutcontentlist);
        }
        public PartialViewResult MeetTheTeam()
        {
            AuthorManager autman = new AuthorManager();
            var authorlist = autman.GetAll();
            return PartialView(authorlist);
        }
        public ActionResult UpdateAboutList()
        {
            var aboutlist = abm.GetAll();
            return View(aboutlist);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            abm.UpdateAboutBM(p);
            return RedirectToAction("UpdateAboutList");
        }
    }
}