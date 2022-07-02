const calendarButton = document.querySelector('.cal');
const calendar = document.querySelector('.cal-popup');

calendarButton.addEventListener('click', e=>{
    if(calendar.style.display === 'none'){
        calendar.style.display = 'block';
    }
    else calendar.style.display = 'none';
})