using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Viernes2510App
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int valorLLegado = Convert.ToInt32( Request.QueryString["valor"]);
            //string valorLLegado2 = Request.QueryString["valor2"];
            

            string valor1 = Request.QueryString["valor"];
            string valor2 = Request.QueryString["valor2"];
            string valor3 = Request.QueryString["valor3"];
            string valor4 = Request.QueryString["valor4"];

            Response.Write(valor1 + " " + valor2 + " " + valor3 + " " + valor4);
           
        }
    }
}