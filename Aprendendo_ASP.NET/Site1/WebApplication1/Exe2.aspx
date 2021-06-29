<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exe2.aspx.cs" Inherits="WebApplication1.Exe2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nome:&nbsp;
            <asp:TextBox ID="tb_nome" runat="server"></asp:TextBox>
            <br />
            <br />
            Data Nascimento:
            <asp:TextBox ID="tb_data" runat="server" style="margin-bottom: 0px" TextMode="Date"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btn_mostrar" runat="server" OnClick="btn_mostrar_Click" Text="Mostrar" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <marquee><h1><asp:Label ID="lbl_mensagem" runat="server"></asp:Label></h1></marquee>
        </div>
    </form>
</body>
</html>
