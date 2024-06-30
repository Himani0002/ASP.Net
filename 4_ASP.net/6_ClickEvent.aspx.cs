using System;

namespace WebApplication1
{
    public partial class ClickEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Btnsave_Click(object sender, EventArgs e)
        {
            txtMsg.Text = "Welcome to the world";
        }

        protected void Btnclear_Click(object sender, EventArgs e)
        {
            txtMsg.Text = "";
        }
    }
}