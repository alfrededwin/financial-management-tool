﻿using System;
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
                transaction.CategoryId = FormCreateTransaction.CatIdToUpdate;
                if (FormCreateTransaction.EventIdToUpdate > 0)
                {
                    transaction.EventId = FormCreateTransaction.EventIdToUpdate;
                }
                else
                {
                    transaction.EventId = null;
                }

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


        public void UpdateTransactionInformation(int IdToUpdate, TransactionDetails info)
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
                transaction.CategoryId = FormCreateTransaction.CatIdToUpdate;
                if (FormCreateTransaction.EventIdToUpdate > 0)
                {
                    transaction.EventId = FormCreateTransaction.EventIdToUpdate;
                }
                else
                {
                    transaction.EventId = null;
                }


                // Update to database
                FinanceToolDBContainer1 db = new FinanceToolDBContainer1();
                using (var context = new FinanceToolDBContainer1())
                {
                    var std = context.Transactions.Find(IdToUpdate);
                    std.CategoryType = info.categoryType;
                    std.Income = info.income;
                    std.Expense = info.expense;
                    std.TransactionDescription = info.transactionDescription;
                    std.TransactionDate = info.transactionDate;
                    std.Amount = info.amount;
                    std.EventName = info.eventName;
                    std.UserId = FormLogin.gblLoggedInUser;
                    std.CategoryId = FormCreateTransaction.CatIdToUpdate;
                    std.EventId = transaction.EventId;
                    context.SaveChanges();
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}




    }
}
