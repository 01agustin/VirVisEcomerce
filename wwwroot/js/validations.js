//function validateForm() {
//    const form = document.querySelector("form");

//    // Limpiar mensajes de error previos
//    cleanErrors();

//    const email = document.getElementById("email");
//    const password = document.getElementById("password");
//    const confirmPassword = document.getElementById("confirmPassword");
//    const firstname = document.getElementById("firstname");
//    const lastname = document.getElementById("lastname");
//    const username = document.getElementById("username");

//    // Validaciones
//    let isValid = true;

//    if (!validateEmail(email.value)) {
//        showError(email, "Por favor, ingresa un correo electrónico válido.");
//        isValid = false;
//    }

//    if (!validatePasswordFormat(password.value)) {
//        showError(password, "La contraseña debe tener entre 8 y 16 caracteres, incluyendo una mayúscula, una minúscula, un número y un carácter especial.");
//        isValid = false;
//    } else if (!validatePasswordFormat(confirmPassword.value)) {
//        showError(confirmPassword, "La confirmación de contraseña debe tener entre 8 y 16 caracteres, incluyendo una mayúscula, una minúscula, un número y un carácter especial.");
//        isValid = false;
//    } else if (!validateSamePassword(password.value, confirmPassword.value)) {
//        showError(confirmPassword, "Las contraseñas no coinciden.");
//        isValid = false;
//    }

//    [firstname, lastname, username].forEach(field => {
//        if (!validateCompleteness(field.value)) {
//            showError(field, `${field.placeholder} debe tener más de un carácter.`);
//            isValid = false;
//        }
//    })

//    if (isValid) {
//        showSuccessMessage("Registro exitoso!");
//        form.reset();
//        window.location.reload();
//        return true;
//    }

//    return false;
//}

//function showSuccessMessage(mensaje) {
//    const successMessage = document.getElementById("success-message");

//    successMessage.textContent = mensaje;
//    successMessage.classList.remove('hidden');
//    successMessage.style.display = 'block';

//    setTimeout(function () {
//        successMessage.style.display = 'none';
//    }, 50000);
//}


//function validateCompleteness(text) {
//    return text.length > 1;
//}

//function validateEmail(email) {
//    const expression = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
//    return email !== "" && expression.test(email);
//}

//function validateSamePassword(password, confirmPassword) {
//    return password === confirmPassword;
//}

//function validatePasswordFormat(password) {
//    const minLength = 8;
//    const maxLength = 16;
//    const hasUppercase = /[A-Z]/.test(password);
//    const hasLowercase = /[a-z]/.test(password);
//    const hasNumber = /\d/.test(password);
//    const hasSpecialChar = /[!@#$%^&*(),.?":{}|<>]/.test(password);

//    return (password.length >= minLength && password.length <= maxLength) && hasUppercase && hasLowercase && hasNumber && hasSpecialChar;
//}

//function showError(inputElement, message) {
//    const fieldContainer = inputElement.closest('.field'); // Obtenemos el div .field
//    let errorElement = fieldContainer.nextElementSibling; // Verificamos si ya hay un message de error

//    // Si no existe, lo creamos
//    if (!errorElement || !errorElement.classList.contains('error-message')) {
//        errorElement = document.createElement("div");
//        errorElement.className = 'text-danger error-message mt-1';
//        fieldContainer.parentNode.insertBefore(errorElement, fieldContainer.nextSibling); // Insertamos debajo del .field
//    }

//    errorElement.textContent = message;
//}


//function cleanErrors() {
//    const errors = document.querySelectorAll(".text-danger.error-message");
//    errors.forEach(error => {
//        error.remove(); // Limpia completamente el mensaje de error
//    });
//}