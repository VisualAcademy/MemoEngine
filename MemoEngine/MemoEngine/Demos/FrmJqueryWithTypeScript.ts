/// <reference path="../scripts/typings/jquery/jquery.d.ts" />
$(document).ready(function () {
    $("#btnClick").click(function () {
        var txtInput = $("#txtInput").val();
        alert(txtInput);
    });
});
