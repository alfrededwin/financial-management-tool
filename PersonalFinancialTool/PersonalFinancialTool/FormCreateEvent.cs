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
    public partial class FormCreateEvent : Form
    {
        FinancialToolDataSet AppDataSet = new FinancialToolDataSet();
        public String sEventLabel = "Event";
        public static int globalIdToUpdate = 0;
        public EventDetails eventDetails { get; set; }
        public FinancialToolDataSet  EventDataSet { get; set; }


        public FormCreateEvent()
        {
            InitializeComponent();
            if (File.Exists("PersonalFinanceToolDB.xml") == true)
            {
                this.AppDataSet.ReadXml("PersonalFinanceToolDB.xml");
            }
        }

        //public EventDetails eventDetails;

        private void CreateEvent(object sender, EventArgs e)
        {
            int loggedInUser = FormLogin.gblLoggedInUser;

            try
            {
                // Assign Values
                this.eventDetails = new EventDetails();
                this.eventDetails.eventName = this.textBoxEventName.Text;
                this.eventDetails.eventDate = this.dateTimeEventDate.Value;
                this.eventDetails.eventStatus = this.rdoRecurring.Text;

                if (string.IsNullOrWhiteSpace(this.eventDetails.eventName))
                {
                    MessageBox.Show(Properties.Resources.COMMON_MISSING_DATA);
                }
                else
                {
                    // Assign to Dataset
                    FinancialToolDataSet.EventsRow eventsRow = this.AppDataSet.Events.NewEventsRow();
                    eventsRow.EventName = this.eventDetails.eventName;
                    eventsRow.EventDate = this.eventDetails.eventDate;
                    eventsRow.EventStatus = this.eventDetails.eventStatus;
                    eventsRow.UserId = loggedInUser;

                    // Apply Changes to DT
                    this.AppDataSet.Events.AddEventsRow(eventsRow);
                    this.AppDataSet.AcceptChanges();

                    // Writing to XML File
                    this.AppDataSet.WriteXml("PersonalFinanceToolDB.xml");

                    // Forwarding to Database.
                    EventModel eventModel = new EventModel();
                    eventModel.SaveEventInformation(this.eventDetails);
                    this.Close();
                    MessageBox.Show(String.Format(Properties.Resources.SUCCESS_MESSAGE, this.sEventLabel));
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SetUpdateFields(String eventName, String eventDate, String eventStatus, int sEventId)
        {
            this.textBoxEventName.Text = eventName;
            this.dateTimeEventDate.Text = eventDate;
            this.rdoRecurring.Text = eventStatus;
            globalIdToUpdate = sEventId;
        }

        private void UpdateEvent(object sender, EventArgs e)
        {
            try
            {
                // Assign Values
                this.eventDetails = new EventDetails();
                this.eventDetails.eventName = this.textBoxEventName.Text;
                this.eventDetails.eventDate = this.dateTimeEventDate.Value;
                this.eventDetails.eventStatus = this.rdoRecurring.Text;

                if (string.IsNullOrWhiteSpace(this.eventDetails.eventName))
                {
                    MessageBox.Show(Properties.Resources.COMMON_MISSING_DATA);
                }
                else
                {
                    // Assign to Dataset
                    FinancialToolDataSet.EventsRow eventsRow = this.AppDataSet.Events.FindByEventId(globalIdToUpdate);
                    eventsRow.EventName = this.eventDetails.eventName;
                    eventsRow.EventDate = this.eventDetails.eventDate;
                    eventsRow.EventStatus = this.eventDetails.eventStatus;

                    // Apply Changes to DT
                    this.AppDataSet.AcceptChanges();

                    // Writing to XML File
                    this.AppDataSet.WriteXml("PersonalFinanceToolDB.xml");

                    // Forwarding to Database.
                    EventModel eventModel = new EventModel();
                    eventModel.UpdateEventInformation(globalIdToUpdate,this.eventDetails);
                    this.Close();
                    MessageBox.Show(String.Format(Properties.Resources.SUCCESS_UPDATE, this.sEventLabel));
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

    }
    }
}
