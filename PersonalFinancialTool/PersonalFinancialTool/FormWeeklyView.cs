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
        //private readonly WeeklyViewController _controller;

        WeeklyViewController weeklyViewController = new WeeklyViewController();

        public FormWeeklyView()
        {
            InitializeComponent();
            SetUpViewData();
        }

        private void dateTimePickerWeeklyView_ValueChanged(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(groupBoxWeeklyView);
        }

        private void SetUpViewData()
        {
            DateTime date = dateTimePickerWeeklyView.Value;
            int xStartPoint = 4;
            int yStartPoint = 65;
            _groupBoxes = new GroupBox[7];
            for (int i = 0; i < 7; i++)
            {
                xStartPoint += 6;
                GroupBox groupBox = new GroupBox();
                groupBox.Size = new Size(150, 375);
                groupBox.Location = new Point(xStartPoint, yStartPoint);
                //groupBox.Text = "GroupBox" + (i + 1).ToString();
                this.Controls.Add(groupBox);
                xStartPoint += groupBox.Width;
                _groupBoxes[i] = groupBox;
            }

            for (int i = 6; i >= 0; i--)
            {
                _groupBoxes[i].Text = date.ToString(System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern);

                WeeklyView day = new WeeklyView(weeklyViewController.GetExpensesOn(date));
                //day.RefreshControls();
                day.Location = new Point(0, 19);

                date = date.AddDays(-1);
                _groupBoxes[i].Controls.Add(day);
            }
        }
    }
}
