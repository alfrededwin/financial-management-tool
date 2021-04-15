using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinancialTool
{
    class CategoryModel
    {

        public void SaveCategoryInformation(CategoryDetails info)
        {
            // Apply Biz Rules
            // Throw Exception
            // Push to Database

            // We need to use Entity Framework


            Category category = new Category();

            category.CategoryName = info.categoryName;
            category.CategoryDescription = info.categoryDescription;
            category.CategoryType = info.categoryType;


            // add to database
            PersonalFinancialToolDBContainer1 db = new PersonalFinancialToolDBContainer1();
            db.Categories.Add(category);
            //db.SaveChanges();
        }

        // Apply Biz Rules
        // Throw Exception
        // Push to Database

        // We need to use Entity Framework

        //StudentInfo studentInfo = new StudentInfo();
        //Address address = new Address();
        //studentInfo.FirstName = info.firstName;
        //    studentInfo.LastName = info.lastName;
        //    address.AddressLine1 = info.address1;
        //    address.AddressLine2 = info.address2;
        //    address.PostalCode = info.postalCode;

        //Category category = new Category();

        //category.CategoryName = info.C
        // Many to Many Relationship.
        //studentInfo.Addresses.Add(address);
        //address.StudentInfoes.Add(studentInfo);

        // add to database
        //PersonalFinancialToolDBContainer db = new PersonalFinancialToolDBContainer();
        ////db.Addresses.Add(address);
        //db.StudentInfoes.Add(studentInfo);
        //db.SaveChanges();
    }
}
