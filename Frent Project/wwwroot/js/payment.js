const payButton = document.querySelector('.pay-button');
const popUp = document.querySelector('.blackscreen');

payButton.addEventListener('click', e => {
    popUp.style.visibility = 'visible';
})

popUp.addEventListener('click', e =>{
    window.location.href = 'Home';
})