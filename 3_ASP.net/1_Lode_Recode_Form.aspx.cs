using System;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class _1_Emp : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-3OS11LV;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=P@ssw0rd");

        protected void Btn1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(); 
            cmd.CommandText = "Select ID, Name from EMP";
            cmd.Connection = cn;    

            if(cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }

            SqlDataReader rdr = cmd.ExecuteReader();

            string Text = "";
            string Value = ""; 

            if(rdr.HasRows)
            {
                DDL1.Items.Clear();
                DDL1.Items.Add(new ListItem("Select Emp ", ""));

                while(rdr.Read())
                {
                    Text = rdr["Id"].ToString() + " - " + rdr["Name"].ToString();
                    Value = rdr["Id"].ToString();
                    DDL1.Items.Add(new ListItem(Text,Value));
                }
            }
            rdr.Close();

            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }

        protected void DDL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select ID, Name, Salary, Hiredate, DeptNo from EMP WHERE ID = "+ DDL1.SelectedValue +"";
            cmd.Connection = cn;

            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {               
                while (rdr.Read())
                {
                    txtID.Text = rdr["ID"].ToString();
                    txtName.Text = rdr["Name"].ToString();
                    txtSalary.Text = rdr["Salary"].ToString();
                    txtHireDate.Text = rdr["HireDate"].ToString();
                    txtDeptNo.Text = rdr["DeptNo"].ToString();
                }
            }

            rdr.Close();

            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }


            cmd.Connection = cn;

            
        }
    }
}