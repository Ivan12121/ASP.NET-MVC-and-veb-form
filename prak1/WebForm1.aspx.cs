using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prak1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("name1", "qwe");
            users.Add("name2", "123");
            users.Add("name3", "qwe123");

            if (users.ContainsKey(TextBoxPassword.Text))
            {
                if (users[TextBoxPassword.Text] == TextBoxLogin.Text || users[TextBoxPassword.Text] == TextBoxPassword.Text.ToUpperInvariant())
                {
                    Response.Redirect("WebForm2.aspx");
                }
                else Label1.Text = "нверный логин";
            }
            else Label1.Text = "неверный логин";
        }
    }
}