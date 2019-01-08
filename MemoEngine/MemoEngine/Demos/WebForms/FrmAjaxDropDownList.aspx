<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAjaxDropDownList.aspx.cs" Inherits="MemoEngine.Demos.WebForms.FrmAjaxDropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>jQuery Ajax를 사용하여 동적으로 드롭다운리스트 만들기</title>
    <script src="../../Scripts/jquery-3.3.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <select id="ddlLandType"></select>
        </div>
    </form>
    <script>
        $(function () {
            GetLandTypes();
        });

        function GetLandTypes() {
            $.ajax({
                type: "POST",
                url: "/api/LandTypeServices/GetLandTypes",
                dataType: "JSON",
                success: function (data) {
                    // console.log(data);
                    if (data) {
                        for (var i = 0; i < data.length; i++) {
                            $("#ddlLandType").append("<option value\"" + data[i].Value + "\">" + data[i].Text + "</option>");
                        }
                    }
                }
            });
        }
    </script>
</body>
</html>
