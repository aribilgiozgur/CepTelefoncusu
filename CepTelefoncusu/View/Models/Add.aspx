<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="CepTelefoncusu.View.Models.Add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

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
        <asp:LinkButton ID="lnkSend" runat="server" onclick="lnkSend_Click">Gönder</asp:LinkButton>
    </div>
    </form>
</body>
</html>
