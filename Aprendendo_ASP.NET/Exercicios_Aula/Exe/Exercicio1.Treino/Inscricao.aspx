<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inscricao.aspx.cs" Inherits="Exercicio1.Treino.Inscricao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nome: <asp:TextBox ID = "tb_nome" runat = "server" TextMode = "SingleLine"></asp:TextBox>
            <br/>
            <br/>
            Morada: <asp:TextBox ID = "tb_morada" runat = "server" TextMode = "MultiLine"></asp:TextBox>
            <br/>
            <br/>
            Data de Nascimento <asp:TextBox ID = "tb_data" runat = "server" TextMode = "Date"></asp:TextBox>
            <br/>
            <br/>
            Género <asp:RadioButtonList ID = "rbl_genero" runat = "server" AutoPostBack ="true" OnSelectedIndexChanged="rbl_genero_SelectedIndexChanged">
                        <asp:ListItem>Masculino</asp:ListItem>
                        <asp:ListItem>Feminino</asp:ListItem>
                   </asp:RadioButtonList> 
            <br/>
            <br/>
            Curso <asp:DropDownList ID = "ddl_curso" runat = "server" ></asp:DropDownList>
            <br/>
            <br/>
            Já conhecia o Cinel? <asp:DropDownList ID = "ddl_conhecia" runat = "server" OnSelectedIndexChanged="ddl_conhecia_SelectedIndexChanged" AutoPostBack = "true">
                                    <asp:ListItem>-----</asp:ListItem>
                                    <asp:ListItem>Sim</asp:ListItem>
                                    <asp:ListItem>Não</asp:ListItem>
                                 </asp:DropDownList>
            <br/>
            <br/>
            <asp:panel ID = "Panel1" runat = "server"  Visible = "false">
                Onde?
                <asp:CheckBoxList ID = "cbl_onde" runat = "server">
                    <asp:ListItem>Amigo</asp:ListItem>
                    <asp:ListItem>Internet</asp:ListItem>
                    <asp:ListItem>IEFP</asp:ListItem>
                    <asp:ListItem>Publicidade</asp:ListItem>
                </asp:CheckBoxList>
                <br/>
                <br/>
                Grau de satisfação: <asp:RadioButtonList ID = "rbl_satisfacao" runat = "server" RepeatDirection = "Horizontal">
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
            </asp:panel>
            <br/>
            <br/>
            <asp:Button ID = "bto_enviar" runat = "server" Text = "Mostrar" OnClick="bto_enviar_Click"/>
            <br/>
            <br/>
            <marquee><h1><asp:Label ID = "lb_out" runat = "server" Text = ""></asp:Label></h1></marquee>
        </div>
    </form>
</body>
</html>
