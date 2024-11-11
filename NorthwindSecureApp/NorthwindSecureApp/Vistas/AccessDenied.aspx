<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccessDenied.aspx.cs" Inherits="NorthwindSecureApp.Vistas.AccessDenied" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Acceso denegado</h2>
            <p>No tienes permiso para acceder a esta pagina</p>
            <a href="Login.aspx">Volver al inicio de sesion</a>
        </div>
    </form>
</body>
</html>
