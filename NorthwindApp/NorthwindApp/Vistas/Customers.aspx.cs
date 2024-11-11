using NorthwindApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindApp.Vistas
{
    public partial class Customers : System.Web.UI.Page
    {
        private CustomersManager _customerManager;
        protected void Page_Load(object sender, EventArgs e)
        {
            _customerManager = new CustomersManager();
            
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

        protected void gvCustomers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string customerId = gvCustomers.DataKeys[e.RowIndex].Value.ToString();

            // Realizar el borrado en base de datos
        }

        protected void gvCustomers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string customerId = gvCustomers.DataKeys[e.NewEditIndex].Value.ToString();

            // Realizar el editado del registro en base de datos
        }
    }
}