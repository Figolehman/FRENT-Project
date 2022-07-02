$(window).on('scroll', function(){
    if(document.body.scrollTop > 170 || document.documentElement.scrollTop > 170){
        $('nav').addClass('pink');
    }
    else{
        $('nav').removeClass('pink');
    }
})