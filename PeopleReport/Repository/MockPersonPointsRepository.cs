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
            PersonPoints p1 = new PersonPoints { Id = 1, FirstName = "Ярополк", SecondName = "Смертоносный", ThirdName = "Николаевич", Email = "dir1@atrade.com", PhoneNumber = "+375 20 1237898", Job = Jobs.Director, Location = Locations.Khatezhino, PhotoUrl= @"https://sun9-2.userapi.com/c858336/v858336113/112697/oPxYzeAmy4Q.jpg", Notes="Не забыть позвонить по поводу рынков", Points = new List<Point>() };
            PersonPoints p2 = new PersonPoints { Id = 2, FirstName = "Максимилиан", SecondName = "Красивый", ThirdName = "Витальевич", Email = "r0@atrade.com", PhoneNumber = "+375 29 1237898", Job = Jobs.Helper1, Location = Locations.Khatezhino, PhotoUrl = @"https://sun9-32.userapi.com/c846021/v846021301/1ab9e2/REXj6TtFkF0.jpg", Notes="", Points = new List<Point>() };
            PersonPoints p3 = new PersonPoints { Id = 3, FirstName = "Наталья", SecondName = "Бухгалтерова", ThirdName = "Валерьевна", Email = "r1@atrade.com", PhoneNumber = "+375 44 1237898", Job = Jobs.Helper2, Location = Locations.Khatezhino, PhotoUrl = @"https://sun9-58.userapi.com/c856036/v856036144/c7fb6/lG6ov7Mm1i0.jpg", Notes="отдать деньги за пряники", Points = new List<Point>() };
            PersonPoints p4 = new PersonPoints { Id = 4, FirstName = "Дмитрий", SecondName = "Ловелас", ThirdName = "Игнатович", Email = "r4@atrade.com", PhoneNumber = "+375 44 4571246", Job = Jobs.R1, Location = Locations.Khatezhino, PhotoUrl = @"https://sun9-49.userapi.com/c851332/v851332933/bf3c4/gJTXJoTegSM.jpg", Notes="", Points = new List<Point>() };
            PersonPoints p5 = new PersonPoints { Id = 5, FirstName = "Алексей", SecondName = "Подъюбкин", ThirdName = "Иванович", Email = "r5@atrade.com", PhoneNumber = "+375 40 4571246", Job = Jobs.R1, Location = Locations.Khatezhino, PhotoUrl = @"https://sun9-48.userapi.com/c844721/v844721375/1b17a0/q-lP3kJUqzw.jpg", Notes="поговорить по поводу отпуска для сотрудника", Points = new List<Point>() };
            PersonPoints p6 = new PersonPoints { Id = 6, FirstName = "Аделаида", SecondName = "Полещук", ThirdName = "Сергеевна", Email = "r6@atrade.com", PhoneNumber = "+375 40 4571247", Job = Jobs.R6, Location = Locations.Khatezhino, PhotoUrl = @"https://sun9-9.userapi.com/c852224/v852224733/100a44/PS8mxYHfo6E.jpg", Notes="", Points = new List<Point>() };

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

        public PersonPoints GetPersonById(int id)
        {
            PersonPoints person = GetAllPersonPoints().ToList().Where(c => c.Id == id).FirstOrDefault();
            return person;
        }

        public IEnumerable<PersonPoints> GetRelatedPersons(int id)
        {
            PersonPoints current = GetPersonById(id);

            if (current.Job == Jobs.Director)
            {
                return GetAllPersonPoints().ToList().Where(x => x.Job == Jobs.Helper1 || x.Job == Jobs.Helper2);
            }

            if (current.Job == Jobs.Helper1 || current.Job == Jobs.Helper2)
            {
                return GetAllPersonPoints().ToList().Where(x => 
                    x.Job == Jobs.R0 || x.Job == Jobs.R1 || x.Job == Jobs.R2 || x.Job == Jobs.R3 || x.Job == Jobs.R4 || x.Job == Jobs.R5 || x.Job == Jobs.R6 || x.Job == Jobs.R7
                );
            }

            var getByDepartament = GetAllPersonPoints().ToList().Where(x => x.Job == current.Job);

            return getByDepartament;
        }
    }
}