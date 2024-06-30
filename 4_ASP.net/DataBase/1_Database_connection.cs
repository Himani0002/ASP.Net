using System;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-3OS11LV;Initial Catalog=test;User ID=sa;Password=P@ssw0rd";

            cn.Open();

            LB1.Text = "Database connection is Successfully Open ";

            cn.Close();
        }
    }
}