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
    public partial class Ejercicio5_9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;
            if (!IsPostBack)
            {
                using (NorthwindDataContext db = new NorthwindDataContext(stringConnection))
                {
                    // APARTADO 1: LISTADO DE ORDERID Y ORDERDATE DONDE LA REGION DE LOS CLIENTES SEA
                    // "WA"
                    var listOrderIdAndOrderDateForWa = db.Orders
                        .Where(or => or.CustomerID == or.Customers.CustomerID && or.Customers.Region == "WA")
                        .Select(or => new
                        {
                            OrderId = or.OrderID,
                            OrderDate = Convert.ToDateTime(or.OrderDate).ToShortDateString()
                        });
                    //GridView1.DataSource = listOrderIdAndOrderDateForWa;
                    //GridView1.DataBind();

                    // APARTADO 2: LISTADO DE CLIENTES Y NUMERO DE PEDIDOS REALIZADOS
                    var listCustomersWithCount = db.Customers
                        .Select(cu => new
                        {
                            CustomerID = cu.CustomerID,
                            NumOrders = cu.Orders.Count()
                        });
                    //GridView1.DataSource = listCustomersWithCount;
                    //GridView1.DataBind();

                    // APARTADO 3: LISTADO DE CLIENTES, PEDIDO Y FECHA PEDIDO PARA TODOS LOS PEDIDOS
                    // CON FECHA POSTERIOR A 01/01/1998
                    var date = new DateTime(1998, 1, 1);
                    var listCustomersAndOrdersAfterDate = db.Orders
                        .Where(o => o.CustomerID == o.Customers.CustomerID && o.OrderDate >= date)
                        .Select(o => new
                        {
                           CustomerID = o.Customers.CustomerID,
                           OrderID = o.OrderID,
                           OrderDate = Convert.ToDateTime(o.OrderDate).ToShortDateString()
                        });
                    //GridView1.DataSource = listCustomersAndOrdersAfterDate;
                    //GridView1.DataBind();

                    // APARTADO 4: LISTADO DE PEDIDOS DE CLIENTES DE WASHINGTON CON FECHA DE PEDIDO
                    // POSTERIOR A 01/01/1997
                    var date2 = new DateTime(1997, 1, 1);
                    var listOrderFromCustomersOfWaAfterDate = db.Orders
                        .Where(ord => ord.CustomerID == ord.Customers.CustomerID 
                        && ord.Customers.Region == "WA" && ord.OrderDate >= date2)
                        .Select(ord => new
                        {
                            OrderID = ord.OrderID,
                            OrderDate = Convert.ToDateTime(ord.OrderDate).ToShortDateString()
                        });
                    //GridView1.DataSource = listOrderFromCustomersOfWaAfterDate;
                    //GridView1.DataBind();

                    // APARTADO 5: LISTADO DE PRODUCTOS CON CATEGORIAS ORDENADOS POR PRODUCTO DESCENDENTE
                    var listProductsOrderedDesc = db.Products
                        .Where(prod => prod.CategoryID == prod.Categories.CategoryID)
                        .OrderByDescending(prod => prod.ProductName)
                        .Select(prod => new
                        {
                            ProductName = prod.ProductName,
                            CategoryName = prod.Categories.CategoryName
                        });
                    //GridView1.DataSource = listProductsOrderedDesc;
                    //GridView1.DataBind();

                    // APARTADO 6: POR CADA CATEGORIA EL PRODUCTO MAS CARO

                    var listCategoryMostExpensiveProduct = from prod in db.Products
                                                           group prod by prod.Categories.CategoryName into grupo
                                                           select new
                                                           {
                                                               CategoryName = grupo.Key,
                                                               MaxProductPrice = grupo.Max(prod => prod.UnitPrice),
                                                               
                                                           };
                    GridView1.DataSource = listCategoryMostExpensiveProduct;
                    GridView1.DataBind();

                    // APARTADO 7: POR CATEGORIA ENCONTRAR LA MEDIA DE LOS PRODUCTOS
                    var listCategoryAvgProductPrice = from prod in db.Products
                                                 group prod by prod.Categories.CategoryName into grupo
                                                 select new
                                                 {
                                                     CategoryName = grupo.Key,
                                                     AvgProductPrice = grupo.Average(prod => prod.UnitPrice)
                                                 };
                    //GridView1.DataSource = listCategoryAvgProductPrice;
                    //GridView1.DataBind();
                }
            }

        }

       
    }
}