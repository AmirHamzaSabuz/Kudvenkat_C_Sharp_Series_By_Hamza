using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_064_Indexers_Part1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Using the string indexer to store session data
            Session["Session1"] = "Session 1 Data";

            // Using the string indexer to store session data
            Session["Session2"] = "Session 2 Data";
            
            // Using the integral indexer to retrieve data 
            Label1.Text = "Session 1 Data = " + Session[0].ToString();

            // Using the string indexer to retrieve data 
            Label2.Text = "Session 2 Data = " + Session["Session2"].ToString();
        }
    }
}