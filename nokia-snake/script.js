document.addEventListener('DOMContentLoaded', () => {
    const squares = document.querySelectorAll('.grid div');
    const scoreDisplay = document.querySelector('span');
    const startBtn = document.querySelector('.start');

    const width = 10;
    let currentIndex = 0; // first div in the grid
    let appleIndex = 0; // also first div in the grid
    // the div in the grid being 2 or the head and being 0 the end so the tail will 1's being the body from now on
    let currentSnake = [2, 1, 0];
    let direction = 1;
    let score = 1;
    let speed = 0;
    let intervalTime = 0;
    let interval =0;

    //assigning function to keycodes
    function control(e){
        //We are removing the class of snkae

    }

})