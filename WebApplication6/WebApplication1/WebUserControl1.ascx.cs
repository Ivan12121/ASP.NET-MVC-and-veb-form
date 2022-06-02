using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        public double Result
        {
            get;
            set;
        }

        public string MyText
        {
            get { return TextBox1.Text; }
            set { TextBox1.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e) { }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Result = Convert.ToDouble(TextBox1.Text) + Convert.ToDouble(TextBox2.Text);
            Label1.Text = Result.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Result = Convert.ToDouble(TextBox1.Text) - Convert.ToDouble(TextBox2.Text);
            Label1.Text = Result.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Result = Convert.ToDouble(TextBox1.Text) / Convert.ToDouble(TextBox2.Text);
            Label1.Text = Result.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Result = Convert.ToDouble(TextBox1.Text) * Convert.ToDouble(TextBox2.Text);
            Label1.Text = Result.ToString();
        }

       
    }
}