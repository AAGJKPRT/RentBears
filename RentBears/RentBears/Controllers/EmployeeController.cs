using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Infrastructure;


namespace RentBears.Controllers
{
    public class EmployeeController : Controller
    {
        gotorichEntities3 db = new gotorichEntities3();


        public ActionResult list()
        {
            return View(db.O_InvestmentTrack.ToList());
        }


    }
}