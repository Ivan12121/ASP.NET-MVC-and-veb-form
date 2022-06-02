using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        double Result;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            Result = client.Addd(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
            Label1.Text = Result.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            Result = client.Subst(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
            Label1.Text = Result.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            Result = client.Div(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
            Label1.Text = Result.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            Result = client.Mult(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
            Label1.Text = Result.ToString();
        }
    }
}