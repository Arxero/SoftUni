function attachAllEvents() {
    // Bind the navigation menu links
    $('#linkMenuAppHome').on('click', showHomeView)
    $('#linkMenuLogin').on('click', showLoginView)
    $('#linkMenuRegister').on('click', showRegisterView)
    $('#linkMenuUserHome').on('click', showHideMenuLinks)
    $('#linkMenuLogout').on('click', logoutUser)
    $('#linkMenuShop').on('click', listProducts)
    $('#linkUserHomeShop').on('click', listProducts)
    $('#linkMenuCart').on('click', listMyProducts)
    $('#linkUserHomeCart').on('click', listMyProducts)
    
    
    // Bind the form submit buttons
    $('#btnLogin').on('click', loginUser)
    $('#btnRegister').on('click', registerUser)
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