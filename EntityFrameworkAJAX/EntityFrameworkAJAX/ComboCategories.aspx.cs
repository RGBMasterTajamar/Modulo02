using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkAJAX
{
    public partial class ComboCategories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<object> GetCategory()
        {
            using(var context = new NORTHWNDEntities())
            {
                var list = context.Categories.Select(c => new
                {
                    c.CategoryID,
                    c.CategoryName
                }).ToList<object>();

                return list;
            }
        }


        [WebMethod]
        public static List<object> GetProductsByCategory(int categoryId)
        {
            using (var context = new NORTHWNDEntities())
            {
                var products = context.Products.Where(p => p.CategoryID == categoryId).Select(p => new
                {
                    p.ProductID,
                    p.ProductName,
                    p.UnitPrice,
                    p.UnitsInStock
                }).ToList<object>();

                return products;
            }
        }
    }
}