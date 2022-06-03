using Sloth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sloth.WebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly Entities.SlothContext db = new Entities.SlothContext();
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact, string name, string email,string phone,string message)
        {

            if (name == null || phone == null || email == null || message == null )
            {
                ViewBag.Danger("Lütfen tüm alanları doldurunuz.");

                return View(contact);
            }
            else
            {
                //ViewBag.Success("Mesajınız tarafımıza iletilmiştir. En kısa sürede sizinle iletişime geçilecektir.");

                if (ModelState.IsValid)
                {

                    db.Contacts.Add(contact);



                    contact.FullName = name;
                    contact.Telephone = phone;
                    contact.Email = email;
                    contact.Message = message;
                    


                    db.SaveChanges();
                }


            }
            return View(contact);

        }
    }
}