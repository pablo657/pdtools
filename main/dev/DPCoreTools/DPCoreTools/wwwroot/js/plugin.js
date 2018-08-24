// -----------------------------------------------------------------
// FOCUS
// -----------------------------------------------------------------
$.fn.setFocus = function () {
    var el = this.get(0);
    var elemLen = el.value.length;

    if(!el.disabled) {
        el.selectionStart = elemLen;
        el.selectionEnd = elemLen;
        el.focus();
    }
        
    return this;
};


// -----------------------------------------------------------------
// EXTEND FOREACH FOR SUPPORT BROWSER <= IE7
// -----------------------------------------------------------------
if (!Array.prototype.forEach) {
    Array.prototype.forEach = function (fn, scope) {
        for (var i = 0, len = this.length; i < len; ++i) {
            fn.call(scope, this[i], i, this);
        }
    }
}


if (typeof String.prototype.trim !== 'function') {
    String.prototype.trim = function () {
        return this.replace(/^\s+|\s+$/g, '');
    }
}


// -----------------------------------------------------------------
// SETTING : REQUIRED, MAX-LENGTH, MIN-LENGTH
// -----------------------------------------------------------------
(function ($) {

    $.fn.setting = function (set) {

        var el = this;
        var validate = {
            numeric: function (event) {
                $(this).val($(this).val().replace(/[^\d].+/, ""));

                if ((event.which < 48 || event.which > 57)) {
                    event.preventDefault();
                }
            },
            decimal: function (event) {
                $(this).val($(this).val().replace(/[^0-9\.]/g, ''));
                if ((event.which != 46 || $(this).val().indexOf('.') != -1) && (event.which < 48 || event.which > 57)) {
                    event.preventDefault();
                }
            },
            date: function (event) { },
            text: function (event) { }
        }

        var setting = $.extend({
            required: undefined,
            minLength: undefined,
            maxLength: undefined,
            type: 'text'
        }, set);

        if (setting.required)
            el.attr('required', setting.required);

        if (setting.minLength)
            el.attr('minlength', setting.minLength);
        
        if (setting.maxLength)
            el.attr('maxlength', setting.maxLength);
        

        switch (setting.type) {
            case 'text':
                break;
            case 'numeric':
                el.on('keypress keyup blur', validate.numeric);
                break;
            case 'decimal':
                el.on('keypress keyup blur', validate.decimal);
                break;
            case 'date':
                // el.on('keypress keyup blur', validate.date);
                break;
            case 'email':
                // el.on('keypress keyup blur', validate.date);
                break;
            default:
                // el.on('keypress keyup blur', validate.text);
                break;
        }
    };

}(jQuery));
/* ============================================= */