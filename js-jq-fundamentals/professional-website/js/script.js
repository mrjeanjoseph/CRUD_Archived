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
        typeSpeed:200,
        backSpeed:50,
        loop:true,
        loopCount:Infinity,
        startDelay:1000
    });
}

function setProgressBar(){

    //Waypoint is not working
    // var waypoint = new Waypoint({
    //     element: document.getElementById('exp-id'),
    //     handler: function() {

    //     }
    // })
    var p = document.querySelectorAll(".progress-bar");

    p[0].setAttribute("style", "width:98%;transition:10s all");
    p[1].setAttribute("style", "width:95%;transition:1.9s all");
    p[2].setAttribute("style", "width:85%;transition:2.5s all");
    p[3].setAttribute("style", "width:77%;transition:3.5s all");
    p[4].setAttribute("style", "width:69%;transition:5.9s all");
}

$(document).ready(function() {
    stickyNavbar();
    setProgressBar();

    localStorage.setItem('skillsSection', 300);
    var scrollToSkills = localStorage.getItem('skillsSection');
    if (scrollToSkills) window.scrollTo(0, scrollToSkills);  

    //This will place the scroll position back to the last stop
    var scrollpos = localStorage.getItem('scrollpos');
    if (scrollpos) window.scrollTo(0, scrollpos);  
    getTyped();
});

//This will place the scroll position back to the last stop
window.onbeforeunload = function(e) {
    localStorage.setItem('scrollpos', window.scrollY);
};  