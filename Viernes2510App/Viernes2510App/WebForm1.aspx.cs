using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Viernes2510App.Models;

namespace Viernes2510App
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // objetos RESPONSE, SERVER 
        // Response.Write(""),
        // Response.Redirect("URL"),
        // Response.ContentType("text/html")
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
                ddlClientes.DataValueField = "Id";
                ddlClientes.DataTextField = "FullName";
                ddlClientes.DataSource = Clientes.CrearClientes();
                ddlClientes.DataBind();
            }
        }

        //protected void rdbList1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Label1.Text = "Has seleccionado: " + rdbList1.SelectedItem.Text;
        //}

        //protected void ddlFrutas_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Label1.Text = ddlFrutas.SelectedItem.Text; // Valor por delante
        //    Label1.Text = ddlFrutas.SelectedItem.Value.ToString();
        //    Label1.Text = ddlFrutas.SelectedItem.Value; // Valor por detras
        //}

        protected void ddlClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "Has seleccionado: " + ddlClientes.SelectedItem.Text;
        }
    }
}