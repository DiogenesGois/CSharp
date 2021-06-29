<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercicio1.aspx.cs" Inherits="Exercicio1.Exercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Courseware Feedback Form</h1>
        </div>
        <div>
            Student Name: <asp:TextBox ID = "tb_name" runat = "server" TextMode = "SingleLine"></asp:TextBox>
            <br/>
            <br/>
            Sex: <asp:RadioButtonList ID = "rbl_sex" runat = "server" AutoPostBack = "true">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                 </asp:RadioButtonList>
            <br/>
            <br/>
            Select course: <asp:DropDownList ID =  "ddl_course" runat = "server">
                                <asp:ListItem>----------</asp:ListItem>
                                <asp:ListItem>ASP-XML</asp:ListItem>
                                <asp:ListItem>JavaPro</asp:ListItem>
                                <asp:ListItem>DotNET</asp:ListItem>
                                <asp:ListItem>Unix</asp:ListItem>
                                <asp:ListItem>C</asp:ListItem>
                                <asp:ListItem>C++</asp:ListItem>
                           </asp:DropDownList>
            <br/>
            <br/>
            Techinical Coverage: <asp:RadioButtonList ID = "rbl_tech" runat = "server" AutoPostBack = "false">
                                    <asp:ListItem>Execellent</asp:ListItem>                                   
                                    <asp:ListItem>Good</asp:ListItem>                                   
                                    <asp:ListItem>Average</asp:ListItem>                                   
                                    <asp:ListItem>Poor</asp:ListItem>                                   
                                 </asp:RadioButtonList>
            Suggestions: 
                <asp:TextBox ID = "tb_suggestions" runat = "server" TextMode = "MultiLine"></asp:TextBox> <asp:Button ID = "bto_submit" runat = "server" Text = "Submit Form" OnClick="bto_submit_Click"/>
            <br/>
            <br/>
            <asp:Label ID = "lbl_out" runat = "server" Visible = "false"></asp:Label>

        </div>
    </form>
</body>
</html>
