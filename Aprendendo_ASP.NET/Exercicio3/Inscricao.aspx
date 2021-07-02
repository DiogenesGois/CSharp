<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inscricao.aspx.cs" Inherits="Exercicio3.Inscricao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 397px">
            Nome:&nbsp;
            <asp:TextBox ID="tb_nome" runat="server"></asp:TextBox>
            <br />
            <br />
            Curso:
            <asp:DropDownList ID="ddl_curso" runat="server" AutoPostBack="True">
                <asp:ListItem>-------------</asp:ListItem>
                <asp:ListItem>Medicina</asp:ListItem>
                <asp:ListItem>Direito</asp:ListItem>
                <asp:ListItem>Mecatrónica</asp:ListItem>
                <asp:ListItem>Barbeiro</asp:ListItem>
            </asp:DropDownList>
&nbsp;<br />
            <br />
            Email:
            <asp:TextBox ID="tb_email" runat="server"></asp:TextBox>
            <br />
            <br />
            Telemóvel:
            <asp:TextBox ID="tb_telemovel" runat="server"></asp:TextBox>
            <br />
            <br />
            Género:
            <asp:RadioButtonList ID="rbl_genero" runat="server">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Feminino</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <asp:Button ID="btn_word" runat="server" OnClick="btn_word_Click" Text="Word" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_excel" runat="server" OnClick="btn_excel_Click" Text="Excel" />
        </div>
    </form>
</body>
</html>
