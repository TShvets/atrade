using PeopleReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleReport.Repository
{
    public interface IPersonPointsRepository
    {
        IEnumerable<PersonPoints> GetAllPersonPoints();
        PersonPoints GetPersonById(int id);

        IEnumerable<PersonPoints> GetRelatedPersons(int id);
    }
}
