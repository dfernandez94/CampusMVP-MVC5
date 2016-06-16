using AnadiendoFuncionalidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnadiendoFuncionalidades.Controllers
{
    [RoutePrefix("Friends")]
    public class FriendsController : Controller
    {
        
        public ActionResult Save(Friend friend)
        {
            // TODO: save friend's data
            //Mensage de error: ModelState.Values.First().Errors.First().ErrorMessage
            return Content("Entity is valid: " + ModelState.IsValid);
        }
        [Route("")]
        // GET: /Friends/
        public ActionResult Index()
        {
            var message = "FriendsController.Index()";
            return Content(message);
        }

        [Route("view/{name:startsWith(jo)}")]
        // GET: /Friends/View/John
        public ActionResult View(string name)
        {
            var message = string.Format("FriendsController.View('{0}')", name);
            return Content(message);
        }

        // GET: /Friends/Edit/23
        [Route("Edit/{id:int:min(0):max(99999999)}")]
        public ActionResult Edit(int id)
        {
            var message = string.Format("FriendsController.Edit({0})", id);
            return Content(message);
        }
    }
}