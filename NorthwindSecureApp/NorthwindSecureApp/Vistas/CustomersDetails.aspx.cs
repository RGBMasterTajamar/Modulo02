using NorthwindSecureApp.BusinsessLogic;
using NorthwindSecureApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindSecureApp.Vistas
{
    public partial class CustomersDetails : System.Web.UI.Page
    {
        private CustomerManager _customManager;
        protected void Page_Load(object sender, EventArgs e)
        {
            _customManager = new CustomerManager();
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