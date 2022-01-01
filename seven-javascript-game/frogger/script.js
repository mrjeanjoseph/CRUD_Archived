document.addEventListener('DOMContentLoaded', () => {
    const squares = document.querySelectorAll('.grid div');
    const timeLeft = ocument.querySelectorAll('#time-left');
    const result = document.querySelectorAll('#result');
    const startBtn = document.querySelectorAll('#button');

    //init the obstacles
    const carsLeft = document.querySelectorAll('.car-left');
    const carsRight = document.querySelectorAll('.car-right');
    const logsLeft = document.querySelectorAll('.log-left');
    const logsRight = document.querySelectorAll('.log-right');
    
    //env access
    const width = 9;
    let currentTime = 20;
    let currentIndex = 76;
    let timerId;

    //Get the frog moving
    squares[currentIndex].classList.add('frog');

    //the function that will get the frog moving
    function moveFrog(e) {
        squares[currentIndex].classList.remove('frog');
        switch (e.keyCode) {
            case 37:
                if (currentIndex % width !== 0) currentIndex -= 1;
                break;
            case 38:
                if (currentIndex - width >= 0) currentIndex -= width;
                break;
            case 39:
                if (currentIndex % width < width - 1) currentIndex += 1;
                break;
            case 40:
                if (currentIndex + width < width * width) currentIndex += width;
                break
        }
        squares[currentIndex].classList.add('frog');
        lose();
        win();
    }

    //move cars
    function autoMoveCars() {
        carsLeft.forEach(CL => moveCarLeft(CL));
        carsRight.forEach(CR => moveCarLeft(CR));
    }

    //On a timeloop, move cars left
    function moveCarLeft(CL) {
        switch (true) {
            case CL.classList.contains('c1'):
                CL.classList.remove('c1');
                CL.classList.add('c2');
                break;
            case CL.classList.contains('c2'):
                CL.classList.remove('c2');
                CL.classList.add('c3');
                break;
            case CL.classList.contains('c3'):
                CL.classList.remove('c3');
                CL.classList.add('c1');
                break;
        }
    }

    //On a timeloop, move cars left
    function moveCarLeft(CR) {
        switch (true) {
            case CR.classList.contains('c1'):
                CR.classList.remove('c1');
                CR.classList.add('c3');
                break;
            case CR.classList.contains('c2'):
                CR.classList.remove('c2');
                CR.classList.add('c1');
                break;
            case CR.classList.contains('c3'):
                CR.classList.remove('c3');
                CR.classList.add('c2');
                break;
        }
    }

    //move logs
    function autoMoveLogs() {
        logsLeft.forEach(LL => moveCarLeft(LL));
        logsRight.forEach(LR => moveCarLeft(LR));
    }

    //On a timeloop, move logs left
    function moveLogLeft(LL) {
        switch (true) {
            case LL.classList.contains('l1'):
                LL.classList.remove('l1');
                LL.classList.add('l2');
                break;
            case LL.classList.contains('l2'):
                LL.classList.remove('l2');
                LL.classList.add('l3');
                break;
            case LL.classList.contains('l3'):
                LL.classList.remove('l3');
                LL.classList.add('l1');
                break;
            case LL.classList.contains('l4'):
                LL.classList.remove('l4');
                LL.classList.add('l5');
                break;
            case LL.classList.contains('l5'):
                LL.classList.remove('l5');
                LL.classList.add('l1');
                break;
        }
    }

    //On a timeloop, move log right
    function moveLogRight(LR) {
        switch (true) {
            case LR.classList.contains('l1'):
                LR.classList.remove('l1');
                LR.classList.add('l5');
                break;
            case LR.classList.contains('l2'):
                LR.classList.remove('l2');
                LR.classList.add('l1');
                break;
            case LR.classList.contains('l3'):
                LR.classList.remove('l3');
                LR.classList.add('l2');
                break;
            case LR.classList.contains('l4'):
                LR.classList.remove('l4');
                LR.classList.add('l3');
                break;
            case LR.classList.contains('l5'):
                LR.classList.remove('l5');
                LR.classList.add('l4');
                break;
        }
    }

    //rules to win
    function win(){
        if(squares[4].classList.contains('frog')) {
            result.innerHTML = 'YOU WIN';
            squares[currentIndex].classList.remove('frog');
            clearInterval(timerId);
            document.removeEventListener('keyup',moveFrog);
        }
    }
    
    //rules for losers
    if((currentTime === 0) ||
    (squares[currentIndex].classList.contains('c1')) ||
    (squares[currentIndex].classList.contains('l5')) ||
    (squares[currentIndex].classList.contains('l4'))
    ) {
        result.innerHTML = 'YOU LOSE';
        squares[currentIndex].classList.remove('frog');
        clearInterval(timerId)
        document.removeEventListener('keyup',moveFrog);
    }

    //Move frog left on log
    function moveWithLogLeft(){
        if(currentIndex >=27 && currentIndex < 35) {
            squares[currentIndex].classList.remove('frog');
            currentIndex += 1;
            squares[currentIndex].classList.add('frog')
        }
    }
    //Move frog right on log as well
    function moveWithLogRight(){
        if(currentIndex > 18 && currentIndex <= 26) {
            squares[currentIndex].classList.remove('frog');
            currentIndex -= 1;
            squares[currentIndex].classList.add('frog')
        }
    }

    //calling all the functions
    function movePieces(){
        currentIndex--;
        timeLeft.textContent = currentIndex;
        autoMoveCars();
        autoMoveLogs();
        moveWithLogLeft();
        moveWithLogRight();
    }

    startBtn.addEventListener('click',()=>{
        if(timerId){
            clearInterval(timerId)
        } else {
            document.addEventListener('keyup',moveFrog)
        }
    });
    
})