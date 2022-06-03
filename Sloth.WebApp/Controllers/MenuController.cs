using Sloth.Entities.Concrete;
using Sloth.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sloth.WebApp.Controllers
{
    public class MenuController : Controller
    {
        private Entities.SlothContext db = new Entities.SlothContext();
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

      
    }
}