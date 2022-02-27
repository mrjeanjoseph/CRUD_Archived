const searchPage = document.querySelector('#search-page');
const searchResult = document.querySelector('#search-result');
const btn = document.querySelector('#btn');
const form = document.querySelector('#form');

const search = document.querySelector('#search');
const results = document.querySelector('#results');
const offlinePage = document.querySelector('#offline-page');
const searchTitle = document.querySelector('#search-title');
const message = document.querySelector('#message');

const detailsPage = document.querySelector('#details-page');
const cardName = document.querySelector('#card-name');
const title = document.querySelector('#title');
const rating = document.querySelector('#rating');
const date = document.querySelector('#date');
const img = document.querySelector('#card-img');
const description = document.querySelector('#description');
const body = document.querySelector('#body');


form.addEventListener('submit', (e) => {
    e.preventDefault();
    handleEvents();
});

function handleEvents() {
    // console.log("Test - "+ window.navigator.onLine);
    if (window.navigator.onLine) {
        searchResult.style.display = "block";
        searchPage.style.display = "none";

        const title = search.value;
        if(title){
            searchTitle.innerText = title;
            showMovies();
            search.value = "";
        } else {
            searchTitle.innerText = "No Title";
            searchPage.style.display = "none";
            offlinePage.style.display = "flex";
            message.innerHTML = "Type something to search";
        }
    } else {
        searchPage.style.display = "none";
        offlinePage.style.display = "flex";
    }
}

function showMovies(){

}