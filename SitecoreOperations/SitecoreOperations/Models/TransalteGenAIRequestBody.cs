using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreOperations.Models
{
    public class TransalteGenAIRequestBody
    {
        public string text { get; set; }
        public string targetlanguage { get; set; }
        public string sourcelanguage { get; set; }
    }
}
