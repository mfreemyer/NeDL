// addItem(), deleteItem(), checkItem()
var createId = function (str) {
    return "id_".concat(str.replace(/ /ig, '_'));
};
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
    var tableRef = document.getElementById('toDoTable');
    var itemToRemove = document.forms['manageItems']['toDoItem'].value;
    if (itemToRemove == '') {
        alert('Please enter an item to delete.');
        return false;
    }
    else {
        /** search by attribute and delete */
        var tr = document.querySelector("[data-id=\"".concat(createId(itemToRemove), "\"]"));
        if (!tr) {
            alert('This item was not found in the list.');
            return false;
        }
        else {
            tr.remove();
            /* tableRef.value = ''; */
            document.forms['manageItems']['toDoItem'].value = ''; // clears the input field after the value has been added to the list.
        }
    }
}
//==============================================
function clearList() {
    var tableRef = document.getElementById("toDoTable");
    tableRef.innerHTML = "";
}
