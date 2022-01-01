const months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
const weekdays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

const giveaway = document.querySelector(".giveaway");
const deadLine = document.querySelector(".deadline");
const items = document.querySelectorAll(".deadline-format h4");

// console.log(items);

let tempDate = new Date();
let tempYear = tempDate.getFullYear();
let tempMonth = tempDate.getMonth();
let tempDay = tempDate.getDate();

// let futureDate = new Date(2022, 0, 9, 20, 15);
const futureDate = new Date(tempYear, tempMonth, tempDay + 1, 11, 30, 0);
// let futureDate = new Date();
// console.log(futureDate);

const year = futureDate.getFullYear();

// let month = futureDate.getMonth();
// month = months[month]
let month = months[futureDate.getMonth()];

let date = futureDate.getDate();

// let weekday = futureDate.getDay();
// weekday = weekdays[futureDate.getDay()];
let weekday = weekdays[futureDate.getDay()];

const hours = futureDate.getHours();
const minutes = futureDate.getMinutes();

// const seconds = futureDate.getSeconds();
// console.log(weekday)
// console.log(months[month])
// console.log(`${year} ${hours}:${minutes} ${seconds}`);

let giveawayDate = `${weekday} ${month} ${date}th, ${year} at ${hours}:${format(minutes)}pm`;
giveaway.textContent = `giveaway ends on ${giveawayDate} `;

//Future time in ms
const futureTime = futureDate.getTime();
console.log(futureTime);

function getRemainingTime() {
    const today = new Date().getTime();
    // console.log(todays);

    const t = futureTime - today;
    // console.log(t)

    //getting values in ms for oneday
    const oneDay = 24 * 60 * 60 * 1000;
    const oneHour = 60 * 60 * 1000;
    const oneMinute = 60 * 1000;
    // console.log(oneDay);

    let days = Math.floor(t / oneDay);
    // console.log(days);

    let hours = Math.floor((t % oneDay) / oneHour);
    // console.log(hours);

    let minutes = Math.floor((t % oneHour) / oneMinute);
    // console.log(minutes);

    let seconds = Math.floor((t % oneMinute) / 1000);
    // console.log(seconds);

    //set values array;
    const values = [days, hours, minutes, seconds];


    items.forEach((item, index) => {
        item.innerHTML = format(values[index]);
    });
    let dealineMessage = `<h4 class="expired">Sorry, this giveaway has expired!</h4>`
    if(t< 0){
        giveaway.innerHTML = dealineMessage;
        deadLine.innerHTML = "";
    }
}

//countdown
let countdown = setInterval(getRemainingTime, 1000)
function format(item) {
    if (item < 10) {
        return item = `0${item}`
    }
    return item;
}
getRemainingTime();