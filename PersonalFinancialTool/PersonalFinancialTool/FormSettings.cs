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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void navUpdateUserInfo(object sender, EventArgs e)
        {
            FormUpdateUserInformation formUpdateUser = new FormUpdateUserInformation();
            formUpdateUser.Show();
        }
    }
}
