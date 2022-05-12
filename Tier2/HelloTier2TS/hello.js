function myFunction() {
    var newname = "";
    newname = document.getElementById("fname").value;
    document.getElementById("greeting").innerHTML = "Hello there, " + newname + "!";
}
