using System;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-3OS11LV;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=P@ssw0rd");

       protected void Btn1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select ID,Name From EMP";
            cmd.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);  
            DataTable dt=new DataTable(); 

            if(cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            da.Fill(dt);

            if(cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            
            if(dt.Rows.Count > 0)
            {
                string Text = "";
                string vlaue = "";
                DDL1.Items.Clear();
                DDL1.Items.Add(new ListItem("Select Emp", ""));
                
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    Text = dt.Rows[i]["Id"].ToString()+"-"+ dt.Rows[i]["Name"].ToString();
                    vlaue = dt.Rows[i]["Id"].ToString();

                    DDL1.Items.Add(new ListItem(Text, vlaue));
                }
            }
        }

        protected void DDL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd=new SqlCommand(); 
            cmd.CommandText = "Select ID, Name, Salary, Hiredate, DeptNo from EMP WHERE ID = " + DDL1.SelectedValue + "";
            cmd.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            da.Fill(dt);

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            
            if (dt.Rows.Count > 0)
            {
                DDL1.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtID.Text = dt.Rows[i]["Id"].ToString();
                    txtName.Text = dt.Rows[i]["Name"].ToString();
                    txtSalary.Text = dt.Rows[i]["Salary"].ToString();
                    txtHireDate.Text = dt.Rows[i]["HireDate"].ToString();
                    txtDeptNo.Text = dt.Rows[i]["DeptNo"].ToString();
                }
            }

            cmd.Connection = cn;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO EMP([ID],[NAME],[SALARY],[HIREDATE],[DEPTNO]) VALUES(@ID,@NAME,@SALARY,@HIREDATE,@DEPTNO)";
            //cmd.CommandText = "Insert into EMP values("+ Convert.ToInt32(txtID.Text) +", '"+ txtName.Text +"', "+ Convert.ToInt32(txtSalary.Text) + ","+ DateTime.ParseExact(txtHireDate.Text, "dd/MM/yyyy", null) +", "+ Convert.ToInt32(txtDeptNo.Text) +")";
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            cmd.Parameters.AddWithValue("@NAME", txtName.Text);
            cmd.Parameters.AddWithValue("@SALARY", Convert.ToInt32(txtSalary.Text));
            cmd.Parameters.AddWithValue("@HIREDATE", DateTime.ParseExact(txtHireDate.Text, "dd/MM/yyyy", null));
            cmd.Parameters.AddWithValue("@DEPTNO", Convert.ToInt32(txtDeptNo.Text));

            cmd.Connection = cn;

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            cmd.ExecuteNonQuery();

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }

            Response.Write("Inserted");
        }

        protected void btnUpDate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE EMP SET NAME=@NAME, SALARY=@SALARY, HIREDATE=@HIREDATE, DEPTNO=@DEPTNO WHERE ID = @ID";

            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            cmd.Parameters.AddWithValue("@NAME", txtName.Text);
            cmd.Parameters.AddWithValue("@SALARY", Convert.ToInt32(txtSalary.Text));
            //cmd.Parameters.AddWithValue("@HIREDATE", DateTime.ParseExact(txtHireDate.Text, "dd/MM/yyyy", null));
            cmd.Parameters.AddWithValue("@DEPTNO", Convert.ToInt32(txtDeptNo.Text));
            cmd.Connection = cn;

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            cmd.ExecuteNonQuery();

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }

            Response.Write("Update");
        }

    }
}
