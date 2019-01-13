<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmWYSIWYG.aspx.cs" Inherits="MemoEngine.FrmWYSIWYG" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="/Scripts/jquery-3.3.1.js"></script>
    <script src="/Scripts/MemoEngine/ckeditor_basic/ckeditor.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" ClientIDMode="Static"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <hr />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>

    <script>
        $(function () {
            CKEDITOR.replace("TextBox1");
        });
    </script>
</body>
</html>
