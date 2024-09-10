using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace model.Models
{
    public class Computer
    {
        public string Processor { get; set; }
        public int Ram { get; set; }

        public Computer()
        {
            if (Processor == null)
            {
                Processor = "";
            }
        }
    }
}
