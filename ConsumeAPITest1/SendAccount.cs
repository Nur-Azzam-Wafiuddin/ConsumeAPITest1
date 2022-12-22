using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeAPITest1
{
    internal class SendAccount
    {
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public List<SendProductCart> productCart { get; set; }
        public List<SendProductHistory> productHistory { get; set; }
    }
}
