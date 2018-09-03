////You need an anonymous function to wrap around your function to avoid conflict
//(function ($) {

//    //Attach this new method to jQuery
//    $.fn.extend({

//        //This is where you write your plugin's name
//        pluginname: function () {

//            //Iterate over the current set of matched elements
//            return this.each(function () {

//                //code to be inserted here

//            });
//        }
//    });

//    //pass jQuery to the function, 
//    //So that we will able to use any valid Javascript variable name 
//    //to replace "$" SIGN. But, we'll stick to $ (I like dollar sign: ) )
//})(jQuery);

//(function ($) {

//    $.fn.extend({

//        //pass the options variable to the function
//        pluginname: function (options) {


//            //Set the default values, use comma to separate the settings, example:
//            var defaults = {
//                padding: 20,
//                mouseOverColor: '#000000',
//                mouseOutColor: '#ffffff'
//            }
//            var options = $.extend(defaults, options);
//            return this.each(function () {
//                var o = options;
//                //code to be inserted here
//                //you can access the value like this
//                alert(o.padding);

//            });
//        }
//    });

//})(jQuery);

(function ($)
 {
    $.fn.extend
    ({
        //plugin name - animatemenu
            animateMenu: function (options) 
            {
                var defaults = {
                                animatePadding: 60,
                                defaultPadding: 10,
                                evenColor: '#ccc',
                                oddColor: '#eee'
                            };

                var options = $.extend(defaults, options);
                return this.each(function () {
                            var o = options;
                            var obj = $(this);
                            var items = $("li", obj);
                            $("li:even", obj).css('background-color', o.evenColor);
                            $("li:odd", obj).css('background-color', o.oddColor);

                                items.mouseover(function () {
                                $(this).animate({ paddingLeft: o.animatePadding }, 300);

                                }).mouseout(function () {
                                $(this).animate({ paddingLeft: o.defaultPadding }, 300);
                            });

                        });

                    }
                    //animatedmenuend
                   
           


    });
})(jQuery);