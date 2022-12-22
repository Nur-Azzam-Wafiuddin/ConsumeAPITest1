using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeAPITest1
{
    internal class SendProductCart
    {
        public string name { get; set; }
        public string approval { get; set; } // Accepted or Pending or Rejected
        public string borrowPeriodStart { get; set; }
        public string borrowPeriodEnd { get; set; }
        public int? accountId { get; set; }
    }
}
