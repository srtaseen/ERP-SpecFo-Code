$(document).ready(function() {
			
			/* 	with background image	*/

			// inner wrap (span.out) to a，  append (span.bg) after span.out
			$("#menu li a").wrapInner( '<span class="out"></span>' ).append( '<span class="bg"></span>' );

			// add layer for each a (span.over)
			$("#menu li a").each(function() {
				$( '<span class="over">' +  $(this).text() + '</span>' ).appendTo( this );
			});

			$("#menu li a").hover(function() { 
				$(".out",this).stop().animate({'top':'45px'},250); // slide down - hidden
				$(".over",this).stop().animate({'top':'0px'},250); // slide down - display
				$(".bg",this).stop().animate({'top':'0px'},	120); // slide down - display

			}, function() { 
				$(".out",this).stop().animate({'top':'0px'},250); // slide up - display
				$(".over",this).stop().animate({'top':'-45px'},250); // slide up - hidden
				$(".bg",this).stop().animate({'top':'-45px'},120); // slide up - hidden
			});
					

			/*	simple with color background	*/
					
			$("#menu2 li a").wrapInner( '<span class="out"></span>' );
			
			$("#menu2 li a").each(function() {
				$('<span class="over">' +  $(this).text() + '</span>' ).appendTo( this );
			});

			$("#menu2 li a").hover(function() {
				$(".out",this).stop().animate({'top':'45px'},200); // slide down - hidden
				$(".over",this).stop().animate({'top':'0px'},200); // slide down - display
			}, function() {
				$(".out",this).stop().animate({'top':'0px'},200); // slide up - display
				$(".over",this).stop().animate({'top':'-45px'},200); // slde up - hidden
			});

		});
