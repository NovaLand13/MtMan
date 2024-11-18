using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtMan
{
    public class Job
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public string PaymentType { get; set; }
        public DateTime DateBilled {get; set; }
        public DateTime DatePaid { get; set; }
        public DateTime ServiceDate { get; set; }
        public string Description { get; set; }
        public int client_ID { get; set; }


    }
}
