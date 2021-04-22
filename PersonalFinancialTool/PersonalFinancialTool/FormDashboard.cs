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
    public partial class FormDashboard : Form
    {

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            FormViewTransaction viewTransaction = new FormViewTransaction();
            viewTransaction.TopLevel = false;
            viewTransaction.FormBorderStyle = FormBorderStyle.None;
            viewTransaction.Dock = DockStyle.Fill;
            tabPageTransaction.Controls.Add(viewTransaction);
            viewTransaction.Show();

            FormViewCategory viewCategoryForm = new FormViewCategory();
            viewCategoryForm.TopLevel = false;
            viewCategoryForm.FormBorderStyle = FormBorderStyle.None;
            viewCategoryForm.Dock = DockStyle.Fill;
            tabPageCategory.Controls.Add(viewCategoryForm);
            viewCategoryForm.Show();

            FormPrediction formPrediction = new FormPrediction();
            formPrediction.TopLevel = false;
            formPrediction.FormBorderStyle = FormBorderStyle.None;
            formPrediction.Dock = DockStyle.Fill;
            tabPagePrediction.Controls.Add(formPrediction);
            formPrediction.Show();

            FormViewEvent formViewEvent = new FormViewEvent();
            formViewEvent.TopLevel = false;
            formViewEvent.FormBorderStyle = FormBorderStyle.None;
            formViewEvent.Dock = DockStyle.Fill;
            tabPageEvent.Controls.Add(formViewEvent);
            formViewEvent.Show();

            FormReport formReport = new FormReport();
            formReport.TopLevel = false;
            formReport.FormBorderStyle = FormBorderStyle.None;
            formReport.Dock = DockStyle.Fill;
            tabPageReport.Controls.Add(formReport);
            formReport.Show();

            FormWeeklyView formWeeklyView = new FormWeeklyView();
            formWeeklyView.TopLevel = false;
            formWeeklyView.FormBorderStyle = FormBorderStyle.None;
            formWeeklyView.Dock = DockStyle.Fill;
            tabPageWeeklyView.Controls.Add(formWeeklyView);
            formWeeklyView.Show();

            FormSettings formSettings = new FormSettings();
            formSettings.TopLevel = false;
            formSettings.FormBorderStyle = FormBorderStyle.None;
            formSettings.Dock = DockStyle.Fill;
            tabPageSettings.Controls.Add(formSettings);
            formSettings.Show();
        }
    }
}
