using PeopleReport.Repository;
using PeopleReport.Utils;
using PeopleReport.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeopleReport.Controllers
{
    public class PersonPointsController : Controller
    {
        private IPersonPointsRepository _personPointsRepository;

        public PersonPointsController(IPersonPointsRepository repository)
        {
            _personPointsRepository = repository;
        }
        public ActionResult Index(string start, string finish, int pointId = -1, int sortOrder= 0)
        {
            var list = _personPointsRepository.GetAllPersonPoints();
            var model = new List<PersonPointsWrapper>();
            foreach(var item in list)
            {
                model.Add(new PersonPointsWrapper(item));
            }

            PersonPointsSortingUtil.CalculateMaxResults(model);

            if (pointId == 0)//sort by profession
            {
                //to do - create sorting by profession
                // for now - leave sorting by id
                if (sortOrder == 0)
                {
                    model = model.OrderBy(c => c.Id).ToList();
                }
                else
                {
                    model = model.OrderByDescending(c => c.Id).ToList();
                }
            }
            else
            {
                if (pointId != -1 && pointId <= model[0].Points.Count)
                {
                    var week = model[0].Points.Where(x => x.Index == pointId).FirstOrDefault();
                    var weekId = model[0].Points.IndexOf(week);

                    if (sortOrder == 0)
                    {
                        model = model.OrderBy(c => c.Points[weekId].Gap).ToList();
                    }
                    else
                    {
                        model = model.OrderByDescending(c => c.Points[weekId].Gap).ToList();
                    }
                }
            }

            DateTime startTime = DateTime.MinValue;
            DateTime finishTime = DateTime.Now.AddYears(100);
            if (!string.IsNullOrEmpty(start) || !string.IsNullOrEmpty(finish))
            {
                startTime = DateTime.TryParse(start, out startTime) ? startTime : DateTime.MinValue;
                finishTime = DateTime.TryParse(finish, out finishTime)? finishTime : DateTime.Now.AddYears(100);

                PersonPointsFilterUtil.FilterByPointDate(model, startTime, finishTime);
                ViewBag.IsShowCurrentMonth = true;
            }
            else
            {
                ViewBag.IsShowAll = true;
            }
            return View(model);
        }
    }
}