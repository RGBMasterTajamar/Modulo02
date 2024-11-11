<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NorthwindSecureApp.Vistas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Iniciar Sesion</h2>
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red" ></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" Placeholder="Usuario" ></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" PlaceHolder="Password"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login"/>
        </div>
    </form>
</body>
</html>
