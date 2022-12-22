using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeAPITest1
{
    internal class ProductHistory
    {
        public int id { get; set; }
        public string name { get; set; }
        public string borrowPeriodStart { get; set; }
        public string borrowPeriodEnd { get; set; }
        public int? accountId { get; set; }
    }
}
