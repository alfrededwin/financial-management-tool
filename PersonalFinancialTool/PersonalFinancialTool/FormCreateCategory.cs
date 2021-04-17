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

        public String sCategoryLabel = "Category";
        public String sCategoryName = "";
        public String sCategoryDesc = "";
        public String sCategoryType = "";

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
                    FinancialToolDataSet.CategoriesRow categoryRow = this.AppDataSet.Categories.NewCategoriesRow();
                    categoryRow.CategoryName = sCategoryName;
                    categoryRow.CategoryDescription = sCategoryDesc;
                    categoryRow.CategoryType = sCategoryType;

                    this.AppDataSet.Categories.AddCategoriesRow(categoryRow);
                    this.AppDataSet.AcceptChanges();


                    this.AppDataSet.WriteXml("PersonalFinanceToolDB.xml");

                    // Wee have now stored into memory // Not dont the Forwarding, that should be done by the Entity Framework.
                    // Might a Web Service or Might call a DB over the internet.
                    // Forwarding


                    CategoryModel categoryModel = new CategoryModel();
                    categoryModel.SaveCategoryInformation(this.categoryDetails);






                    MessageBox.Show(String.Format(Properties.Resources.SUCCESS_MESSAGE, this.sCategoryLabel));


                    //FormViewCategory formViewCategory = new FormViewCategory();
                    //formViewCategory.loadData();


                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //void loadData()
        //{

        //    var st = from s in AppDataSet.Categories select s;
        //    FormViewCategory formViewCategory = new FormViewCategory();
        //    var y = formViewCategory.dataGridViewCategory;
        //    y.DataSource = st;

        //}

        public void SetUpdateFields(String categoryName, String categoryDesc, String categoryType) {
            this.textBoxCategoryName.Text = categoryName;
            this.textBoxCategoryDesc.Text = categoryDesc;
            this.comboBoxCategoryType.Text = categoryType;
        }




        private void UpdateCategory(object sender, EventArgs e)
        {
            //textBoxCategoryName.Text = categoryDetails.categoryName;
            //textBoxCategoryDesc.Text = categoryDetails.categoryDescription;
            //comboBoxCategoryType.Text = categoryDetails.categoryType;

            try
            {

                this.categoryDetails = new CategoryDetails();
                this.categoryDetails.categoryName = this.textBoxCategoryName.Text;
                this.categoryDetails.categoryDescription = this.textBoxCategoryDesc.Text;
                this.categoryDetails.categoryType = this.comboBoxCategoryType.Text.ToString();

                sCategoryName = this.categoryDetails.categoryName;
                sCategoryDesc = this.categoryDetails.categoryDescription;
                sCategoryType = this.categoryDetails.categoryType;

                FinancialToolDataSet.CategoriesRow categoryRow = this.AppDataSet.Categories.NewCategoriesRow();
                categoryRow.CategoryName = sCategoryName;
                categoryRow.CategoryDescription = sCategoryDesc;
                categoryRow.CategoryType = sCategoryType;

                this.AppDataSet.Categories.AddCategoriesRow(categoryRow);
                this.AppDataSet.AcceptChanges();


                this.AppDataSet.WriteXml("PersonalFinanceToolDB.xml");

                // Wee have now stored into memory // Not dont the Forwarding, that should be done by the Entity Framework.
                // Might a Web Service or Might call a DB over the internet.
                // Forwarding


                CategoryModel categoryModel = new CategoryModel();
                categoryModel.SaveCategoryInformation(this.categoryDetails);






                MessageBox.Show(String.Format(Properties.Resources.SUCCESS_MESSAGE, this.sCategoryLabel));
                this.Close();
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
