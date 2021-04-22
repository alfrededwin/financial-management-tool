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
    public partial class FormViewTransaction : Form
    {
        FinancialToolDataSet AppDataSet = new FinancialToolDataSet();
        public TransactionDetails transactionDetails { get; set; }
        public FinancialToolDataSet TransactionDataSet { get; set; }

        public String sTransCategoryType = "";
        public String sIncome = "";
        public String sExpense = "";
        public String sTransDesc = "";
        public String sTransDate = "";
        public String sAmount = "";
        public String sTransEventName = "";
        public int iTransactionId = 0;


        public FormViewTransaction()
        {
            InitializeComponent();
            loadViewTransactionData();
            if (File.Exists("PersonalFinanceToolDB.xml") == true)
            {
                this.AppDataSet.ReadXml("PersonalFinanceToolDB.xml");
            }

            //this.TransactionDataSet = this.AppDataSet;
            //this.financialToolDataSet = this.TransactionDataSet;
            //this.dataGridViewTransaction.DataSource = this.financialToolDataSet;
            //this.dataGridViewTransaction.DataMember = "Transactions";
        }

        private void navCreateTransaction(object sender, EventArgs e)
        {
            FormCreateTransaction formCreateTransaction = new FormCreateTransaction();
            formCreateTransaction.btnUpdateEvent.Hide();
            formCreateTransaction.Show();
        }

        private void SelectTransactionRow(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow getRow = dataGridViewTransaction.Rows[e.RowIndex];
            iTransactionId = Int32.Parse(this.dataGridViewTransaction.CurrentRow.Cells[0].Value.ToString());
            sTransCategoryType = this.dataGridViewTransaction.CurrentRow.Cells[1].Value.ToString();
            sIncome = this.dataGridViewTransaction.CurrentRow.Cells[2].Value.ToString();
            sExpense = this.dataGridViewTransaction.CurrentRow.Cells[3].Value.ToString();
            sTransDesc = this.dataGridViewTransaction.CurrentRow.Cells[4].Value.ToString();
            sTransDate = this.dataGridViewTransaction.CurrentRow.Cells[5].Value.ToString();
            sAmount = this.dataGridViewTransaction.CurrentRow.Cells[6].Value.ToString();
            sTransEventName = this.dataGridViewTransaction.CurrentRow.Cells[7].Value.ToString();
        }

        private void navUpdateTransaction(object sender, EventArgs e)
        {
            FormCreateTransaction formCreateTransaction = new FormCreateTransaction();
            formCreateTransaction.SetUpdateFields(sTransCategoryType, sIncome, sExpense, sTransDesc, sTransDate, sAmount, sTransEventName, iTransactionId);
            formCreateTransaction.btnCreateEvent.Hide();
            formCreateTransaction.Show();
        }

        public void loadViewTransactionData()
        {

            FinanceToolDBContainer1 db = new FinanceToolDBContainer1();
            var transactionData =
                from transaction_tab in db.Transactions
                where transaction_tab.UserId == FormLogin.gblLoggedInUser
                select new
                {
                    TransactionId = transaction_tab.Id,
                    CategoryType = transaction_tab.CategoryType,
                    Income = transaction_tab.Income,
                    Expense = transaction_tab.Expense,
                    TransactionDescription = transaction_tab.TransactionDescription,
                    TransactionDate = transaction_tab.TransactionDate,
                    Amount = transaction_tab.Amount,
                    EventName = transaction_tab.EventName,
                    UserId = transaction_tab.UserId,
                    CategoryId = transaction_tab.CategoryId,
                    EventId = transaction_tab.EventId
                };


            dataGridViewTransaction.DataSource = transactionData.ToList();
            dataGridViewTransaction.Columns[0].Visible = false;
            dataGridViewTransaction.Columns[8].Visible = false;
            dataGridViewTransaction.Columns[9].Visible = false;
            dataGridViewTransaction.Columns[10].Visible = false;

        }

        private void MenuStripTransaction(object sender, MouseEventArgs e)
        {
            loadViewTransactionData();
        }
    }
}
