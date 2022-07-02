
const dropDown = document.querySelector('.nav-dropdown');
const droppedContent = document.querySelector('.dropped');

dropDown.addEventListener('click', e=>{
    if(dropDown.style.transform === 'rotate(180deg)'){
        dropDown.style.transform = 'rotate(0deg)';
        droppedContent.style.visibility = 'hidden';
    }
    else{
        dropDown.style.transform = 'rotate(180deg)';
        droppedContent.style.visibility = 'visible';
    }
})
