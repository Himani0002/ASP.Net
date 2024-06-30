using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace kriyal
{
    public partial class _12_check_db_conn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheckDbCon_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-3OS11LV;Initial Catalog=kriyaldb;User ID=sa;Password=P@ssw0rd";

            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
                lblMessage.Text = "DB Connection is Open";
            }

            if(cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
                lblMessage.Text += " DB Connection is closed";
            }
        }
    }
}