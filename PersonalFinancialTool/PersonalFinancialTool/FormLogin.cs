using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinancialTool
{
    
    public partial class FormLogin : Form
    {
        FinancialToolDataSet myDataSet = new FinancialToolDataSet();
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
            if (isValid()) {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FinanceDB.mdf;Integrated Security=True")) {
                string query = "SELECT * FROM Users WHERE Username = '" + textBoxUsername.Text.Trim() + "' AND Password = '" + textBoxPassword.Text.Trim() + "'  ";
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                    con.Close();
                    if (dta.Rows.Count == 1) {
                    FormDashboard formDashboard = new FormDashboard();
                    formDashboard.Show();
                    this.Hide();
                }
                else {
                        MessageBox.Show("Please Enter Correct Username and Password");
             
                    }
                }

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




        private void BTNCAT_Click(object sender, EventArgs e)
        {
            FormViewCategory formViewCategory = new FormViewCategory();
            formViewCategory.CategoryDataSet = this.myDataSet;
            formViewCategory.Show();
        }
    }
}
