using PeopleReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleReport.Wrappers
{
    public class PointWrapper: Point
    {
        public double Gap { get; set; }
        public bool IsMaximum { get; set; }
    }
}