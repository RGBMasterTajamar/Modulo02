<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComboCategories.aspx.cs" Inherits="EntityFrameworkAJAX.ComboCategories" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Combo Categories</title>
    <script src="Scripts/jquery-3.7.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="btnLoadCategories" type="button" value="Cargar combo" />
            <select id="ddlCategory"></select>
            
        </div>
        <div>
            <table id="productsTable" border="1">
                <thead>
                    <tr>
                        <th>Product ID</th>
                        <th>Product Name</th>
                        <th>Product Price</th>
                        <th>Units in stock</th>
                    </tr>
                </thead>
                <tbody>

                </tbody>
            </table>
        </div>
    </form>
</body>
</html>

<script>
    $(function () {
        $("#btnLoadCategories").on("click", function () {
            $.ajax({
                type: "POST",
                url: "ComboCategories.aspx/GetCategory",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var options = '<option value="">Elige la categoria</option>';
                    $.each(response.d, function (i, category) {
                        options += '<option value=' + category.CategoryID + '>' + category.CategoryName + '</option>';
                    })
                    $("#ddlCategory").html(options);
                },
                error: function () {
                    alert('Algo ha ido mal');
                }
            });
        });

    });

    $(function () {
        $("#ddlCategory").change(function () {
            $.ajax({
                type: "POST",
                url: "ComboCategories.aspx/GetProductsByCategory",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var rows = '';
                    $.each(response.d, function (i, product) {
                        rows += '<tr>';
                        rows += '<td>' + product.ProductID + '</td>';
                        rows += '<td>' + product.ProductName + '</td>';
                        rows += '<td>' + product.UnitPrice + '</td>';
                        rows += '<td>' + product.UnitsIntStock + '</td>';
                        rows += '</tr>';
                    });
                    $("#productsTable tbody").html(rows);
                },
                error: function () {
                    alert("Se produjo un error");
                }
            });
        });
    });

</script>
