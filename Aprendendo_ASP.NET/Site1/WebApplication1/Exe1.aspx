<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exe1.aspx.cs" Inherits="WebApplication1.Exe1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><b>Exemplo da minha primeira página a correr do lado do servidor</b></h1>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>Qual o teu nome?&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtBox1" runat="server" ></asp:TextBox>
            </p>
            <asp:Button ID="btn_mostrar" runat="server" OnClick="Button1_Click" Text="Mostrar Nome"/>
        </div>        
        <br />
        <br />
        <br />
        Data Nascimento<asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <br />
        <br />
        Observações<asp:TextBox ID="txt_obs" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <br />
        Password<asp:TextBox ID="txt_pass" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <br />
        Curso:
        <asp:DropDownList ID="ddl_curso" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_curso_SelectedIndexChanged">
            <asp:ListItem>--------------</asp:ListItem>
            <asp:ListItem>CetTPSI</asp:ListItem>
            <asp:ListItem>CETredes</asp:ListItem>
            <asp:ListItem>CETMultimedia</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Módulo <asp:DropDownList ID="ddl_modulos" runat="server">
        </asp:DropDownList>
        <br />
        <br />
    </form>
</body>
</html>
