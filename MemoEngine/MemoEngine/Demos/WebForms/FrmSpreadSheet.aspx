<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmSpreadSheet.aspx.cs" Inherits="MemoEngine.Demos.WebForms.FrmSpreadSheet" %>

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
                        AutoGenerateColumns="false" ItemType="MemoEngine.Models.PriceOutputDto">
                        <Columns>
                            <asp:BoundField DataField="Index" HeaderText="년차" />
                            <asp:BoundField DataField="Year" HeaderText="년도" />
                            <asp:BoundField DataField="StandardPrice" HeaderText="기준단가" />
                            <asp:BoundField DataField="UserPrice" HeaderText="사용자단가" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%--<asp:TextBox ID="txtUserPrice" runat="server" Text='' ClientIDMode="Static"></asp:TextBox>--%>
                                    <input type="text" id="txtUserPrice" name="txtUserPrice" value="<%#: Item.UserPrice %>" />
                                    <input type="hidden" name="hdnIndex" value="<%#: Item.Index %>" />
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
                    <asp:Button ID="btnSave" runat="server" Text="저장" OnClick="btnSave_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
