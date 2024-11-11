<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjercicioPropuesto.aspx.cs" Inherits="Viernes2510App.EjercicioPropuesto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Add Product</h2>
        <div>
            Name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            Category:
            <asp:DropDownList 
                ID="ddlCategory"
                runat="server" 
                AutoPostBack="true" 
                OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
                <asp:ListItem Value="0" Text=""></asp:ListItem>
                <asp:ListItem Value="1">Confections</asp:ListItem>
                <asp:ListItem Value="2">Produce</asp:ListItem>
            </asp:DropDownList>
            <br />
            Supplier:
            <asp:DropDownList 
                ID="ddlSupplier" 
                runat="server" 
                AutoPostBack="true" 
                OnSelectedIndexChanged="ddlSupplier_SelectedIndexChanged">
                <asp:ListItem Value="0" Text=""></asp:ListItem>
                <asp:ListItem Value="1">New Orleans Cajun Delights</asp:ListItem>
                <asp:ListItem Value="2">Exotic Liquids</asp:ListItem>
            </asp:DropDownList>
            <br />
            Unit Price:
            <asp:TextBox ID="txtUnitPrice" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnUno" runat="server" Text="Save" OnClick="btnUno_Click"/>
    </form>
</body>
</html>
