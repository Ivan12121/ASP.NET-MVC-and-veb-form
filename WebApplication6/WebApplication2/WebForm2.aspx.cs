using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet Source;
            Source = (DataSet)Cache["MyCache"];
            if(Source == null)
            {
                ServiceReference2.WebService2SoapClient client = new ServiceReference2.WebService2SoapClient();
                Source = client.GetCustomers();
                GridView1.DataSource = Source;
                Cache["MyCache"] = Source;
                

                //Cache.Add("MyCache", Source, null, DateTime.Now.AddSeconds(5))
                GridView1.DataBind();
                Label1.Text = "Данные загруженны из таблицы";
            }
            else
            {
                Label1.Text = "Данные загруженны из Кэша";
            }
        }

    }
}