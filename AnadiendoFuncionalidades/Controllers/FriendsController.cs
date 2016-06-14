using AnadiendoFuncionalidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnadiendoFuncionalidades.Controllers
{
    public class FriendsController : Controller
    {
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Save(Friend friend)
        {
            // TODO: save friend's data
            //Mensage de error: ModelState.Values.First().Errors.First().ErrorMessage
            return Content("Entity is valid: " + ModelState.IsValid);
        }
    }
}