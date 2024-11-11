<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lunes2810App2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:TextBox ID="txtData" runat="server"></asp:TextBox>

            <asp:DropDownList ID="ddlEmpleados" runat="server" AppendDataBoundItems="true">
                <asp:ListItem Value="0" Text="Choose an employee" Selected="True"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
