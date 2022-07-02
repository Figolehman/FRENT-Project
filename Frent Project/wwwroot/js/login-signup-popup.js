const signupButton = document.querySelector('#signup-button');
const loginButton = document.querySelector('#login-button');
const startButton = document.querySelector('.start-button');
const loginClose = document.querySelector('#CloseForm-LogIn img');
const signupClose = document.querySelector('#CloseForm-SignUp img');
const signupPopup = document.querySelector('#signup-screen');
const loginPopup = document.querySelector('#login-screen');

const toggleVisibility = (popup) => {
    if (popup.style.visibility === 'hidden') {
        popup.style.visibility = 'visible';
    } else {
        popup.style.visibility = 'hidden';
    }
}

signupButton.addEventListener('click', e=>{
    toggleVisibility(signupPopup);
});
loginButton.addEventListener('click', e=>{
    toggleVisibility(loginPopup);
});
loginClose.addEventListener('click', e=>{
    toggleVisibility(loginPopup);
});
signupClose.addEventListener('click', e=>{
    toggleVisibility(signupPopup);
});
startButton.addEventListener('click', e=>{
    toggleVisibility(signupPopup);
});
