<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Viernes2510App.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--<%--<asp:RadioButtonList 
                ID="rdbList1" 
                runat="server" 
                AutoPostBack="true" fuerza al cliente a mirar el codigo del server 
                OnSelectedIndexChanged="rdbList1_SelectedIndexChanged">
                <asp:ListItem Selected="True">SI</asp:ListItem>
                <asp:ListItem>NO</asp:ListItem>
            </asp:RadioButtonList>--%>

            <asp:DropDownList 
                ID="ddlClientes" 
                runat="server" 
                OnSelectedIndexChanged="ddlClientes_SelectedIndexChanged"
                AutoPostBack="true">
                
            </asp:DropDownList>
        </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
