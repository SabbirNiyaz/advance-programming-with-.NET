using RegistrationValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace RegistrationValidation.Controllers
{
    public class RegularExpressionController : Controller
    {
        // GET: RegularExpression
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.Regex());
        }

        [HttpPost]
        public ActionResult Index(Models.Regex regex)
        {
            if (ModelState.IsValid)
            {
               TempData["Msg"] = "Registration successful!";
               return RedirectToAction("Index");
            }
            return View(regex);
        }
    }
}