﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Origem.aspx.cs" Inherits="WebApplication1.destino" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nome<asp:TextBox ID="tb_nome" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="btn_enviar" runat="server" OnClick="btn_enviar_Click" Text="Enviar" />
    </form>
</body>
</html>
