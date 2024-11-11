using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Viernes2510App
{
    public partial class EjercicioPropuesto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUno_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string optCategory = ddlCategory.SelectedItem.Text;
            string optSupplier = ddlSupplier.SelectedItem.Text;
            string unitPrice = txtUnitPrice.Text;
            Response.Redirect(
                "WebForm3.aspx?valor=" + name +
                "&valor2=" + optCategory +
                "&valor3=" + optSupplier +
                "&valor4=" + unitPrice
            );

            // Server.Transfer("WebForm3.aspx");
        }

        protected void ddlSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}