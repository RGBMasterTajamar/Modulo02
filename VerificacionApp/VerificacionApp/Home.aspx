<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="VerificacionApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Pagina de Incio</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Bienvenido, <%: User.Identity.Name %>!!!</h2>
            <p>Esta pagina solo es accesible para usuarios autenticados</p>
            <asp:LinkButton ID="LogoutButton" runat="server" OnClick="LogoutButton_Click" Text="Cerrar Sesion" />
        </div>
    </form>
</body>
</html>
