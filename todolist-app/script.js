$(document).ready(function () {
    $("#projects").tabs();
    $("ul").sortable({ axis: "x", containment: "#projects" });
    $("ol").sortable({ axis: "y", containment: "#projects" });
    $("#btnAddProject").button().click(function () {
        $("#project-dialog").dialog({
            width: 400,
            resizable: false,
            modal: true,
            buttons: {
                "Add new project": function () {
                    var projectName = $("#new-project").val();
                    $(`<li><a href="#${projectName}">${projectName}</a></li>`)
                        .appendTo("#main");
                    $("#projects").tabs("refresh");


                    $(`<ol id="${projectName}"></ol>`).appendTo("#projects");
                    var tabCount = $("#projects .ui-tabs-nav li").length;
                    $("#projects").tabs("option", "active", tabCount - 1);
                    $(this).val("");
                    $(this).dialog("close");
                },
                "Cancel": function () {
                    $(this).val("");
                    $(this).dialog("close");
                },
            }
        });
    });

    // var theColorIs = $('#ui-id-1').css("background-color");
    // console.log(theColorIs);
})

