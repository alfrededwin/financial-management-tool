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

        private void CreateCategory(object sender, EventArgs e)
        {
            sCategoryName = this.textBoxCategoryName.Text;
            sCategoryDesc = this.textBoxCategoryDesc.Text;
            sCategoryType = this.comboBoxCategoryType.Text.ToString();


            FinancialToolDataSet.CategoryRow categoryRow = this.AppDataSet.Category.NewCategoryRow();
            categoryRow.CategoryName = sCategoryName;
            categoryRow.CategoryDescription = sCategoryDesc;
            categoryRow.CategoryType = sCategoryType;

            this.AppDataSet.Category.AddCategoryRow(categoryRow);
            this.AppDataSet.AcceptChanges();

            this.AppDataSet.WriteXml("PersonalFinanceToolDB.xml");


            this.Close();
        }
    }
}
