$(document).ready(function () {
    createToDoUI();
    addProject();
    addTask();
})

function createToDoUI() {
    $("#projects").tabs();

    $("ul").sortable({ axis: "x", containment: "#projects" });
    $("ol").sortable({ axis: "y", containment: "#projects" });
}

function addProject() {
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

                    $(`<ol id=${projectName}></ol>`).appendTo("#projects");
                    var tabCount = $("#projects .ui-tabs-nav li").length;
                    $("#projects").tabs("option", "active", tabCount - 1);

                    $("#new-project").val("");
                    $(this).dialog("close");
                },
                "Cancel": function () {
                    $("#projects").tabs("refresh");
                    $("#new-project").val("");
                    $(this).dialog("close");
                }
            }
        })
    });
}

function addTask() {
    $("#btnAddTask").button();
}