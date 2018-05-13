function attachAllEvents() {
    //Bind the navigation menu links
    
    

    // Bind the form submit buttons
    $("form").on('submit', function (event) { event.preventDefault() })

    
    // Bind the info / error boxes
    $("#infoBox, #errorBox").on('click', function () {
        $(this).fadeOut()
    })

    // Attach AJAX "loading" event listener
    $(document).on({
        ajaxStart: function () { $("#loadingBox").show() },
        ajaxStop: function () { $("#loadingBox").hide() }
    })
}