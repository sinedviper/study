type="text/javascript">
jQuery(document).ready(function($){
 $().appendTo('body');
 var
 speed = 550,
 $scrollTop = $('<a href="#" class="scrollTop">').appendTo('body'); 
 $scrollTop.click(function(e){
 e.preventDefault();
 $( 'html:not(:animated),body:not(:animated)' ).animate({ scrollTop: 0}, speed );
 });
 
 //появление
 function show_scrollTop(){
 ( $(window).scrollTop() > 330 ) ? $scrollTop.fadeIn(700) : $scrollTop.fadeOut(700);
 }
 $(window).scroll( function(){ show_scrollTop(); } );
 show_scrollTop();
});