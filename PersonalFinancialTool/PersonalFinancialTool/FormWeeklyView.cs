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
        private GroupBox[] _groupBoxes;
        //private readonly WeeklyViewController weeklyViewController;

        WeeklyViewController weeklyViewController = new WeeklyViewController();
        FinancialToolDataSet finance_dataset = new FinancialToolDataSet();

        public FormWeeklyView()
        {
            InitializeComponent();
            //weeklyViewController = controller;
            SetUpViewData();

        }

        private void dateTimePickerWeeklyView_ValueChanged(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(groupBoxWeeklyView);
            SetUpViewData();
        }

        private void SetUpViewData()
        {
            DateTime date = dateTimePickerWeeklyView.Value;
            int xStartPoint = 4;
            int yStartPoint = 100;
            _groupBoxes = new GroupBox[7];
            for (int i = 0; i < 7; i++)
            {
                xStartPoint += 4;
                GroupBox groupBox = new GroupBox();
                groupBox.Size = new Size(138, 304);
                groupBox.Location = new Point(xStartPoint, yStartPoint);
                //groupBox.Text = "GroupBox" + (i + 1).ToString();
                this.Controls.Add(groupBox);
                xStartPoint += groupBox.Width;
                _groupBoxes[i] = groupBox;
            }

            for (int i = 6; i >= 0; i--)
            {
                _groupBoxes[i].Text = date.ToString(System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern);

                WeeklyView day = new WeeklyView(weeklyViewController.GetExpenses(date));
                day.RefreshControls();
                day.Location = new Point(0, 19);

                date = date.AddDays(-1);
                _groupBoxes[i].Controls.Add(day);
            }
        }


        public List<FinancialToolDataSet.TransactionsRow> GetExpenses(DateTime date)
        {
            return finance_dataset.Transactions.Where(t => t.Date.Year == date.Year && t.Date.Month == date.Month && t.Date.Day == date.Day).ToList();
        }
    }
}
