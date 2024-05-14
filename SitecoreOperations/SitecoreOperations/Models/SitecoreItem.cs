using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreOperations.Models
{
    public class SitecoreItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<SitecoreItemFields> Fields { get; set; }
    }
}
