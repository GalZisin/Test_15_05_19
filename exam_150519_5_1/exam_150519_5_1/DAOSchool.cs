using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_150519_5_1
{
    class DAOSchool:IDAOSchool
    {
        public void print()
        {
            using (SchoolEntities school = new SchoolEntities())
            {
                // 1. Print all 
                Console.WriteLine("Print all: ");
                school.Courses.ToList().ForEach(r => Console.WriteLine(JsonConvert.SerializeObject(r)));
            }
        }
        public void Update()
        {
            using (SchoolEntities school = new SchoolEntities())
            {
                //school.Courses.Single(s => s.NAME == "Programming Practices");
                //entities.Persons.Take(1).FirstOrDefault().Name = "new name";
                var query =
                           from s in school.Courses
                           where s.ID == 1
                           select s;

                // Execute the query, and change the column values
                // you want to change.
                foreach (Cours s in query)
                {
                    s.NAME = "Golf";
                    s.HOURS = "800";
                    s.AVG_GRADE = 80;
                    s.HIGHSET_GRADE = 88;
                    school.SaveChanges();
                }
            }
        }

   
    }
}
