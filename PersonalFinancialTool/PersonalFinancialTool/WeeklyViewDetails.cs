using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinancialTool
{
    public class WeeklyViewDetails
    {
        public string categoryType { get; set; }
        public string income { get; set; }
        public string expense { get; set; }
        public string transactionDescription { get; set; }
        public DateTime transactionDate { get; set; }
        public decimal amount { get; set; }
        public string eventName { get; set; }

        public WeeklyViewDetails(String categoryType, String income, String expense, String transactionDescription, DateTime transDate, Decimal amount, String eventName)
        {
            this.categoryType = categoryType;
            this.income = income;
            this.expense = expense;
            this.transactionDescription = transactionDescription;
            this.transactionDate = transDate;
            this.amount = amount;
            this.eventName = eventName;
        }
    }
}
