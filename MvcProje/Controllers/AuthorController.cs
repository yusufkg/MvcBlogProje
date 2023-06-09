﻿using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class AuthorController : Controller
    {
        BlogManager blogmanager = new BlogManager();
        AuthorManager authormanager = new AuthorManager();
        // GET: Author
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetails = blogmanager.GetBlogByID(id);
            return PartialView(authordetails);
        }

        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogauthorid = blogmanager.GetAll().Where(x => x.BlogID == id).Select(y => y.AuthorID).FirstOrDefault();
            var authorsblog = blogmanager.GetBlogByAuthor(blogauthorid);
            return PartialView(authorsblog);
        }

        public ActionResult AuthorList()
        {
            var authorlist = authormanager.GetAll();
            return View(authorlist);
        }

        [HttpGet]
        public ActionResult AddAuthor()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddAuthor(Author p)
        {
            authormanager.AddAuthorBL(p);
            return RedirectToAction("AuthorList");
        }

        [HttpGet]
        public ActionResult AuthorEdit(int id)
        {
            Author author = authormanager.FindAuthor(id);
            return View(author);
        }

        [HttpPost]
        public ActionResult AuthorEdit(Author p)
        {
            authormanager.EditAuthor(p);
            return RedirectToAction("AuthorList");
        }
    }
}