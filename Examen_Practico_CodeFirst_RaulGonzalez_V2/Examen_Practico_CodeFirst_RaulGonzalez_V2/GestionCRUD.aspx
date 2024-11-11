<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionCRUD.aspx.cs" Inherits="Examen_Practico_CodeFirst_RaulGonzalez_V2.GestionCRUD" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Gestión de Accidentes y Multas</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEJtJRU5/5o9P2F2T4pM6PjPT6sdzM1Ej4ql4weI8j6vShwQFZ6vvFggA2scA" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-pzjw8f+ua7Kw1TIq0BqX8ITTJl2X1hXB0Dnyb3qB7gk6pc1Xljy2xYo/uj9p6EYd" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
        <!-- Contenedor principal -->
        <div class="container mt-5">
            <h2 class="mb-4 text-center">Gestión de Accidentes y Multas</h2>

            <!-- Sección de Accidentes -->
            <div class="mb-5">
                <h3>Accidentes</h3>
                <div class="d-flex justify-content-between mb-3">
                    <asp:Button runat="server" ID="btnInsertarAccidente" Text="Insertar Accidente" OnClick="btnInsertarAccidente_Click" CssClass="btn btn-primary" />
                    <asp:Button runat="server" ID="btnBorrarAccidente" Text="Eliminar Accidente" OnClick="btnBorrarAccidente_Click" CssClass="btn btn-danger" />
                    <asp:Button runat="server" ID="btnEditarAccidente" Text="Editar Accidente" OnClick="btnEditarAccidente_Click" CssClass="btn btn-warning" />
                    <asp:Button runat="server" ID="btnMostrarAccidente" Text="Mostrar Accidente" OnClick="btnMostrarAccidente_Click" CssClass="btn btn-info" />
                </div>
                <br />
                <asp:GridView runat="server" ID="gvAccidentes" CssClass="table table-striped table-bordered"></asp:GridView>
            </div>

            <!-- Sección de Multas -->
            <div>
                <h3>Multas</h3>
                <div class="d-flex justify-content-between mb-3">
                    <asp:Button runat="server" ID="btnInsertarMulta" Text="Insertar Multa" OnClick="btnInsertarMulta_Click" CssClass="btn btn-primary" />
                    <asp:Button runat="server" ID="btnBorrarMulta" Text="Eliminar Multa" OnClick="btnBorrarMulta_Click" CssClass="btn btn-danger" />
                    <asp:Button runat="server" ID="btnEditarMulta" Text="Editar Multa" OnClick="btnEditarMulta_Click" CssClass="btn btn-warning" />
                    <asp:Button runat="server" ID="btnMostrarMulta" Text="Mostrar Multa" OnClick="btnMostrarMulta_Click" CssClass="btn btn-info" />
                </div>
                <br />
                <asp:GridView runat="server" ID="gvMultas" CssClass="table table-striped table-bordered"></asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
