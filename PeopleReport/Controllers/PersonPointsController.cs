using PeopleReport.Repository;
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
        public ActionResult Index()
        {
            var list = _personPointsRepository.GetAllPersonPoints();
            var model = new List<PersonPointsWrapper>();
            foreach(var item in list)
            {
                model.Add(new PersonPointsWrapper(item));
            }
            return View(model);
        }
    }
}