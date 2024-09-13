using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace model.Models
{
    public class num
    {
        // we can directly mention the name which will come from Json like below
        // then while doing deserializing or serializing they will map
        // automatically
        // [JsonPropertyName("Id")]
        public int id { get; set; }

        public string name { get; set; }

        public num()
        {
            if (name == null)
            {
                name = "";
            }
        }
    }
}
