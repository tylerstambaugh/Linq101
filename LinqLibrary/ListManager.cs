using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
    public class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            {
                List<Person> output = new List<Person>();

                output.Add(new Person { FirstName = "Tyler", LastName = "Bobe", Birthday = Convert.ToDateTime("1/15/1984"), YearsExperience = 2 });
                output.Add(new Person { FirstName = "Cindy", LastName = "Mackey", Birthday = Convert.ToDateTime("2/5/1985"), YearsExperience = 1 });
                output.Add(new Person { FirstName = "Eric", LastName = "Ford", Birthday = Convert.ToDateTime("12/1/1970"), YearsExperience = 1 });
                output.Add(new Person { FirstName = "Gordon", LastName = "Mason", Birthday = Convert.ToDateTime("7/19/1992"), YearsExperience = 3 });
                output.Add(new Person { FirstName = "Marcus", LastName = "Taylor", Birthday = Convert.ToDateTime("4/15/1995"), YearsExperience = 4 });
                output.Add(new Person { FirstName = "Amy", LastName = "Hodson", Birthday = Convert.ToDateTime("2/15/1980"), YearsExperience = 2 });

                return output;

            }
        }
    }
}
