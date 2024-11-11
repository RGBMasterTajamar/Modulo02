using EjerciciosPropuestos2910_Raul_Gonzalez.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjerciciosPropuestos2910_Raul_Gonzalez
{
    public partial class Ejercicio5_7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;
            if (!IsPostBack)
            {
                using (NorthwindDataContext db = new NorthwindDataContext(stringConnection))
                {
                    var categories = db.Categories.ToList();
                    ddlCombobox.DataTextField = "CategoryName";
                    ddlCombobox.DataValueField = "CategoryID";
                    ddlCombobox.DataSource = categories;
                    ddlCombobox.DataBind();
                }
            }
        }

        protected void ddlCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryID = Convert.ToInt32(ddlCombobox.SelectedValue);
            string stringConnection = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;
            using (NorthwindDataContext db = new NorthwindDataContext(stringConnection))
            {
                var products = db.Products
                    .Where(prod => prod.CategoryID == categoryID).ToList();

                GridView1.DataSource = products;
                GridView1.DataBind();
            }
        }
    }
}