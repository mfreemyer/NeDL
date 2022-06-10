﻿const uri = 'api/hiitexercises';
let exercises = [];

function getItems() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}

function addItem() {
    const addNameTextbox = document.getElementById('add-name');
    const addPmgTextbox = document.getElementById('add-pmg');
    const addEquipmentTextbox = document.getElementById('add-equipment');

    const item = {
        /*isComplete: false,*/
        name: addNameTextbox.value.trim(),
        pmg: addPmgTextbox.value.trim(),
        equipment: addEquipmentTextbox.value.trim()
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(response => response.json())
        .then(() => {
            getItems();
            addNameTextbox.value = '';
            addPmgTextbox.value = '';
            addEquipmentTextbox.value = '';
        })
        .catch(error => console.error('Unable to add item.', error));
}

function deleteItem(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to delete item.', error));
}

function displayEditForm(id) {
    const item = exercises.find(item => item.id === id);

    document.getElementById('edit-name').value = item.name;
    document.getElementById('edit-pmg').value = item.pmg;
    document.getElementById('edit-equipment').value = item.equipment;
    document.getElementById('edit-id').value = item.id;
    /*document.getElementById('edit-isComplete').checked = item.isComplete;*/
    document.getElementById('editForm').style.display = 'block';
}

function updateItem() {
    const itemId = document.getElementById('edit-id').value;
    const item = {
        id: parseInt(itemId, 10),
        /*isComplete: document.getElementById('edit-isComplete').checked,*/
        name: document.getElementById('edit-name').value.trim(),
        pmg: document.getElementById('edit-pmg').value.trim(),
        equipment: document.getElementById('edit-equipment').value.trim()
    };

    fetch(`${uri}/${itemId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to update item.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayCount(itemCount) {
    const name = (itemCount === 1) ? 'exercise' : 'exercises';

    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

function _displayItems(data) {
    const tBody = document.getElementById('exercises');
    tBody.innerHTML = '';

    _displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(item => {
        //let isCompleteCheckbox = document.createElement('input');
        //isCompleteCheckbox.type = 'checkbox';
        //isCompleteCheckbox.disabled = true;
        //isCompleteCheckbox.checked = item.isComplete;

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${item.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteItem(${item.id})`);

        let tr = tBody.insertRow();

        //let td1 = tr.insertCell(0);
        //td1.appendChild(isCompleteCheckbox);

        let td1 = tr.insertCell(0);
        let textNode = document.createTextNode(item.name);
        td1.appendChild(textNode);

        let td2 = tr.insertCell(1);
        textNode = document.createTextNode(item.pmg);
        td2.appendChild(textNode);

        let td3 = tr.insertCell(2);
        textNode = document.createTextNode(item.equipment);
        td3.appendChild(textNode);

        let td4 = tr.insertCell(3);
        td4.appendChild(editButton);

        let td5 = tr.insertCell(4);
        td5.appendChild(deleteButton);
    });

    exercises = data;
}