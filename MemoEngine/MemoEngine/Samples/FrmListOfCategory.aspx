<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmListOfCategory.aspx.cs" Inherits="MemoEngine.Samples.FrmListOfCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>카테고리 리스트</h1>
            <asp:GridView ID="ctlCategoryList" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
