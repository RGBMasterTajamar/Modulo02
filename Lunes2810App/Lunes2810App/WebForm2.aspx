<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Lunes2810App.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewCompleto" runat="server"></asp:GridView>
            Start: <asp:DropDownList ID="ddlStart" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStart_SelectedIndexChanged"></asp:DropDownList>
            End: <asp:DropDownList ID="ddlEnd" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlEnd_SelectedIndexChanged"></asp:DropDownList>
            <asp:GridView ID="GridViewPartial" runat="server"></asp:GridView>

            <%--<asp:TextBox ID="txtDato" runat="server"></asp:TextBox>--%>
        </div>
    </form>
</body>
</html>
