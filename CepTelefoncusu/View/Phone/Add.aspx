<%@ Page Title="" Language="C#" MasterPageFile="~/View/BootStrap.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="CepTelefoncusu.View.Phone.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--  public int BrandId;
        public int ModelId;
        public int SerialNo;
        public double SalePrice;
        public string Description;
        public Boolean HasTouchScreen;
        public Boolean HasBlueTooth;
        public String OperatingSystem;-->
    <div class="container">
        <table class="table">
            <tr>
                <td>Markası:</td>
                <td><asp:DropDownList ID="drpBrandId" runat="server" CssClass="form-control" OnSelectedIndexChanged="drpBrandId_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
            </tr>
            <tr>
                <td>Modeli</td>
                <td><asp:DropDownList ID="drpModelId" runat="server" CssClass="form-control"></asp:DropDownList></td>
            </tr>
            <tr>
                <td>Fiyatı:</td>
                <td><asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Açıklaması</td>
                <td><asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="9" CssClass="form-control"></asp:TextBox></td>
            </tr>
            <tr>
                <td>İşletim Sistemi:</td>
                <td><asp:TextBox ID="txtOperatingSystem" runat="server" CssClass="form-control"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Dokunmatikli Mi</td>
                <td><asp:CheckBox ID="chkTouchScreen" runat="server" Text=" " CssClass="checkbox"/></td>
            </tr>
            <tr>
                <td>Bluetooth'u var mı?</td>
                <td><asp:CheckBox ID="chkBlueTooth" runat="server" Text=" " CssClass="checkbox"/></td>
            </tr>
            
            <tr>
                <td colspan="2">
                    <asp:LinkButton ID="lnkSend" runat="server" CssClass="btn btn-success pull-right" >Gönder</asp:LinkButton>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
