<%@ Page Title="" Language="C#" MasterPageFile="~/View/BootStrap.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="CepTelefoncusu.View.Brands.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <h3>Marka: </h3>
        <asp:TextBox ID="txtBrandName" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:LinkButton ID="lnkSakla" runat="server" onclick="lnkSakla_Click" CssClass="btn btn-success">Güncelle</asp:LinkButton>
    </div>
</asp:Content>
