<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="CepTelefoncusu.View.Models.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div>
        Markası: <asp:DropDownList ID="drpMarka" runat="server">
    </asp:DropDownList><br />
    Modeli: <asp:TextBox ID="txtModel" runat="server"></asp:TextBox><br />
        <asp:LinkButton ID="lnkSend" runat="server">Gönder</asp:LinkButton>
    </div>
    </form>
</body>
</html>
