// ~/HTML/Home.html

const male = document.querySelector('.MaleText');
const male2 = document.querySelector('.fotoPria');
const female = document.querySelector('.FemaleText');
const female2 = document.querySelector('.fotoWanita');

const checkmale = document.querySelector('.check1');
const checkfemale = document.querySelector('.check2');

const confirmButton = document.querySelector('.confirmBtn')

male.addEventListener('click', e=>{
    checkmale.style.visibility = 'visible';

    male.style.cursor = 'default';
    male2.style.cursor = 'default';

    if(checkfemale.style.visibility === 'visible'){
        checkfemale.style.visibility = 'hidden';

        female.style.cursor = 'pointer';
        female2.style.cursor = 'pointer';
    }
})

male2.addEventListener('click', e=>{
    checkmale.style.visibility = 'visible';

    male.style.cursor = 'default';
    male2.style.cursor = 'default';

    if(checkfemale.style.visibility === 'visible'){
        checkfemale.style.visibility = 'hidden';

        female.style.cursor = 'pointer';
        female2.style.cursor = 'pointer';
    }
})

female.addEventListener('click', e=>{
    checkfemale.style.visibility = 'visible';

    female.style.cursor = 'default';
    female2.style.cursor = 'default';

    if(checkmale.style.visibility === 'visible'){
        checkmale.style.visibility = 'hidden';

        male.style.cursor = 'pointer';
        male2.style.cursor = 'pointer';
    }
})

female2.addEventListener('click', e=>{
    checkfemale.style.visibility = 'visible';

    female.style.cursor = 'default';
    female2.style.cursor = 'default';

    if(checkmale.style.visibility === 'visible'){
        checkmale.style.visibility = 'hidden';

        male.style.cursor = 'pointer';
        male2.style.cursor = 'pointer';
    }
})

confirmButton.addEventListener('click', e=>{
    if(checkmale.style.visibility === 'visible' || checkfemale.style.visibility ==='visible'){
        window.location.href = 'Home';
    }
})