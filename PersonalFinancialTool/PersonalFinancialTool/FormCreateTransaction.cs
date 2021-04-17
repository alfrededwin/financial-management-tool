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
    public partial class FormCreateTransaction : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FinanceDB.mdf;Integrated Security=True");
        public String sTransactionLabel = "Transaction";

        FinancialToolDataSet AppDataSet = new FinancialToolDataSet();
        public TransactionDetails transactionDetails { get; set; }
        public FinancialToolDataSet TransactionDataSet { get; set; }

        public FormCreateTransaction()
        {
            InitializeComponent();

            if (File.Exists("PersonalFinanceToolDB.xml") == true)
            {
                this.AppDataSet.ReadXml("PersonalFinanceToolDB.xml");
            }

            //GetIncome();
        }


        //void GetIncome()
        //{


        //    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FinanceDB.mdf;Integrated Security=True");
        //    con.Open();
        //    string query = "SELECT * FROM Catergories";
        //    //SqlDataAdapter sda = new SqlDataAdapter(query, con);
        //    //DataTable dta = new DataTable();
        //    //sda.Fill(dta);

        //    SqlCommand cmd = new SqlCommand("SELECT * FROM Catergories", con);

        //    SqlDataReader reader = cmd.ExecuteReader();

        //    while (reader.Read()) {

        //        string income = reader.GetString(1);
        //        cmbIncomeType.Items.Add(income);

        //    }

        //    //OleDbCommand cmd = new OleDbCommand("SELECT * FROM ALWO_Airport_Info_TAB ", Con);
        //    //OleDbDataReader read = cmd.ExecuteReader();

        //    //while (read.Read())
        //    //{

        //    //    //string iAirportID = read.GetString(1);
        //    //    // comboBoxAircraftID.Items.Add(iAirportID);
        //    //    cmbIncomeType.Items.Add(read["CategoryDescription"].ToString());

        //    //}
        //    con.Close();

        //}

        private void FormCreateTransaction_Load(object sender, EventArgs e)
        {
            //using (FinancialToolDataSet financialToolDataSet = new FinancialToolDataSet()) {
            //    categoriesBindingSource.DataSource = financialToolDataSet.Categories.ToList();
            //}
        }

        private void CreateTransaction(object sender, EventArgs e)
        {
            try
            {
                this.transactionDetails = new TransactionDetails();
                this.transactionDetails.categoryType = this.comboBoxTransCategoryType.Text.ToString();
                this.transactionDetails.income = this.cmbIncomeType.Text.ToString();
                this.transactionDetails.expense = this.cmbExpenseType.Text.ToString();
                this.transactionDetails.transactionDescription = this.textBoxTransDesc.Text;
                this.transactionDetails.transactionDate = this.dateTimeTransDate.Text.ToString();
                this.transactionDetails.amount = this.textBoxTransAmount.Text;
                this.transactionDetails.eventName = this.comboBoxTransEventName.Text.ToString();

                FinancialToolDataSet.TransactionsRow transactionsRow = this.AppDataSet.Transactions.NewTransactionsRow();

                transactionsRow.CategoryType = this.transactionDetails.categoryType;
                transactionsRow.Income = this.transactionDetails.income;
                transactionsRow.Expense = this.transactionDetails.expense;

                transactionsRow.TransDescription = this.transactionDetails.transactionDescription;
                transactionsRow.Date = this.transactionDetails.transactionDate;
                transactionsRow.Amount = this.transactionDetails.amount;
                transactionsRow.EventName = this.transactionDetails.eventName;

                this.AppDataSet.Transactions.AddTransactionsRow(transactionsRow);
                this.AppDataSet.AcceptChanges();


                this.AppDataSet.WriteXml("PersonalFinanceToolDB.xml");

                // Wee have now stored into memory // Not dont the Forwarding, that should be done by the Entity Framework.
                // Might a Web Service or Might call a DB over the internet.
                // Forwarding


                //TransactionModel transactionModel = new TransactionModel();
                //transactionModel.SaveTransactionInformation(this.transactionDetails);






                MessageBox.Show(String.Format(Properties.Resources.SUCCESS_MESSAGE, this.sTransactionLabel));
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void SetUpdateFields(String categoryType, String income, String expense, String transDesc, String transDate, String amount, String eventName)
        {
            this.comboBoxTransCategoryType.Text = categoryType;
            this.cmbIncomeType.Text = income;
            this.cmbExpenseType.Text = expense;
            this.textBoxTransDesc.Text = transDesc;
            this.dateTimeTransDate.Text = transDate;
            this.textBoxTransAmount.Text = amount;
            this.comboBoxTransEventName.Text = eventName;
        }


        //String getCategoryType(String description)
        //{
        //    //String type = "";
           
        //    //string MyConnection = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FinanceDB.mdf;Integrated Security=True";
        //    //SqlConnection MyConn2 = new SqlConnection(MyConnection);
        //    //MyConn2.Open();
        //    //String query = "SELECT * FROM iexpensedb.category_tab  WHERE category_name = '" + description + "' and username = '" + username + "'; ";
        //    //SqlDataAdapter sqlCommand = new SqlDataAdapter(query, MyConn2);
        //    //SqlDataReader mySqlDataReader;
        //    //mySqlDataReader = sqlCommand.ExecuteReader();
        //    //while (mySqlDataReader.Read())
        //    //{

        //    //    if (mySqlDataReader.GetString("category_name").Equals(description))
        //    //    {
        //    //        type = mySqlDataReader.GetString("category_type");
        //    //        break;
        //    //    }
        //    //}
        //    //MyConn2.Close();
        //    //return type;


        //}



    }
}
