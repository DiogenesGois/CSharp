<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exe3.aspx.cs" Inherits="WebApplication2.Exe3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hobbies:<asp:CheckBoxList ID="cbl_hobbies" runat="server">
                <asp:ListItem>Musica</asp:ListItem>
                <asp:ListItem>Pintura</asp:ListItem>
                <asp:ListItem>Karaté</asp:ListItem>
                <asp:ListItem>Natação</asp:ListItem>
                <asp:ListItem>Corrida</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
            Profissão:<br />
            <asp:RadioButtonList ID="rbl_profissao" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>Musico</asp:ListItem>
                <asp:ListItem>Pintor</asp:ListItem>
                <asp:ListItem>Atleta</asp:ListItem>
                <asp:ListItem>Nadador</asp:ListItem>
                <asp:ListItem>Corredor</asp:ListItem>
                <asp:ListItem>Outra</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Qual?<asp:TextBox ID="tb_qual" runat="server" Enabled="False" ></asp:TextBox>
            <br />
            <br />
            <br />
            Genero Musical:<br />
            <asp:RadioButtonList ID="rbl_musical" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rbl_musical_SelectedIndexChanged">
                <asp:ListItem>Jazz</asp:ListItem>
                <asp:ListItem>Bossa Nova</asp:ListItem>
                <asp:ListItem>Samba</asp:ListItem>
                <asp:ListItem>Prog-Rock</asp:ListItem>
                <asp:ListItem>Outro</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                Qual?
                <asp:TextBox ID="tb_musical_qual" runat="server"></asp:TextBox>

            </asp:Panel>
            
            <br />
        </div>
    </form>
</body>
</html>
