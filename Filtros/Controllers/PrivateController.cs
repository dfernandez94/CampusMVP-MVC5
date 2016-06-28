using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtros.Controllers
{
    [Authorize]
    public class PrivateController : Controller
    {
        // GET: Private
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Users = "david_f_rodr@hotmail.com")]
        public ActionResult OnlyForMe()
        {
            
            return Content(User.Identity.Name+" "+ User.Identity.AuthenticationType);
        }
    }
}