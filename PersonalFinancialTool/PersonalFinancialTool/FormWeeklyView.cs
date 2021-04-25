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
    public partial class FormWeeklyView : Form
    {
        private TransactionModel helper = new TransactionModel();
        public DateTime selectedDate = DateTime.Now;
        private GroupBox[] _groupBoxes;

        public FormWeeklyView()
        {
            InitializeComponent();
            SetUpViewData();
        }

        private void dateTimePickerWeeklyView_ValueChanged(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(groupBoxWeeklyView);
            selectedDate = dateTimePickerWeeklyView.Value;
            SetUpViewData();
        }

        
        private void SetUpViewData()
        {
       
            int xStartPoint = 0;
            int yStartPoint = 100;
            _groupBoxes = new GroupBox[7];

            for (int i = 0; i < 7; i++)
            {
                xStartPoint += 5;
                GroupBox groupBox = new GroupBox();
                groupBox.Size = new Size(138, 304);
                groupBox.Location = new Point(xStartPoint, yStartPoint);
                this.Controls.Add(groupBox);
                xStartPoint += groupBox.Width;
                _groupBoxes[i] = groupBox;
            }

            for (int i = 6; i >= 0; i--)
            {
                _groupBoxes[i].Text = selectedDate.ToString("d,dddd");
                WeeklyView item = new WeeklyView(GetExpensesOn(selectedDate));
                item.RefreshControls();
                item.Location = new Point(0, 19);

                selectedDate = selectedDate.AddDays(-1);
                _groupBoxes[i].Controls.Add(item);
            }
        }


        public List<WeeklyViewDetails> GetExpensesOn(DateTime date)
        {
            return helper.GetListOfTransactions(date);
        }

    }
}
