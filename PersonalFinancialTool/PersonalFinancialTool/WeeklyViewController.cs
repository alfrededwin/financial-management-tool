using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinancialTool
{
   
    public class WeeklyViewController
    {
        FinancialToolDataSet finance_dataset = new FinancialToolDataSet();

        public WeeklyViewController()
        {
        }

        public WeeklyViewController(ref FinancialToolDataSet dataset)
        {
            FinancialToolDataSet finance_dataset = dataset;
        }

      

        //public void ShowWeeklyView()
        //{
        //    FormWeeklyView weeklyView = new FormWeeklyView(this);
        //    weeklyView.ShowDialog();
        //}

        public List<FinancialToolDataSet.TransactionsRow> GetExpensesOn(DateTime date)
        {
            return finance_dataset.Transactions.Where(t => t.Expense == t.Expense ).ToList();
        }

        //&&
        //    t.Date.Year == date.Year && t.Date.Month == date.Month && t.Date.Day == date.Day


    }

}
