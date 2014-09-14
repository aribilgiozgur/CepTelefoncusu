<%@ Page Title="" Language="C#" MasterPageFile="~/View/BootStrap.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CepTelefoncusu.View.Brands.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container">
            <table class="table table-striped">
                <tr class="success">
                    <th>Id</th>
                    <th>Markası</th>
                    <th>İşlemler</th>
                </tr>

                <asp:Repeater ID="rptBrand" runat="server">
                <ItemTemplate>
                    <tr> 
                        <td><%# Eval("Id") %></td>
                        <td><%# Eval("BrandText") %></td>
                        <td><a href="Edit.aspx?Id=<%# Eval("Id") %>"><i class="glyphicon glyphicon-wrench"></i></a>
                        <a href="Delete.aspx?Id=<%# Eval("Id") %>"><i class="glyphicon glyphicon-remove"></i></a></td>
                    </tr>
                </ItemTemplate>
                </asp:Repeater>                
            </table>
            <a href="/View/Brands/Add.aspx">Marka Ekle</a>
    
        </div>
</asp:Content>
