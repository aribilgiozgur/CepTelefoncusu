<%@ Page Title="" Language="C#" MasterPageFile="~/View/BootStrap.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="CepTelefoncusu.View.Brands.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h3>Marka:</h3>
        <asp:Label ID="lblBrand" runat="server" Text=""></asp:Label><br />
        <p>Silmek istediğinize emin misiniz?</p>
        <p><asp:LinkButton ID="lnkEvet" runat="server" OnClick="lnkEvet_Click" CssClass="btn btn-danger btn-lg">Evet</asp:LinkButton> 
            <a href="List.aspx" class="btn btn-default btn-lg">Hayır</a></p>       
    
    </div>
</asp:Content>
