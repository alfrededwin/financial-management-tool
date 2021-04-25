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
    public partial class FormCreateCategory : Form
    {

        FinancialToolDataSet AppDataSet = new FinancialToolDataSet();
        public CategoryDetails categoryDetails { get; set; }
        public FinancialToolDataSet CategoryDataSet { get; set; }

        CategoryModel categoryModel = new CategoryModel();

        public String sCategoryLabel = "Category";
        public String sCategoryName = "";
        public String sCategoryDesc = "";
        public String sCategoryType = "";
        public static int globalIdToUpdate = 0;

        public String sFormStatus;


        public FormCreateCategory()
        {
            InitializeComponent();

            if (File.Exists("PersonalFinanceToolDB.xml") == true)
            {
                this.AppDataSet.ReadXml("PersonalFinanceToolDB.xml");
            }

        }

        private void CreateCategory(object sender, EventArgs e)
        {
            int loggedInUser = FormLogin.gblLoggedInUser;

            try
            {
                this.categoryDetails = new CategoryDetails();
                this.categoryDetails.categoryName = this.textBoxCategoryName.Text;
                this.categoryDetails.categoryDescription = this.textBoxCategoryDesc.Text;
                this.categoryDetails.categoryType = this.comboBoxCategoryType.Text.ToString();

                sCategoryName = this.categoryDetails.categoryName;
                sCategoryDesc = this.categoryDetails.categoryDescription;
                sCategoryType = this.categoryDetails.categoryType;

                if (string.IsNullOrWhiteSpace(sCategoryName) || string.IsNullOrWhiteSpace(sCategoryDesc) || string.IsNullOrEmpty(sCategoryType))
                {
                    MessageBox.Show(Properties.Resources.COMMON_MISSING_DATA);
                }
                else
                {
                    // Assign to Dataset
                    FinancialToolDataSet.CategoriesRow categoryRow = this.AppDataSet.Categories.NewCategoriesRow();
                    categoryRow.CategoryName = sCategoryName;
                    categoryRow.CategoryDescription = sCategoryDesc;
                    categoryRow.CategoryType = sCategoryType;
                    categoryRow.UserId = loggedInUser;

                  

                    // Apply Changes to DT
                    this.AppDataSet.Categories.AddCategoriesRow(categoryRow);
                    this.AppDataSet.AcceptChanges();

                    // Writing to XML File
                    this.AppDataSet.WriteXml("PersonalFinanceToolDB.xml");

                    // Forwarding to Database.
                    CategoryModel categoryModel = new CategoryModel();
                    //categoryModel.SaveCategoryInformation(this.categoryDetails);

                    // Handled using Threads
                    Task.Run(() => categoryModel.SaveCategoryAsync(this.categoryDetails));

                    this.Close();
                    MessageBox.Show(String.Format(Properties.Resources.SUCCESS_MESSAGE, this.sCategoryLabel));
                  
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        public void loadViewCategoryData()
        {

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


            FormViewCategory formViewCategory = new FormViewCategory();
            formViewCategory.dataGridViewCategory.DataSource = category1.ToList();
            formViewCategory.dataGridViewCategory.Columns[0].Visible = false;
            formViewCategory.dataGridViewCategory.Columns[4].Visible = false;

        }





        public void SetUpdateFields(String categoryName, String categoryDesc, String categoryType, int sCategoryId) {
            globalIdToUpdate = sCategoryId;
            this.textBoxCategoryName.Text = categoryName;
            this.textBoxCategoryDesc.Text = categoryDesc;
            this.comboBoxCategoryType.Text = categoryType;
        }




        private void UpdateCategory(object sender, EventArgs e)
        {
   
            try
            {

                this.categoryDetails = new CategoryDetails();
                this.categoryDetails.categoryName = this.textBoxCategoryName.Text;
                this.categoryDetails.categoryDescription = this.textBoxCategoryDesc.Text;
                this.categoryDetails.categoryType = this.comboBoxCategoryType.Text.ToString();

                sCategoryName = this.categoryDetails.categoryName;
                sCategoryDesc = this.categoryDetails.categoryDescription;
                sCategoryType = this.categoryDetails.categoryType;

                FinancialToolDataSet.CategoriesRow categoryRow = this.AppDataSet.Categories.FindByCategoryId(globalIdToUpdate);
                categoryRow.CategoryName = sCategoryName;
                categoryRow.CategoryDescription = sCategoryDesc;
                categoryRow.CategoryType = sCategoryType;
                this.AppDataSet.AcceptChanges();

                this.AppDataSet.WriteXml("PersonalFinanceToolDB.xml");

                FormViewCategory formViewCategory = new FormViewCategory();
                formViewCategory.dataGridViewCategory.Update();
                formViewCategory.dataGridViewCategory.Refresh();

                // Update to Database
                CategoryModel categoryModel = new CategoryModel();
                //categoryModel.UpdateCategoryInformation(globalIdToUpdate, this.categoryDetails);

                // Handled using Threads
                Task.Run(() => categoryModel.UpdateCategoryAsync(globalIdToUpdate,this.categoryDetails));

                this.Close();
                MessageBox.Show(String.Format(Properties.Resources.SUCCESS_UPDATE, this.sCategoryLabel));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCreateCategory_Load(object sender, EventArgs e)
        {
            if (categoryDetails != null)
            {
                textBoxCategoryName.Text = categoryDetails.categoryName;
                textBoxCategoryDesc.Text = categoryDetails.categoryDescription;
                comboBoxCategoryType.Text = categoryDetails.categoryType;
            }
        }
    }
}
