<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/DashboardCore.Master" AutoEventWireup="true" CodeBehind="Descriptions.aspx.cs" Inherits="MemoEngine.Descriptions" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <link href="/Content/bootstrap.css" rel="stylesheet" />
    <script src="/Scripts/jquery-3.3.1.js"></script>
    <script src="/Scripts/MemoEngine/ckeditor_basic/ckeditor.js"></script>

    <div class="container">

        <h3 class="text-center">설명서 관리자</h3>

        <div class="row">
            <div class="col-12 text-right">
                <asp:button id="btnSave" runat="server" text="업데이트" onclick="btnSave_Click" cssclass="btn btn-primary" />
            </div>
        </div>

        <div class="row">
            <div class="col-2 text-right">
                사이트 이름: 
            </div>
            <div class="col-10">
                <asp:textbox id="txtSiteName" runat="server" textmode="SingleLine" cssclass="form-control"></asp:textbox>
            </div>
        </div>


        <div class="row">
            <div class="col-2 text-right">
                사이트 설명: 
            </div>
            <div class="col-10">
                <asp:textbox id="txtSiteDescription" runat="server" textmode="MultiLine" cssclass="form-control" clientidmode="Static"></asp:textbox>
            </div>
        </div>

        <div class="row">
            <div class="col-2 text-right">
                사용자 가이드: 
            </div>
            <div class="col-10">
                <asp:textbox id="txtUserGuide" runat="server" textmode="MultiLine" cssclass="form-control" clientidmode="Static"></asp:textbox>
            </div>
        </div>
    </div>



    <script>
        $(function () {
            CKEDITOR.replace("txtSiteDescription");
            CKEDITOR.replace("txtUserGuide");
        });
    </script>

</asp:Content>
