using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleReport.Models
{
    public class Point
    {
        public int Index { get; set; }
        public DateTime Date { get; set; }
        public Double Value { get; set; }
        public bool IsVacation { get; set; }
    }
}