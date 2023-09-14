using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries.API.Core
{
    public class Country
    {
        
        public Name Name { get; set; }
        public string[] Capital { get; set; }

        public string Region { get; set; }
        public string SubRegion { get; set; }

        public string[] Borders { get; set; }

        public Flags Flags { get; set; }


    }


    public class Flags
    {
        [JsonProperty("png")]
        public string Png { get; set; }
    }

    public class Name
    {
        [JsonProperty("common")]
        public string Common { get; set; }
    }
}
