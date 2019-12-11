using PeopleReport.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleReport.Utils
{
    public static class PersonPointsFilterUtil
    {
        public static void FilterByPointDate(IList<PersonPointsWrapper> source, DateTime start, DateTime finish)
        {
            for(var i = 0; i< source.Count; i++)
            {
                source[i].Points = source[i].Points.Where(x => (x.Date >= start && x.Date <= finish)).ToList();
            }
        }
    }
}