<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmGridViewWithRadioButtonCheckedChanged.aspx.cs" Inherits="MemoEngine.Demos.WebForms.FrmGridViewWithRadioButtonCheckedChanged" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GridView에 있는 라디오버튼 클릭할 때 해당 행의 Id값 가져오기</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="ctlSelectWeather" runat="server">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:RadioButton ID="optId" runat="server" GroupName="Provinces" 
                                AutoPostBack="true"
                                OnCheckedChanged="optId_CheckedChanged" />
                            <asp:HiddenField ID="hdnId" runat="server" Value='<%# Eval("Id") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <hr />
            <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
