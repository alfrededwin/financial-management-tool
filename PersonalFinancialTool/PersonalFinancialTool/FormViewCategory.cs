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

        int index;
        public FormViewCategory()
        {
            InitializeComponent();

            if (File.Exists("PersonalFinanceToolDB.xml") == true)
            {
                this.myDataSet.ReadXml("PersonalFinanceToolDB.xml");
            }


            //myDataSet.ReadXml("PersonalFinanceToolDB.xml");
            this.CategoryDataSet = this.myDataSet;
            this.financialToolDataSet = this.CategoryDataSet;
            this.dataGridViewCategory.DataSource = this.financialToolDataSet;
            this.dataGridViewCategory.DataMember = "Categories";
        }

        private void navCreateCategory(object sender, EventArgs e)
        {
            FormCreateCategory formCreateCategory = new FormCreateCategory();
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
            //index = e.RowIndex;
            //DataGridViewRow row = dataGridViewCategory.Rows[index];
            //DataGridViewRow getRow = dataGridViewCategory.Rows[e.RowIndex];

            //FormCreateCategory formCreateCategory = new FormCreateCategory();
            //formCreateCategory.textBoxCategoryName = getRow.Cells["CategoryName"].Value.ToString();
            //formCreateCategory.textBoxCategoryDesc = dataGridViewCategory.CurrentRow.Cells[2].Value.ToString();
            //formCreateCategory.comboBoxCategoryType = getRow.dataGridViewCategory.CurrentRow.Cells[3].Value.ToString();
            //formCreateCategory.Show();

        }

        private void navUpdateCategory(object sender, EventArgs e)
        {
            //CategoryDetails obj = categoriesBindingSource.Current as CategoryDetails;
            //if (obj != null) {

                FormCreateCategory formCreateCategory = new FormCreateCategory();
                //// using(FormCreateCategory formCreateCategory = new FormCreateCategory() { categoryDetails = obj })
                // {
                //if (formCreateCategory.ShowDialog() == DialogResult.OK)
                //    {

                //    }
                formCreateCategory.Show();
                //categoriesBindingSource.EndEdit();
                //btnUpdateCategory.Focus();


                //// }
            //}





            //FormCreateCategory formCreateCategory = new FormCreateCategory();
            //formCreateCategory.Show();
        }

        private void dataGridViewCategory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //FormCreateCategory formCreateCategory = new FormCreateCategory();
            //formCreateCategory.textBoxCategoryName = this.dataGridViewCategory.CurrentRow.Cells[1].Value.ToString();
        }
    } 
}
