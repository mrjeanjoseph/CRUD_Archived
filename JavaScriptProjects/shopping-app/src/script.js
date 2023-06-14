//Initializing Dexie

const db = new Dexie('ShoppingApp');
db.version(1).stores( {items: '++id, name, price, isPurchased'});

//Accessing the DOM
const itemForm = document.querySelector("#itemForm");
const itemsDiv = document.querySelector("#itemsDiv");
const totalPriceDiv = document.querySelector("#totalPriceDiv");


itemForm.onsubmit = async (event) => {
    event.preventDefault();

    const name = document.querySelector("#nameInput").value;
    const quantity = document.querySelector("#quantityInput").value;
    const price = document.querySelector("#priceInput").value;

    await db.items.add({
        name,
        quantity,
        price
    })
    itemForm.reset();

}