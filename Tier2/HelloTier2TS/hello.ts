
function myFunction() {
    let newname : string = "";
    newname = (<HTMLInputElement>document.getElementById("fname")).value;
    document.getElementById("greeting").innerHTML = "Hello there, " + newname + "!";
}