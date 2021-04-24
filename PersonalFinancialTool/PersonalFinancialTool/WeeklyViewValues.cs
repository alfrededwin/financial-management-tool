using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinancialTool
{
    public partial class WeeklyViewValues : UserControl
    {
        FinancialToolDataSet.TransactionsRow _transaction;

        public WeeklyViewValues(FinancialToolDataSet.TransactionsRow transaction)
        {
            InitializeComponent();
            _transaction = transaction;

            SetUpViewData();
        }

        private void SetUpViewData()
        {
            labelCategory.Text = _transaction.Expense;
            //lblNote.Text = _transaction.Note;
            labelAmount.Text = WeeklyViewController.GetFormattedCurrency(_transaction.Amount);
            //this.BackColor = Color.FromName(_transaction.FinancialAccountRow.Color);
        }
    }
}
