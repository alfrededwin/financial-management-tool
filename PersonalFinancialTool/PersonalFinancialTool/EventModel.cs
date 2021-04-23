using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinancialTool
{
    class EventModel:DbContext
    {
        public void SaveEventInformation(EventDetails info)
        {
            try
            {
                Event eventobj = new Event();

                eventobj.EventName = info.eventName;
                eventobj.EventDate = info.eventDate;
                eventobj.EventStatus = info.eventStatus;
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

        public void UpdateEventInformation(int IdToUpdate, EventDetails info)
        {

            try
            {
                Event eventobj = new Event();

                eventobj.EventName = info.eventName;
                eventobj.EventDate = info.eventDate;
                eventobj.EventStatus = info.eventStatus;
                eventobj.UserId = FormLogin.gblLoggedInUser;

                // Update to database
                FinanceToolDBContainer1 db = new FinanceToolDBContainer1();

                using (var context = new FinanceToolDBContainer1())
                {
                    var std = context.Events.Find(IdToUpdate);
                    std.EventName = info.eventName;
                    std.EventDate = info.eventDate;
                    std.EventStatus = info.eventStatus;
                    std.UserId = FormLogin.gblLoggedInUser;

                    // Updating the Event Name based on the Event Name From Events Table.
                    var transactionUpdate = context.Transactions.Where(x => x.EventId == IdToUpdate).ToList();
                    foreach (var item in transactionUpdate)
                    {
                        item.EventName = info.eventName;
                    }

                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
