let exerciseArray = [];


/* let name = document.getElementById('add-name');
let pMG = document.getElementById('add-PMG');
let equipment = document.getElementById('add-equipment'); */

function addItem() {
    const addNameTextbox = document.getElementById('add-name');
    const addPmgTextbox = document.getElementById('add-pmg');
    const addEquipmentTextbox = document.getElementById('add-equipment');

    const item = {
        name: addNameTextbox.value.trim(),
        pmg: addPmgTextbox.value.trim(),
        equipment: addEquipmentTextbox.value.trim()
    };

    // fetch(uri, {
    //     method: 'POST',
    //     headers: {
    //         'Accept': 'application/json',
    //         'Content-Type': 'application/json'
    //     },
    //     body: JSON.stringify(item)
    // })
    //     .then(response => response.json())
    //     .then(() => {
    //         getItems();
    //         addNameTextbox.value = '';
    //         addPmgTextbox.value = '';
    //         addEquipmentTextbox.value = '';
    //     })
    //     .catch(error => console.error('Unable to add item.', error));
}