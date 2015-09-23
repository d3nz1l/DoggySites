

$(document).ready(function () {
    
    // Override default options
    jQuery.validator.setDefaults({
    
        highlight: function (element, errorClass, validClass) {
            $(element).closest('.form-group').removeClass(validClass).addClass(errorClass); // add the Bootstrap error class to the control group
        },
        unhighlight: function (element, errorClass, validClass) {
            $(element).closest('.form-group').removeClass(errorClass).addClass(validClass); // remove the Boostrap error class from the control group
        }
    });

    // Override any options set by unobtrusive
    //$.validator.unobtrusive.options = {
    //errorPlacement: function (error, element) {
    //    var errorContainer = element.closest('.form-group').find('.error-message');
    //    var search = '[data-valmsg-for=' + element.attr('id') + ']';
    //    var errorPlaceholder = errorContainer.find(search);

    //    if (errorPlaceholder && errorPlaceholder.length) {
    //        errorPlaceholder.html(error);
    //    } else {
    //        errorContainer.html(error);
    //    }

    //};
});
