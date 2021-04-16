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
    public partial class FormCreateTransaction : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FinanceDB.mdf;Integrated Security=True");
        public String sTransactionLabel = "Transaction";

        public FormCreateTransaction()
        {
            InitializeComponent();
        }


        void GetIncome()
        {
            con.Open();
            string query = "SELECT c.CategoryDescription FROM Catergories c";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dta = new DataTable();
            sda.Fill(dta);


            //OleDbCommand cmd = new OleDbCommand("SELECT * FROM ALWO_Airport_Info_TAB ", Con);
            //OleDbDataReader read = cmd.ExecuteReader();

            //while (read.Read())
            //{

            //    //string iAirportID = read.GetString(1);
            //    // comboBoxAircraftID.Items.Add(iAirportID);
            //    cmbIncomeType.Items.Add(read["CategoryDescription"].ToString());

            //}
            con.Close();

        }
    }
}
