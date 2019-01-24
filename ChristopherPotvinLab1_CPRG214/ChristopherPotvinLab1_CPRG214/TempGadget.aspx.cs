using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// 
/// Author: Chris Potvin
/// Date: 1/17/2019
/// Details: This is a ASP webforms application that incorporates a simple temperature conversion. It calls a bootstrap file from bootswatch and has two forms of validation
/// on the temperature input. It requires the user to enter a valid temperature between -1000 and 1000. Also requires them to enter an input value with two errors that display. 
///
namespace ChristopherPotvinLab1_CPRG214
{
    public partial class TempGadget : System.Web.UI.Page

    {   //declare constants
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void BtnClear_Click(object sender, EventArgs e)
        {
            txtInputTemp.Text = ""; // clear the input temp text
            LblConversion.Text = ""; // clear the conversion txt box
            DropDownList1.SelectedIndex = 0; // set drop down list back to Fahrenheit on button clear
            DropDownList2.SelectedIndex = 0; // set drop down list back to Celsius on button clear
           
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            double temp = 0; 
            
            if ((DropDownList1.SelectedIndex == 0) && (DropDownList2.SelectedIndex == 0))
            {
                temp = ((Convert.ToDouble(txtInputTemp.Text) - 32) / (1.8)); // F --> C
            }

            else if ((DropDownList1.SelectedIndex == 0) && (DropDownList2.SelectedIndex == 1)) 
                
            {
                temp = Convert.ToDouble(txtInputTemp.Text); // F --> F

            }

            else if ((DropDownList1.SelectedIndex == 1) && (DropDownList2.SelectedIndex == 0))
            {
                temp = Convert.ToDouble(txtInputTemp.Text); // C --> C

            }

            else if ((DropDownList1.SelectedIndex == 2) && (DropDownList2.SelectedIndex == 2))
            {
                temp = Convert.ToDouble(txtInputTemp.Text); // K --> K


            }

            else if ((DropDownList1.SelectedIndex == 0) && (DropDownList2.SelectedIndex == 2))
            {
                temp = ((Convert.ToDouble(txtInputTemp.Text) + 459.67) / (1.8)); // F --> K

            }

            else if ((DropDownList1.SelectedIndex == 1) && (DropDownList2.SelectedIndex == 1))
            {
                temp = ((Convert.ToDouble(txtInputTemp.Text)* (1.8)) + (32)); // C --> F

            }

            else if ((DropDownList1.SelectedIndex == 1) && (DropDownList2.SelectedIndex == 2 ))
            {
                temp = (Convert.ToDouble(txtInputTemp.Text) + 273.15); // C --> K

            }
            else if ((DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 0))
            {
                temp = ((Convert.ToDouble(txtInputTemp.Text) - 273.15)); // K --> F

            }

            else if ((DropDownList1.SelectedIndex == 2 ) && (DropDownList2.SelectedIndex == 1))
            {
                temp = ((Convert.ToDouble(txtInputTemp.Text) - 273.15) * (1.8) + 32); // K --> C


            }

            LblConversion.Text = Math.Round(temp, 2).ToString(); // rounding the output to two decimal places


        }
    }
}