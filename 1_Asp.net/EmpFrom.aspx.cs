using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-3OS11LV;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=P@ssw0rd");
        SqlCommand cmd = new SqlCommand();

        StringBuilder htmlTable = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (SqlCommand scmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM EMP";
                    cn.Open();
                    SqlDataReader articleReader = cmd.ExecuteReader();

                    htmlTable.Append("<table border='1'>");
                    htmlTable.Append("<tr><th>EID</th><th>EName</th><th>ShowData</th></tr>");

                    if (articleReader.HasRows)
                    {
                        while (articleReader.Read())
                        {
                            htmlTable.Append("<tr>");
                            htmlTable.Append("<td>" + articleReader["ID"] + "</td>");
                            htmlTable.Append("<td>" + articleReader["Name"] + "</td>");
                            htmlTable.Append("<td><a href='emp.aspx?eid="+ articleReader["ID"] + "'>Detail</a></td>");
                            htmlTable.Append("</tr>");
                        }
                        htmlTable.Append("</table>");

                        PlaceHolder1.Controls.Add(new Literal { Text = htmlTable.ToString() });

                        articleReader.Close();
                        articleReader.Dispose();
                    }
                }
            }
        }
    }
}
