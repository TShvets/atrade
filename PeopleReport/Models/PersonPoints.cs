using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleReport.Models
{
    public class PersonPoints
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Locations Location { get; set; }
        public Jobs Job { get; set; }
        public IEnumerable<Point> Points { get; set; }
    }
}