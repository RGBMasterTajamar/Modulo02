﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstAppAJAX
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre = Request.Form["nombre"];
            string apellido = Request.Form["apellido"];

            string nombreCompleto = $"{nombre} {apellido}";
            Response.Write(nombreCompleto);
        }
    }
}