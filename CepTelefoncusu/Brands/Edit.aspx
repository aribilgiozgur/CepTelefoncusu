<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="CepTelefoncusu.Brands.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Marka: <asp:TextBox ID="txtBrandName" runat="server"></asp:TextBox><br />
        <asp:LinkButton ID="lnkSakla" runat="server" onclick="lnkSakla_Click">Ekle</asp:LinkButton>
    </div>
    </form>
</body>
</html>
