<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Destino3.aspx.cs" Inherits="WebApplication1.Destino3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><asp:Label ID="lbl_mensagem" runat="server" Text="Label"></asp:Label></h1>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
        </div>
        <asp:Button ID="bto_sair" runat="server" OnClick="bto_sair_Click" Text="Sair" />
    </form>
</body>
</html>
