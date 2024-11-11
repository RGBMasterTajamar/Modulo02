<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="AutenticacionConBD.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Bienvenido, <%: User.Identity.Name %>!!!</h2>
            <p>Esta pagina solo es accesible para usuarios autenticados</p>
            <asp:LinkButton ID="logoutButton" OnClick="logoutButton_Click" runat="server" Text="Cerrar Sesion"/>
        </div>
    </form>
</body>
</html>
