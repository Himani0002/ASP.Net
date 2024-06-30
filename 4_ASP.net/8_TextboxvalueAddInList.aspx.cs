using System;


namespace WebApplication1
{
    public partial class TextboxvalueAddInList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BTN_Click(object sender, EventArgs e)
        {
            DDL.Items.Add(TB.Text);
        }
    }
}