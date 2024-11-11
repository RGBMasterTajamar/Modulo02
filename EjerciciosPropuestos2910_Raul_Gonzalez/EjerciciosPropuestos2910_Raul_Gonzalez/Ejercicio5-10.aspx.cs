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
    public partial class Ejercicio5_10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void InsertShipper(string shipperName, string shipperPhone)
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;
            using (NorthwindDataContext db = new NorthwindDataContext(stringConnection))
            {
                var newShipper = new Shippers { CompanyName = shipperName, Phone = shipperPhone };
                db.Shippers.InsertOnSubmit(newShipper);
                db.SubmitChanges();
            }
        }

        public void DeleteShipper(int shipperID)
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;
            using (NorthwindDataContext db = new NorthwindDataContext(stringConnection))
            {
                var shipperToDelete = db.Shippers.SingleOrDefault(s => s.ShipperID == shipperID);
                if (shipperToDelete != null)
                {
                    db.Shippers.DeleteOnSubmit(shipperToDelete);
                    db.SubmitChanges();
                }
                else
                {
                    Response.Write("No se ha encontrado el registro deseado.");
                }
            }
        }
        public void UpdateShipper(int shipperID, string shipperName, string shipperPhone)
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;
            using (NorthwindDataContext db = new NorthwindDataContext(stringConnection))
            {
                var shipperToUpdate = db.Shippers.SingleOrDefault(s => s.ShipperID == shipperID);
                if (shipperToUpdate != null) 
                {
                    shipperToUpdate.CompanyName = shipperName;
                    shipperToUpdate.Phone = shipperPhone;
                    db.SubmitChanges();
                }
            }
        }

        protected void btnUno_Click(object sender, EventArgs e)
        {
            InsertShipper("Shipper1", "123-456-7890");
        }

        protected void btnDos_Click(object sender, EventArgs e)
        {
            DeleteShipper(5);
        }

        protected void btnTres_Click(object sender, EventArgs e)
        {
            UpdateShipper(8, "ShipperUpdated", "123-456-7890");
        }
    }
}