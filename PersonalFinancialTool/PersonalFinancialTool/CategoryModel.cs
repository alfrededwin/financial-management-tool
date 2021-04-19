using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinancialTool
{
    class CategoryModel :DbContext
    {

        public void SaveCategoryInformation(CategoryDetails info)
            {

                try
                {
             
                    Category category = new Category();

                    category.CategoryName = info.categoryName;
                    category.CategoryDescription = info.categoryDescription;
                    category.CategoryType = info.categoryType;
                    category.UserId = FormLogin.gblLoggedInUser;

                    // Add to database
                    FinanceToolDBContainer1 db = new FinanceToolDBContainer1();
                    db.Categories.Add(category);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

             }


        public void UpdateCategoryInformation(int IdToUpdate, CategoryDetails info)
        {

            try
            {
                Category category = new Category();

                category.CategoryName = info.categoryName;
                category.CategoryDescription = info.categoryDescription;
                category.CategoryType = info.categoryType;
                category.UserId = FormLogin.gblLoggedInUser;

                // Update to database
                FinanceToolDBContainer1 db = new FinanceToolDBContainer1();
  
                using (var context = new FinanceToolDBContainer1())
                {
                    var std = context.Categories.Find(IdToUpdate);
                    std.CategoryName = info.categoryName;
                    std.CategoryDescription = info.categoryDescription;
                    std.CategoryType = info.categoryType;
                    std.UserId = FormLogin.gblLoggedInUser;
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
