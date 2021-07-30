$(function () {
    $('.fotorama')
        .on('fotorama:ready', function (e, fotorama) {
        var info = $('<span class="count"/>');
        info.text((fotorama.activeIndex + 1) + ' / ' + fotorama.size);
        $(this).find('.fotorama__stage').append(info);
    })
        .on('fotorama:show', function (e, fotorama, extra) {
        var info = $(this).find('.count');
        info.text((fotorama.activeIndex + 1) + ' / ' + fotorama.size);
    });

    $('.fotorama').fotorama({
        width: 640,
        maxwidth: '100%',
        ratio: 16/9,
        allowfullscreen: true,
        nav: 'thumbs'
    });
});
        

$(document).ready(function() {
    $('.box-promo-btn').click(function() {
        $('.box-promo .bg-hide').hide();
        $('.box-promo-btn').hide();
        $('.box-promo-list').css({"height": "auto"});
    });
})
