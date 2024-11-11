using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CssGridApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string password = txtPassword.Text;

            Response.Redirect($"Process.aspx?nombre={nombre}&&correo={correo}");
        }
    }
}