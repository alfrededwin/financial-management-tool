using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinancialTool
{
    public partial class FormViewEvent : Form
    {
        FinancialToolDataSet myDataSet = new FinancialToolDataSet();
        FinancialToolDataSet UserDataSet { get; set; }

        public String sEventName = "";
        public String sEventStatus = "";
        public String sEventDate = "";
        public int sEventId = 0;
        public FormViewEvent()
        {
            InitializeComponent();
        }

        private void navCreateEvent(object sender, EventArgs e)
        {
            FormCreateEvent formCreateEvent = new FormCreateEvent();
            formCreateEvent.btnUpdateEvent.Hide();
            formCreateEvent.Show();
        }

        private void FormViewEvent_Load(object sender, EventArgs e)
        {
            myDataSet.ReadXml("PersonalFinanceToolDB.xml");
            this.UserDataSet = this.myDataSet;
            this.financialToolDataSet = this.myDataSet;
            this.dataGridViewEvent.DataSource = this.financialToolDataSet;
            this.dataGridViewEvent.DataMember = "Events";
        }

        private void UpdateEvent(object sender, EventArgs e)
        {
            FormCreateEvent formCreateEvent = new FormCreateEvent();
            formCreateEvent.SetUpdateFields(sEventName, sEventDate, sEventStatus, sEventId);
            formCreateEvent.btnCreateEvent.Hide();
            formCreateEvent.Show();
        }

        private void SelectEventRow(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow getRow = dataGridViewEvent.Rows[e.RowIndex];
            sEventId = Int32.Parse(this.dataGridViewEvent.CurrentRow.Cells[0].Value.ToString());
            sEventName = this.dataGridViewEvent.CurrentRow.Cells[1].Value.ToString();
            sEventDate = this.dataGridViewEvent.CurrentRow.Cells[2].Value.ToString();
            sEventStatus = this.dataGridViewEvent.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
