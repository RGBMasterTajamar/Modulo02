using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Viernes2510App.Models;

namespace Viernes2510App
{
    public partial class FuncionesDeLenguaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Metodos extensores:
            // deben estar contenidos en clases estaticas
            // son metodos estaticos
            // Indicar la clase a la que extienden se referencia con this
            Persona persona = new Persona("javier", "Vazquez");
            string user = persona.ObtenerNombreCompleto();

            string fecha = "12/05/1998";
            DateTime fechaDate = StringExtensions.ToDate(fecha);

            List<int> lista1 = new List<int>();
            lista1.Add(1);
            lista1.Add(2);
            lista1.Add(3);
            lista1.Add(4);
            lista1.Add(5);
            lista1.Imprimir();



            // Inicializadores de objetos
            // agiliza la cracion de codigo para iniciar un objeto
            // Generalizar a colecciones
            Persona persona1 = new Persona {Apellido= "Gomez", Nombre="Juan" };

            List<Persona> amigos = new List<Persona>
            {
                new Persona {Apellido= "Gomez", Nombre="Juan" },
                new Persona {Apellido= "Perez", Nombre="Miguel" }
            };

            // tipos anoninmos
            var person = new { Apellido = "Suarez", Nombre = "Ana" };

            // LINQ
            string[] words = { "hello", "wonderful", "linq", "word", "excel" };

            foreach (string word in words)
            {
                if (word.Length <= 5)
                {
                    Response.Write(word);
                }
            }

            // LINQ to Object --> Linq toSQL
            var palabrasCortas =
                from word in words
                where word.Length <= 5
                select word;


            int[] fiboNumbers = new int[] { 0, 1, 2, 3, 4, 5, 6, };
            var data = (from n in fiboNumbers where n%2==0 select n).ToList();

            string[] tools = { "Tablesaw", "Bandsaw", "Planer", "Jointer", "Brill", "Bander" };

            var tool = from t in tools select t.ToUpper();

            string aString = "ABCDE99F-J74-12-89A";
            List<char> stringQuery = (from a in aString where char.IsDigit(a) select a).ToList();

            foreach (char a in stringQuery)
            {
                Response.Write(a + " ");
                Response.Write("<br /> ");
            };

            IEnumerable<char> stringQuery2 = (aString.TakeWhile(a => a != '-')).ToList();



            List<int> lista2 = new List<int>();
            lista2.Add(1);
            lista2.Add(2);
            lista2.Add(3);
            lista2.Add(3);
            lista2.Add(5);
            lista2.Add(4);

            var data3 = (from n in lista2 where n == 3 select n);
            var data4= (from n in lista2 where n == 3 select n).FirstOrDefault();



            string[] Birds = { "Indigo Bunting", "Rose Breasted Grosbeak", "Robin", "House Finch", "Gold Finch", "Ruby Throated Hummingbird", "Rufous Hummingbird", "Downy Woodpecker" };
            var data5 = from b in Birds where b.StartsWith("R") select b;

            var listaOrdenada = from b in Birds orderby b ascending select b;


            var datos = PartesMotor.CrearPartes();

            var lista = from p in datos orderby p.Id ascending select p;
            var listaLambda = datos.OrderByDescending(p => p.Id).Select(p => p);

            var partes = from p in datos where p.Nombre.StartsWith("C") select p;
            var partesLambda = datos.Where(p=>p.Nombre.StartsWith("C")).Select(p => p);

            var parteNombre = (from p in datos where p.Id.Equals(5) select p.Nombre).FirstOrDefault();
            var parteNombreLambda = datos.Where(p=>p.Id.Equals(5)).Select(p=>p).FirstOrDefault();


        }
    }
}