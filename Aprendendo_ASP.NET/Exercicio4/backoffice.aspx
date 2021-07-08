<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="backoffice.aspx.cs" Inherits="Exercicio4.backoffice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_info" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btn_word" runat="server" OnClick="btn_word_Click" Text="Word" />
&nbsp;&nbsp;
            <asp:Button ID="btn_excel" runat="server" OnClick="btn_excel_Click" Text="Excel" />
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="XML" />
&nbsp;&nbsp;
            <asp:Button ID="btn_pdf" runat="server" OnClick="btn_pdf_Click" Text="PDF" />
        </div>
    </form>
</body>
</html>
