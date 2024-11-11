<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Process.aspx.cs" Inherits="CssGridApp.Process" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    
    <form id="form1" runat="server" class="container mt-5">
        <div class="card p-4 shadow">
            <h3 class="text-center">Procesamiento del Registro</h3>
            <p class="text-center">
                Te has registrado <b><% =Request.QueryString["nombre"] %></b><br />
                Te hemos enviado un correo de confirmacion <b><% =Request.QueryString["correo"] %></b>
            </p>

        </div>
    </form>
</body>
</html>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"></script>