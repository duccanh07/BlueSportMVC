$(document).ready(function() {

  //Header
  $(".open-sub").click(function(ev) {
    ev.preventDefault();
    $(this).next(".submenu").slideToggle().toggleClass("active");
    $(this).next(".sub-submenu").slideToggle().toggleClass("active");
    $(this).parent().toggleClass("active");
  });
  $('.header-menu').click(function() {
    $('.main-menu').toggleClass('show-menu');
    bodyscroll();
  });
  $('.close-menu').click(function() {
    $('.main-menu').removeClass('show-menu');
    bodyscroll();
  });
  function bodyscroll() {
    if ($('.main-menu').hasClass('show-menu')) {
      $('body').css({"overflow": "hidden"});
    } else {
      $('body').css({"overflow": "scroll"});
    }
  }


  //search show
  $('.header-search').click(function() {
    $('body').addClass('body-search');
    $('.bgcover').fadeIn(300);
    $('.search-show').fadeIn(300);
    $(this).fadeOut(300);
  });
  $('.search-close').click(function() {
    $('body').removeClass('body-search');
    $('.bgcover').fadeOut(300);
    $('.search-show').fadeOut(300);
    $('.header-search').fadeIn(300);
  });
  $('.clear-search').click(function() {
    $(this).prev('.search-top input').val('');
  });



  //Footer
  $('.open-menufooter').click(function(event) {
    event.preventDefault();
    $(this).next(".submenu-footer").slideToggle();
    $(this).parent().toggleClass("act");
  });

});