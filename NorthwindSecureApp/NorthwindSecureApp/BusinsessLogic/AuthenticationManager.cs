using NorthwindSecureApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace NorthwindSecureApp.BusinsessLogic
{
    public class AuthenticationManager
    {
        string connectionQuery = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;
        private NorthwindDataContext _context;
        public AuthenticationManager() 
        {
            _context = new NorthwindDataContext(connectionQuery);
        }

        public bool ValidateUser(string username, string password)
        {
            var user = _context.Users
                .Where(u => u.Username == username && u.Password == password)
                .FirstOrDefault();
            if (user != null)
            {
                // Crear la cookie de autenticacion
                FormsAuthentication.SetAuthCookie(username, false);

                // Almacenar el rol del usuario en la sesion
                System.Web.HttpContext.Current.Session["UserRole"] = user.Role;

                return true;
            }
            return false;
        }

        public void Logout()
        {
            FormsAuthentication.SignOut();
            System.Web.HttpContext.Current.Session.Clear();
        }

        public bool IsUserInRole(string role)
        {
            return System.Web.HttpContext.Current.Session["UserRole"]?.ToString() == role; 
        }
    }
}