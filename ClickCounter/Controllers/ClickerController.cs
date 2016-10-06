using ClickCounter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClickCounter.Controllers
{
    public class ClickerController : Controller
    {
        public ActionResult Index()
        {
            ClickCounterModel model;
            using (var context = new ClickCounterContext())
            {
                model = context.ClickCounters.FirstOrDefault();
            }
            return View(model);
        }

        public ActionResult Count(ClickCounterModel model)
        {
            using (var context = new ClickCounterContext())
            {
                model = context.ClickCounters.FirstOrDefault();
                if (ModelState.IsValid)
                {
                    model.Count += 1;
                    context.SaveChanges();
                }
            }
            return View("Index", model);
        }
    }
}