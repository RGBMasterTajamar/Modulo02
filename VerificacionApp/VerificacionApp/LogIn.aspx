<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="VerificacionApp.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Login ID="LogingControl" runat="server" OnAuthenticate="LogingControl_Authenticate">

            </asp:Login>
        </div>
    </form>
</body>
</html>
