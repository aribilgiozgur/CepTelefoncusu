<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="CepTelefoncusu.View.Models.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <b></b><asp:Label ID="lblModel" runat="server" Text=""></asp:Label> Modelini <br />
        <p>Silmek istediğinize emin misiniz?</p>
        <p><asp:LinkButton ID="lnkEvet" runat="server" OnClick="lnkEvet_Click">Evet</asp:LinkButton> - 
            <a href="List.aspx">Hayır</a></p>
        
    </div>
    </form>
</body>
</html>
