using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if(DDL1.SelectedIndex == 0)
            {
                spnDdl.InnerText = "Name must be selected.";
            }
            else if(txtId.Text.Trim() == "")
            {
                spnID.InnerText = "ID cannot be null.";
            }
            else if (txtName.Text.Trim() == "")
            {
                spnName.InnerText = "Name cannot be null.";
            }
            else if (txtSalary.Text.Trim() == "")
            {
                spnSalary.InnerText = "Salary cannot be null.";
            }
            else if (txtHireDate.Text.Trim() == "")
            {
                spnHireDate.InnerText = "IHire Date cannot be null.";
            }
            else
            {
                spnDdl.InnerText = "";
                spnID.InnerText = "";
                spnName.InnerText = "";
                spnSalary.InnerText = "";
                spnHireDate.InnerText = "";

                // Opearion
            }
        }
    }
}