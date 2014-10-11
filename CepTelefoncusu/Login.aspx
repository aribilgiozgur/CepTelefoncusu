<%@ Page Title="" Language="C#" MasterPageFile="~/View/BootStrap.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CepTelefoncusu.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-right: 35%; padding-top:10%; ">
      
        <asp:Panel ID="Panel1" runat="server" DefaultButton="Button1">
             <div class="navbar-form navbar-right" role="form">
            <div class="form-group">
            <asp:TextBox ID="txtUserName" runat="server" placeholder="Email" CssClass="form-control  input-lg"></asp:TextBox>
            </div><br />
            <div class="form-group">
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" placeholder="Password" CssClass="form-control  input-lg"></asp:TextBox>

            </div><br />
          <asp:LinkButton ID="lnkSubmit" runat="server" CssClass="btn btn-success btn-lg" OnClick="lnkSubmit_Click">Gönder</asp:LinkButton>
              
                    </div>
   <asp:Button ID="Button1" runat="server" style="display:none" OnClick="Button1_Click" />
</asp:Panel>
        </div>
    <asp:Label ID="lblError" runat="server" Text="Label" Visible="false"></asp:Label>
</asp:Content>
