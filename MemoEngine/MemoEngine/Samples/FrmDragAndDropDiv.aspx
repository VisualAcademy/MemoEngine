<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmDragAndDropDiv.aspx.cs" Inherits="MemoEngine.Samples.FrmDragAndDropDiv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        /* Draggable Test Styles */

        .test_container {
            width: 800px;
            height: 380px;
            background-color: #D6D6D6;
            overflow: hidden;
        }

        .gallery_one, .gallery_two {
            float: left;
            width: 270px;
            height: 260px;
            border: solid 1px #BBBBBB;
            margin: 60px 0px 0px 50px;
            overflow: hidden;
            background-color: #CED5DB;
        }

        .box {
            float: left;
            width: 100px;
            height: 100px;
            overflow: hidden;
            cursor: pointer;
            background-color: #E1E1E1;
            margin: 20px 0px 0px 20px;
            text-align: center;
            line-height: 100px;
            cursor: pointer;
            border: 1px solid #B3B3B3;
            font-weight: bold;
        }

        .gallery_two {
            margin: 60px 0px 0px 150px;
        }

        .box_current {
            background-color: #BBBBFF;
        }
    </style>

    <script src="../Scripts/jquery-3.3.1.js"></script>
    <script
        src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"
        integrity="sha256-T0Vest3yCU7pafRw9r+settMBX6JkKN06dqBnpQ8d30="
        crossorigin="anonymous"></script>

    <script>
        function galleryDragAndDrop(mainContainer, containerOne, containerTwo, dragItem) {
            $(dragItem).draggable(
                {
                    revert: "invalid",
                    containment: mainContainer,
                    helper: "clone",
                    cursor: "move",
                    drag: function (event, ui) {
                        $(ui.helper.prevObject).addClass("box_current");
                    },
                    stop: function (event, ui) {
                        $(ui.helper.prevObject).removeClass("box_current");
                    }
                });

            $(containerTwo).droppable({
                accept: dragItem,
                activeClass: "ui-state-highlight",
                drop: function (event, ui) {
                    console.log($(ui.draggable).attr("id"));
                    //console.dir(ui.draggable);
                    //alert(ui.draggable.text());
                    acceptBoxIngalleryTwo(ui.draggable);
                }
            });

            $(containerOne).droppable({
                accept: dragItem,
                activeClass: "ui-state-highlight",
                drop: function (event, ui) {
                    acceptBoxIngalleryOne(ui.draggable);
                }
            });

            function acceptBoxIngalleryTwo(item) {
                $(item).fadeOut(function () {
                    $(containerTwo).append(item);
                });

                $(item).fadeIn();
                $(item).removeClass("box_current");
            }

            function acceptBoxIngalleryOne(item) {
                $(item).fadeOut(function () {
                    $(containerOne).append(item);
                });

                $(item).fadeIn();
                $(item).removeClass("box_current");
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Draggable</h2>
        <div id="test-container" class="test_container">
            <div id="gallery-one" class="gallery_one">
                <div id="box1" class="box">
                    ONE
                </div>
                <div id="box2" class="box">
                    TWO
                </div>
                <div id="box3" class="box">
                    THREE
                </div>
                <div id="box4" class="box">
                    FOUR
                </div>
            </div>
            <div id="gallery-two" class="droppable gallery_two">
            </div>
        </div>
        <script type="text/javascript">
            $(document).ready(function () {
                galleryDragAndDrop("#test-container", "#gallery-one", "#gallery-two", ".box");
            });
        </script>
    </form>
</body>
</html>
