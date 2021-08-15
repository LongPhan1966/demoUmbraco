$(document).ready(function(){

    $('.owl-carousel-3').owlCarousel({
        loop:true,
        margin:10,
        nav:true,
        responsive:{
            0:{
                items:1
            },
            600:{
                items:1
            },
            1000:{
                items:3
            }
        }
    })



    $(".menu-right-open").click(function(){
        $(".menu-right").addClass("active")
    })
    $(".menu-right-close").click(function(){
        $(".menu-right").removeClass("active")
    })

    $(".nav-mobile-menu").click(function(){
        $(".nav-mb-right").addClass("active")
        
    })
    $(".nav-mobile-close").click(function(){
        $(".nav-mb-right").removeClass("active")
    })
});


/* document.getElementById("btn-regis").addEventListener("click", Registration)

    function Registration(){
        alert ("Đăng ký lái thử thành công");
    } */
