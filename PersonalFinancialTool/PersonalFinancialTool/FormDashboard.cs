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
            FormViewCategory viewCategoryForm = new FormViewCategory();
            viewCategoryForm.TopLevel = false;
            viewCategoryForm.FormBorderStyle = FormBorderStyle.None;
            viewCategoryForm.Dock = DockStyle.Fill;
            tabPageCategory.Controls.Add(viewCategoryForm);
            viewCategoryForm.Show();
        }
    }
}
