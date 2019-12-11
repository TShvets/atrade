using PeopleReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeopleReport.Controllers
{
    public class SalaryController : Controller
    {
        // GET: Salary
        public ActionResult Index()
        {
            var salary = new Salary { Data = 14, TotalResult = 180 };
            return View(salary);
        }
    }
}