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
    public partial class FormViewTransaction : Form
    {
        public FormViewTransaction()
        {
            InitializeComponent();
        }

        private void navCreateTransaction(object sender, EventArgs e)
        {
            FormCreateTransaction formCreateTransaction = new FormCreateTransaction();
            formCreateTransaction.Show();
        }
    }
}
