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
    public partial class FormRegister : Form
    {
        FinancialToolDataSet AppDataSet = new FinancialToolDataSet();

        public String sFullName = null;
        public String sUsername = null;
        public String sEmail = null;
        public String sPassword = null;

        public FormRegister()
        {
            InitializeComponent();
            if (File.Exists("PersonalFinanceToolDB.xml") == true)
            {
                this.AppDataSet.ReadXml("PersonalFinanceToolDB.xml");
            }
        }

        public UserDetails userDetails;

        private void CreateRegister(object sender, EventArgs e)
        {
            this.userDetails = new UserDetails();
            this.userDetails.fullName = this.textBoxFullName.Text;
            this.userDetails.username = this.textBoxUsername.Text;
            this.userDetails.email = this.textBoxEmail.Text;
            this.userDetails.password = this.textBoxNewPassword.Text;

            sFullName = this.userDetails.fullName;
            sUsername = this.userDetails.username;
            sEmail = this.userDetails.email;
            sPassword = this.userDetails.password;


            FinancialToolDataSet.UserRow userRow = this.AppDataSet.User.NewUserRow();
            userRow.FullName = sFullName;
            userRow.Username = sUsername;
            userRow.Email = sEmail;
            userRow.Password = this.sPassword;

            this.AppDataSet.User.AddUserRow(userRow);
            this.AppDataSet.AcceptChanges();

            this.AppDataSet.WriteXml("PersonalFinanceToolDB.xml");

            // Wee have now stored into memory // Not dont the Forwarding, that should be done by the Entity Framework.
            // Might a Web Service or Might call a DB over the internet.
            // Forwarding

            UserModel userModel = new UserModel();
            userModel.SaveUserInformation(this.userDetails);

            this.Close();


        }
    }
}
