function autenticate()
{
    var username=document.getElementById("username").value;
    var password=document.getElementById("password").value;

    if(username=="user"&& password=="password"){
        alert("login successful!");
        return false;
    }
    else{
        alert("login failed!");
        alert("Try again");
    }
}