using ClosedXML.Excel;
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
    public partial class FormReport : Form
    {
        FinancialToolDataSet myDataSet = new FinancialToolDataSet();
        public FormReport()
        {
            InitializeComponent();
            if (File.Exists("PersonalFinanceToolDB.xml") == true)
            {
                this.myDataSet.ReadXml("PersonalFinanceToolDB.xml");
            }
        }

        private void GenerateReport(object sender, EventArgs e)
        {
            try {

                string relative = @"C:\Users\Alfred Edwin\Documents\FinanceToolDB.mdf";
                string absolute = Path.GetDirectoryName(relative);
                AppDomain.CurrentDomain.SetData("DataDirectory", absolute);

                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FinanceToolDB.mdf;Integrated Security=True"))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    using(DataTable dt = new DataTable("Transactions"))
                    {
                        using( SqlCommand cmd = new SqlCommand("SELECT t.Id, t.CategoryType, t.Income, t.Expense, t.TransactionDescription, t.TransactionDate, t.Amount, t.EventName, t.UserId FROM Transactions t WHERE t.TransactionDate between @startdate and @enddate", con))
                        {
                            cmd.Parameters.AddWithValue("@startdate", dateTimePickerStartDate.Value);
                            cmd.Parameters.AddWithValue("@enddate", dateTimePickerEndDate.Value);
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                            sqlDataAdapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DownloadReport(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter="Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using(XLWorkbook workbook = new XLWorkbook())
                            {
                                workbook.Worksheets.Add(this.myDataSet.Transactions.CopyToDataTable(), "Transactions");
                                workbook.SaveAs(sfd.FileName);
                            }
                            MessageBox.Show("You have Successfully Download the Report", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
