using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstAppAJAX
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int dato = Convert.ToInt32(Request.Form["dato"]);
            int valor = Factorial(dato);
            Response.Write(valor);

        }

        private int Factorial(int number)
        {
            if (number < 2)
            {
                return 1;
            }
            else
            {
                return number*Factorial(number - 1);
            }
        }
    }
}