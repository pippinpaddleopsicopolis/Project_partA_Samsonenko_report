using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_partA_Samsonenko_report
{
    public class Director : IPerson
    {
        public int Income { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Director(string name, string surname, int age, int income)
        {
            throw new NotImplementedException();
        }
    }


}
