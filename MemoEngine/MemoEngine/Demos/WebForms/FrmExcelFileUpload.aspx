<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmExcelFileUpload.aspx.cs" Inherits="MemoEngine.Demos.WebForms.FrmExcelFileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>엑셀 파일 업로드</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="csvFile" runat="server" />
            <asp:Button ID="btnUpload" runat="server" Text="업로드" OnClick="btnUpload_Click" />
            <hr />          
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
