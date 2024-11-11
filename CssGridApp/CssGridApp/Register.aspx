<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CssGridApp.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .form-container{
            display:grid;
            grid-template-columns:1fr;
            gap:1rem;
            max-width:400px;
            margin: 2rem auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="form-container card p-4 shadow">
            <h3 class="text-center mb-4">Registro de usuario</h3>
            <div class="form-group">
                <label for="txtNombre" class="form-label">Nombre:</label>
                <asp:TextBox  ID="txtNombre" runat="server" CssClass="form-control" Placeholder="Ingresa tu nombre"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCorreo" class="form-label">Correo:</label>
                <asp:TextBox TextMode="Email" ID="txtCorreo" runat="server" CssClass="form-control" Placeholder="Ingresa tu correo"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPassword" class="form-label">Password:</label>
                <asp:TextBox TextMode="Password" ID="txtPassword" runat="server" CssClass="form-control" Placeholder="Ingresa tu contraseña"></asp:TextBox>
            </div>
            <div class="d-grid gap-2">
                <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary" Text="Regisgtrar" OnClick="btnRegistrar_Click" />
            </div>
        </div>
    </form>
</body>
</html>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"></script>