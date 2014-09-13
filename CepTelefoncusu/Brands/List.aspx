<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CepTelefoncusu.Brands.List" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cep Telefoncu Hilmi</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <ul>
        <asp:Repeater ID="rptBrand" runat="server">
        <ItemTemplate>
            <li> <%#Eval("BrandText") %></li>
        </ItemTemplate>
        </asp:Repeater>
        <li><a href="/Brands/Add.aspx">Marka Ekle</a></li>
    </ul>
    </div>
    </form>
</body>
</html>
