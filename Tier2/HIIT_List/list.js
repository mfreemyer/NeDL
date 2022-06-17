function validateAndAdd() {
    // put the values in the form into the variables
    var theNewExercise = document.forms["myForm"]["newExercise"].value;
    var theNewNumber = document.forms["myForm"]["newNumber"].value;
    // validate that something was entered for exercise
    if (theNewExercise == "") {
        alert("Please enter a word to check.");
        return false;
    }

    // since we now have valid data, add it to the table
    var tableRef = document.getElementById("myList");
    (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewExercise;

    // erase the form fields
    document.forms["myForm"]["newExercise"].value = "";
    document.forms["myForm"]["newNumber"].value = "";
    return true;
}

    function clearList1() {
        var tableRef = document.getElementById("myList1");
        tableRef.innerHTML = "";
    }

    /* function clearList2() {
        var tableRef = document.getElementById("myList2");
        tableRef.innerHTML = "";
    } */


