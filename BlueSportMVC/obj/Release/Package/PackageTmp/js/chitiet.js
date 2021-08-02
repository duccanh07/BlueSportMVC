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
        clicktransition: 'dissolve',
        caption: true,
        width: '100%',
        maxwidth: '100%',
        maxheight: '100%',
        ratio: 16/9,
        // allowfullscreen: true,
        nav: 'thumbs',
        thumbmargin: 8,
        thumbwidth: 60,
        thumbheight: 60,
        fit: 'cover',
        allowfullscreen: true,
    });
    
    
});
        

$(document).ready(function() {

    $('.box-promo-btn').click(function() {
        $('.box-promo .bg-hide').hide();
        $('.box-promo-btn').hide();
        $('.box-promo-list').css({"height": "auto"});
    });

    $('.info-title').click(function(event) {
        event.preventDefault();
        $(this).toggleClass('current');
        $(this).next('.info .info-content').slideToggle();
    });

    //scroll hide show gradient market
    var market = document.getElementById('market');
    market.onscroll = function (evt) {
      if (market.scrollTop + window.innerHeight >= market.scrollHeight) {
        $('.bg-gradient').fadeOut(400);
      }
      else {
        $('.bg-gradient').fadeIn(400);
      }
    }

    $(".btn-spmarket").click(function() {
        $(".show-market").addClass("show");
        $('body').css({"overflow": "hidden"});
    });
      $(".show-market-close").click(function() {
        $(".show-market").removeClass("show");
        $('body').css({"overflow": "scroll"});
    });

    $(".btn-addcart").click(function() {
        $(".btn-addcart .txt").hide();
        $(".qtySelector").fadeIn(100).css({"display": "flex"});
    });

    $("#provincial").click(function() {
        $(".provincial").toggleClass('crt');
        $(".district").removeClass('crt');
        $(this).toggleClass('act');
        $('#district').removeClass('act');
    });
    $("#district").click(function() {
        $(".district").toggleClass('crt');
        $(".provincial").removeClass('crt');
        $(this).toggleClass('act');
        $('#provincial').removeClass('act');
    });

    var minVal = 1, maxVal = 20; // Set Max and Min values
    // Increase product quantity on cart page
    $(".increaseQty").on('click', function(){
        var $parentElm = $(this).parents(".qtySelector");
        $(this).addClass("clicked");
        setTimeout(function(){
            $(".clicked").removeClass("clicked");
        },100);
        var value = $parentElm.find(".qtyValue").val();
        if (value < maxVal) {
            value++;
        }
        $parentElm.find(".qtyValue").val(value);
    });
    // Decrease product quantity on cart page
    $(".decreaseQty").on('click', function(){
        var $parentElm = $(this).parents(".qtySelector");
        $(this).addClass("clicked");
        setTimeout(function(){
            $(".clicked").removeClass("clicked");
        },100);
        var value = $parentElm.find(".qtyValue").val();
        if (value > 1) {
            value--;
        }
        $parentElm.find(".qtyValue").val(value);
    });

    //cach chon size popup
    $(".size-top-right").click(function() {
        $(".popup-size").fadeIn(300);
        $('body').css({"overflow": "hidden"});
    });
    $(".popup-size-close").click(function() {
        $(".popup-size").fadeOut(300);
        $('body').css({"overflow": "scroll"});
    });

})

