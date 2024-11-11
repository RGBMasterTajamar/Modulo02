<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="NorthwindSecureApp.Vistas.Customers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LoginStatus ID="LoginStatus1" runat="server" LogoutAction="Redirect" LogoutPageUrl="~/Vistas/Login.aspx"/>
            <h2>Lista de clientes</h2>
            <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gvCustomers_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="CustomerID" HeaderText="ID" />
                    <asp:BoundField DataField="CompanyName" HeaderText="Company Name" />
                    <asp:BoundField DataField="ContactName" HeaderText="Contact Name" />
                    <asp:ButtonField ButtonType="Button" Text="Ver Detalles" CommandName="Select" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
