const months = ["January","February","March","April","May","June","July","August","September","October","November","December"];
const weekdays = ["Sun","Mon","Tue","Wed","Thu","Fri","Sat"];

const giveaway = document.querySelector(".giveaway");
const deadLine = document.querySelector(".deadline");
const items = document.querySelectorAll(".deadline-format h4");

// console.log(items);

let futureDate = new Date(2022, 0, 9, 17, 0);
console.log(futureDate);