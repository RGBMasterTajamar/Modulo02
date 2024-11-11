<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomersDetails.aspx.cs" Inherits="NorthwindApp.Vistas.CustomersDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Detalles de cliente</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Detalles de pedidos</h2>
            <asp:Label ID="lblCustomerInfo" runat="server" Text=""></asp:Label>
            <h3>Pedidos</h3>
            <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="OrderID" HeaderText="ID Pedido" />
                    <asp:BoundField DataField="OrderDate" HeaderText="Fecha Pedido" />
                    <asp:BoundField DataField="ShipCity" HeaderText="Ciudad de envio" />
                    <asp:BoundField DataField="ShipCountry" HeaderText="Pais de envio" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="btnBack" runat="server" Text="Volver" OnClick="btnBack_Click" />
        </div>
    </form>
</body>
</html>
