using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNRegister_Click(object sender, EventArgs e)
        {
            if(TFN.Text.Trim()=="")
            {
                MSGFN.Text = "First Name Cannot be blank!";
            }
            else if(TFN.Text.Length < 2)
            {
                MSGFN.Text = "Length must be 2 Characters";
            }
            else if (TFN.Text.Length > 20)
            {
                MSGFN.Text = "Length must be 20 Characters";
            }
            else
            {
                MSGFN.Text = "";
            }

            if(DDL.SelectedIndex == 0)
            {
                MSGCTY.Text = "Countery must be Selected";
            }
            else
            {
                MSGCTY.Text = "";
            }

            if (chkAgree.Checked == false)
            {
                msgAgree.Text = "Terms must be agreed";
            }
            else
            {
                msgAgree.Text = "";
            }
        }
    }
}