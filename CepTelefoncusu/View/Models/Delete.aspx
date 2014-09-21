<%@ Page Title="" Language="C#" MasterPageFile="~/View/BootStrap.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="CepTelefoncusu.View.Models.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container">
      <b></b><asp:Label ID="lblModel" runat="server" Text=""></asp:Label> Modelini <br />
        <p>Silmek istediğinize emin misiniz?</p>
        <p><asp:LinkButton ID="lnkEvet" runat="server" OnClick="lnkEvet_Click" CssClass="btn btn-danger">Evet</asp:LinkButton> - 
            <a href="List.aspx" class="btn btn-default" >Hayır</a></p>
        
    </div>
</asp:Content>
