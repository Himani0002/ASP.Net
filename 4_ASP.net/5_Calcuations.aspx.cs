using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Calcuations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddition_Click(object sender, EventArgs e)
        {
            txtresult.Text = (Convert.ToInt32(txtval1.Text) + Convert.ToInt32(txtval2.Text)).ToString();
        }

        protected void btnSubstraction_Click(object sender, EventArgs e)
        {

           
            txtresult.Text = (Convert.ToInt32(txtval1.Text) - Convert.ToInt32(txtval2.Text)).ToString();
        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {

            txtresult.Text = (Convert.ToInt32(txtval1.Text) * Convert.ToInt32(txtval2.Text)).ToString();
        }

        protected void btnDivision_Click(object sender, EventArgs e)
        {

            txtresult.Text = (Convert.ToInt32(txtval1.Text) / Convert.ToInt32(txtval2.Text)).ToString();

        }
    }
}