using PeopleReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleReport.Repository
{
    public class MockPersonPointsRepository: IPersonPointsRepository
    {
        public IEnumerable<PersonPoints> GetAllPersonPoints()
        {
            PersonPoints p1 = new PersonPoints { Id = 1, FirstName = "Ярополк", SecondName = "Смертоносный", ThirdName = "Николаевич", Email = "dir1@atrade.com", PhoneNumber = "+375 20 1237898", Job = Jobs.Director, Location = Locations.Khatezhino, Points = new List<Point>() };
            PersonPoints p2 = new PersonPoints { Id = 2, FirstName = "Максимилиан", SecondName = "Красивый", ThirdName = "Витальевич", Email = "r0@atrade.com", PhoneNumber = "+375 29 1237898", Job = Jobs.R0, Location = Locations.Khatezhino, Points = new List<Point>() };
            PersonPoints p3 = new PersonPoints { Id = 3, FirstName = "Наталья", SecondName = "Бухгалтерова", ThirdName = "Валерьевна", Email = "r1@atrade.com", PhoneNumber = "+375 44 1237898", Job = Jobs.R2, Location = Locations.Khatezhino, Points = new List<Point>() };
            PersonPoints p4 = new PersonPoints { Id = 4, FirstName = "Дмитрий", SecondName = "Ловелас", ThirdName = "Игнатович", Email = "r4@atrade.com", PhoneNumber = "+375 44 4571246", Job = Jobs.R1, Location = Locations.Khatezhino, Points = new List<Point>() };
            PersonPoints p5 = new PersonPoints { Id = 4, FirstName = "Алексей", SecondName = "Подъюбкин", ThirdName = "Иванович", Email = "r5@atrade.com", PhoneNumber = "+375 40 4571246", Job = Jobs.R5, Location = Locations.Khatezhino, Points = new List<Point>() };
            PersonPoints p6 = new PersonPoints { Id = 4, FirstName = "Аделаида", SecondName = "Полещук", ThirdName = "Сергеевна", Email = "r6@atrade.com", PhoneNumber = "+375 40 4571247", Job = Jobs.R6, Location = Locations.Khatezhino, Points = new List<Point>() };

            p1.Points.Add(new Point { Date = new DateTime(2019, 06, 01), IsVacation = false, Value = 170 });
            p1.Points.Add(new Point { Date = new DateTime(2019, 06, 08), IsVacation = false, Value = 180 });
            p1.Points.Add(new Point { Date = new DateTime(2019, 06, 15), IsVacation = false, Value = 190 });
            p1.Points.Add(new Point { Date = new DateTime(2019, 06, 22), IsVacation = false, Value = 200 });

            p2.Points.Add(new Point { Date = new DateTime(2019, 06, 01), IsVacation = false, Value = 17 });
            p2.Points.Add(new Point { Date = new DateTime(2019, 06, 08), IsVacation = false, Value = 18 });
            p2.Points.Add(new Point { Date = new DateTime(2019, 06, 15), IsVacation = false, Value = 19 });
            p2.Points.Add(new Point { Date = new DateTime(2019, 06, 22), IsVacation = false, Value = 20 });

            p3.Points.Add(new Point { Date = new DateTime(2019, 06, 01), IsVacation = false, Value = 500 });
            p3.Points.Add(new Point { Date = new DateTime(2019, 06, 08), IsVacation = false, Value = 400 });
            p3.Points.Add(new Point { Date = new DateTime(2019, 06, 15), IsVacation = false, Value = 500 });
            p3.Points.Add(new Point { Date = new DateTime(2019, 06, 22), IsVacation = false, Value = 600 });

            p4.Points.Add(new Point { Date = new DateTime(2019, 06, 01), IsVacation = false, Value = 1 });
            p4.Points.Add(new Point { Date = new DateTime(2019, 06, 08), IsVacation = false, Value = 4 });
            p4.Points.Add(new Point { Date = new DateTime(2019, 06, 15), IsVacation = false, Value = 3 });
            p4.Points.Add(new Point { Date = new DateTime(2019, 06, 22), IsVacation = false, Value = 2 });

            p5.Points.Add(new Point { Date = new DateTime(2019, 06, 01), IsVacation = false, Value = 10 });
            p5.Points.Add(new Point { Date = new DateTime(2019, 06, 08), IsVacation = false, Value = 45 });
            p5.Points.Add(new Point { Date = new DateTime(2019, 06, 15), IsVacation = false, Value = 30 });
            p5.Points.Add(new Point { Date = new DateTime(2019, 06, 22), IsVacation = false, Value = 21 });

            p6.Points.Add(new Point { Date = new DateTime(2019, 06, 01), IsVacation = false, Value = 14 });
            p6.Points.Add(new Point { Date = new DateTime(2019, 06, 08), IsVacation = false, Value = 2 });
            p6.Points.Add(new Point { Date = new DateTime(2019, 06, 15), IsVacation = false, Value = 30 });
            p6.Points.Add(new Point { Date = new DateTime(2019, 06, 22), IsVacation = false, Value = 17 });

            return new List<PersonPoints> { p1, p2, p3, p4, p5, p6 };
        }
    }
}