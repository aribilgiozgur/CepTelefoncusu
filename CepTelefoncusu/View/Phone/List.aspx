<%@ Page Title="" Language="C#" MasterPageFile="~/View/BootStrap.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CepTelefoncusu.View.Phone.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table class="table  table-striped">
            <tr class="success">
                <th>#</th>
                <th>Marka</th>
                <th>Model</th>
                <th>Seri No</th>    
                <th>İşletim Sistemi</th>
            </tr>
            <asp:Repeater ID="rptPhones" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Id") %></td>
                        <td><%# Eval("BrandText") %></td>
                        <td><%# Eval("ModelText") %></td>
                        <td><%# Eval("SerialNo") %></td>
                        <td><%# Eval("OperatingSystem") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</asp:Content>
