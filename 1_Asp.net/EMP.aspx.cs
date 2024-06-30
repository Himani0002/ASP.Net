using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication1
{
    public partial class EMP : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-3OS11LV;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=P@ssw0rd");
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Request.QueryString["eid"]);

            int Id = Convert.ToInt32(Request.QueryString["eid"]);
            SqlCommand cmd = new SqlCommand("Select * From Emp Where Id = " + Id);
            cmd.Connection = cn;

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlDataReader rdr = cmd.ExecuteReader();
            
            if(rdr.Read())
            {
                TxtEId.Text = rdr["Id"].ToString();
                TxtEName.Text = rdr["Name"].ToString();
                TxtESalary.Text = rdr["Salary"].ToString();
                TxtEHireDate.Text = rdr["HireDate"].ToString();
                TxtEDeptNo.Text = rdr["DeptNo"].ToString();
            }
            rdr.Close();

            if(cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cmd.Connection = cn;
        }
    }
}