using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace exam_150519_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDAOSchool s = new DAOSchool();
            s.print();
            s.Update();
            Console.ReadLine();
        }
    }
}
