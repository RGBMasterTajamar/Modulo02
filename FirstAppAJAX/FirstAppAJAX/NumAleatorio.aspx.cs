using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstAppAJAX
{
    public partial class NumAleatorio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [WebMethod]
        public static int GetNum()
        {
            Random random = new Random();
            var numAleatorio = random.Next(1, 100);
            return numAleatorio;
        }
    }
}