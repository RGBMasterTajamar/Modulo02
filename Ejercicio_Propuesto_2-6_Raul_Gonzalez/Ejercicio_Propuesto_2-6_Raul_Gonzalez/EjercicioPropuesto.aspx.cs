using Ejercicio_Propuesto_2_6_Raul_Gonzalez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio_Propuesto_2_6_Raul_Gonzalez
{
    public partial class EjercicioPropuesto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnUno_Click(object sender, EventArgs e)
        {
            // Muestra los contactos ordenados por apellido ascendente
            List<Contact> listOfContacts = Contact.CrearLista();

            //var contact = from c in contacts orderby c.LastName ascending select c;

            var contactLambda = listOfContacts.OrderBy(c => c.LastName);

            foreach (Contact c in contactLambda)
            {
                Response.Write(c.FirstName + " " + c.LastName + "</br>");
            }

        }

        protected void btnDos_Click(object sender, EventArgs e)
        {
            // Muestra todos los contactos que empiezen por la A
            List<Contact> listOfContacts = Contact.CrearLista();

            //var contact2 = from c in listOfContacts where c.FirstName.StartsWith("A") select c;

            var contactLambda2 = listOfContacts.Where(c => c.FirstName.StartsWith("A"))
                .Select(c => c.FirstName + " " + c.LastName + " " + c.Phone);

            foreach (string c in contactLambda2)
            {
                Response.Write($"{c} </br>");
            }

        }

        protected void btnTres_Click(object sender, EventArgs e)
        {
            // Muestra el telefono de contacto cuyo email es igual a alguien@gmail.com
            List<Contact> listOfContacts = Contact.CrearLista();
            
            var telefonoContactos = (from t in listOfContacts 
                                     where t.Email == "alguien@gmail.com" 
                                     select t).FirstOrDefault();

            Response.Write(telefonoContactos.Phone.ToString());
        }

        protected void btnCuatro_Click(object sender, EventArgs e)
        {
            // Muestra los contactos del estado de Alabama
            List<Contact> listOfContacts = Contact.CrearLista();

            var contactsOfAlabama = from c in listOfContacts
                                    where c.State.Equals("Alabama") && c.Phone.StartsWith("(9")
                                    select c;

            foreach (Contact c in contactsOfAlabama)
            {
                Response.Write(c.FirstName + " " + c.LastName + " " + c.Phone + "</br>");
            }
            
        }

      
    }
}