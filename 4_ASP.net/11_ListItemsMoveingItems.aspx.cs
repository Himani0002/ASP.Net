using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ListItems : System.Web.UI.Page
    {
        int i;

        protected void Btn1_Click(object sender, EventArgs e)
        {

            for (i = LB1.Items.Count-1; i >= 0 ; i--)
            {
                if (LB1.Items[i].Selected == false)
                {
                    LB1.Items.RemoveAt(i);

                }
            }
            
        }
        protected void TextBtn1_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (i = LB1.Items.Count - 1; i >= 0; i--)
            {

                if (LB1.Items[i].Text == TB1.Text)
                {
                    c++;
                }
            }
            SapnMsg.InnerText = "Total Records are : " + c;


        }

        protected void SeleteBtn1_Click(object sender, EventArgs e)
        {


            for (i = LB1.Items.Count - 1; i >= 0; i--)
            {

                if (LB1.Items[i].Text == TB1.Text)
                {
                    LB1.Items[i].Selected = true;
                }
            }
        }
    }
    
}