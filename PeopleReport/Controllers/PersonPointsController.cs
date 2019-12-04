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
        public ActionResult Index(int pointId = -1, int sortOrder= 0)
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
                if (pointId != -1 && pointId < model[0].Points.Count)
                {
                    if (sortOrder == 0)
                    {
                        model = model.OrderBy(c => c.Points[pointId].Gap).ToList();
                    }
                    else
                    {
                        model = model.OrderByDescending(c => c.Points[pointId].Gap).ToList();
                    }
                }
            }
            return View(model);
        }
    }
}