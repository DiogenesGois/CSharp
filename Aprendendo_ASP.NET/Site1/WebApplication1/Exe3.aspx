<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exe3.aspx.cs" Inherits="WebApplication1.Exe3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hobbies:<asp:CheckBoxList ID="cbl_hobbies" runat="server">
                <asp:ListItem>Leitura</asp:ListItem>
                <asp:ListItem>Pesca</asp:ListItem>
                <asp:ListItem>Viajar</asp:ListItem>
                <asp:ListItem>correr</asp:ListItem>
                <asp:ListItem>Futebol</asp:ListItem>
            </asp:CheckBoxList>
&nbsp;</div>
        <p>
            &nbsp;</p>
        <p>
            Profissão:</p>
        <p>
            <asp:RadioButtonList ID="rbl_profissao" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rbl_profissao_SelectedIndexChanged">
                <asp:ListItem>Mecanico</asp:ListItem>
                <asp:ListItem>Professor</asp:ListItem>
                <asp:ListItem>Enfermeiro</asp:ListItem>
                <asp:ListItem>Vendedor</asp:ListItem>
                <asp:ListItem>Fiel de Armazem</asp:ListItem>
                <asp:ListItem>Bombeiro</asp:ListItem>
                <asp:ListItem>Outra</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            Qual?
            <asp:TextBox ID="tb_qual" runat="server" Enabled="False" OnTextChanged="tb_qual_TextChanged" Width="381px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            Genero Musical:<asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem>Jazz</asp:ListItem>
                <asp:ListItem>Bossa nova</asp:ListItem>
                <asp:ListItem>Rock</asp:ListItem>
                <asp:ListItem>Prog-Rock</asp:ListItem>
                <asp:ListItem>Samba</asp:ListItem>
                <asp:ListItem>Outro</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                Qual?
                <asp:TextBox ID="tb_musical_qual" runat="server" Width="379px"></asp:TextBox>

            </asp:Panel>
            
        </p>
    </form>
</body>
</html>
