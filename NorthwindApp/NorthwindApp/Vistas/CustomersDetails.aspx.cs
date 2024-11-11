using NorthwindApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindApp.Vistas
{
    public partial class CustomersDetails : System.Web.UI.Page
    {
        private CustomersManager _customManager;
        protected void Page_Load(object sender, EventArgs e)
        {
            _customManager = new CustomersManager();
            if (!IsPostBack)
            {
                string customerId = Request.QueryString["CustomerID"];
                if (!string.IsNullOrEmpty(customerId))
                {
                    LoadCustomerDetails(customerId);
                }
            }
        }

        private void LoadCustomerDetails(string customerId)
        {
            var customer = _customManager.GetCustomerByID(customerId);
            if (customer != null) 
            {
                lblCustomerInfo.Text =
                    $"<b>{customer.CompanyName}</b><br/>" +
                    $"Contacto: {customer.ContactName} <br/>" +
                    $"Telefono: {customer.Phone} <br/>" +
                    $"Pais: {customer.Country}";
                
                gvOrders.DataSource = _customManager.GetOrdersByCustomerId(customerId);
                gvOrders.DataBind();
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customers.aspx");
        }
    }
}