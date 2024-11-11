<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="NorthwindApp.Vistas.Customers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView 
                ID="gvCustomers" 
                runat="server" 
                AutoGenerateColumns="false" 
                OnSelectedIndexChanged="gvCustomers_SelectedIndexChanged"
                DataKeyNames="CustomerID"
                OnRowDeleting="gvCustomers_RowDeleting"
                OnRowEditing="gvCustomers_RowEditing" >
                <Columns>
                    <asp:BoundField DataField="CustomerID" HeaderText="ID" />
                    <asp:BoundField DataField="CompanyName" HeaderText="Company Name" />
                    <asp:BoundField DataField="ContactName" HeaderText="Contact Name" />
                    <%--<asp:ButtonField ButtonType="Button" Text="Ver Detalles" CommandName="Select" />--%>
                    <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" ShowSelectButton="true" ButtonType="Button" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
