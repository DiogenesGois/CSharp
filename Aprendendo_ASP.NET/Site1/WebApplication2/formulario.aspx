<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formulario.aspx.cs" Inherits="WebApplication2.formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nome:
            <asp:TextBox ID="tb_nome" runat="server" Width="306px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tb_nome" ErrorMessage="Nome obrigatório" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Morada: <asp:TextBox ID="tb_morada" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            Data de nascimento:
            <asp:TextBox ID="tb_data" runat="server" TextMode="Date" Width="195px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tb_data" ErrorMessage="Data de nascimento obrigatória" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Email:
            <asp:TextBox ID="tb_email" runat="server" Width="299px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tb_email" ErrorMessage="Email obrigatorio" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tb_email" ErrorMessage="Email inválido" ForeColor="#00CC00" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="bt_enviar" runat="server" OnClick="bt_enviar_Click" Text="Enviar" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
