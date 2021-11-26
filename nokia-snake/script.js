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
    let interval = 0;

    //to start, and restart the game
    function startGame() {
        currentSnake.forEach(index => squares[index].classList.remove('snake'))
        squares[appleIndex].classList.remove('apple');
        clearInterval(interval);
        score = 0;
        //randomApple()
        direction = 1;
        scoreDisplay.innerText = score;
        intervalTime = 1000;
        currentSnake = [2, 1, 0];
        currentSnake.forEach(index => squares[index].classList.add('snake'));
        interval = setInterval(moveOutcomes, intervalTime);
    }

    //function that deals with All the move outcomes of the Snake
    function moveOutcomes() {
        //Deals with snake hitting border and snake hitting itself
        if ((currentSnake[0] + width >= (width * width) && direction === width) ||
            (currentSnake[0] % width === width - 1 && direction === 1) ||
            (currentSnake[0] % width === 0 && direction === -1) ||
            (currentSnake[0] - width < 0 && direction === -width) ||
            squares[currentIndex[0] + direction].classList.contains('snake')) {
            return clearInterval(interval)//This will clear the interval if any of the above happen
        }
        const tail = currentSnake.pop();
        squares[tail].classList.remove('snake');
        currentSnake.unshift(currentSnake[0] + direction);

        //Deals with snake getting apple
        if (squares[currentSnake[0]].classList.contains('apple')) {
            squares[currentSnake[0]].classList.remove('apple')
            squares[tail].classList.add('snake')
            currentSnake.push(tail);
            //randomApple()
            score++;
            scoreDisplay.textContent = score;
            clearInterval(interval);
            intervalTime = intervalTime * speed;
            interval = setInterval(moveOutcomes, intervalTime);
        }
        squares[currentSnake[0]].classList.add('snake');
    }





    //assigning function to keycodes
    function control(e) {
        //We are removing the class of snake from all squares.
        squares[currentIndex].classList.remove('snake');
        if (e.keycode === 39) {
            direction = 1; //If we press the right arrow on our keyboard, the snake will go right one
        } else if (e.keycode === 38) {
            direction = -width; //pressing the up arrow, the snake will go back ten div
        } else if (e.keycode === 38) {
            direction = -1;
        } else if (e.keycode === 40) {
            direction = +width; //pressing the down arrow, the snake head will appear
        }
    }

    document.addEventListener('keyup', control);
    startBtn.addEventListener('click', startGame);

})