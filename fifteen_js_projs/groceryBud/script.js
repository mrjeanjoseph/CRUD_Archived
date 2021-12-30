
const alert = document.querySelector(".alert");
const form = document.querySelector(".grocery-form");
const grocery = document.querySelector("#grocery");
const submitBtn = document.querySelector(".submit-btn");
const container = document.querySelector(".grocery-container");
const list = document.querySelector(".grocery-list");
const clearBtn = document.querySelector(".clear-btn");

let editElement;
let editFlag = false;
let editId = "";

form.addEventListener("submit", addItem); //Submitting the form
clearBtn.addEventListener("click", clearItems);
window.addEventListener("DOMContentLoaded", loadItemsFromLocalStorage)

function addItem(e) {
    e.preventDefault();
    // console.log(grocery.value);
    const value = grocery.value;
    const id = new Date().getTime().toString();
    // console.log(id)
    // console.log(value)
    if (value && !editFlag) {
        // console.log("Adding items");
        createListItem(id, value);
        displayAlert("Item added to the list", "success"); // on success display message
        container.classList.add("show-container") // make container visible on success

        addToLocalStorage(id, value); // This will save our data in local mem
        setBackToDefault(); //This will clear out local mem
    } else if (value !== "" && editFlag === true) {
        // console.log("editing");
        editElement.innerHTML = value;
        displayAlert("value changed", "success");
        //editLocalStorage(editId, value);
        setBackToDefault();
    } else {
        // console.log("empty value")
        // alert.textContent = "Please enter a value";
        // alert.classList.add("alert-danger")
        displayAlert("Please enter a value", "danger")
    }
}

function displayAlert(text, action) { // turn alert into a function to avoid duplicate
    alert.textContent = text;
    alert.classList.add(`alert-${action}`);
    //only display alert message for short period of time.
    setTimeout(() => {
        alert.textContent = "";
        alert.classList.remove(`alert-${action}`);
    }, 3000)
}

function setBackToDefault() {
    // console.log("added to local storage");
    grocery.value = "";
    editFlag = false;
    editId = "";
    submitBtn.textContent = "submit";
}

function clearItems() { //Clearing the item list
    const items = document.querySelectorAll(".grocery-item");

    if (items.length > 0) {
        items.forEach(function (item) {
            list.removeChild(item)
        });
    }
    container.classList.remove("show-container");
    displayAlert("Item list has been cleared", "danger");
    setBackToDefault();
    localStorage.removeItem("list")
}

function deleteItem(e) {
    const element = e.currentTarget.parentElement.parentElement;
    const id = element.dataset.id;
    list.removeChild(element);
    if (list.children.lenght === 0) {
        container.classList.remove("show-container");
    }
    displayAlert("Item has been removed", "danger");
    setBackToDefault();
    // remove from local storage
    removeFromLocalStorage(id);
}

function editItem(e) {
    const element = e.currentTarget.parentElement.parentElement;
    editElement = e.currentTarget.parentElement.previousElementSibling;
    grocery.value = editElement.innerHTML;
    editFlag = true;
    editId = element.dataset.id;
    submitBtn.textContent = 'edit';

    displayAlert("Item is being edited", "danger");
}



function addToLocalStorage(id, value) {
    // console.log("back to default")
    const grocery = { id: id, value: value }; // this can shorten like this {id, value}
    // console.log(grocery);
    let items = getLocalStorage();
    // console.log(items)
    items.push(grocery);
    localStorage.setItem("list", JSON.stringify(items));
    // console.log(items);

}

function getLocalStorage() {
    return localStorage.getItem("list") ? JSON.parse(localStorage.getItem("list")) : [];
}

function removeFromLocalStorage(id) {
    let items = getLocalStorage();
    items = items.filter(function (item) {
        if (item.id !== id) {
            return item;
        }
    });
    localStorage.setItem("list", JSON.stringify(items));
}

function editLocalStorage(id, value) {
    let items = getLocalStorage();
    items = items.map(function (item) {
        if (item.id === id) {
            item.value = value;
        }
        return item;
    });
    localStorage.setItem("list", JSON.stringify(items));
}

function loadItemsFromLocalStorage() {
    let items = getLocalStorage();
    if (items.length > 0) {
        items.forEach(function (item) {
            createListItem(item.id, item.value)
        });
        container.classList.add("show-container");
    }
}

function createListItem(id, value) {
    const element = document.createElement("article");
    element.classList.add("grocery-item"); // adding the class
    const attr = document.createAttribute("data-id"); // adding the id attr
    attr.value = id;
    element.setAttributeNode(attr);
    element.innerHTML = `
    <p class="title">${value}</p>
    <div class="btn-container">
        <button type="button" class="edit-btn">
            <i class="fas fa-edit"></i>
        </button>
        <button type="button" class="delete-btn">
            <i class="fas fa-trash"></i>
        </button>
    </div>`;

    const deleteBtn = element.querySelector(".delete-btn");//access the delete class inside the element
    const editBtn = element.querySelector(".edit-btn");//access the edit class inside the element

    deleteBtn.addEventListener("click", deleteItem);
    editBtn.addEventListener("click", editItem);

    list.appendChild(element); // this is to append the html items above
}

// localStorage.setItem("orange", JSON.stringify(["item", "item2"]));
// const oranges = JSON.parse(localStorage.getItem("orange"));
// console.log(oranges)

// localStorage.removeItem("orange");
// console.log(oranges);