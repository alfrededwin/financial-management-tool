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
            loadViewEventData();
        }

        private void navCreateEvent(object sender, EventArgs e)
        {
            FormCreateEvent formCreateEvent = new FormCreateEvent();
            formCreateEvent.btnUpdateEvent.Hide();
            formCreateEvent.Show();
        }

        private void FormViewEvent_Load(object sender, EventArgs e)
        {
            // If accessing through the dataset from XML
            //myDataSet.ReadXml("PersonalFinanceToolDB.xml");
            //this.UserDataSet = this.myDataSet;
            //this.financialToolDataSet = this.myDataSet;
            //this.dataGridViewEvent.DataSource = this.financialToolDataSet;
            //this.dataGridViewEvent.DataMember = "Events";
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

        public void loadViewEventData()
        {

            FinanceToolDBContainer1 db = new FinanceToolDBContainer1();
            var eventData =
                from event_tab in db.Events
                where event_tab.UserId == FormLogin.gblLoggedInUser
                select new
                {
                    EventId = event_tab.Id,
                    EventName = event_tab.EventName,
                    EventDate = event_tab.EventDate,
                    EventStatus = event_tab.EventStatus,
                    UserId = event_tab.UserId
                };


            dataGridViewEvent.DataSource = eventData.ToList();
            dataGridViewEvent.Columns[0].Visible = false;
            dataGridViewEvent.Columns[4].Visible = false;

        }

        private void MenuStripViewEvent(object sender, MouseEventArgs e)
        {
            loadViewEventData();
        }
    }
}
