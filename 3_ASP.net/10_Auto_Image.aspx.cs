using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kriyal
{
    public partial class _10_Auto_Image : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
                lstImages.SelectedIndex = 0;
                img.ImageUrl = lstImages.Items[0].Value;
                lstImages.Focus();
            }
        }

        protected void lstImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            img.ImageUrl = lstImages.SelectedItem.Value;
            lstImages.Focus();
        }
    }
}