<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculadora.aspx.cs" Inherits="Ex2.calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style = "background-color:darkcyan  ">
    <form id="form1" runat="server">
        <div>
            Operador
            <asp:TextBox ID="tb_operador1" runat="server"></asp:TextBox>
            <br />
            <br />
            Operador
            <asp:TextBox ID="tb_operador2" runat="server"></asp:TextBox>
            <br />
            <br />
            Operação
            <asp:DropDownList ID="ddl_operacao" runat="server">
                <asp:ListItem>----------------</asp:ListItem>
                <asp:ListItem>Soma</asp:ListItem>
                <asp:ListItem>Subtração</asp:ListItem>
                <asp:ListItem>Multiplicação</asp:ListItem>
                <asp:ListItem>Divisão</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btn_calcular" runat="server" OnClick="btn_calcular_Click" Text="Calcular" Width="90px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_limpar" runat="server" OnClick="btn_limpar_Click" Text="Limpar" Width="90px" />
            <br />
            <br />
            <br />
            <asp:Label ID="lbl_resultado" runat="server" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
