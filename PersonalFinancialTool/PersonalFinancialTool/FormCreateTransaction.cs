using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace PersonalFinancialTool
{
    public partial class FormCreateTransaction : Form
    {
       
        public String sTransactionLabel = "Transaction";
        public static int globalIdToUpdate = 0;
        public static int CatIdToUpdate = 0;
        public static int EventIdToUpdate = 0;


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

            getEventName();
            cmbExpenseType.Enabled = false;
            cmbIncomeType.Enabled = false;

        }


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
                // Assign Values
                this.transactionDetails = new TransactionDetails();
                this.transactionDetails.categoryType = this.comboBoxTransCategoryType.Text;
                this.transactionDetails.income = this.cmbIncomeType.Text;
                this.transactionDetails.expense = this.cmbExpenseType.Text;
                this.transactionDetails.transactionDescription = this.textBoxTransDesc.Text;
                this.transactionDetails.transactionDate = this.dateTimeTransDate.Value;
                this.transactionDetails.amount = decimal.Parse(this.textBoxTransAmount.Text);
                this.transactionDetails.eventName = this.comboBoxTransEventName.Text;


                if (this.dateTimeTransDate.Value == null || this.textBoxTransDesc.Text == "")
                {
                    MessageBox.Show(String.Format(Properties.Resources.COMMON_MISSING_DATA, MessageBoxButtons.OK, MessageBoxIcon.Error));
                }
                else
                {
                    // Assign to Dataset
                    FinancialToolDataSet.TransactionsRow transactionsRow = this.AppDataSet.Transactions.NewTransactionsRow();

                    transactionsRow.CategoryType = this.transactionDetails.categoryType;
                    transactionsRow.Income = this.transactionDetails.income;
                    transactionsRow.Expense = this.transactionDetails.expense;
                    transactionsRow.TransDescription = this.transactionDetails.transactionDescription;
                    transactionsRow.Date = this.transactionDetails.transactionDate;
                    transactionsRow.Amount = this.transactionDetails.amount;
                    transactionsRow.EventName = this.transactionDetails.eventName;

                    // Apply Changes to DT
                    this.AppDataSet.Transactions.AddTransactionsRow(transactionsRow);
                    this.AppDataSet.AcceptChanges();

                    // Writing to XML File
                    this.AppDataSet.WriteXml("PersonalFinanceToolDB.xml");

                    // Forwarding to Database.
                    TransactionModel transactionModel = new TransactionModel();
                    transactionModel.SaveTransactionInformation(this.transactionDetails);

                    MessageBox.Show(String.Format(Properties.Resources.SUCCESS_MESSAGE, this.sTransactionLabel));
                    this.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void SetUpdateFields(String categoryType, String income, String expense, String transDesc, String transDate, String amount, String eventName, int iTransactionId)
        {
            globalIdToUpdate = iTransactionId;
            this.comboBoxTransCategoryType.Text = categoryType;
            this.cmbIncomeType.Text = income;
            this.cmbExpenseType.Text = expense;
            this.textBoxTransDesc.Text = transDesc;
            this.dateTimeTransDate.Text = transDate;
            this.textBoxTransAmount.Text = amount;
            this.comboBoxTransEventName.Text = eventName;
        }


        public void getEventName()
        {
            string relative = @"C:\Users\Alfred Edwin\Documents\FinanceToolDB.mdf";
            string absolute = Path.GetDirectoryName(relative);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FinanceToolDB.mdf;Integrated Security=True"))
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Events e WHERE e.UserId = '"+ FormLogin.gblLoggedInUser  + "' ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String sEventName = reader.GetString(1);
                    comboBoxTransEventName.Items.Add(sEventName);


                    //if (reader.GetString(1).Equals(description))
                    //{
                    //    type = mySqlDataReader.GetString("category_type");
                    //    break;
                    //}

                    //if (mySqlDataReader.GetString("category_name").Equals(description))
                    //{
                    //    type = mySqlDataReader.GetString("category_type");
                    //    break;
                    //}
                }

                con.Close();
            }

        }


        public void getIncomeExpense()
        {
            string relative = @"C:\Users\Alfred Edwin\Documents\FinanceToolDB.mdf";
            string absolute = Path.GetDirectoryName(relative);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);

            

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FinanceToolDB.mdf;Integrated Security=True"))
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Categories e WHERE e.CategoryType = '" + comboBoxTransCategoryType.Text.Trim() + "' AND e.UserId = '" + FormLogin.gblLoggedInUser + "' ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String sIncomeExpense = reader.GetString(1);
                    cmbIncomeType.Items.Add(sIncomeExpense);
                    cmbExpenseType.Items.Add(sIncomeExpense);
                  
                }
                con.Close();
            }

          
            if (comboBoxTransCategoryType.Text.Trim().Equals("Income")) {
                cmbExpenseType.Enabled = false;
                lblExpense.Enabled = false;
                cmbIncomeType.Enabled = true;
                lblIncome.Enabled = true;
                cmbExpenseType.Text = "";
            }

            if (comboBoxTransCategoryType.Text.Trim().Equals("Expense"))
            {
                cmbIncomeType.Enabled = false;
                lblIncome.Enabled = false;
                cmbExpenseType.Enabled = true;
                lblExpense.Enabled = true;
                cmbIncomeType.Text = "";
            }


        }

        private void TriggerCategoryTypeDropDown(object sender, EventArgs e)
        {
            cmbIncomeType.Items.Clear();
            cmbExpenseType.Items.Clear();
            getIncomeExpense();
        }

        private void UpdateTransaction(object sender, EventArgs e)
        {
            try
            {
                // Assign Values
                this.transactionDetails = new TransactionDetails();
                this.transactionDetails.categoryType = this.comboBoxTransCategoryType.Text;
                this.transactionDetails.income = this.cmbIncomeType.Text;
                this.transactionDetails.expense = this.cmbExpenseType.Text;
                this.transactionDetails.transactionDescription = this.textBoxTransDesc.Text;
                this.transactionDetails.transactionDate = this.dateTimeTransDate.Value;
                this.transactionDetails.amount =  decimal.Parse( this.textBoxTransAmount.Text);
                this.transactionDetails.eventName = this.comboBoxTransEventName.Text;


                if (this.dateTimeTransDate.Value == null || this.textBoxTransDesc.Text == "")
                {
                    MessageBox.Show(String.Format(Properties.Resources.COMMON_MISSING_DATA, MessageBoxButtons.OK, MessageBoxIcon.Error));
                }
                else
                {

                    if (comboBoxTransEventName.Text == "")
                    {
                        EventIdToUpdate = 0;
                    }

                    // Assign to Dataset
                    FinancialToolDataSet.TransactionsRow transactionsRow = this.AppDataSet.Transactions.FindByTransactionId(globalIdToUpdate);

                    transactionsRow.CategoryType = this.transactionDetails.categoryType;
                    transactionsRow.Income = this.transactionDetails.income;
                    transactionsRow.Expense = this.transactionDetails.expense;
                    transactionsRow.TransDescription = this.transactionDetails.transactionDescription;
                    transactionsRow.Date = this.transactionDetails.transactionDate;
                    transactionsRow.Amount = this.transactionDetails.amount;
                    transactionsRow.EventName = this.transactionDetails.eventName;


                    // Apply Changes to DT
                    this.AppDataSet.AcceptChanges();


                    // Writing to XML File
                    this.AppDataSet.WriteXml("PersonalFinanceToolDB.xml");

                    // Forwarding to Database.
                    TransactionModel transactionModel = new TransactionModel();
                    transactionModel.UpdateTransactionInformation(globalIdToUpdate,this.transactionDetails);

                    this.Close();
                    MessageBox.Show(String.Format(Properties.Resources.SUCCESS_UPDATE, this.sTransactionLabel, MessageBoxIcon.Information));

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TriggerIncomeDropDown(object sender, EventArgs e)
        {
            string relative = @"C:\Users\Alfred Edwin\Documents\FinanceToolDB.mdf";
            string absolute = Path.GetDirectoryName(relative);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);



            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FinanceToolDB.mdf;Integrated Security=True"))
            {

                con.Open();
                string query = "SELECT * FROM Categories e WHERE e.CategoryName = '" + cmbIncomeType.Text.Trim() + "' AND e.UserId = '" + FormLogin.gblLoggedInUser + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                con.Close();
                if (dta.Rows.Count == 1)
                {
                    //labelCategoryId.Text = dta.Rows[0]["Id"].ToString();
                    CatIdToUpdate = Int32.Parse(dta.Rows[0]["Id"].ToString());
                }
            }

        }

        private void TriggerExpenseDropDown(object sender, EventArgs e)
        {
            string relative = @"C:\Users\Alfred Edwin\Documents\FinanceToolDB.mdf";
            string absolute = Path.GetDirectoryName(relative);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FinanceToolDB.mdf;Integrated Security=True"))
            {

                con.Open();
                string query = "SELECT * FROM Categories e WHERE e.CategoryName = '" + cmbExpenseType.Text.Trim() + "' AND e.UserId = '" + FormLogin.gblLoggedInUser + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                con.Close();
                if (dta.Rows.Count == 1)
                {
                    //labelCategoryId.Text = dta.Rows[0]["Id"].ToString();
                    CatIdToUpdate = Int32.Parse(dta.Rows[0]["Id"].ToString());
                   
                }
            }
        }

        private void TriggerEventNameDropDown(object sender, EventArgs e)
        {
            string relative = @"C:\Users\Alfred Edwin\Documents\FinanceToolDB.mdf";
            string absolute = Path.GetDirectoryName(relative);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);



            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FinanceToolDB.mdf;Integrated Security=True"))
            {

                con.Open();
                string query = "SELECT * FROM Events e WHERE e.EventName = '" + comboBoxTransEventName.Text.Trim() + "' AND e.UserId = '" + FormLogin.gblLoggedInUser + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                con.Close();
                if (dta.Rows.Count == 1)
                {
                    //labelEventId.Text = dta.Rows[0]["Id"].ToString();
                    EventIdToUpdate = Int32.Parse(dta.Rows[0]["Id"].ToString());
                }
            }
        }
    }
}
