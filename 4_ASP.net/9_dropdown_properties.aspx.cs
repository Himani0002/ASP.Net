using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _9_dropdown_properties : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTotal_Click(object sender, EventArgs e)
        {
            SapnMsg.InnerText = "Total Records are : " + (DDl.Items.Count - 1).ToString();
        }

        protected void BtnGetSelected_Click(object sender, EventArgs e)
        {
            SapnMsg.InnerText = "Selected Item is : " + DDl.SelectedItem.Text;

        }

        protected void BtnGetSelectedIndex_Click(object sender, EventArgs e)
        {
            SapnMsg.InnerText = "Selected Index is : " + DDl.SelectedIndex.ToString();

        }

       

        protected void BtnRemoveSelected_Click(object sender, EventArgs e)
        {
            DDl.Items.Remove(DDl.SelectedItem);
        }

        protected void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            DDl.Items.Clear();
        }
        protected void BtnRemoveByIndex_Click(object sender, EventArgs e)
        {
            DDl.Items.RemoveAt(Convert.ToInt32(TxtIndex.Text));
        }
    }
}