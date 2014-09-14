<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="CepTelefoncusu.Brands.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <b>Marka:</b><asp:Label ID="lblBrand" runat="server" Text=""></asp:Label><br />
        <p>Silmek istediğinize emin misiniz?</p>
        <p><asp:LinkButton ID="lnkEvet" runat="server" OnClick="lnkEvet_Click">Evet</asp:LinkButton> - 
            <a href="List.aspx">Hayır</a></p>
        
    
    </div>
    </form>
</body>
</html>
