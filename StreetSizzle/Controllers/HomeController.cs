using StreetSizzle.Models;
using StreetSizzle.Modules.Interface;
using StreetSizzle.Modules.Services;
using StructureMap.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StreetSizzle.Controllers
{
    public class HomeController : Controller
    {
        private IContact contactservice;

        public HomeController(IContact contactservice)
        {
            this.contactservice = contactservice;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Feature()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Chef()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Menu()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        [HttpPost]
        public ActionResult addInquiry(ContactModel model)
        {
            contactservice.addInquiry(model);
            return RedirectToAction("inquirysuccess");
        }
        public ActionResult inquirysuccess()
        {
            return View();
        }

    }
}