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
    public partial class WeeklyView : UserControl
    {

        private readonly List<WeeklyViewDetails> _transactions;

        public WeeklyView(List<WeeklyViewDetails> transactionsRows)
        {
            InitializeComponent();
            _transactions = transactionsRows;
            SetUpViewData();
        }

   
        public void RefreshControls()
        {
            SetUpViewData();
        }
      
        private void SetUpViewData()
        {

            decimal amount = 0;
            int ySpacer = 3;
            foreach (var item in _transactions)
            {
                WeeklyViewValues dayItem = new WeeklyViewValues(item);
                dayItem.Location = new Point(3, ySpacer);
                panelWeekView.Controls.Add(dayItem);
                ySpacer += dayItem.Height + 3;
                amount += item.amount;
            }

            lbltotal.Text = "LKR. " + amount.ToString();
            
        }


    }
}
