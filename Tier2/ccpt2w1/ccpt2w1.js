// addItem(), deleteItem(), checkItem()

function addItem() {
    var newItem = document.forms["manageItems"]["toDoItem"].value;

    if (newItem == "") {
        alert("Please enter a to-do item.")
        return false;
    }
    else {
        var tableRef = document.getElementById("toDoTable");
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = newItem
    }
}
