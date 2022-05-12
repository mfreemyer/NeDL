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

    function deleteItem() {
        for (aRow = 0; aRow < (tableRef.rows.length); aRow++) {
            /* document.getElementById("tableRef").deleteRow((tableRef.rows[aRow]).innerHTML === newItem); */
            if ((tableRef.rows[aRow]).innerHTML == addItem) {
                
                /* document.getElementById("tableRef").deleteRow(0); */
                /* (tableRef.updateRow(tableRef.rows.length)).innerHTML ="" */
                /* (tableRef.rows[aRow]).innerHTML = ""; */
                /* addItem + " -- this is the item to delete."; */
            } 
        }
    }
}
