using Lunes2810App2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lunes2810App2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadena = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;
            if (!IsPostBack)
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext(cadena))
                {
                    // EJERCICIO 5.1 - SACAR EL NOMBRE DE LA COMPAÑIA PARA TODOS LOS CLIENTES DE LA CIUDAD
                    // DE SAO PAULO
                    //var query = from customer in db.Customers
                    //            where customer.City == "Sao Paulo"
                    //            select customer.CompanyName;
                    //GridView1.DataSource = query.ToList();

                    // USANDO EXPRESION LAMBDA
                    //var queryLambda = db.Customers.Where(q => q.City == "Sao Paulo").Select(q => q.CompanyName);
                    //GridView1.DataSource = queryLambda.ToList();


                    // EJERCICIO 5.2 - MOSTRAR NOMBRE Y APELLIDO CONCATENADO Y LA FECHA DE NACIMIENTO
                    // ORDENADO POR EDAD DE TODOS LOS EMPLEADOS DE LONDRES
                    //var query = from employee in db.Employees
                    //            where employee.City == "London"
                    //            orderby employee.BirthDate
                    //            select new
                    //            {
                    //                FullName = employee.FirstName + " " + employee.LastName,
                    //                DateOfBirth = Convert.ToDateTime(employee.BirthDate).ToShortDateString()
                    //            };
                    //GridView1.DataSource = query.ToList();


                    // USANDO EXPRESION LAMBDA
                    //var queryLambda = db.Employees
                    //    .Where(emp => emp.City == "London")
                    //    .OrderBy(emp => emp.BirthDate)
                    //    .Select(emp => new
                    //    {
                    //        FullName = emp.FirstName + " " + emp.LastName,
                    //        DateOfBirth = Convert.ToDateTime(emp.BirthDate).ToShortDateString()
                    //    });
                    //GridView1.DataSource = queryLambda.ToList();


                    // EJERCICIO 5.3 - MOSTRAR NOMBRE DEL PRODUCTO Y LAS UNIDADES EN STOCK DE LOS PRODUCTOS
                    // CON UN PRECIO SUPERIOR A 50€

                    //var query = from product in db.Products
                    //            where product.UnitPrice > 50
                    //            select new
                    //            {
                    //                ProductName = product.ProductName,
                    //                UnitInStock = product.UnitsInStock
                    //            };

                    //GridView1.DataSource = query.ToList();

                    // USANDO EXPRESION LAMBDA
                    //var queryLambda = db.Products
                    //    .Where(prod => prod.UnitPrice > 50)
                    //    .Select(prod => new
                    //    {
                    //        ProductName = prod.ProductName,
                    //        UnitInStock = prod.UnitsInStock
                    //    });
                    //GridView1.DataSource = queryLambda.ToList();
                    //GridView1.DataBind();


                    //var data = db.Employees.ToList();
                    //ddlEmpleados.DataTextField = "LastName";
                    //ddlEmpleados.DataValueField = "EmployeeID";
                    //ddlEmpleados.DataSource = data;
                    //ddlEmpleados.DataBind();


                    //var data = from c in db.Customers
                    //           where c.Country == "Spain"
                    //           orderby c.CompanyName
                    //           select new
                    //           {
                    //               c.CustomerID,
                    //               c.ContactName,
                    //               c.Country,
                    //               orderCount = c.Orders.Count()
                    //           };

                    // Uso de selectmany que es un join
                    //var data = (from c in db.Customers
                    //            where c.Country == "Spain"
                    //            select c).SelectMany(c => c.Orders);


                    // EJEMPLOS DE SELECT MANY 
                    // NAVEGACION DE LAS TABLAS
                    //var query = db.Orders
                    //    .OrderBy(p => p.OrderDate)
                    //    .ThenBy(p => p.Employees.LastName)
                    //    .Select(p => new
                    //    {
                    //        Employee = p.Employees.FirstName + " " + p.Employees.LastName,
                    //        OrderDate = p.OrderDate

                    //    });


                    //var query = db.Orders
                    //    .SelectMany(p => p.Order_Details)
                    //    .Where(p => p.Orders.Employees.FirstName == "Michael" && p.Orders.Employees.LastName == "Suyama")
                    //    .Select(p => p.UnitPrice * p.Quantity).Average().ToString("#.##");

                    //txtData.Text = query;



                    //GridView1.DataSource = query;
                    //GridView1.DataBind();
                }
            }
        }
    }
}