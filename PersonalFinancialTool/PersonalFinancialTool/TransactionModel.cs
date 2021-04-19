using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinancialTool
{
    class TransactionModel
    {
        public void SaveTransactionInformation(TransactionDetails info)
        {
            try
            {
                Transaction transaction = new Transaction();
                transaction.CategoryType = info.categoryType;
                transaction.Income = info.income;
                transaction.Expense = info.expense;
                transaction.TransactionDescription = info.transactionDescription;
                transaction.TransactionDate = info.transactionDate;
                transaction.Amount = info.amount;
                transaction.EventName = info.eventName;
                transaction.UserId = FormLogin.gblLoggedInUser;

                // Add to database
                FinanceToolDBContainer1 db = new FinanceToolDBContainer1();
                db.Transactions.Add(transaction);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
      



}
}
