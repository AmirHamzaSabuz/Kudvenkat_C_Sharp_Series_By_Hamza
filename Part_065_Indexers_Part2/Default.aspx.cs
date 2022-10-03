using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_065_Indexers_Part2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();
            Label1.Text = "Name of Employee with Id = 2: " + company[2];
            Label2.Text= "<br/>";

            Label3.Text = "Name of Employee with Id = 5: " + company[5];
            Label4.Text = "<br/>";

            Label5.Text = "Name of Employee with Id = 8: " + company[8];


            Label6.Text = "<br/>";
            Label7.Text = "<br/>";


            Label8.Text = "Changing names of employees with Id = 2,5,8";
            Label9.Text = "<br/>";

            company[2] = "Employee 2 Name Changed";
            company[5] = "Employee 5 Name Changed";
            company[8] = "Employee 8 Name Changed";


            Label10.Text = "Name of Employee with Id = 2: " + company[2];
            Label11.Text = "<br/>";

            Label12.Text = "Name of Employee with Id = 5: " + company[5];
            Label13.Text = "<br/>";

            Label14.Text = "Name of Employee with Id = 8: " + company[8];


        }
    }
}