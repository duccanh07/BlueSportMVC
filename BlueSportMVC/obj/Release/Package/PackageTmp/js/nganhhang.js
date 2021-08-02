$(document).ready(function() {

  $(".slider-banner").owlCarousel({
    loop: true,
    items: 1,
    dots: true,
    nav: false,
    autoplay: true,
    autoplayTimeout: 3000,
    autoplayHoverPause: true
  });

    $(".clear-selected-all").click(function() {
      $(".filter-selected").hide();
    });

    //click border blue & show item FILTER
    $('.c-btnbox').on('click', function(event) {
      event.preventDefault();
      $(this).toggleClass('active');
    });

    //click open item filter
    $('.jsTitle').click(function(e) {
      e.preventDefault();
      var notthis = $('.active').not(this);
      notthis.toggleClass('active').next('.filter-show').fadeToggle(300);
      $(this).toggleClass('active').next().fadeToggle("fast");
      if($('.jsTitle').hasClass('active')) {
        $('body').addClass('bg-black');
        $('body').css({"overflow": "hidden"});
      }else {
        $('body').removeClass('bg-black');
        $('body').css({"overflow": "scroll"});
      }
      
    });
    $(".btn-filter-close").click(function() {
      $(".filter-show").fadeOut(300);
      $('.jsTitle').removeClass('active');
      $('body').removeClass('bg-black');
    });


    //click open & close filter TOLTAL
    $(".filter-total").click(function() {
      $(".show-total").addClass("active");
      $('body').css({"overflow": "hidden"});
    });
    $(".btn-closefilter").click(function() {
      $(".show-total").removeClass("active");
      $('body').css({"overflow": "scroll"});
    });
    $(".btn-filter-close").click(function() {
      $(".show-total").removeClass("active");
      $('body').css({"overflow": "scroll"});
    });



    //Scroll fixed thanh filter
    var item = $('.jsfix').offset().top;
    $(window).scroll(function(){    
        if ($(this).scrollTop() > item){ 
            $('.jsfix').addClass('fixed'); 
        }
        else {
            $('.jsfix').removeClass('fixed');
        }
    });

    $('.btn-note').click(function() {
      $('.bg-note').hide();
      $('.btn-note').hide();
      $('.note__list').css({"height": "auto"});
    });

    //scroll hide show gradient total filter
    var wrapper = document.getElementById('wrapper');
    wrapper.onscroll = function (evt) {
      if (wrapper.scrollTop + window.innerHeight >= wrapper.scrollHeight) {
        $('.bg-whitefix').fadeOut(400);
      }
      else {
        $('.bg-whitefix').fadeIn(400);
      }
    }

    //scroll Left & Right Filter show hide Gradient
  $( '.scrolling' ).on( 'scroll', function () {
    var parent_div = $(this).parent();
    if( $(this).scrollLeft() + $(this).innerWidth() >= $(this)[0].scrollWidth ) {
      if( parent_div.hasClass('scroll-right') ) { parent_div.removeClass('scroll-right'); }
    } else if( $(this).scrollLeft() === 0) {
      if( parent_div.hasClass('scroll-left') ) { parent_div.removeClass('scroll-left'); }
    } else {
      if( ! parent_div.hasClass('scroll-right') ) { parent_div.addClass('scroll-right'); }
      if( ! parent_div.hasClass('scroll-left') ) { parent_div.addClass('scroll-left'); }
    }
  });
  scrolling_tables = document.getElementsByClassName('scrolling');
  for (var i=0; i<scrolling_tables.length; i++) {
    scrolling_div = scrolling_tables[i];
    if ( scrolling_div.offsetWidth < scrolling_div.scrollWidth ) {
      if( ! $('.scrolling_inner').hasClass('scroll-right') ) {
        $('.scrolling_inner').addClass('scroll-right');
      }
    }
  }

})
