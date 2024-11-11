<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5-7.aspx.cs" Inherits="EjerciciosPropuestos2910_Raul_Gonzalez.Ejercicio5_7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlCombobox" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="ddlCombobox_SelectedIndexChanged">
                 <asp:ListItem Value="0" Text="Choose a product category" Selected="True"></asp:ListItem>
            </asp:DropDownList>

            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
