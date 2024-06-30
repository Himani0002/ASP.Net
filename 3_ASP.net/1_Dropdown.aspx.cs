using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testASP.Dhruvi_Kriyal
{
    public partial class _1_Dropdown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Only text
            /*
            lstCountry.Items.Add("India");
            lstCountry.Items.Add("Australia");
            lstCountry.Items.Add("USA");
            */

            // Text with value
            lstCountry.Items.Add(new ListItem("India", "IN"));
            lstCountry.Items.Add(new ListItem("Australia", "AU"));
            lstCountry.Items.Add(new ListItem("USA", "US"));
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            LstStates.Items.Add("Gujarat");
            LstStates.Items.Add("Maharastra");
            LstStates.Items.Add("Bihar");
        }

        protected void btnAddName_Click(object sender, EventArgs e)
        {
            lstNames.Items.Add(txtName.Text);
            txtName.Text = "";
            txtName.Focus();
        }
    }
}