<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exe1.aspx.cs" Inherits="WebApplication2.Exe1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><b>Meu primeiro site de estudos a correr no servidor</b></h1>

            <p>
                Qual o teu nome? <asp:TextBox ID = "tb_nome" runat = "server"></asp:TextBox>
            </p>

            <asp:Button ID = "btn_mostrar" runat = "server" text = "Mostrar " OnClick="btn_mostrar_Click" />
        </div>
        <div>
            <p>Data de Nascimento: <asp:TextBox ID = "tb_data" runat = "server" TextMode = "Date"></asp:TextBox></p>

            <p>Password: <asp:TextBox ID = "tb_pass" runat = "server" TextMode = "Password"></asp:TextBox></p>

            <p>Observações: <asp:TextBox ID = "tb_obs" runat ="server" TextMode = "MultiLine"></asp:TextBox></p>
        </div>
        <div>
            <p>Curso: 
                <asp:DropDownList ID = "ddl_curso" runat = "server" AutoPostBack = "true" OnSelectedIndexChanged="ddl_curso_SelectedIndexChanged1" > 
                    <asp:ListItem>--------------</asp:ListItem>
                    <asp:ListItem>CETTPSI</asp:ListItem>
                    <asp:ListItem>CETREDES</asp:ListItem>
                    <asp:ListItem>CETMultimedia</asp:ListItem>
                </asp:DropDownList>

            </p>
            <p>Módulos: 
                <asp:DropDownList ID = "ddl_modulos" runat = "server" AutoPostBack = "true" ></asp:DropDownList>

            </p>
        </div>

    </form>
</body>
</html>
