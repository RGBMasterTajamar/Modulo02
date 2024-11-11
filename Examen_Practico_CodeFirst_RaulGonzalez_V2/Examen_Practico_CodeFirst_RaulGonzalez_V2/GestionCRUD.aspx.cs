using Examen_Practico_CodeFirst_RaulGonzalez_V2.DBContext;
using Examen_Practico_CodeFirst_RaulGonzalez_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen_Practico_CodeFirst_RaulGonzalez_V2
{
    public partial class GestionCRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnInsertarAccidente_Click(object sender, EventArgs e)
        {
            using (var context = new AgenciaSegurosContext())
            {
                var accidente = new Accidente()
                {
                    Date = DateTime.Now,
                    Hour = DateTime.Now,
                    Location = "Mi cabeza"
                };
                if (accidente != null)
                {
                    context.Accidentes.Add(accidente);
                    context.SaveChanges();
                }
                
            }
        }

        protected void btnBorrarAccidente_Click(object sender, EventArgs e)
        {
            using (var context = new AgenciaSegurosContext())
            {
                var accidente = context.Accidentes.Where(a => a.AccidenteID == 5).FirstOrDefault();
                
                if (accidente != null)
                {
                    context.Accidentes.Remove(accidente);
                    context.SaveChanges();
                }
                else
                {
                    Response.Write("Error al eliminar");
                }

            }
        }

        protected void btnEditarAccidente_Click(object sender, EventArgs e)
        {

        }
        protected void btnMostrarAccidente_Click(object sender, EventArgs e)
        {
            using(var context = new AgenciaSegurosContext())
            {
                var query = context.Accidentes.Select(a => new
                {
                    Fecha = a.Date,
                    Hora = a.Hour,
                    Lugar = a.Location
                }).ToList();

                gvAccidentes.DataSource = query;
                gvAccidentes.DataBind();
            }
        }

        protected void btnInsertarMulta_Click(object sender, EventArgs e)
        {
            using (var context = new AgenciaSegurosContext())
            {
                var multa = new Multa()
                {
                    Date = DateTime.Now,
                    Hour = DateTime.Now,
                    Location = "Mi cabeza",
                    Amount = 150,
                    VehiculoID = 3
                };
                if (multa != null)
                {
                    context.Multas.Add(multa);
                    context.SaveChanges();
                }

            }
        }

        protected void btnBorrarMulta_Click(object sender, EventArgs e)
        {
            using (var context = new AgenciaSegurosContext())
            {
                var multa = context.Multas.Where(m => m.MultaID == 7).FirstOrDefault();

                if (multa != null)
                {
                    context.Multas.Remove(multa);
                    context.SaveChanges();
                }
                else
                {
                    Response.Write("Error al eliminar");
                }

            }
        }

        protected void btnEditarMulta_Click(object sender, EventArgs e)
        {

        }

        protected void btnMostrarMulta_Click(object sender, EventArgs e)
        {
            using (var context = new AgenciaSegurosContext())
            {
                var queryMultas = context.Multas.Select(m => new
                {
                    Fecha = m.Date,
                    Hora = m.Hour,
                    Lugar = m.Location,
                    Importe = m.Amount,
                    IDVehiculo = m.VehiculoID,
                    IDPersona = m.Vehiculo.PersonaID
                }).ToList();
                

                gvMultas.DataSource = queryMultas;
                gvMultas.DataBind();
            }
        }

        
    }
}