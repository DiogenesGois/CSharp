<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Origem2.aspx.cs" Inherits="WebApplication2.Origem2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nome:
            <asp:TextBox ID="tb_nome" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="bto_enviar" runat="server" OnClick="bto_enviar_Click" Text="Enviar" />
        </div>
    </form>
</body>
</html>
