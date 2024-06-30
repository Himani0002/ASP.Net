using System;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Database_connection2 : System.Web.UI.Page
    {
        SqlConnection cn =new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Data Source=DESKTOP-3OS11LV;Initial Catalog=test;User ID=sa;Password=P@ssw0rd";
        }

        protected void BTN1_Click(object sender, EventArgs e)
        {
            if(cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select DeptId,DeptName From Departments";
            cmd.Connection = cn;
            SqlDataReader rdr = cmd.ExecuteReader();

            if(rdr.HasRows)
            {
                while(rdr.Read())
                {
                    DDL1.Items.Add(new ListItem(rdr["DeptName"].ToString(), rdr["DeptId"].ToString()));
                }
            }
            rdr.Close();

            if(cn .State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }
    }
}