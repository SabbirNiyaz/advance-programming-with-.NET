using RegistrationValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationValidation.Controllers
{
    public class RegistationValidationController : Controller
    {
        // GET: RegistationValidation
        [HttpGet]
        public ActionResult RegistationForm()
        {
            return View(new FormValidation());
        }

        [HttpPost]
        public ActionResult RegistationForm(FormValidation fv)
        {
            if (ModelState.IsValid)
            {
                TempData["Msg"] = "Registation Successfull";
                return RedirectToAction("RegistationForm");
            }
            return View(fv);
        }
    }
}