var logform = document.getElementById("logform");
var regform = document.getElementById("regform");
var line = document.getElementById("line");

function register() {
    regform.style.transform = "translateX(0px)";
    logform.style.transform = "translateX(0px)";
    line.style.transform = "translateX(100px)";
}

function login() {
    regform.style.transform = "translateX(300px)";
    logform.style.transform = "translateX(300px)";
    line.style.transform = "translateX(0px)";

}

