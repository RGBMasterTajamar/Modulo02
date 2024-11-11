<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjercicioPropuesto.aspx.cs" Inherits="Ejercicio_Propuesto_2_6_Raul_Gonzalez.EjercicioPropuesto" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio Propuesto</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <h1 class="mb-4">Gestión de Contactos</h1>
            <div class="btn-group" role="group" aria-label="Botones de contacto">
                <asp:Button ID="btnUno" runat="server" OnClick="btnUno_Click" Text="Ordenar por apellido" CssClass="btn btn-primary"/>
                <asp:Button ID="btnDos" runat="server" OnClick="btnDos_Click" Text="Comienza por A" CssClass="btn btn-secondary"/>
                <asp:Button ID="btnTres" runat="server" OnClick="btnTres_Click" Text="Teléfono" CssClass="btn btn-success"/>
                <asp:Button ID="btnCuatro" runat="server" OnClick="btnCuatro_Click" Text="Contactos Alabama" CssClass="btn btn-warning"/>
            </div>
        </div>
    </form>
</body>
</html>
