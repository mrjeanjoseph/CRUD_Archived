let list = document.querySelectorAll(".navigation li");

function activeLink() {
    list.forEach((item) => item.classList.remove("hovered"));    
    this.classList.add("hovered");
}

list.forEach((item) => item.addEventListener('mouseover', activeLink));

// Menu toggler
let toggle = document.querySelector(".toggle");
let navigation = document.querySelector(".navigation");
let main = document.querySelector(".main");

toggle.onclick = () => {
    navigation.classList.toggle("slideLeft");
    main.classList.toggle("slideLeft");
}