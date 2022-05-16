// addItem(), deleteItem(), checkItem()
/* const createId = (str) => {
    return `id_${str.replace(/ /ig, '_')}`;
  } */
function addItem() {
    var newItem = document.forms["manageItems"]["toDoItem"].value;
    if (newItem == "") {
        alert("Please enter a to-do item.");
        return false;
    }
    else {
        var tableRef = document.getElementById("toDoTable");
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = newItem;
        document.forms["manageItems"]["toDoItem"].value = ""; // clears the input field after the value has been added to the list.
        /* return true; */
    }
}
//==============================================
function deleteItem() {
    // get word to delete from form
    var wordToDelete = document.forms["manageItems"]["toDoItem"].value;
    alert("aaarrrrgh!");
    // validation
    if (wordToDelete == "") {
        alert("Please enter a value in the To-Do Item field.");
        return false;
    }
    // once valid value has been entered
    else {
        // initialize variables
        var found = false;
        var tableRef = document.getElementById("toDoTable");
        // loop through to-do list
        for (var index = 0; index < tableRef.rows.length; index++) {
            // if match is found
            if ((tableRef.rows[index].innerHTML).toLowerCase() == (wordToDelete).toLowerCase()) {
                // set to true
                found = true;
                // remove the first matching element from the list
                tableRef.rows[index].remove();
                // break out of the loop
                break;
            }
        }
        // alert if no match found
        if (found == false) {
            alert("This value is not found in the list. Please try again.");
        }
    }
}
//==============================================
function clearList() {
    var tableRef = document.getElementById("toDoTable");
    tableRef.innerHTML = "";
}
