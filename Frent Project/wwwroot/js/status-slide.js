
const onGoing = document.querySelector('#ongoing-slide');
const completed = document.querySelector('#completed-slide');
const onGoingContent = document.querySelector('#ongoing-content');
const completedContent = document.querySelector('#completed-content');

onGoing.addEventListener('click', e=>{
    if(onGoingContent.style.display === 'none'){
        completed.style.cursor = 'pointer';
        completed.style.textDecoration = 'none';
        completed.style.color = 'black';
        onGoing.style.cursor = 'default';
        onGoing.style.textDecoration = 'underline #DF3A3A';
        onGoing.style.color = '#DF3A3A';
        onGoingContent.style.display = 'block';
        completedContent.style.display = 'none';
    }
})

completed.addEventListener('click', e=>{
    console.log('tes');
    if(completedContent.style.display === 'none'){
        onGoing.style.cursor = 'pointer';
        onGoing.style.textDecoration = 'none';
        onGoing.style.color = 'black';
        completed.style.cursor = 'default';
        completed.style.textDecoration = 'underline #DF3A3A';
        completed.style.color = '#DF3A3A';
        completedContent.style.display = 'block';
        onGoingContent.style.display = 'none';
    }
})

const rate = document.querySelector('#rate-button');
const closeForm = document.querySelector('#close-form');
const popUp = document.querySelector('.blackscreen');
const confirmForm = document.querySelector('.confirm-button');

rate.addEventListener('click', e=>{
    popUp.style.display = 'block';
})

closeForm.addEventListener('click', e=>{
    popUp.style.display = 'none';
})

confirmForm.addEventListener('click', e=>{
    popUp.style.display = 'none';
})