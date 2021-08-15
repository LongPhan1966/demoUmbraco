$(document).ready(function(){
    var owl = $('.aaaa').owlCarousel({
        items:1,
        loop:true,
        margin:0,
        autoplay:true,
        autoplayTimeout:5000,
        autoplayHoverPause:true
    });

    $('.play').on('click',function(){
        owl.trigger('play.owl.autoplay',[1000])
    })
});