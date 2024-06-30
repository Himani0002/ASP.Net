using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kriyal
{
    public partial class _11_inversedelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = lstItems.Items.Count - 1; i >= 0 ; i--)
            {
                if(lstItems.Items[i].Selected == false)
                {
                    lstItems.Items.RemoveAt(i);
                }
            } 
        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            btnResult.Enabled = true;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
            txtsearch.Focus();
            int cnt = 0;

            for(int i = 0; i < lstItems.Items.Count; i++)
            {
                if(lstItems.Items[i].Text == txtsearch.Text)
                {
                    lstItems.Items[i].Selected = true;
                    cnt++;
                }                
            }

            if (cnt == 0)
            {
                lblMessage.Text = "No Match In Search Items";
            }

        }
    }
}