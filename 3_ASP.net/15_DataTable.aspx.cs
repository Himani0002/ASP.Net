using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace kriyal
{
    public partial class _15_DataTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-3OS11LV;Initial Catalog=kriyaldb;User ID=sa;Password=P@ssw0rd");
        protected void btnLoad_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select deptID,deptName from Departments";
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            if(cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            da.Fill(dt);

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }

            if(dt.Rows.Count > 0)
            {
                string text = "";
                string value = "";
                ddlDepartments.Items.Clear();
                ddlDepartments.Items.Add(new ListItem("Select Departments", ""));

                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    text = dt.Rows[i]["deptID"].ToString() + " - " + dt.Rows[i]["deptName"].ToString();
                    value = dt.Rows[i]["deptID"].ToString();

                    ddlDepartments.Items.Add(new ListItem(text, value));
                }
            }
        }
    }
}