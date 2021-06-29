<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exe2.aspx.cs" Inherits="WebApplication2.Exe2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Segunda página</h1>

            <p>Qual teu nome? <asp:TextBox ID ="tb_nome" runat = "server" TextMode ="SingleLine"></asp:TextBox></p>

            <p>Qua a sua data de nascimento? <asp:TextBox ID = "tb_data" runat = "server" TextMode = "Date"></asp:TextBox></p>
            <asp:Button ID = "bto_mostrar" runat = "server" Text = "Mostrar" OnClick="bto_mostrar_Click" />

            <marquee><h1> <asp:Label ID = "lbl_mensagem" runat = "server"></asp:Label></h1></marquee>
        </div>
    </form>
</body>
</html>
