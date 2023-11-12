using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != string.Empty)
            {
                SqlDataSource1.Insert();
                GridView1.DataBind();
                TextBox1.Text = string.Empty;
            }
            else
            {
                Label3.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text != string.Empty)
            {
                SqlDataSource2.Insert();
                GridView2.DataBind();
                TextBox2.Text = string.Empty;
            }
            else
            {
                Label4.Visible = true;
            }
        }
    }
}