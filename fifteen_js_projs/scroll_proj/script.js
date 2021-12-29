

// Dynamically update the year 
const date = document.querySelector("#date");
date.innerHTML = new Date().getFullYear();

//working with the toggler
const navToggle = document.querySelector(".nav-toggle");
const linksContainer = document.querySelector(".links-container");
const links = document.querySelector(".links");

navToggle.addEventListener("click", function () {
    //This is for hard coded height value 
    // linksContainer.classList.toggle("show-links");
    const containerHeight = linksContainer.getBoundingClientRect().height;
    // console.log(containerHeight);
    const linksHeight = links.getBoundingClientRect().height;
    // console.log(linksHeight);
    if (containerHeight === 0) {
        linksContainer.style.height = `${linksHeight}px`;
    } else {
        linksContainer.style.height = 0;
    }
})

const navbar = document.querySelector(".nav");
const topLink = document.querySelector(".top-link");
// working with the nav bar
window.addEventListener("scroll", function(){
    // console.log(window.pageYOffset);
    const scrollHeight = window.pageYOffset;
    const navHeight = navbar.getBoundingClientRect().height;
    if(scrollHeight > navHeight) {
        navbar.classList.add("fixed-nav");
    } else {
        navbar.classList.remove("fixed-nav");
    }

    if(scrollHeight > 50) {
        topLink.classList.add("show-link");
    }else {
        topLink.classList.remove("show-link");
    }

});

