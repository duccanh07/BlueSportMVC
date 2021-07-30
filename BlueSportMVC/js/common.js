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

  $('.header-search').click(function() {
    $('.search-show').addClass('current');
    $('body').css({"overflow": "hidden"});
  });
  $('.close-showsearch').click(function() {
    $('.search-show').removeClass('current');
    $('body').css({"overflow": "scroll"});
  });
  $('.clear-icon').click(function() {
    $(this).prev('.search-form input').val('');
  });


  //Footer
  $('.open-menufooter').click(function(event) {
    event.preventDefault();
    $(this).next(".submenu-footer").slideToggle();
    $(this).parent().toggleClass("act");
  });

});