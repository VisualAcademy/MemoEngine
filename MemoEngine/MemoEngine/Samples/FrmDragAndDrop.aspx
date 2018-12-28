<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmDragAndDrop.aspx.cs" Inherits="MemoEngine.Samples.FrmDragAndDrop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js" type="text/javascript"></script>
    <script src="http://code.jquery.com/ui/1.8.20/jquery-ui.min.js" type="text/javascript"></script>
    <script src="http://jquery-ui.googlecode.com/svn/tags/latest/external/jquery.bgiframe-2.1.2.js" type="text/javascript"></script>
    <script src="http://jquery-ui.googlecode.com/svn/tags/latest/ui/minified/i18n/jquery-ui-i18n.min.js" type="text/javascript"></script>

    <style type="text/css">
        h1 {
            padding: .2em;
            margin: 0;
            font-family: Arial;
        }

        #products {
            float: left;
            width: 500px;
            margin-right: 2em;
        }

        #fish, #reptiles, #mammals {
            width: 200px;
            float: left;
        }

        #animals li {
            font-weight: bold;
            font-family: Arial;
        }

        #fish ol, #reptiles ol, #mammals ol {
            border-style: solid;
            margin: 0;
            padding: 1em 0 1em 3em;
        }
    </style>

    <script type="text/javascript">
        $(function () {

            $("#animals li").draggable({
                appendTo: "body",
                helper: "clone"
            });

            $("#fish ol, #reptiles ol, #mammals ol").droppable({
                activeClass: "ui-state-default",
                hoverClass: "ui-state-hover",
                accept: ":not(.ui-sortable-helper)",
                drop: function (event, ui) {
                    //debugger;
                    $(this).find(".placeholder").remove();
                    $("<li></li>").text(ui.draggable.text()).appendTo(this);

                    $("#animals").find(":contains('" + ui.draggable.text() + "')")[2].hidden = true;

                }
            }).sortable({
                items: "li:not(.placeholder)",
                sort: function () {
                    // gets added unintentionally by droppable interacting with sortable
                    // using connectWithSortable fixes this, but doesn't allow you to customize active/hoverClass options
                    // $(this).removeClass("ui-state-default");
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="demo">
            <table>
                <tr>
                    <td>
                        <div id="mammals">
                            <h1 class="ui-widget-header">Mammals</h1>
                            <div class="ui-widget-content">
                                <ol>
                                    <li class="placeholder">Add your items here</li>
                                </ol>
                            </div>
                        </div>
                    </td>
                    <td rowspan="3" valign="top">
                        <br />
                        <br />
                        <div id="products">

                            <div id="animals">
                                <div>
                                    <ul>
                                        <li>Dog</li>
                                        <li>Whale</li>
                                        <li>Shark</li>
                                        <li>Pigeon</li>
                                        <li>Alligator</li>
                                        <li>Cobra</li>
                                        <li>Rooster</li>
                                        <li>Deer</li>
                                        <li>Racoon</li>
                                        <li>Chipmunk</li>
                                        <li>Rat</li>
                                        <li>Bass</li>
                                        <li>Trout</li>
                                        <li>Squirrel</li>
                                        <li>Tilapia</li>
                                        <li>Mussel</li>
                                        <li>Clam</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div id="reptiles">
                            <h1 class="ui-widget-header">Reptiles</h1>
                            <div class="ui-widget-content">
                                <ol>
                                    <li class="placeholder">Add your items here</li>
                                </ol>
                            </div>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div id="fish">
                            <h1 class="ui-widget-header">Fish</h1>
                            <div class="ui-widget-content">
                                <ol>
                                    <li class="placeholder">Add your items here</li>
                                </ol>
                            </div>
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
