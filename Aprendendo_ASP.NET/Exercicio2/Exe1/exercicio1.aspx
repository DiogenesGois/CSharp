<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exercicio1.aspx.cs" Inherits="Exe1.exercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p> 
                <asp:Label ID = "lbl_name" runat = "server" Text = "Name" AssociatedControlID = "tb_Name"></asp:Label>
                <asp:TextBox ID="tb_name" runat="server"></asp:TextBox>
            </p>

            <p> <asp:Label ID = "lbl_age" runat = "server" Text = "Age" AssociatedControlID = "tb_age"></asp:Label> 
                <asp:TextBox ID = "tb_age" runat = "server" Width="168px"></asp:TextBox> 

            </p>

            <p> <asp:Label ID = "lbl_email" runat = "server" Text = "Email" AssociatedControlID = "tb_email"></asp:Label> 
                <asp:TextBox ID = "tb_email" runat = "server"></asp:TextBox> 

            </p>

        </div>
    </form>
</body>
</html>
