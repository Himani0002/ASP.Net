using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Image : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Img2.ImageUrl = "/Asp.net/Img2.jpg";
            Img2.Height = 400;
            Img2.Width = 400;

        }
        protected void DDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Img3.ImageUrl = DDL.SelectedValue;
        }
    }
}