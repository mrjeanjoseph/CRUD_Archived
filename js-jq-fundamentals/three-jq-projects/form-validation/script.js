$("form span").hide();

$("#password").keyup(errorMessageEvent).keyup(enableButton);
$("#confirm-pass").keyup(matchedPass).keyup(enableButton);;

function isPassValid() {
    return $("#password").val().length > 5;
}

function isPassMatching() {
    return $("#confirm-pass").val() === $("#password").val();
}

function errorMessageEvent() {
    if (isPassValid()) {
        $(this).next().hide();
    } else {
        $(this).next().show();
    }
}

function matchedPass() {
    if (isPassMatching()) {
        $(this).next().hide();
    } else {
        $(this).next().show();
    }
}

function isBtnEnabled() {
    return isPassValid() && isPassMatching();
}

function enableButton() {
    $("#submit").prop("disabled", !isBtnEnabled);
    if(!isBtnEnabled()) {
        $("#submit").css({
            backgroundColor: "grey", 
            color: "whitesmoke",
            cursor: "not-allowed"
        })
    } else {
        $("#submit").css({backgroundColor: "#546de5;", color: "whitesmoke"})
    }
}