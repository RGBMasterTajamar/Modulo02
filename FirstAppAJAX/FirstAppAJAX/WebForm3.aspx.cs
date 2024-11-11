﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstAppAJAX
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private static int Sumar (int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        private static int Restar(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        private static int Multiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        private static decimal Dividir(decimal valor1, decimal valor2)
        {
            return (valor1 / valor2);
        }

        [System.Web.Services.WebMethod]
        public static int GetSuma(string valor1, string valor2)
        {
            var dato1 = Convert.ToInt32(valor1);
            var dato2 = Convert.ToInt32(valor2);
            int resultado = Sumar(dato1,dato2);
            return resultado;
        }


        [System.Web.Services.WebMethod]
        public static int GetResta(string valor1, string valor2)
        {
            var dato1 = Convert.ToInt32(valor1);
            var dato2 = Convert.ToInt32(valor2);
            int resultado = Restar(dato1, dato2);
            return resultado;
        }

        [System.Web.Services.WebMethod]
        public static int GetMultiplica(string valor1, string valor2)
        {
            var dato1 = Convert.ToInt32(valor1);
            var dato2 = Convert.ToInt32(valor2);
            int resultado = Multiplicar(dato1, dato2);
            return resultado;
        }

        [System.Web.Services.WebMethod]
        public static decimal GetDivide(string valor1, string valor2)
        {
            var dato1 = Convert.ToDecimal(valor1);
            var dato2 = Convert.ToDecimal(valor2);
            decimal resultado = Dividir(dato1, dato2);
           
            return resultado;
        }
    }
}