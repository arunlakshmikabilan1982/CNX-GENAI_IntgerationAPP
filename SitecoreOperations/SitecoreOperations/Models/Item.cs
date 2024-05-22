using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreOperations.Models
{
    public class Items
    {
        public string id { get; set; }
        public string name { get; set; }
        public item[] fields { get; set; }
    }

    public class item
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}
