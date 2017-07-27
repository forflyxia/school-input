(function($) {
    $.fn.extend({
        
    });

    $.extend({
        clearSearchCondition: function (cssname) {
            $(cssname).each(function () {
                var self = $(this);
                
                if (self.val() == "0" || self.val() == "0001/1/1 0:00:00") {
                    self.val("");
                }
            });
        }
    });
})(jQuery);