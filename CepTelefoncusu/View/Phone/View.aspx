<%@ Page Title="" Language="C#" MasterPageFile="~/View/BootStrap.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="CepTelefoncusu.View.Phone.View" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Repeater ID="rptPhone" runat="server">
            <ItemTemplate>
                <h2><%# Eval("BrandText") %> <%# Eval("ModelText") %></h2>
                <table class="table table-bordered table-hover">
                    <tr>
                        <th>Seri Numarası</th>
                        <td align="center"><%# Eval("SerialNo") %></td>
                    </tr>
                    <tr>
                        <th>Satış Fiyatı</th>
                        <td align="center"><%# Eval("SalePrice") %></td>
                    </tr>
                    <tr>
                        <th>Açıklaması</th>
                        <td align="center">
                            <textarea class="form-control" rows="9" disabled="true"><%# Eval("Description") %></textarea></td>
                    </tr>
                    <tr>
                        <th>Dokunmatiği Var Mı</th>
                        <td align="center"><%# Eval("HasTouchScreen").ToString() == "True" ? "<input type='checkbox' checked='true' disabled = 'true'/>" : "<input type='checkbox' disabled = 'true'/>" %></td>
                    </tr>
                    <tr>
                        <th>Bluetooth'u Var mı?</th>
                        <td align="center"><%# Eval("HasBlueTooth").ToString() == "True" ? "<input type='checkbox' checked='true' disabled = 'true'/>" : "<input type='checkbox' disabled = 'true'/>" %></td>
                    </tr>
                </table>
                <a href="List.aspx" class="btn btn-default"><i class="glyphicon glyphicon-backward"></i></a>
                <a href="Edit.aspx?Id=<%# Eval("Id") %>" class="btn btn-success"><i class="glyphicon glyphicon-wrench"></i></a>
                <a href="Delete.aspx?Id=<%# Eval("Id") %>" class="btn btn-danger"><i class="glyphicon glyphicon-remove"></i></a>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
