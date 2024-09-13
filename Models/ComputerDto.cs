using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace model.Models
{
    public class ComputerDto
    {
        public string Processor { get; set; }
        public int Ram { get; set; }

        public ComputerDto()
        {
            if (Processor == null)
            {
                Processor = "";
            }
        }
    }
}