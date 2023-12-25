using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_partA_Samsonenko_report
{
    public class Critic : IPrintable
    {
        public Film Film { get; set; } 
        public int Rating { get; set; }
        public Critic(Film film, int rating)
        {
            throw new NotImplementedException();
        }
        public string PrintToDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
