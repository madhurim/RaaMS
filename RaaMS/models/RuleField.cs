using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaaMS.Models
{
    public class RuleField
    {
        public int RuleFieldId { get; set; }
        public String FieldName { get; set; }
        public String DataSource { get; set; }
        public int RuleId { get; set; }
        public String FieldType { get; set; }
    }
}
