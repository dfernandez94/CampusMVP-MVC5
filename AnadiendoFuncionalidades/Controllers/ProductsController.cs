using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnadiendoFuncionalidades.Controllers
{
    [RoutePrefix("Products")]
    public class ProductsController : Controller
    {
        // GET: /Products/All
        [Route("All"),Route("")]
        public ActionResult Index()
        {
            var message = "ProductsController.Index()";
            return Content(message);
        }

        // GET: /Products/Sony-Vaio
        [Route("{id}")]
        public ActionResult View(string id)
        {
            var message = string.Format("ProductsController.View('{0}')", id);
            return Content(message);
        }

        // GET: /Products/Category/Ultrabooks
        [Route("Category/{category}")]
        public ActionResult ByCategory(string category)
        {
            var message = string.Format("ProductsController.ByCategory('{0}')", category);
            return Content(message);
        }
    }
}