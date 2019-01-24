using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/// 
/// Author: Chris Potvin
/// Date: 1/18/2019
/// Details: This is the second ASP webforms application that maintains the count for the party date that user has selected
/// from the first webform calendar. 
///
namespace ChristopherPotvinLab2_CPRG_214
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        int party_count1 = 0;
        int party_count2 = 0;
        int party_count3 = 0;
      
        protected void Page_Load(object sender, EventArgs e) // method during form load refresh the count
        {
            if (Application["count1"] != null)
            {
                party_count1 = (int)Application["count1"];
            }

            if (Application["count2"] != null)
            {
                party_count2 = (int)Application["count2"];
            }

            if (Application["count3"] != null)
            {
                party_count3 = (int)Application["count3"];
            }

            txtCount1.Text = party_count1.ToString(); // display the party count in the txtCount txt box
            txtCount2.Text = party_count2.ToString();
            txtCount3.Text = party_count3.ToString();
        }

        protected void BtnReturn1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PartyPicker.aspx");
        }
    }
}