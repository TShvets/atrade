using PeopleReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Excel = Microsoft.Office.Interop.Excel;

namespace PeopleReport.Repository
{
    public class ExcelPersonPointsRepository : IPersonPointsRepository
    {
        private const string DateFormat = "dd.MM.yyyy";
        List<PersonPoints> _personPoints = new List<PersonPoints>();
        public IEnumerable<PersonPoints> GetAllPersonPoints()
        {
            string path = HttpContext.Current.Server.MapPath("~/App_Data/data.xlsx");
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            var index = 0;

            for (int i = 2; i <= rowCount; i++)
            {
                PersonPoints p = new PersonPoints();
                p.FirstName = xlRange.Cells[i, 2].Value2.ToString();
                p.SecondName = xlRange.Cells[i, 3].Value2.ToString();
                p.ThirdName = xlRange.Cells[i, 4].Value2.ToString();
                p.Email = xlRange.Cells[i, 5].Value2.ToString();
                p.PhoneNumber = xlRange.Cells[i, 6].Value2.ToString();
                p.PhotoUrl = xlRange.Cells[i, 7].Value2.ToString();

                Locations loc = Locations.Khatezhino;
                Enum.TryParse(xlRange.Cells[i, 8].Value2.ToString(), out loc);
                p.Location = loc; 

                if (xlRange.Cells[i, 9] != null && xlRange.Cells[i, 9].Value2 != null)
                {
                    p.Notes = xlRange.Cells[i, 9].Value2.ToString();
                }

                Jobs job = Jobs.Director;
                Enum.TryParse(xlRange.Cells[i, 10].Value2.ToString(), out job);
                p.Job = job;

                p.Points = new List<Point>();
                index = 0;

                for (int j = 11; j <= colCount; j++)
                {
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        Double d = 0;
                        double.TryParse(xlRange[i, j].Value2.ToString(), out d);

                        DateTime date = DateTime.ParseExact(xlRange[1, j].Value2.ToString(), DateFormat, System.Globalization.CultureInfo.InvariantCulture);
                        p.Points.Add(new Point { Index = index, Value = d, Date = date });
                    }
                    index++;
                }

                _personPoints.Add(p);
            }

            return _personPoints;
        }

        public PersonPoints GetPersonById(int id)
        {
            PersonPoints person = _personPoints.Where(c => c.Id == id).FirstOrDefault();
            return person;
        }

        public IEnumerable<PersonPoints> GetRelatedPersons(int id)
        {
            throw new NotImplementedException();
        }
    }
}