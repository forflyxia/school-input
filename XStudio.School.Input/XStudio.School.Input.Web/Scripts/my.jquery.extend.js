(function($) {
    $.fn.extend({
        
    });

    $.extend({
        clearSearchCondition: function (cssname) {
            $(cssname).each(function () {
                var self = $(this);
                if (self.val() == "0") {
                    self.val("");
                }
            });
        }
    });
})(jQuery);