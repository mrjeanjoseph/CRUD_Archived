$(document).ready(function () {
    var $select = $("<select></select>");

    $("#mainmenu").append($select);

    $select.change(function (e) {
        e.preventDefault();
        window.location = $select.val();
    })

    $("#mainmenu a").each(function () {
        
        var $option = $("<option></option>");
        $option.val($(this).attr("href"));
        $option.text($(this).text());

        if ($(this).parent().hasClass("selected")) {
            $option.prop("selected", true);
        }
        $select.append($option);
    })
})