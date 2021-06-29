<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Utilizador:
            <asp:TextBox ID="tb_nome" runat="server" Width="421px"></asp:TextBox>
            <br />
            <br />
            Palavra-chave:
            <asp:TextBox ID="tb_pass" runat="server" TextMode="Password" Width="384px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_entrar" runat="server" OnClick="btn_entrar_Click" Text="Entrar" />
        </div>
    </form>
</body>
</html>
