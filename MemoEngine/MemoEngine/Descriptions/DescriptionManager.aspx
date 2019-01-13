<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/DashboardCore.Master" AutoEventWireup="true" CodeBehind="DescriptionManager.aspx.cs" Inherits="MemoEngine.DescriptionManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    페이지 내용 관리자 
    <hr />
    <asp:FormView ID="FormView1" runat="server" DataKeyNames="Id" DataSourceID="sdsDescriptions" DefaultMode="ReadOnly">
        <EditItemTemplate>
            Id:
            <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="IdLabel1" /><br />
            SiteName:
            <asp:TextBox Text='<%# Bind("SiteName") %>' runat="server" ID="SiteNameTextBox" /><br />
            SiteDescription:
            <asp:TextBox Text='<%# Bind("SiteDescription") %>' runat="server" ID="SiteDescriptionTextBox" /><br />
            <asp:LinkButton runat="server" Text="Update" CommandName="Update" ID="UpdateButton" CausesValidation="True" />&nbsp;<asp:LinkButton runat="server" Text="Cancel" CommandName="Cancel" ID="UpdateCancelButton" CausesValidation="False" />
        </EditItemTemplate>
        <InsertItemTemplate>
            SiteName:
            <asp:TextBox Text='<%# Bind("SiteName") %>' runat="server" ID="SiteNameTextBox" /><br />
            SiteDescription:
            <asp:TextBox Text='<%# Bind("SiteDescription") %>' runat="server" ID="SiteDescriptionTextBox" /><br />
            <asp:LinkButton runat="server" Text="Insert" CommandName="Insert" ID="InsertButton" CausesValidation="True" />&nbsp;<asp:LinkButton runat="server" Text="Cancel" CommandName="Cancel" ID="InsertCancelButton" CausesValidation="False" />
        </InsertItemTemplate>
        <ItemTemplate>
            Id:
            <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="IdLabel" /><br />
            SiteName:
            <asp:Label Text='<%# Bind("SiteName") %>' runat="server" ID="SiteNameLabel" /><br />
            SiteDescription:
            <asp:Label Text='<%# Bind("SiteDescription") %>' runat="server" ID="SiteDescriptionLabel" /><br />
            <asp:LinkButton runat="server" Text="Edit" CommandName="Edit" ID="EditButton" CausesValidation="False" />&nbsp;<asp:LinkButton runat="server" Text="New" CommandName="New" ID="NewButton" CausesValidation="False" />
        </ItemTemplate>
    </asp:FormView>
  



    <asp:SqlDataSource runat="server" ID="sdsDescriptions" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' DeleteCommand="DELETE FROM [Descriptions] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Descriptions] ([SiteName], [SiteDescription]) VALUES (@SiteName, @SiteDescription)" SelectCommand="SELECT * FROM [Descriptions]" UpdateCommand="UPDATE [Descriptions] SET [SiteName] = @SiteName, [SiteDescription] = @SiteDescription WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32"></asp:Parameter>
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="SiteName" Type="String"></asp:Parameter>
            <asp:Parameter Name="SiteDescription" Type="String"></asp:Parameter>
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="SiteName" Type="String"></asp:Parameter>
            <asp:Parameter Name="SiteDescription" Type="String"></asp:Parameter>
            <asp:Parameter Name="Id" Type="Int32"></asp:Parameter>
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
