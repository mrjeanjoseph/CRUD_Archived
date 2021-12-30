
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

form.addEventListener("submit",addItem);

function addItem(e){
    e.preventDefault();
    // console.log(grocery.value);
    const value = grocery.value;
    const id = new Date().getTime().toString();
    // console.log(id)
    if(value !== "" && editFlag === false) {
        console.log("Adding items");
    } else if (value !=="" && editFlag === true) {
        console.log("editing");
    } else {
        // console.log("empty value")
        // alert.textContent = "Please enter a value";
        // alert.classList.add("alert-danger")
        displayAlert("Please enter a value", "danger")
    }
}

function displayAlert(text, action) {
    alert.textContent = text;
    alert.classList.add(`alert-${action}`);
    //only display alert message for short period of time.
    setTimeout(() => {
        alert.textContent = "";
        alert.classList.remove(`alert-${action}`);
    },3000)
}