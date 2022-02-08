const menu = document.querySelector("#mobile-menu");
const menuLinks = document.querySelector(".navbar__menu");

menu.addEventListener("click", function() {
    menu.classList.toggle("is-active");
    menuLinks.classList.toggle("active");
});

window.onbeforeunload = function(e) {
    e.preventDefault();
    localStorage.setItem('scrollpos', window.scrollY);
};  


// alert(document.body.clientWidth);