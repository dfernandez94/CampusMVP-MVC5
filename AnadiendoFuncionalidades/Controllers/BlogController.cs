using AnadiendoFuncionalidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnadiendoFuncionalidades.Controllers
{
    public class BlogController : Controller
    {
        // 
        // GET: /Blog/ 
        public ActionResult Index()
        {
            using (var manager = new BlogManager())
            {
                var posts = manager.GetLatestPosts(10); // 10 latests posts 
                return View(posts);                     //Vista por defecto: Index
            }
        }
    }
}