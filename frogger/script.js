document.addEventListener('DOMContentLoaded', () => {
    const squres = document.querySelectorAll('.grid div');
    const timeLeft = document.querySelector('#time-left');
    const result = document.querySelector('#result');
    const startBtn = document.querySelector('#button');
    const width = 9;
    const currentIndex = 76;
    let timerId;

    //redender frog on starting block
    squres[currentIndex].classList.add('frog');

    //A function that will move the frong
});