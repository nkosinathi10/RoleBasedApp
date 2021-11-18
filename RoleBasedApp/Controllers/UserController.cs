using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoleBasedApp.Controllers
{
    public class UserController : Controller
    {
        [Authorize]
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
    }
}