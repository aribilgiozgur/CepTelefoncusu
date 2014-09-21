<%@ Page Title="" Language="C#" MasterPageFile="~/View/BootStrap.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="CepTelefoncusu.View.Models.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        Markası: <asp:DropDownList ID="drpMarka" runat="server" CssClass="form-input">
    </asp:DropDownList><br />
    Modeli: <asp:TextBox ID="txtModel" runat="server" CssClass="form-input"></asp:TextBox><br />
        <asp:LinkButton ID="lnkSend" runat="server" OnClick="lnkSend_Click" CssClass="btn btn-success">Gönder</asp:LinkButton>
    </div>
</asp:Content>
