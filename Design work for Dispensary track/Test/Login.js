// Fade in the login form after page load
window.addEventListener('load', function () {
    const container = document.querySelector('.container');
    container.style.opacity = 1;
});

// Perform login form submission
document.getElementById('login-form').addEventListener('submit', function (event) {
    event.preventDefault(); // Prevent default form submission behavior

    // Perform your login logic here
    // For this example, we'll just display an alert with the entered username and password
    const username = document.getElementById('username').value;
    const password = document.getElementById('password').value;

    alert('Submitted!\nUsername: ' + username + '\nPassword: ' + password);

    // Reset the form
    this.reset();
});