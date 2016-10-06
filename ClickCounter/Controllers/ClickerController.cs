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
                if (model == null)
                {
                    model = new ClickCounterModel();
                    model.Count = 0;
                    context.ClickCounters.Add(model);
                    context.SaveChanges();   
                }
            }
            return View(model);
        }

        public ActionResult Count(ClickCounterModel model)
        {
            using (var context = new ClickCounterContext())
            {
                var dbmodel = context.ClickCounters.FirstOrDefault(x=>x.Id == model.Id);
                dbmodel.Count += 1;
                if (TryValidateModel(dbmodel))
                {
                    context.SaveChanges();
                }
                else { dbmodel.Count -= 1; }
                model = dbmodel;
            }
            return View("Index", model);
        }
    }
}