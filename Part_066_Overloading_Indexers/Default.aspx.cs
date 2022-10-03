using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_066_Overloading_Indexers
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            Label1.Text = "Before Update";
            Label2.Text = "<br/>";
            Label3.Text = "Total Number of Male Employees :  " + company["Male"];
            Label4.Text = "<br/>";
            Label5.Text = "Total Number of Female Employees :  " + company["Female"];

            Label6.Text = "<br/>";
            Label7.Text = "<br/>";

            company["Male"] = "Female";

            Label8.Text = "After Update";
            Label9.Text = "<br/>";
            Label10.Text = "Total Number of Male Employees :  " + company["Male"];
            Label11.Text = "<br/>";
            Label12.Text = "Total Number of Female Employees :  " + company["Female"];

        }
    }
}