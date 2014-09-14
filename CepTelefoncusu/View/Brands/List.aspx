<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CepTelefoncusu.Brands.List" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cep Telefoncu Hilmi</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th>Id</th>
                    <th>Markası</th>
                    <th colspan="2">İşlemler</th>
                </tr>

                <asp:Repeater ID="rptBrand" runat="server">
                <ItemTemplate>
                    <tr> 
                        <td><%# Eval("Id") %></td>
                        <td><%# Eval("BrandText") %></td>
                        <td><a href="Edit.aspx?Id=<%# Eval("Id") %>">Edit</a></td>
                        <td><a href="Delete.aspx?Id=<%# Eval("Id") %>">Sil</a></td>
                    </tr>
                </ItemTemplate>
                </asp:Repeater>                
            </table>
            <a href="/View/Brands/Add.aspx">Marka Ekle</a>
    
        </div>
    </form>
</body>
</html>
