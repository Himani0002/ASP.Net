using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Longin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lstCountry3.Items.Add("Select Country");
            lstCountry3.Items.Add("Usa");
            lstCountry3.Items.Add(new ListItem("Chaina"));
            lstCountry3.Items.Add("Japan");
            lstCountry3.Items.Add("nepal");
            lstCountry3.Items.Add("Uk");

            lstCountry4.Items.Add(new ListItem("Select Country", ""));
            lstCountry4.Items.Add(new ListItem("India", "2"));
            lstCountry4.Items.Add(new ListItem("Usa", "3"));
            lstCountry4.Items.Add(new ListItem("Uk", "4"));
            lstCountry4.Items.Add(new ListItem("China", "5"));


        }
    }
}