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
    public partial class _16_Country_State_City : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-3OS11LV;Initial Catalog=kriyaldb;User ID=sa;Password=P@ssw0rd");


        protected void loadRecordsIntoDropdown(string sql, string selectText, string txtCol, string valCol, DropDownList ddl)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =  sql;
            cmd.Connection = cn;

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            SqlDataReader rdr = cmd.ExecuteReader();
            string text = "", value = "";

            if (rdr.HasRows)
            {
                ddl.Items.Clear();
                ddl.Items.Add(new ListItem(selectText, ""));

                while (rdr.Read())
                {
                    text = rdr[txtCol].ToString();
                    value = rdr[valCol].ToString();

                    ddl.Items.Add(new ListItem(text, value));
                }
            }

            rdr.Close();

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                loadRecordsIntoDropdown("Select CnID,CnName from Countries",
                                        "Select Country",
                                        "CnName",
                                        "CnID",
                                        ddlCountry);

                /*
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select CnID,CnName from Countries";
                cmd.Connection = cn;

                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                SqlDataReader rdr = cmd.ExecuteReader();
                string text = "", value = "";

                if (rdr.HasRows)
                {
                    ddlCountry.Items.Clear();
                    ddlCountry.Items.Add(new ListItem("Select Countries", " "));

                    while (rdr.Read())
                    {
                        text = rdr["CnName"].ToString();
                        value = rdr["CnID"].ToString();

                        ddlCountry.Items.Add(new ListItem(text, value));
                    }
                }

                rdr.Close();

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                */
            }
        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadRecordsIntoDropdown("Select StID,StName from States where StCnID = " + Convert.ToInt32(ddlCountry.SelectedValue) + "",
                                        "Select State",
                                        "StName",
                                        "StID",
                                        ddlState);
            /*
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select StID,StName from States where StCnID = " + Convert.ToInt32(ddlCountry.SelectedValue) + "";
            cmd.Connection = cn;

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            SqlDataReader rdr = cmd.ExecuteReader();
            string text = "", value = "";

            if (rdr.HasRows)
            {
                ddlState.Items.Clear();
                ddlState.Items.Add(new ListItem("Select States", " "));

                while (rdr.Read())
                {
                    text = rdr["StName"].ToString();
                    value = rdr["StID"].ToString();

                    ddlState.Items.Add(new ListItem(text, value));
                }
            }
            else
            {
                ddlState.Items.Clear();
                ddlState.Items.Add(new ListItem("Select States", " "));
            }

            rdr.Close();

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            */
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadRecordsIntoDropdown("Select CtID,CtName from Cities where CtStID = " + Convert.ToInt32(ddlState.SelectedValue) + "",
                                        "Select City",
                                        "CtName",
                                        "CtID",
                                        ddlCity);
        }
    }
}