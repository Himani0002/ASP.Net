using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_A
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void btnLast_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSource.Items.Count; i++)
            {
                lstDestination.Items.Add(lstSource.Items[i]);
            }

            lstSource.Items.Clear();
        }

        protected void btnFirst_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDestination.Items.Count; i++)
            {
                lstSource.Items.Add(lstDestination.Items[i]);
            }

            lstDestination.Items.Clear();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            for (int i = lstSource.Items.Count - 1; i >= 0; i--)
            {
                if (lstSource.Items[i].Selected == true)
                {
                    lstDestination.Items.Add(lstSource.Items[i]);
                    lstSource.Items.RemoveAt(i);
                }

            }
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            for (int i = lstDestination.Items.Count - 1; i >= 0; i--)
            {
                if (lstDestination.Items[i].Selected == true)
                {
                    lstSource.Items.Add(lstDestination.Items[i]);
                    lstDestination.Items.RemoveAt(i);
                }

            }
        }

    }
}