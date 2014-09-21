<%@ Page Title="" Language="C#" MasterPageFile="~/View/BootStrap.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="CepTelefoncusu.View.Models.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        Markası: <asp:DropDownList ID="drpMarka" runat="server" CssClass="form-control">
    </asp:DropDownList><br />
    Modeli: <asp:TextBox ID="txtModel" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:LinkButton ID="lnkSend" runat="server" onclick="lnkSend_Click" CssClass="btn btn-danger" >Gönder</asp:LinkButton>
    </div>
</asp:Content>
