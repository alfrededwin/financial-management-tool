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
        public int sCategoryId =0 ;

        public FormViewCategory()
        {
            InitializeComponent();

            if (File.Exists("PersonalFinanceToolDB.xml") == true)
            {
                this.myDataSet.ReadXml("PersonalFinanceToolDB.xml");
            }

            //loadData();

            //myDataSet.ReadXml("PersonalFinanceToolDB.xml");
            //this.CategoryDataSet = this.myDataSet;
            //this.financialToolDataSet = this.CategoryDataSet;
            //this.dataGridViewCategory.DataSource = this.financialToolDataSet;
            //this.dataGridViewCategory.DataMember = "Categories";

            //FinanceToolDBContainer1 db = new FinanceToolDBContainer1();
            //var category1 =
            //    from category in db.Categories
            //    where category.UserId == FormLogin.gblLoggedInUser
            //    select new
            //    {
            //        CategoryId = category.Id,
            //        CategoryName = category.CategoryName,
            //        CategoryDescription = category.CategoryDescription,
            //        CategoryType = category.CategoryType,
            //        UserId = category.UserId
            //    };
                
        
            //dataGridViewCategory.DataSource = category1.ToList();
            //dataGridViewCategory.Columns[0].Visible = false;
            //dataGridViewCategory.Columns[4].Visible = false;

            loadViewCategoryData();

        }

        private void navCreateCategory(object sender, EventArgs e)
        {
            FormCreateCategory formCreateCategory = new FormCreateCategory();
            formCreateCategory.btnUpdateCategory.Hide();
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Hide();
            formCreateCategory.Show();
        }

        private void FormViewCategory_Load(object sender, EventArgs e)
        {

            //myDataSet.ReadXml("PersonalFinanceToolDB.xml");
            //this.CategoryDataSet = this.myDataSet;
            //this.financialToolDataSet = this.CategoryDataSet;
            //this.dataGridView1.DataSource = this.financialToolDataSet;
            //this.dataGridView1.DataMember = "Categories";

            loadViewCategoryData();
        }

        private void SelectCategoryRow(object sender, DataGridViewCellEventArgs e)
        {
           DataGridViewRow getRow = dataGridViewCategory.Rows[e.RowIndex];
           sCategoryId = Int32.Parse( this.dataGridViewCategory.CurrentRow.Cells[0].Value.ToString());
           sCategoryName = this.dataGridViewCategory.CurrentRow.Cells[1].Value.ToString();
           sCategoryDesc = this.dataGridViewCategory.CurrentRow.Cells[2].Value.ToString();
           sCategoryType = this.dataGridViewCategory.CurrentRow.Cells[3].Value.ToString();
        }

        public void loadViewCategoryData() {

            FinanceToolDBContainer1 db = new FinanceToolDBContainer1();
            var category1 =
                from category in db.Categories
                where category.UserId == FormLogin.gblLoggedInUser
                select new
                {
                    CategoryId = category.Id,
                    CategoryName = category.CategoryName,
                    CategoryDescription = category.CategoryDescription,
                    CategoryType = category.CategoryType,
                    UserId = category.UserId
                };


            dataGridViewCategory.DataSource = category1.ToList();
            dataGridViewCategory.Columns[0].Visible = false;
            dataGridViewCategory.Columns[4].Visible = false;

        }

        private void navUpdateCategory(object sender, EventArgs e)
        {
            
            FormCreateCategory formCreateCategory = new FormCreateCategory();

            formCreateCategory.SetUpdateFields(sCategoryName, sCategoryDesc, sCategoryType, sCategoryId);
            formCreateCategory.btnCreateCategory.Hide();
            formCreateCategory.Show();
        }

  
        private void MenuStripViewCategory(object sender, MouseEventArgs e)
        {
            loadViewCategoryData();
        }
    } 
}
