using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace kriyal
{
    public partial class _14_CountRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-3OS11LV;Initial Catalog=kriyaldb;User ID=sa;Password=P@ssw0rd");

        protected void btnCount_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select count(*) from Departments";
            cmd.Connection = cn;

            if(cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }

            int totalRecords = Convert.ToInt32(cmd.ExecuteScalar());

            if(cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }

            lblMssage.Text = "Total Departlments: " + totalRecords.ToString();
        }
    }
}