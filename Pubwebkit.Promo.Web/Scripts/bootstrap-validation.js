$(function () {
    $('form').submit(function () {
        if ($(this).valid()) {
            $(this).find('control-group, form-group').each(function () {
                if ($(this).find('span.field-validation-error').length == 0) {
                    $(this).removeClass('has-error');
                }
            });
        }
        else {
            $(this).find('div.control-group, div.form-group').each(function () {
                if ($(this).find('span.field-validation-error').length > 0) {
                    $(this).addClass('has-error');
                }
            });
        }
    });

    $('form').each(function () {
        $(this).find('.control-group, .form-group').each(function () {
            if ($(this).find('span.field-validation-error').length > 0) {
                $(this).addClass('has-error');
            }
        });
    });
});

var page = function () {
    //Update that validator
    $.validator.setDefaults({
        highlight: function (element) {
            $(element).closest(".control-group, .form-group").addClass("has-error");
        },
        unhighlight: function (element) {
            $(element).closest(".control-group, .form-group").removeClass("has-error");
        }
    });
}();