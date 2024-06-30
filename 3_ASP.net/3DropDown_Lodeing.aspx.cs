using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    
    public partial class _3DropDown_Lodeing : System.Web.UI.Page
    {

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-3OS11LV;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=P@ssw0rd");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlCommand cmd = new SqlCommand("select * from Countries", cn);
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
                    string Text = "";
                    string vlaue = "";
                    DDL1.Items.Clear();
                    DDL1.Items.Add(new ListItem("--Select Countries--", ""));

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        Text = dt.Rows[i]["CId"].ToString() + "-" + dt.Rows[i]["CName"].ToString();
                        vlaue = dt.Rows[i]["CId"].ToString();

                        DDL1.Items.Add(new ListItem(Text, vlaue));
                    }
                }
                cmd.Connection = cn;
            }
        }
        protected void DDL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from States where Cid =" + DDL1.SelectedItem.Value, cn);
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
                string Text = "";
                string vlaue = "";
                DDL2.Items.Clear();
                DDL2.Items.Add(new ListItem("--Select States--", ""));

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    Text = dt.Rows[i]["SId"].ToString() + "-" + dt.Rows[i]["SName"].ToString();
                    vlaue = dt.Rows[i]["SId"].ToString();
                    DDL2.Items.Add(new ListItem(Text, vlaue));
                }
            }
            cmd.Connection = cn;
        }

        protected void DDL2_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select * from Cities where Sid=" + DDL2.SelectedItem.Value, cn);
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
                string Text = "";
                string vlaue = "";
                DDL3.Items.Clear();
                DDL3.Items.Add(new ListItem("--Select Citys--", ""));

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Text = dt.Rows[i]["CId"].ToString() + "-" + dt.Rows[i]["CName"].ToString();
                    vlaue = dt.Rows[i]["CId"].ToString();
                    DDL3.Items.Add(new ListItem(Text, vlaue));
                }
            }
            cmd.Connection = cn;
        }

    }
}
