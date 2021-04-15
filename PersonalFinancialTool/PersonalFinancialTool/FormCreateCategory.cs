﻿using System;
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

        public String sCategoryLabel = "Category";
        public String sCategoryName = null;
        public String sCategoryDesc = null;
        public String sCategoryType = null;

        public FormCreateCategory()
        {
            InitializeComponent();

            if (File.Exists("PersonalFinanceToolDB.xml") == true)
            {
                this.AppDataSet.ReadXml("PersonalFinanceToolDB.xml");
            }
        }

        public CategoryDetails categoryDetails;

        private void CreateCategory(object sender, EventArgs e)
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
            else {
                FinancialToolDataSet.CategoryRow categoryRow = this.AppDataSet.Category.NewCategoryRow();
                categoryRow.CategoryName = sCategoryName;
                categoryRow.CategoryDescription = sCategoryDesc;
                categoryRow.CategoryType = sCategoryType;

                this.AppDataSet.Category.AddCategoryRow(categoryRow);
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

            
        }
    }
}
