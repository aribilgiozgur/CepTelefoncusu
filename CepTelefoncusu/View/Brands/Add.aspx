<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="CepTelefoncusu.Brands.Add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cep Telefoncu Hilmi</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Marka: <asp:TextBox ID="txtBrandName" runat="server"></asp:TextBox><br />
        <asp:LinkButton ID="lnkEkle" runat="server" onclick="lnkEkle_Click">Ekle</asp:LinkButton>
    </div>
    </form>
</body>
</html>
