using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWebClient
{
    public partial class UI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HelloWebServiceNamespace.HelloWebServiceSoapClient client = new HelloWebServiceNamespace.HelloWebServiceSoapClient();
            Label1.Text = client.Hello(TextBox1.Text);
        }
    }
}