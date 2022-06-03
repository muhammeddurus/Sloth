using Sloth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Sloth.WebApp.Areas.Admin.Controllers
{
    public class ContactsController : Controller
    {
        Entities.SlothContext db = new Entities.SlothContext();
        // GET: Admin/Contacts
        public ActionResult Index()
        {
            return View(db.Contacts.ToList());
        }
        // GET: Admin/Contacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}