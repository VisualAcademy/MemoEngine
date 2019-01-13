<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmSpreadSheetWithDatabase.aspx.cs" Inherits="MemoEngine.Demos.WebForms.FrmSpreadSheetWithDatabase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>스프레드시트 형태의 데이터 다루기</title>
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    기준 단가: <asp:TextBox ID="txtStandardPrice" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-6">
                    &nbsp;
                </div>
            </div>
            <div class="row">
                <div class="col-md-3">
                    <asp:DropDownList ID="ddlSelect" runat="server" CssClass="form-control">
                        <asp:ListItem Value="0">고정</asp:ListItem>
                        <asp:ListItem Value="0">변동</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <asp:Button ID="btnCreate" runat="server" Text="생성" CssClass="form-control btn btn-primary" OnClick="btnCreate_Click"/>
                </div>
                <div class="col-md-6">
                    &nbsp;
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <asp:GridView ID="ctlTwentyYears" runat="server" CssClass="table table-bordered table-condensed table-hover"
                        AutoGenerateColumns="false" ItemType="MemoEngine.Models.UserPriceData">
                        <Columns>
                            <asp:BoundField DataField="Num" HeaderText="년차" />
                            <asp:BoundField DataField="Year" HeaderText="년도" />
                            <asp:BoundField DataField="StandardPrice" HeaderText="기준단가" />
                            <asp:TemplateField HeaderText="사용자단가">
                                <ItemTemplate>
                                    <input type="text" id="txtUserPrice" name="txtUserPrice" value="<%#: Item.UserPrice %>" class="form-control" />
                                    <input type="hidden" name="hdnNum" value="<%#: Item.Num %>" />
                                    <input type="hidden" name="hdnYear" value="<%#: Item.Year %>" />
                                    <input type="hidden" name="hdnStandardPrice" value="<%#: Item.StandardPrice %>" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>

                    <asp:GridView ID="ctlSavedData" runat="server"></asp:GridView>
                </div>
                <div class="col-md-6">
                    <div id="chartArea">

                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:Button ID="btnSave" runat="server" Text="저장" OnClick="btnSave_Click" CssClass="btn btn-primary" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
