$("form span").hide();

$("#password").mouseout(errorMessageEvent);
$("#confirm-pass").mouseout(matchedPass);

function isPassValid() {
    return $("#password").val().length > 12;
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
