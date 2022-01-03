$(document).ready(function(){
    createToDoUI();
    addProject();
})

function createToDoUI(){
    $("#projects").tabs();
    
    $("ul").sortable({axis:"x", containment:"#projects"});
    $("ol").sortable({axis:"y", containment:"#projects"});
}

function addProject() {
    $("#btnAddProject").button()
    .click(function () {
        $("#project-dialog").dialog({
            width:400,
            resizable:false,
            modal:true,
            buttons:{
                
            }
        })
    });
}