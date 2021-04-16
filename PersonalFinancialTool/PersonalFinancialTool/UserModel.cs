using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinancialTool
{
    class UserModel
    {
        public void SaveUserInformation(UserDetails info)
        {
            // Apply Biz Rules
            // Throw Exception
            // Push to Database

            // We need to use Entity Framework

            User user = new User();
            user.FullName = info.fullName;
            user.Username = info.username;
            user.Email = info.email;
            user.Password = info.password;

            //// add to database
            FinanceDBContainer db = new FinanceDBContainer();
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}
