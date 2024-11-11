using NorthwindSecureApp.BusinsessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindSecureApp.Vistas
{
    public partial class Customers : System.Web.UI.Page
    {
        private CustomerManager _customerManager;
        private AuthenticationManager _authenticationManager;
        protected void Page_Load(object sender, EventArgs e)
        {
            _authenticationManager = new AuthenticationManager();

            // Verificar si el usuarion es Admin
            if (!_authenticationManager.IsUserInRole("Admin"))
            {
                // Redirigimos a una pagina de acceso denegado
                Response.Redirect("AccessDenied.aspx");
            }


            _customerManager = new CustomerManager();

            if (!IsPostBack)
            {
                LoadCustomers();
            }
        }

        private void LoadCustomers()
        {
            gvCustomers.DataSource = _customerManager.GetCustomers();
            gvCustomers.DataBind();
        }

        protected void gvCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // obtenemos el id del cliente seleccionado
            string customerId = gvCustomers.SelectedRow.Cells[0].Text;

            // Redirigimos al customers details pasando el customerId
            Response.Redirect($"CustomersDetails.aspx?CustomerID={customerId}");
        }
    }
}