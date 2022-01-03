$(document).ready(function() {
    $("#projects").tabs();
    $("ul").sortable({axis:"x", containment: "#projects"});
    $("ol").sortable({axis:"y", containment: "#projects"});
    $("#btnAddProject").button().click(function() {
        $("#project-dialog").dialog({
            width:400, 
            resizable:false,
            modal:true,
            buttons:{
                "Add new project": function() {},
                "Cancel":function(){
                    // $(this).val("");
                    $(this).dialog("close");
                },    
            }
        });
    });

    // var theColorIs = $('#ui-id-1').css("background-color");
    // console.log(theColorIs);
})

