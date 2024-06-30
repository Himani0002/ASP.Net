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
    public partial class _17_Employees_data : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-3OS11LV;Initial Catalog=kriyaldb;User ID=sa;Password=P@ssw0rd");

        protected DataTable GetDataTable(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
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

            return dt;
        }
        protected void loadRecordsIntoTextbox(string sql, string selectText, string txtCol, string valCol, DropDownList ddl)
        {
            DataTable dt = new DataTable();
            dt = GetDataTable(sql);

            if (dt.Rows.Count > 0)
            {
                string text = "";
                string value = "";

                ddl.Items.Clear();
                ddl.Items.Add(new ListItem(selectText, ""));

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    text = dt.Rows[i][txtCol].ToString();
                    value = dt.Rows[i][valCol].ToString();

                    ddl.Items.Add(new ListItem(text, value));
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                loadRecordsIntoTextbox("Select EID, EName, ESalary, EDOB, ECity from Employees",
                                        "Select Employees",
                                        "EName",
                                        "EID",
                                        ddlEmployees);
                /*
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select EID, EName, ESalary, EDOB, ECity from Employees";
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
                    string text = "";
                    string value = "";
                    ddlEmployees.Items.Clear();
                    ddlEmployees.Items.Add(new ListItem("Select Employees", ""));

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        text = dt.Rows[i]["EName"].ToString();
                        value = dt.Rows[i]["EID"].ToString();

                        ddlEmployees.Items.Add(new ListItem(text, value));
                    }
                } */
            }
        }

        protected void ddlEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = GetDataTable("Select EID, EName, ESalary, EDOB, ECity from Employees where EID = " + Convert.ToInt32(ddlEmployees.SelectedValue) + "");

            txtEID.Text = dt.Rows[0]["EID"].ToString();
            txtEName.Text = dt.Rows[0]["EName"].ToString();
            txtESalary.Text = dt.Rows[0]["ESalary"].ToString();
            txtEDOB.Text = dt.Rows[0]["EDOB"].ToString();
            txtECity.Text = dt.Rows[0]["ECity"].ToString();

            /*SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select EID, EName, ESalary, EDOB, ECity from Employees where EID = " + Convert.ToInt32(ddlEmployees.SelectedValue) + "";
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

            txtEID.Text = dt.Rows[0]["EID"].ToString();
            txtEName.Text = dt.Rows[0]["EName"].ToString();
            txtESalary.Text = dt.Rows[0]["ESalary"].ToString();
            txtEDOB.Text = dt.Rows[0]["EDOB"].ToString();
            txtECity.Text = dt.Rows[0]["ECity"].ToString();*/
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Employees(EID,EName,ESalary,EDOB,ECity) VALUES(@EID,@EName,@ESalary,@EDOB,@ECity)";
            cmd.Parameters.AddWithValue("@EID", Convert.ToInt32(txtEID.Text));
            cmd.Parameters.AddWithValue("@EName", txtEName.Text);
            cmd.Parameters.AddWithValue("@ESalary", Convert.ToInt32(txtESalary.Text));
            cmd.Parameters.AddWithValue("@EDOB", DateTime.ParseExact(txtEDOB.Text, "dd/MM/yyyy", null));
            cmd.Parameters.AddWithValue("@ECity", txtECity.Text);

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

            Response.Write("Done");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Employees SET EName = @EName, ESalary = @ESalary, EDOB = @EDOB, ECity = @ECity WHERE EID = @EID";
            cmd.Parameters.AddWithValue("@EName", txtEName.Text);
            cmd.Parameters.AddWithValue("@ESalary", Convert.ToInt32(txtESalary.Text));
            cmd.Parameters.AddWithValue("@EDOB", DateTime.ParseExact(txtEDOB.Text, "dd/MM/yyyy", null));
            cmd.Parameters.AddWithValue("@ECity", txtECity.Text);
            cmd.Parameters.AddWithValue("@EID", Convert.ToInt32(txtEID.Text));

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

            Response.Write("Update Record");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Employees WHERE EID = @EID";
            cmd.Parameters.AddWithValue("@EID", txtEID.Text);
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

            Response.Write("Delete Record");
        }
    }
}