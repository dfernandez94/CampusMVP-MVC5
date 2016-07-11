using FormularioEdicion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormularioEdicion.Controllers
{
    public class UserController : Controller
    {

        // GET: User
        [HttpGet]
        [Route("profile")]
        public ActionResult Edit()
        {
            ViewBag.UserType = UserViewModel.getTipos();
            return View();
        }


        // Post: User
        [HttpPost]
        [Route("profile")]
        public ActionResult Edit(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                return Content("OK");
            }
            else
            {
                ViewBag.UserType = UserType.getUserTypes();
                return View(user);
            }           
        }


        public JsonResult UsernameAvaiblable(string name)
        {
            bool valido = true;
            return Json(valido, JsonRequestBehavior.AllowGet);
        }
    }
}