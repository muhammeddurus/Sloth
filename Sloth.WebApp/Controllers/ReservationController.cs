using Sloth.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sloth.WebApp.Controllers
{
    public class ReservationController : Controller
    {
        private readonly Entities.SlothContext db = new Entities.SlothContext();
        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }

        // GET: Iletisim
        [HttpPost]
        public ActionResult Index(Reservation reservation, string name, string email, string time, string phone, int person, string date)
        {

            if (name == null || phone == null || email == null || date == null || time == "0" || person == 0)
            {
                ViewBag.Danger("Lütfen tüm alanları doldurunuz.");

                return View(reservation);
            }
            else
            {
                //ViewBag.Success("Mesajınız tarafımıza iletilmiştir. En kısa sürede sizinle iletişime geçilecektir.");

                if (ModelState.IsValid)
                {

                    db.Reservations.Add(reservation);

                    if (time == "1")
                        time = "Kahvaltı";
                    else if (time == "2")
                        time = "Öğle Yemeği";
                    else if (time == "3")
                        time = "Akşam Yemeği";

                    reservation.FullName = name;
                    reservation.Email = email;
                    reservation.Telephone = phone;
                    reservation.Guests = person;
                    reservation.OrgazinationDate = date;
                    reservation.Time = time;


                    db.SaveChanges();
                }


            }
            return View(reservation);

        }
    }
}