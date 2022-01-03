$(document).ready(function() {
    $("#projects").tabs();
    $("ul").sortable({axis:"x", containment: "#projects"});
    $("ol").sortable({axis:"y", containment: "#projects"});
    $("#btnAddProject").button().click(function() {
        $("#project-dialog").dialog();
    });

    // var theColorIs = $('#ui-id-1').css("background-color");
    // console.log(theColorIs);
})

