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
    public partial class FormViewCategory : Form
    {
        public FinancialToolDataSet UserDataSet { get; set; }
        public FormViewCategory()
        {
            InitializeComponent();
        }

        private void navCreateCategory(object sender, EventArgs e)
        {
            FormCreateCategory formCreateCategory = new FormCreateCategory();
            formCreateCategory.Show();
        }

        private void FormViewCategory_Load(object sender, EventArgs e)
        {
    
            this.financialToolDataSet = this.UserDataSet;
            this.dataGridViewCategory.DataSource = this.financialToolDataSet;
            this.dataGridViewCategory.DataMember = "Category";
        }
    }
}
