using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Viernes2510App
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUno_Click(object sender, EventArgs e)
        {
            //string resultado = "algo de texto";
            //Response.Redirect("WebForm3.aspx?valor="+23+"&valor2="+resultado);

            Server.Transfer("WebForm3.aspx");
        }
    }
}