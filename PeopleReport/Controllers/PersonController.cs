using PeopleReport.Models;
using PeopleReport.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeopleReport.Controllers
{
    public class PersonController : Controller
    {
        private IPersonPointsRepository _personPointsRepository;

        public PersonController(IPersonPointsRepository repository)
        {
            _personPointsRepository = repository;
        }

        public ActionResult Index(int personId = 1)
        {
            var person = _personPointsRepository.GetPersonById(personId);
            if (person == null)
            {
                //Todo Handle errors
                return View();
            }

            List<PersonPoints> relatedPersons = _personPointsRepository.GetRelatedPersons(personId).ToList();

            ViewBag.Related = relatedPersons;

            return View(person);
        }
    }
}