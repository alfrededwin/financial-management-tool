using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinancialTool
{
   
    public class WeeklyViewController
    {
        public const int ALL_ACCOUNTS_VALUE = -1;
        public const int ALL_RECORDS_VALUE = -1;

        public const string COMBOBOX_MEMEBER_KEY = "Key";
        public const string COMBOBOX_MEMEBER_VALUE = "Value";

        FinancialToolDataSet finance_dataset = new FinancialToolDataSet();

        //public WeeklyViewController(ref FinancialToolDataSet dataset)
        //{
        //    FinancialToolDataSet finance_dataset = dataset;
        //}

        public WeeklyViewController()
        {

        }



        //public void ShowWeeklyView()
        //{
        //    FormWeeklyView weeklyView = new FormWeeklyView(this);
        //    weeklyView.ShowDialog();
        //}

        public List<FinancialToolDataSet.TransactionsRow> GetExpenses(DateTime date)
        {
           
            return finance_dataset.Transactions.Where(t => t.Expense == t.CategoryType  &&
            t.Date.Year == date.Year && t.Date.Month == date.Month && t.Date.Day == date.Day).ToList();
        }

       

        public static string GetFormattedCurrency(decimal amount)
        {
            return string.Format("{0} {1}",
                Properties.Resources.CURRENCY_PREFIX,
                amount.ToString("#,##0.00"));
        }



    }

}
