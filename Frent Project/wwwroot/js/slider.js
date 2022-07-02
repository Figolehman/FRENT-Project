const track = document.querySelector('.slidetrack');
const slides = Array.from(track.children);
const rightButton = document.querySelector('.slider-button.right');
const leftButton = document.querySelector('.slider-button.left');
const dotsNav = document.querySelector('.slider-nav');
const dots = Array.from(dotsNav.children);

const slideWidth = slides[0].getBoundingClientRect().width;

slides.forEach((slide, index) => {
    slide.style.left = slideWidth * index + 'px';
    
});

const moveToSlide = (track, currentSlide, targetSlide) =>{

    track.style.transform = 'translateX(-' + targetSlide.style.left + ')';
    currentSlide.classList.remove('current-slide');
    targetSlide.classList.add('current-slide');

}

const updateDots = (currentDot, targetDot) => {
    currentDot.classList.remove('current-slide');
    targetDot.classList.add('current-slide');
}

leftButton.addEventListener('click', e =>{
    const currentDot = dotsNav.querySelector('.current-slide');
    const targetDot = currentDot.previousElementSibling;
    const currentSlide = track.querySelector('.current-slide');  
    const prevSlide = currentSlide.previousElementSibling;
    
    moveToSlide(track, currentSlide, prevSlide)
    updateDots(currentDot, targetDot);
})

rightButton.addEventListener('click', e =>{
    const currentDot = dotsNav.querySelector('.current-slide');
    const targetDot = currentDot.nextElementSibling;
    const currentSlide = track.querySelector('.current-slide');
    const nextSlide = currentSlide.nextElementSibling;

    moveToSlide(track, currentSlide, nextSlide);
    updateDots(currentDot, targetDot);
})

dotsNav.addEventListener('click', e =>{
    const targetDot = e.target.closest('button');

    if(!targetDot) return;

    const currentSlide = track.querySelector('.current-slide');
    const currentDot = dotsNav.querySelector('.current-slide');

    const targetIndex = dots.findIndex(dot => dot === targetDot);
    const targetSlide = slides[targetIndex];

    moveToSlide(track, currentSlide, targetSlide);
    updateDots(currentDot, targetDot);
})