
document.addEventListener('DOMContentLoaded', () => {
    const squares = document.querySelectorAll('.grid div');
    const scoreDisplay = document.querySelector('span');
    const startBtn = document.querySelector('.start');

    const width = 10;
    let currentIndex = 0 // So the first div in our grid
    let appleIndex = 0;// So the first div in our grid
    let currentSnake = [2, 1, 0];
    //So the div in our grid being 2 being the head and 0 bing the end (TAIL, will all 1s being the body from now on.)
    let direction = 1;
    let score= 0;
    let speed = 0.9;
    let intervalTime = 0;
    let interval = 0;
})