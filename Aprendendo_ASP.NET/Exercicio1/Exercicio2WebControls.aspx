<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercicio2WebControls.aspx.cs" Inherits="Exercicio1.Exercicio2WebControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_hello" runat="server" Text="Hello"></asp:Label>
            <br />
            <br />
            <asp:CheckBox ID="cb_check" runat="server" Text="Sim?" />
        </div>
        <center>
            <div>
                
                <asp:Button ID = "btn_click" runat = "server" Text = "Click me" BackColor="#00CC00" BorderColor="Black" ForeColor="Black" OnClick="btn_click_Click" onmouseover = "this.style.backgroundColor = 'yellow'" onmouseout = "this.style.backgroundColor = '#00CC00'"/>
            </div>
        </center>
        <div>
            <br />
            <br />
            <asp:Label ID="lbl_mensagem" runat="server" Visible="false" Text="Welcome to Radiant"></asp:Label>
        </div>

    </form>
</body>
</html>
