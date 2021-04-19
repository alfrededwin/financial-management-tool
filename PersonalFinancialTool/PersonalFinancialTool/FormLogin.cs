using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinancialTool
{
    
    public partial class FormLogin : Form
    {
        FinancialToolDataSet myDataSet = new FinancialToolDataSet();

        public static int gblLoggedInUser = 0;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void GetRegister(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
            this.Hide();
        }

        private void Login(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {

                    string relative = @"C:\Users\Alfred Edwin\Documents\FinanceToolDB.mdf";
                    string absolute = Path.GetDirectoryName(relative);
                    AppDomain.CurrentDomain.SetData("DataDirectory", absolute);


                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FinanceToolDB.mdf;Integrated Security=True"))
                    {
                        string query = "SELECT * FROM Users WHERE Username = '" + textBoxUsername.Text.Trim() + "' AND Password = '" + textBoxPassword.Text.Trim() + "'  ";
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        DataTable dta = new DataTable();
                        sda.Fill(dta);
                        con.Close();
                        if (dta.Rows.Count == 1)
                        {
                            getLoggedInUser();
                            FormDashboard formDashboard = new FormDashboard();
                            formDashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Correct Username and Password");

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private bool isValid() {
            if (textBoxUsername.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Please Enter correct Username", "Error");
                return false;
            }
            else if (textBoxPassword.Text.TrimStart() == string.Empty) {
                MessageBox.Show("Please Enter correct Password", "Error");
                return false;
            }
            return true;
        }

        public void getLoggedInUser() {

            int loggedInUser=0;

            string relative = @"C:\Users\Alfred Edwin\Documents\FinanceToolDB.mdf";
            string absolute = Path.GetDirectoryName(relative);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);
        
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FinanceToolDB.mdf;Integrated Security=True"))
            {
               
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT u.Id FROM Users u WHERE u.Username = '" + textBoxUsername.Text.Trim() + "' AND u.Password = '" + textBoxPassword.Text.Trim() + "'  ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    loggedInUser = reader.GetInt32(0);


                }

                con.Close();
            }

            gblLoggedInUser = loggedInUser;

        }




        private void BTNCAT_Click(object sender, EventArgs e)
        {
            FormViewCategory formViewCategory = new FormViewCategory();
            formViewCategory.CategoryDataSet = this.myDataSet;
            formViewCategory.Show();
        }
    }
}
