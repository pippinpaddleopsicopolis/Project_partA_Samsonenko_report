using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_partA_Samsonenko_report
{
    public class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Job Job { get; set; }

        public Worker(int id, string firstName, string lastName, int age, Job job)
        {
            throw new NotImplementedException();
        }
    }

}
