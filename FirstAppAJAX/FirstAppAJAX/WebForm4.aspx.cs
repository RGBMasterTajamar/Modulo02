using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstAppAJAX
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string GetUserInfo(int userId)
        {
            if (userId == 1) 
            {
                return "Usuario: Javier Perez, Email:jperez@gmail.com, Edad: 30";
            }
            else
            {
                return "Usuario no encontrado";
            }
        }
    }
}