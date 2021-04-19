using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinancialTool
{
    class UserModel
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


    }
}
