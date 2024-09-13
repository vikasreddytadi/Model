using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace model.Models
{
    public class numDto
    {
        public int id { get; set; }

        public string name { get; set; }

        public numDto()
        {
            if (name == null)
            {
                name = "";
            }
        }
    }
}