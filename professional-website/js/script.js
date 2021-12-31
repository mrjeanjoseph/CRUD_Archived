function stickyNavbar() {
    
    $(window).on('scroll', function() {
        var scroll = $(window).scrollTop();
        // console.log(scroll);
        if(scroll > 50) {
            $(".sticky").addClass("stickyadd")
        } else {
            $(".sticky").removeClass("stickyadd")
        }
    });
}

function getTyped() {
    var typed = new Typed(".element", {
        strings: ["Jean-Joseph", "a fullstack developer", "an entrepreneur"],
        smartBackspace: true,
        typeSpeed:50,
        backSpeed:200,
        loop:true,
        loopCount:Infinity,
        startDelay:1000
    });
}


$(document).ready(function() {
    stickyNavbar();
    //getTyped(); 
    $(this).scrollTop(0);
});

onpageLoad = function(e) {
    e.preventDefault();
} 