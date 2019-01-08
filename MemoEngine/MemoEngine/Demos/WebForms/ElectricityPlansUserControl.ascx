<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ElectricityPlansUserControl.ascx.cs" Inherits="MemoEngine.Demos.WebForms.ElectricityPlansUserControl" %>
<asp:DropDownList ID="ddlElectricUses" runat="server" CssClass="form-control" AutoPostBack="true" 
    OnSelectedIndexChanged="ddlElectricUses_SelectedIndexChanged">
</asp:DropDownList>

<asp:DropDownList ID="ddlRateType" runat="server" CssClass="form-control" AutoPostBack="true" 
    OnSelectedIndexChanged="ddlRateType_SelectedIndexChanged">
</asp:DropDownList>

<asp:DropDownList ID="ddlRateDetails" runat="server" CssClass="form-control">
</asp:DropDownList>
