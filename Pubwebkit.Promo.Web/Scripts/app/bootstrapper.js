$(function () {

    // Toastr configuration
    toastr.options = {
        "closeButton": false,
        "debug": false,
        "positionClass": "toast-top-right",
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "10000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    };

    $(window).resize(function() {
        updateFooterPosition();
    });

    $(window).load(function () {
        updateFooterPosition();
    });

    function updateFooterPosition() {
        console.log('updateFooterPosition');
        var footer = $('body > footer')
          , wrapper = $('#content-wrapper')
          , height = footer.height();

        wrapper.css('margin-bottom', '-' + height + 'px');
        wrapper.css('padding-bottom', height);
    };
});