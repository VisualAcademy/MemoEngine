<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmDropDownListCascading.aspx.cs" Inherits="MemoEngine.Demos.WebForms.FrmDropDownListCascading" %>

<%@ Register Src="~/Demos/WebForms/ElectricityPlansUserControl.ascx" TagPrefix="uc1" TagName="ElectricityPlansUserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-6">

            <h3>전기 요금제 선택</h3>

            <asp:DropDownList ID="ddlElectricUses" runat="server" CssClass="form-control" AutoPostBack="true" 
                OnSelectedIndexChanged="ddlElectricUses_SelectedIndexChanged">
<%--                <asp:ListItem Value="Home">주택용</asp:ListItem>
                <asp:ListItem Value="Industry">일반/산업용</asp:ListItem>--%>
            </asp:DropDownList>

            <asp:DropDownList ID="ddlRateType" runat="server" CssClass="form-control" AutoPostBack="true" 
                OnSelectedIndexChanged="ddlRateType_SelectedIndexChanged">
<%--                <asp:ListItem Value="HighPressure">고압</asp:ListItem>
                <asp:ListItem Value="LowPressure">저압</asp:ListItem>--%>
            </asp:DropDownList>

            <asp:DropDownList ID="ddlRateDetails" runat="server" CssClass="form-control">
                <%--<asp:ListItem Value="">-선택-</asp:ListItem>--%>
            </asp:DropDownList>

        </div>
        <div class="col-md-6">
            <uc1:ElectricityPlansUserControl runat="server" ID="ElectricityPlansUserControl" />
        </div>

        <hr />

        <asp:Button ID="btnGetValueFromUserControl" runat="server" Text="선택한 값 가져오기" OnClick="btnGetValueFromUserControl_Click" />

        <hr />
        <asp:Label ID="lblSelectedValue" runat="server" Text="선택된 값: "></asp:Label>
    </form>
</body>
</html>
