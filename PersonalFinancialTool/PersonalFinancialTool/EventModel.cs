using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinancialTool
{
    class EventModel
    {
        public void SaveEventInformation(EventDetails info)
        {
            try
            {
                Event eventobj = new Event();

                eventobj.EventName = info.eventName;
                eventobj.EventDate = info.eventDate;
                eventobj.EventStatus = info.eventDate;
                eventobj.UserId = FormLogin.gblLoggedInUser;

                // Add to database
                FinanceToolDBContainer1 db = new FinanceToolDBContainer1();
                db.Events.Add(eventobj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }


    }
}
