using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinancialTool
{
    public class TransactionDetails
    {
       
        public string categoryType { get; set; }
        public string income { get; set; }
        public string expense { get; set; }
        public string transactionDescription { get; set; }
        public string transactionDate { get; set; }
        public string amount { get; set; }
        public string eventName { get; set; }
    }
}
