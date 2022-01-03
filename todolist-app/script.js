$(document).ready(function(){
    createToDoUI();
})

function createToDoUI(){
    $("#projects").tabs();
    
    $("ul").sortable({axis:"x", containment:"#projects"});
    $("ol").sortable({axis:"y", containment:"#projects"});
}