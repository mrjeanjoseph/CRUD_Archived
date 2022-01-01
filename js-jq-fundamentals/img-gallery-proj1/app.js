
const gallery = document.getElementById("gallery");
const popup = document.getElementById("popup");
const selectedImage = document.getElementById("selectedImage");
const imageIndexes = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
indexes = [];
const selectedIndexes = null;

for(var i = 1; i< 15; i++ ) {
    //console.log(`${i},`);
    indexes += `${i},`;

}
console.log(indexes.length);

imageIndexes.forEach((i) => {
    const image = document.createElement("img");
    image.src = `/images/img${i}.jpg`;
    image.alt = `Cover for ${i} of the impage folder`;
    image.classList.add("galleryImg");

    image.addEventListener("click", () => {
        //Popup stuff --
        popup.style.transform = `translateY(0)`;
        selectedImage.src = `/images/img${i}.jpg`;
        image.alt = `Cover for ${i} of the impage folder`;
    });

    gallery.appendChild(image);
});

popup.addEventListener("click", () => {
    popup.style.transform = "translateY(-100%)";
    popup.src = "";
    popup.alt = "";
});