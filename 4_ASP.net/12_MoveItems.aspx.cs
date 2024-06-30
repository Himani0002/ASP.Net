using System;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class MoveItems : System.Web.UI.Page
    {
        int i=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(Page.IsPostBack==false)
            //{ 
                LB1.Items.Add(new ListItem("C Lang", "C"));
                LB1.Items.Add(new ListItem("C++", "CPP"));
                LB1.Items.Add(new ListItem("C#", "Cs"));
                LB1.Items.Add(new ListItem("Html", "Html"));
                LB1.Items.Add(new ListItem("Java", "Java"));
                LB1.Items.Add(new ListItem("Python", "Py"));
            //}
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            
           for(i=LB1.Items.Count-1;i>=0;i--)
           {
                if (LB1.Items[i].Selected == true)
                {
                    LB2.Items.Add(LB1.Items[i]);
                    LB1.Items.RemoveAt(i);
                }
            }
            LB2.ClearSelection();
           
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {

            for (i = 0; i < LB1.Items.Count; i++)
            {
                LB2.Items.Add(LB1.Items[i]);
            }
            LB1.Items.Clear();
        }

        protected void Btn3_Click(object sender, EventArgs e)
        {
            for(i=LB2.Items.Count-1;i>=0;i--)
            {
                if(LB2.Items[i].Selected==true)
                {
                    LB1.Items.Add(LB2.Items[i]);
                    LB2.Items.RemoveAt(i);
                }

            }
            LB1.ClearSelection();
        }

        protected void Btn4_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < LB2.Items.Count - 1; i++)
            {
                LB1.Items.Add(LB2.Items[i]);
            }
            LB2.Items.Clear();


        }
    }
}