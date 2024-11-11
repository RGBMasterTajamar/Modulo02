using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutenticacionConBD
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogingControl_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string userName = LoginControl.UserName;
            string password = LoginControl.Password;


            if (ValidateUser(userName, password, out string role)) {
                // Crear una cookie de autenticacion.
                FormsAuthentication.SetAuthCookie(userName, true);
                // GUARDAR EL ROL DE USUARIO
                Response.Cookies["UserRole"].Value = role;
                Response.Cookies["UserRole"].Expires = DateTime.Now.AddMinutes(30);

                Response.Redirect("~/AdminPage.aspx");
            }
        }

        private bool ValidateUser(string userName, string password, out string role)
        {
            role = string.Empty;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                // abrimos la conexion
                connection.Open();
                string query = "SELECT PasswordHash, Role FROM Usuarios WHERE UserName=@UserName";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserName", userName);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) 
                {
                    // Obtenemos el password y el role
                    string storedPasswordHash = reader["PasswordHash"].ToString();
                    role = reader["Role"].ToString();

                    // Comparar la contraseña ingresada con la almacenada
                    if (VerficarPassword(password, storedPasswordHash))
                    {
                        return true;
                    }
                    else {
                        return false;
                    }
                }

            }
            return false;
        }

        private bool VerficarPassword(string password, string storedPasswordHash)
        {
            return password == storedPasswordHash;

            //librerias de encriptacion
            // SHA256
            // BCrypt
        }
    }
}