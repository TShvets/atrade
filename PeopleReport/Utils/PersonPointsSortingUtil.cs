using PeopleReport.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleReport.Utils
{
    public static class PersonPointsSortingUtil
    {
        public static void CalculateMaxResults (IList<PersonPointsWrapper> source)
        {
            for(var i = 0; i< source.Count; i++)
            {
                for (var j = 1; j < source[i].Points.Count; j++)
                {
                    double max = double.MinValue;
                    for (var c = 0; c < source.Count; c++)
                    {
                        if (source[c].Points[j].Gap > max)
                        {
                            max = source[c].Points[j].Gap;
                        }
                    }

                    if (j >= 2 && source[i].Points[j].Value > source[i].Points[j-1].Value&& source[i].Points[j-1].Value > source[i].Points[j - 2].Value && source[i].Points[j].Gap == max)
                    {
                        source[i].Points[j].IsMaximum = true;
                    }
                    else
                    {
                        source[i].Points[j].IsMaximum = false;
                    }
                }
            }
        }
    }
}