function validateForm() {
    const nameInput = document.getElementById('name');
    const numberInput = document.getElementById('number');
    const emailInput = document.getElementById('email');

    const errorName = document.getElementById('errorName')
    const errorNumber = document.getElementById('errorNumber')
    const errorEmail = document.getElementById('errorEmail')
    const errorsSummary = document.getElementById('errorsSummary')

    resetErrors([nameInput, numberInput, emailInput], [errorName, errorNumber, errorEmail], errorsSummary)

    let valid = true;

    if (!checkRequired(nameInput.value)) {
        valid = false;
        nameInput.classList.add("error-input");
        errorName.innerText = "The field is required";
    }
    else if (!checkTextLengthRange(nameInput.value, 2, 60)) {
        valid = false;
        nameInput.classList.add("error-input");
        errorName.innerText = "The field should contain from 2 to 60 characters"
    }

    if (!checkRequired(numberInput.value)) {
        valid = false;
        numberInput.classList.add("error-input");
        errorNumber.innerText = "The field is required";
    }
    else if (!checkNumber(numberInput.value)) {
        valid = false;
        numberInput.classList.add("error-input");
        errorNumber.innerText = "The field should be a number";
    }
    else if (!checkNumberRange(numberInput.value, 1, 100)) {
        valid = false;
        numberInput.classList.add("error-input");
        errorNumber.innerText = "The field should be a number between 1 and 100"
    }

    if (!checkRequired(emailInput.value)) {
        valid = false;
        emailInput.classList.add("error-input");
        errorEmail.innerText = "The field is required";
    } else if (!checkTextLengthRange(emailInput.value, 5, 60)) {
        valid = false;
        emailInput.classList.add("error-input");
        errorEmail.innerText = "The field should contain from 2 to 60 characters";
    } else if (!checkEmail(emailInput.value)) {
        valid = false;
        emailInput.classList.add("error-input");
        errorEmail.innerText = "The field should contain a valid email address";
    }

    if (!valid) {
        errorsSummary.innerText = "The form contains errors";
    }

    return valid;
}