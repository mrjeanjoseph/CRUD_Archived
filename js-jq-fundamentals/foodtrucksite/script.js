$(document).ready(function(){
    $('.fa-drumstick-bite').click(function() {
        $(this).toggleClass('fa-times');
        $('nav').toggleClass('nav-toggle');
    });

    $('nav ul li a').click(function() {
        $('.fa-drumstick-bite').removeClass('fa-times');
        $('nav').removeClass('nav-toggle');
    });
    $('.dot1').click(function(){
        $('.vid1').css('display', 'block');
        $('.vid2').css('display', 'none');
        $('.vid3').css('display', 'none');
    });
    $('.dot2').click(function(){
        $('.vid1').css('display', 'none');
        $('.vid2').css('display', 'block');
        $('.vid3').css('display', 'none');
    });
    $('.dot3').click(function(){
        $('.vid1').css('display', 'none');
        $('.vid2').css('display', 'none');
        $('.vid3').css('display', 'block');
    });
})