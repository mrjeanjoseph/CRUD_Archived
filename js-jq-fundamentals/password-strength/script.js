const strengthMeter = document.getElementById("strength-meter");
const passwordInput = document.getElementById("password-input");
const reasonsContainer = document.getElementById("reasons");

passwordInput.addEventListener("input", updateStrengthMeter);

function updateStrengthMeter() {
    const weaknesses = calculatePasswordStrength(passwordInput.value);
    //console.log(weaknesses);

    let strength = 100;
    reasonsContainer.innerHTML = '';

    weaknesses.forEach( function(weakness) {
        if (weakness == null) return;
        strength -= weakness.deduction;
    })
    strengthMeter.style.setProperty('--strength', strength);
}

function calculatePasswordStrength(password) {
    const weaknesses = [];
    weaknesses.push(lengthWeakness(password))
    return weaknesses;
};

function lengthWeakness(password) {
    const length = password.length;
    if(length <= 0) {return{message:"",deduction:100}}

    if (length <= 5) {
        return {
            message: "Your password is too short",
            deduction: 50
        }
    }

    if (length <= 10) {
        return {
            message: "Your password could be longer",
            deduction: 15
        }
    }
}