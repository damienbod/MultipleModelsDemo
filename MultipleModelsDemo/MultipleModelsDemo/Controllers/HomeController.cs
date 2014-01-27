using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleModelsDemo.ViewModels;

namespace MultipleModelsDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new IndexViewModel();
            model.HeaderText = "Strongly typed model used here, no view bag";
            return View(model);
        }

        public ActionResult MyEditActionOne(IndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Index", model);
            }

            throw new Exception("My Model state is not valid");
        }
    }
}
