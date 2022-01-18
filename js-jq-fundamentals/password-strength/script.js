const strengthMeter = document.getElementById("strength-meter");
const passwordInput = document.getElementById("password-input");
const reasonsContainer = document.getElementById("reasons");

passwordInput.addEventListener("input", updateStrengthMeter);

function updateStrengthMeter() {
    const weaknesses = calculatePasswordStrength(passwordInput.value);
    //console.log(weaknesses);

    let strength = 100;
    reasonsContainer.innerHTML = '';

    weaknesses.forEach(function (weakness) {
        if (weakness == null) return;
        strength -= weakness.deduction;

        const messageElement = document.createElement("div");
        messageElement.innerHTML = weakness.message;
        reasonsContainer.appendChild(messageElement);
    })
    strengthMeter.style.setProperty('--strength', strength);
}

function calculatePasswordStrength(password) {
    const weaknesses = [];
    weaknesses.push(lowercaseWeakness(password));
    weaknesses.push(uppercaseWeakness(password));
    weaknesses.push(lengthWeakness(password));
    weaknesses.push(numberWeakness(password));
    weaknesses.push(specialCharWeakness(password));
    weaknesses.push(repeatCharWeakness(password));
    return weaknesses;
};

function lengthWeakness(password) {
    const length = password.length;

    if (length <= 4) { return { message: "", deduction: 100 } }

    if (length <= 8) {
        return {
            message: "Your password is too short",
            deduction: 75
        }
    }

    if (length <= 12) {
        return {
            message: "Your password could be longer",
            deduction: 15
        }
    } else return { message: "", deduction: 0 }

}

function lowercaseWeakness(password) {
    return characterTypeWeakness(password, /[a-z]/g, 'lowercase');
}

function uppercaseWeakness(password) {
    return characterTypeWeakness(password, /[A-Z]/g, 'uppercase');
}

function numberWeakness(password) {
    return characterTypeWeakness(password, /[0-9]/g, 'numeric');
}

function specialCharWeakness(password) {
    /* /[^0-9a-zA-Z]/s This is checking for anything not upper, lower and number */
    return characterTypeWeakness(password, /[^0-9a-zA-Z\s]/g, 'special');
}


function characterTypeWeakness(password, regex, type) {
    const matches = password.match(regex) || [];

    if (matches.length <= 1) {
        return {
            message: `You need at lease two ${type} characters.`,
            deduction: 20
        }
    }

    if (matches.length === 2) {
        return {
            message: `Your password could use more ${type} characters`,
            deduction: 5
        }
    }
}

function repeatCharWeakness(password) {
    const matches = password.match(/(.)\1/g) || [];

    if(matches.length > 0){
        return {
            message: 'You have repeat characters',
            deduction: matches.length * 5
        }
    }

}