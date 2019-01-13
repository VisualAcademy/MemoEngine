<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmDescriptionsBy.aspx.cs" Inherits="MemoEngine.Demos.WebForms.FrmDescriptionsBy" %>

<%@ Register Src="~/Descriptions/DescriptionsUserControl.ascx" TagPrefix="uc1" TagName="DescriptionsUserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:DescriptionsUserControl runat="server" id="DescriptionsUserControl" />
            <hr />
            <uc1:DescriptionsUserControl runat="server" id="DescriptionsUserControl1" FieldName="SiteDescription" />
            <hr />
            <uc1:DescriptionsUserControl runat="server" ID="DescriptionsUserControl2" FieldName="UserGuide" />
        </div>
    </form>
</body>
</html>
