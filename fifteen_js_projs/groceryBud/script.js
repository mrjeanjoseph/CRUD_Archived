
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

form.addEventListener("submit", addItem);

function addItem(e) {
    e.preventDefault();
    // console.log(grocery.value);
    const value = grocery.value;
    const id = new Date().getTime().toString();
    // console.log(id)
    // console.log(value)
    if (value !== "" && editFlag === false) {
        // console.log("Adding items");
        const element = document.createElement("article");
        element.classList.add("grocery-item"); // adding the class
        const attr = document.createAttribute("data-id"); // adding the id attr
        attr.value = id;
        element.setAttributeNode(attr);
        element.innerTHML = `
        <p class="title">${value}</p>
        <div class="btn-container">
            <button type="button" class="edit-btn">
                <i class="fas fa-edit"></i>
            </button>
            <button type="button" class="delete-btn">
                <i class="fas fa-trash"></i>
            </button>
        </div>`;
        list.appendChild(element); // this is to append the html items above
        displayAlert("Item added to the list", "success"); // on success display message
        container.classList.add("show-container") // make container visible on success

        addToLocalStorage(id, value); // This will save our data in local mem
        setBackToDefault(); //This will clear out local mem
    } else if (value !== "" && editFlag === true) {
        console.log("editing");
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

function addToLocalStorage(id, value) {
    console.log("back to default")
}

function setBackToDefault() {
    console.log("added to local storage")
}