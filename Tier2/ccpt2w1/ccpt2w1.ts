// addItem(), deleteItem(), checkItem()

function addItem() {
    var newItem = document.forms["manageItems"]["toDoItem"].value;

    if (newItem == "") {
        alert("Please enter a to-do item.")
        return false;
    }
    else {
        var tableRef = document.getElementById("toDoTable") as HTMLTableElement;
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = newItem
        document.forms["manageItems"]["toDoItem"].value = ""; // clears the input field after the value has been added to the list.
        /* return true; */
    }
}

function deleteItem() {
    /* var tableRef = document.getElementById("toDoTable") as HTMLTableElement; */
    var itemToRemove = document.forms["manageItems"]["toDoItem"].value;

    /* (tableRef.deleteRow(tableRef.rows.length)).innerHTML = newItem */
    /* document.getElementById("tableRef").deleteRow("itemToRemove"); */
    /* document.getElementById("tableRef").innerHTML = document.getElementById("tableRef").innerHTML.replace(itemToRemove,itemToRemove.strike()); */
    /* document.getElementById("tableRef").innerHTML.deleteRow(0); */ // trying to delete first row, just to see if i can...
    alert("Whyyyyy can't I figure out the delete?!?!?!" ) 
    
    
    

}

function clearList() {
    var tableRef = document.getElementById("toDoTable");
    tableRef.innerHTML = ""; 
}