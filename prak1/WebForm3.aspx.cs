using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prak1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String str = "TextBoxInput: " + TextBoxInput.Text;
            str += "<br/>ListBoxSpices: " + ListBoxSpices.SelectedValue;
            str += "<br/>DropDownListFruits: " + DropDownListFruits.SelectedValue;

            if (RadioButtonCup.Checked)
            {
                str += "<br/>RadioButtonCup: " + RadioButtonCup.Text;
            }

            if (RadioButtonPlate.Checked)
            {
                str += "<br/>RadioButtonPlate: " + RadioButtonPlate.Text;
            }

            if (RadioButtonKettle.Checked)
            {
                str += "<br/>RadioButtonKettle: " + RadioButtonKettle.Text;
            }

            Label1.Text = str;
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}