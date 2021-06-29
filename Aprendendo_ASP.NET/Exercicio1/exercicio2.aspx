<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exercicio2.aspx.cs" Inherits="Exercicio1.exercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <p>Click on any of the figures of the first three to display it at the bottom</p>
            <br/>
            <br/>
            <p>Click on the bottom image to clear it</p>
        </div>
        <center>
            <div>
                <asp:ImageButton ID = "imgb_circulo" runat = "server" ImageUrl = "~/circulo.png" Width = "28%" OnClick="imgb_circulo_Click" /><asp:ImageButton ID = "imgb_quadrado" runat = "server" ImageUrl = "~/quadrado.png" Width = "28% " OnClick="imgb_quadrado_Click"/><asp:ImageButton ID = "imgb_triangulo" runat = "server" ImageUrl = "~/triangulo.png" width = "28% " OnClick="imgb_triangulo_Click"/>
                <hr/>
                <br/>
                <br/>
                <asp:ImageButton ID = "imgb_out" runat = "server" Visible = "false" OnClick="imgb_out_Click" Width = "28%" />

            </div>
        </center>
    </form>
</body>
</html>
