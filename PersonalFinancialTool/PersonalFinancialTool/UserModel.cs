using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinancialTool
{
    class UserModel : DbContext
    {
        public void SaveUserInformation(UserDetails info)
        {
            try
            {
                User user = new User();
                user.FullName = info.fullName;
                user.Username = info.username;
                user.Email = info.email;
                user.Password = info.password;

                // Add to database
                FinanceToolDBContainer1 db = new FinanceToolDBContainer1();
                db.Users.Add(user);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void UpdateUserInformation(int IdToUpdate, UserDetails info)
        {
            try
            {
                User user = new User();
                user.FullName = info.fullName;
                user.Username = info.username;
                user.Email = info.email;
                user.Password = info.password;

                // Update to database
                FinanceToolDBContainer1 db = new FinanceToolDBContainer1();
                using (var context = new FinanceToolDBContainer1())
                {
                    var std = context.Users.Find(IdToUpdate);
                    std.FullName = info.fullName;
                    std.Username = info.username;
                    std.Email = info.email;
                    std.Password = info.password;
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
