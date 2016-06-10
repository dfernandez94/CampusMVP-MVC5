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

        // 
        // GET /Blog/Archive/2005/3 
        public ActionResult Archive(int year, int month)
        {
            using (var manager = new BlogManager())
            {
                var posts = manager.GetPostsByDate(year, month);
                return View(posts);
            }
        }

        //
        // GET /Blog/Hello-world
        public ActionResult ViewPost(string code)
        {
            using (var manager = new BlogManager())
            {
                var post = manager.GetPost(code);
                if (post == null)
                    return HttpNotFound();
                else
                    return View(post);
            }
        }
    }
}