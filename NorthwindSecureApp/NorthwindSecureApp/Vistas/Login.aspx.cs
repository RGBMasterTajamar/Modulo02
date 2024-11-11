using NorthwindSecureApp.BusinsessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindSecureApp.Vistas
{
    public partial class Login : System.Web.UI.Page
    {
        private AuthenticationManager _authenticationManager;
        protected void Page_Load(object sender, EventArgs e)
        {
            _authenticationManager = new AuthenticationManager();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (_authenticationManager.ValidateUser(userName, password)) {
                Response.Redirect("Customers.aspx");
            }
            else
            {
                lblMessage.Text = "Credenciales incorrectas.  Intentelo de nuevo";
            }
        }
    }
}