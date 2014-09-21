<%@ Page Title="" Language="C#" MasterPageFile="~/View/BootStrap.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CepTelefoncusu.View.Models.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
<!--    
        public int BrandId { get; set; }
        public String ModelText { get; set; }-->
        <table class="table table-striped">
            <tr class="success">
                <th>#</th>
                <th>Markası</th>
                <th>Modeli</th>  
                <th>İşlemler</th>              
            </tr>
            <asp:Repeater ID="rptModels" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Id") %></td>
                        <td><%# Eval("BrandText") %></td>
                        <td><%# Eval("ModelText") %></td>
                        <td><a href="Edit.aspx?Id=<%# Eval("Id") %>"><i class="glyphicon glyphicon-wrench"></i></a>
                        <a href="Delete.aspx?Id=<%# Eval("Id") %>"><i class="glyphicon glyphicon-remove"></i></a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <center><a href="/View/Models/Add.aspx" class="btn btn-danger">Model Ekle</a></center>

    </div>
</asp:Content>
