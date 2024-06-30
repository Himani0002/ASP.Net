using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace kriyal
{
    public partial class _13_populate_dropdown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-3OS11LV;Initial Catalog=kriyaldb;User ID=sa;Password=P@ssw0rd");

        protected void btnTotal_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select deptID,deptName from Departments";
            cmd.Connection = cn;

            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }

            SqlDataReader rdr = cmd.ExecuteReader();
            string text = "", value = "";

            if(rdr.HasRows)
            {
                ddlDepartments.Items.Clear();
                ddlDepartments.Items.Add(new ListItem("Select Departmen", ""));

                while(rdr.Read())
                {
                    text = rdr["deptID"].ToString() + " - " + rdr["deptName"].ToString();
                    //value = rdr["deptID"].ToString();

                    ddlDepartments.Items.Add(new ListItem(text, value));
                }
            }

            rdr.Close();

            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }
    }
}