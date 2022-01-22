
var $overlay = $("<div id='overlay'></div>");

$("body").append($overlay);

var $image = $("<img>");

$overlay.append($image);

var $close = $("<img id='closeImage'>");

$overlay.append($close);

$("#imageGallery a").click(function(e){
    e.preventDefault();

    var imageSource = $(this).attr("href");
    $image.attr("src",imageSource);
    $close.attr("src", "https://cdn-icons-png.flaticon.com/512/1828/1828778.png")

    $overlay.show();
})

$close.click(function(){
    $($overlay).hide();
})