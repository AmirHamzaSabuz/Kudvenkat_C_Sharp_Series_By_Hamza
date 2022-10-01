using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_061_Partial_Classes
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PartialCustomer c2 = new PartialCustomer();
            c2.FirstName = "Amir";
            c2.LastName = "Hamza";

            string FullName2 = c2.GetFullName();
            Label1.Text = "Full Name = " + FullName2 + "<br/>";
        }
    }
}