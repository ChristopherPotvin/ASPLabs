using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/// 
/// Author: Chris Potvin
/// Date: 1/18/2019
/// Details: This is a ASP webforms application that includes two webforms for a party picking application. It allows the user to 
/// select a date from the calendar and post the selected voting result to the second web form. It updates the count in real time
/// in the second page according to the date selected. The application also blacks out dates that do not allow the user to select an other
/// date other than the Saturdays requested in the business rules. 
///
namespace ChristopherPotvinLab2_CPRG_214
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int party_count1 = 0;
        int party_count2 = 0;
        int party_count3 = 0;
        DateTime today = DateTime.Now;
        DateTime partyDay;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["count1"] != null)
            {
                party_count1 = (int)Application["count1"];
            }

            else if (Application["count2"] != null)
            {
                party_count2 = (int)Application["count2"];
            }

            else if (Application["count3"] != null)
            {
                party_count3 = (int)Application["count3"];
            }

        }


        public void DayRender (object sender, DayRenderEventArgs e) // Initializes a new instance of the class using the specified cell and calendar day.
        {
  

            if (e.Day.Date >= (today.AddDays(21)) || e.Day.Date.DayOfWeek != (DayOfWeek.Saturday) || e.Day.Date <= today) // this statement ensures that only the three Saturdays are selectable to the user
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Black; // this turns the background color of the Calendar cell to black if the selecting is false
                e.Cell.ForeColor = System.Drawing.Color.White;
            }

            else 
            {
                e.Day.IsSelectable = true; 
                e.Cell.BackColor = System.Drawing.Color.White; // this turns the background color of the Calendar cell to white if the selecting is true
                e.Cell.ForeColor = System.Drawing.Color.Black;
            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e) // method to output the label depending on the Saturday that is selected
        {
            lblChanged.Text = "The party date is " + Calendar1.SelectedDate.ToShortDateString();  // lbl to string so the user can see the date that they've selected



        }

        protected void SubmitVote_Click(object sender, EventArgs e) // method to caclculate the count and attach the count to the Application in the second webform
        {
            partyDay = Calendar1.SelectedDate; // setting the variable partyDay to the selected calendar date

            if (partyDay <= today.AddDays(7)) // First saturday selected 

            {
                Application.Lock(); // Locks access to an System.Web.HttpApplicationState variable to facilitate access to synchronization.
                if (Application["count1"] != null) // ensuring that the application count is storing an int when return to the first webform
                    party_count1 = (int)Application["count1"]; // setting the application to an int
                    party_count1++; // auto incrementing the count or the variable party_count1

                Application["count1"] = party_count1;
               
                Application.UnLock(); // Unlocks access to an System.Web.HttpApplicationState variable to facilitate access to sycnchronization

                Response.Redirect("PartyCounter.aspx"); // Redirects a request to a new URL and specifies the new URL in the parameter.

            }

            else if (partyDay >= today.AddDays(7) && partyDay <= today.AddDays(14)) // ensuring that the second saturday is selected
            {
                Application.Lock();

                if (Application["count2"] != null)
                    party_count2 = (int)Application["count2"];
                    party_count2++;

                Application["count2"] = party_count2;
                

                Application.UnLock();

                Response.Redirect("PartyCounter.aspx");
            }

            else // everything other than the two Saturdays defaults to the third Saturday
            {
                Application.Lock();
                if (Application["count3"] != null)
                    party_count3 = (int)Application["count3"];
                    party_count3++;

                Application["count3"] = party_count3;
                

                Application.UnLock();

                Response.Redirect("PartyCounter.aspx");
            }
        }
    }
}