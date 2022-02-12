$(document).ready(function(){
    $('.fa-drumstick-bite').click(function() {
        $(this).toggleClass('fa-times');
        $('nav').toggleClass('nav-toggle');
    });

    $('nav ul li a').click(function() {
        $('.fa-drumstick-bite').removeClass('fa-times');
        $('nav').removeClass('nav-toggle');
    })
})