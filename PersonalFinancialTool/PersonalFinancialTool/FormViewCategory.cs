using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinancialTool
{
    public partial class FormViewCategory : Form
    {
        FinancialToolDataSet myDataSet = new FinancialToolDataSet();
        public FinancialToolDataSet CategoryDataSet { get; set; }

        public CategoryDetails categoryDetails { get; set; }

        public String sCategoryName = "";
        public String sCategoryDesc = "";
        public String sCategoryType = "";

        public FormViewCategory()
        {
            InitializeComponent();

            if (File.Exists("PersonalFinanceToolDB.xml") == true)
            {
                this.myDataSet.ReadXml("PersonalFinanceToolDB.xml");
            }

            //loadData();

            //myDataSet.ReadXml("PersonalFinanceToolDB.xml");
            this.CategoryDataSet = this.myDataSet;
            this.financialToolDataSet = this.CategoryDataSet;
            this.dataGridViewCategory.DataSource = this.financialToolDataSet;
            this.dataGridViewCategory.DataMember = "Categories";
        }

        private void navCreateCategory(object sender, EventArgs e)
        {
            FormCreateCategory formCreateCategory = new FormCreateCategory();
            formCreateCategory.btnUpdateCategory.Hide();
            formCreateCategory.ShowDialog();
        }

        private void FormViewCategory_Load(object sender, EventArgs e)
        {
          
            //myDataSet.ReadXml("PersonalFinanceToolDB.xml");
            //this.CategoryDataSet = this.myDataSet;
            //this.financialToolDataSet = this.CategoryDataSet;
            //this.dataGridView1.DataSource = this.financialToolDataSet;
            //this.dataGridView1.DataMember = "Categories";
        }

        private void SelectCategoryRow(object sender, DataGridViewCellEventArgs e)
        {
           DataGridViewRow getRow = dataGridViewCategory.Rows[e.RowIndex];
           sCategoryName = this.dataGridViewCategory.CurrentRow.Cells[1].Value.ToString();
           sCategoryDesc = this.dataGridViewCategory.CurrentRow.Cells[2].Value.ToString();
           sCategoryType = this.dataGridViewCategory.CurrentRow.Cells[3].Value.ToString();
        }

        public void loadData() {

            var st = from s in myDataSet.Categories select s;
            dataGridViewCategory.DataSource = st;

        }

        private void navUpdateCategory(object sender, EventArgs e)
        {
            FormCreateCategory formCreateCategory = new FormCreateCategory();
            formCreateCategory.SetUpdateFields(sCategoryName, sCategoryDesc, sCategoryType);
            formCreateCategory.btnCreateCategory.Hide();
            formCreateCategory.Show();
        }

    } 
}
