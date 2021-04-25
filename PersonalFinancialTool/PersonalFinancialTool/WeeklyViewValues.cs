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
        WeeklyViewDetails _transaction;

        public WeeklyViewValues(WeeklyViewDetails transaction)
        {
            InitializeComponent();
            _transaction = transaction;
            SetUpViewData();
        }

        private void SetUpViewData()
        {
       
            labelCategory.Text = _transaction.expense;
            labelAmount.Text = "Rs." + _transaction.amount;
        }
    }
}
