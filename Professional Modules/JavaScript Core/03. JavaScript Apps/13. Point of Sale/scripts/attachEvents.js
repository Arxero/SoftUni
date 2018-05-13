function attachAllEvents() {
    //Bind the navigation menu links
    $('#linkOverview').on('click', listAllReceipts)
    $('#addItemBtn').on('click', addEntry)
    $('#linkEditor').on('click', showHideMenuLinks)
    $('#checkoutBtn').on('click', checkoutReceipt)
    //$('#checkoutBtn').on('click', checkoutReceipt)
    
    
    // Bind the form submit buttons
    $('#registerBtn').on('click', registerUser)
    $('#loginBtn').on('click', loginUser)
    $('#linkLogout').on('click', logoutUser)
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