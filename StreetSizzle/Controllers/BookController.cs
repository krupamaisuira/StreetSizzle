using StreetSizzle.Models;
using StreetSizzle.Modules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StreetSizzle.Controllers
{
    public class BookController : Controller
    {
        private IReservation reservationservice;

        public BookController(IReservation reservationservice)
        {
            this.reservationservice = reservationservice;
        }
        public ActionResult reservation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult bookreservation(ReservationModel model)
        {
            reservationservice.bookreservation(model);
            return RedirectToAction("success");
        }
        public ActionResult success()
        {
            return View();
        }

    }
}