

// Dynamically update the year 
const date = document.querySelector("#date");
date.innerHTML = new Date().getFullYear();

const navToggle = document.querySelector(".nav-toggle");
const linksContainer = document.querySelector(".links-container");
const links = document.querySelector(".links");

navToggle.addEventListener("click", function(){
    //This is for hard coded height value 
    // linksContainer.classList.toggle("show-links");
    const containerHeight = linksContainer.getBoundingClientRect();
    console.log(containerHeight);
})