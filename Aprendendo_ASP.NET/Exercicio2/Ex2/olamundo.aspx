<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="olamundo.aspx.cs" Inherits="Ex2.olamundo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style = "background-color: darkcyan;">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_ola" runat="server" OnClick="btn_ola_Click" Text="Olá" Width="93px" />
            <br />
            <br />
            <asp:Label ID="lbl_ola" runat="server" ForeColor="Red" Text="Olá a todos" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_adeus" runat="server" OnClick="btn_adeus_Click" Text="Adeus" Width="92px" />
            <br />
            <br />
            <asp:Label ID="lbl_adeus" runat="server" ForeColor="Red" Text="Adeus a todos" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
