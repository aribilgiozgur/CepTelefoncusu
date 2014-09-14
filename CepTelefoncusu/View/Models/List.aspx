<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CepTelefoncusu.View.Models.List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<!--    
        public int BrandId { get; set; }
        public String ModelText { get; set; }-->
        <table>
            <tr>
                <th>#</th>
                <th>Markası</th>
                <th>Modeli</th>                
            </tr>
            <asp:Repeater ID="rptModels" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Id") %></td>
                        <td><%# Eval("BrandText") %></td>
                        <td><%# Eval("ModelText") %></td>
                        <td><a href="Edit.aspx?Id=<%# Eval("Id") %>">Edit</a></td>
                        <td><a href="Delete.aspx?Id=<%# Eval("Id") %>">Sil</a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <a href="/View/Models/Add.aspx">Model Ekle</a>

    </div>
    </form>
</body>
</html>
