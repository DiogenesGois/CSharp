<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inscricao.aspx.cs" Inherits="Exercicio2.Inscricao" %>

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
            Morada
            <asp:TextBox ID="tb_morada" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            Data de nascimento:
            <asp:TextBox ID="tb_data" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <br />
            Género:<asp:RadioButtonList ID="rbl_genero" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rbl_genero_SelectedIndexChanged">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Feminino</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            Curso: <asp:DropDownList ID="ddl_curso" runat="server">
            </asp:DropDownList>
&nbsp;<br />
            <br />
            Já conhecia?&nbsp;
            <asp:DropDownList ID="ddl_conhecia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_conhecia_SelectedIndexChanged">
                <asp:ListItem>--------</asp:ListItem>
                <asp:ListItem>Sim</asp:ListItem>
                <asp:ListItem>Não</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                Onde?<br />
                <asp:CheckBoxList ID="cbl_onde" runat="server">
                    <asp:ListItem>Internet</asp:ListItem>
                    <asp:ListItem>Amigo</asp:ListItem>
                    <asp:ListItem>Publicidade</asp:ListItem>
                    <asp:ListItem>IEFP</asp:ListItem>
                </asp:CheckBoxList>
                <br />
                Grau de satisfação<br />
                <asp:RadioButtonList ID="rbl_satisfacao" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <br />
            </asp:Panel>
        </div>
        <asp:Button ID="tbn_gravar" runat="server" OnClick="Button1_Click" Text="Gravar" />
    </form>
</body>
</html>
