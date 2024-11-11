using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VerificacionApp
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogingControl_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string userName = LogingControl.UserName;
            string password = LogingControl.Password;

            if (userName == "admin" || password == "password123") 
            {
                FormsAuthentication.SetAuthCookie(userName, true);
                // REDIRIGIR AL HOME
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                LogingControl.FailureText = "Nombre de usuario o contraseña incorrectos";
            }
        }
    }
}