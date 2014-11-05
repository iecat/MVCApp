$(function () {
    setInterval("rotateImages()", 3000);
});
function rotateImages() {
    var curPhoto = $("#photoshow div.current");
    var nextPhoto = curPhoto.next();
    if (nextPhoto.length == 0) {
        nextPhoto = $("#photoshow div:first");
    }
    curPhoto.removeClass('current').addClass('previous');
    nextPhoto.css({ opacity: 0.0 }).addClass('current').animate({ opacity: 1.0 }, 1000, function () {
        curPhoto.removeClass('previous');
    });

}

function imageClick(img)
{
    $("#mainImg").attr("src", img['src']);
}