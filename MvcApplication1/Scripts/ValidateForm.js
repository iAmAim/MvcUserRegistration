

function validateField(field) {
    //var name = document.getElementById("name1").value;
    var fieldName = field.getAttribute("name");
    var validationFieldName = "val-" + fieldName;
    var valField = document.getElementById(validationFieldName);

    var isSuccessful = true;
    if (field.value == null || field.value.trim() == "") {

        valField.innerHTML = "Please enter a valid " + fieldName + " to continue."
        isSuccessful = false;

    }
    else {
        valField.innerHTML = " ";
        isSuccessful = true;

    }

    return isSuccessful;


}


function validateForm() {

    var nameField = document.getElementById("Name");
    var emailField = document.getElementById("Email");
    var passwordField = document.getElementById("Password");

    var allValid, nameValid, passwordValid, emailValid = false;

    emailValid = validateField(emailField);
    nameValid = validateField(nameField);
    passwordValid = validateField(passwordField);

    allValid = emailValid && nameValid && passwordValid;

    return allValid;

}


function clearValidation() {
    /*   later add class=validation to all validation fields  */
    var validations = document.getElementsByClassName("text-validation");
    for (var i = 0; i < validations.length; i++) {
        validations[i].innerHTML = "";
    }

}



