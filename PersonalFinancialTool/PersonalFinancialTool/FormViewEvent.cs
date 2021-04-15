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
    public partial class FormViewEvent : Form
    {
        public FormViewEvent()
        {
            InitializeComponent();
        }

        private void navCreateEvent(object sender, EventArgs e)
        {
            FormCreateEvent formCreateEvent = new FormCreateEvent();
            formCreateEvent.Show();
        }
    }
}
