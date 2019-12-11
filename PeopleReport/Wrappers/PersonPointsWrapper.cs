using PeopleReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleReport.Wrappers
{
    public class PersonPointsWrapper
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Locations Location { get; set; }
        public Jobs Job { get; set; }
        public IList<PointWrapper> Points { get; set; }
        public PersonPointsWrapper (PersonPoints original)
        {
            Id = original.Id;
            FirstName = original.FirstName;
            SecondName = original.SecondName;
            ThirdName = original.ThirdName;
            Email = original.Email;
            PhoneNumber = original.PhoneNumber;
            Location = original.Location;
            Job = original.Job;
            Points = CalcualtePoints(original);
        }

        private IList<PointWrapper> CalcualtePoints(PersonPoints source)
        {
            List<PointWrapper> result = new List<PointWrapper>();
            if (source.Points.Count() > 0)
            {
                result.Add(new PointWrapper { 
                    Index = source.Points.ToList()[0].Index, 
                    Date = source.Points.ToList()[0].Date, 
                    IsVacation = source.Points.ToList()[0].IsVacation, 
                    Value = source.Points.ToList()[0].Value, 
                    Gap = 1 
                });
            }
            if (source.Points.Count() > 1)
            {
                var previousValue = source.Points.ToList()[0].Value;
                var currentValue = source.Points.ToList()[1].Value;

                result.Add(new PointWrapper {
                    Index = source.Points.ToList()[1].Index, 
                    Date = source.Points.ToList()[1].Date, 
                    IsVacation = source.Points.ToList()[1].IsVacation, 
                    Value = source.Points.ToList()[1].Value, 
                    Gap = previousValue == 0 ? 1 : ((currentValue - previousValue) / previousValue) 
                });
            }

            for(var i = 2; i< source.Points.Count(); i++)
            {
                var secondValue = source.Points.ToList()[i - 1].Value;
                var currentValue = source.Points.ToList()[i].Value;

                result.Add(new PointWrapper {
                    Index = source.Points.ToList()[i].Index, 
                    Date = source.Points.ToList()[i].Date, 
                    IsVacation = source.Points.ToList()[i].IsVacation, 
                    Value = source.Points.ToList()[i].Value, 
                    Gap = secondValue == 0 ? 1 : ((currentValue - secondValue)/secondValue ) 
                });
            }

            return result;
        }
    }
}