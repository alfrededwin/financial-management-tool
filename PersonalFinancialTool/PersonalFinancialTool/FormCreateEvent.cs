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

        public FormCreateEvent()
        {
            InitializeComponent();
            if (File.Exists("PersonalFinanceToolDB.xml") == true)
            {
                this.AppDataSet.ReadXml("PersonalFinanceToolDB.xml");
            }
        }

        public EventDetails eventDetails;

        private void CreateEvent(object sender, EventArgs e)
        {
            this.eventDetails = new EventDetails();
            this.eventDetails.eventName = this.textBoxEventName.Text;
            this.eventDetails.eventDate = this.dateTimeEventDate.Text;
            this.eventDetails.eventStatus = this.rdoRecurring.Text;

            FinancialToolDataSet.EventsRow eventsRow = this.AppDataSet.Events.NewEventsRow();
            eventsRow.EventName = this.eventDetails.eventName;
            eventsRow.EventDate = this.eventDetails.eventDate;
            eventsRow.EventStatus = this.eventDetails.eventStatus;
          

            this.AppDataSet.Events.AddEventsRow(eventsRow);
            this.AppDataSet.AcceptChanges();

            this.AppDataSet.WriteXml("PersonalFinanceToolDB.xml");

            // Wee have now stored into memory // Not dont the Forwarding, that should be done by the Entity Framework.
            // Might a Web Service or Might call a DB over the internet.
            // Forwarding

            //CategoryModel categoryModel = new CategoryModel();
            //categoryModel.SaveCategoryInformation(this.categoryDetails);
            //MessageBox.Show(String.Format(Properties.Resources.SUCCESS_MESSAGE, this.sCategoryLabel));

            this.Close();
        }


        public void SetUpdateFields(String eventName, String eventDate, String eventStatus)
        {
            this.textBoxEventName.Text = eventName;
            this.dateTimeEventDate.Text = eventDate;
            this.rdoRecurring.Text = eventStatus;
        }





    }
}
