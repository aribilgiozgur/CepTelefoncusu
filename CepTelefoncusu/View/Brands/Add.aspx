<%@ Page Title="" Language="C#" MasterPageFile="~/View/BootStrap.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="CepTelefoncusu.View.Brands.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
        <h3>Marka: </h3>
        <asp:TextBox ID="txtBrandName" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:LinkButton ID="lnkEkle" runat="server" onclick="lnkEkle_Click" CssClass="btn btn-success" >Ekle</asp:LinkButton>
    </div>
</asp:Content>
