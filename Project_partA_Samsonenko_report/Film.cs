using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_partA_Samsonenko_report
{
    public class Film
    {
        public string Name { get; set; }
        public Director Owner { get; set; }
        public List<Worker> Workers { get; set; }

        public Film(string name, Director owner, List<Worker> workers)
        {
            throw new NotImplementedException();
        }
    }
}
