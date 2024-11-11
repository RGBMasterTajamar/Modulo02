<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BlogsDBFirst.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre Blog" />
                    <asp:BoundField DataField="URL" HeaderText="URL Blog" />
                    <asp:BoundField DataField="TituloPost" HeaderText="Titulo Post" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
