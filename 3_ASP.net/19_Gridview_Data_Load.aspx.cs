using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace kriyal
{
    public partial class _19_Gridview_Data_Load : System.Web.UI.Page
    {
        static SqlConnection cn = new SqlConnection("Data Source=DESKTOP-3OS11LV;Initial Catalog=kriyaldb;User ID=sa;Password=P@ssw0rd");
        static DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select EID,EName,ESalary,EDOB,ECity from Employees";
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            da.Fill(dt);

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }

            //grdView.DataSource = dt;
            //grdView.DataBind();


            StringBuilder html = new StringBuilder();
            
            html.Append("<table border = '1'>");
            html.Append("<tr>");

            for(int i = 0; i<dt.Columns.Count; i++)
            {
                html.Append("<th>");
                html.Append(dt.Columns[i].ToString());
                html.Append("</th>");
            }

            /*
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<th>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            */

            /*Manual Column Heading         
            html.Append("<th>ID</th>");
            html.Append("<th>Name</th>");
            html.Append("<th>Salary</th>");
            html.Append("<th>Birth Date</th>");
            html.Append("<th>City</th>");
            */

            html.Append("</tr>");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                html.Append("<tr>");

                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    html.Append("<td>");
                    html.Append(dt.Rows[i][j].ToString());
                    html.Append("</td>");
                }

                html.Append("</tr>");
            }

            /*
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }
            */

            //Table end.
            html.Append("</table>");
            
            string strText = html.ToString();
            
            PlaceHolder1.Controls.Add(new Literal {Text = html.ToString()});
        }
    }
}