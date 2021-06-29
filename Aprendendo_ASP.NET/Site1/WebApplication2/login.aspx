<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication2.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Utilizador: <asp:TextBox ID = "tb_utilizador" runat = "server"  TextMode = "SingleLine"></asp:TextBox>
            <br/>
            <br/>
            Palavra-Passe: <asp:TextBox ID = "tb_pw" runat = "server" TextMode ="Password"></asp:TextBox> 
            <br/>
            <br/>
            <asp:Button ID = "btn_entrar" runat = "server" Text = "Entrar" OnClick="btn_entrar_Click" />
            <br />
            <br />
            <asp:Label ID = "lbl_erro" runat = "server" Visible = "false" ForeColor = "Red" Text = "Utilizador ou pass errados"></asp:Label>
        </div>
    </form>
</body>
</html>

