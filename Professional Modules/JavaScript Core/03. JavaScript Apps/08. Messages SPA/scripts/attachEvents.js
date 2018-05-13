function attachAllEvents() {
    //Bind the navigation menu links
    $('#linkMenuAppHome').on('click', showHomeView)
    $('#linkMenuLogin').on('click', showLoginView)
    $('#linkMenuRegister').on('click', showRegisterView)
    $('#linkMenuLogout').on('click', logoutUser)
    $('#linkMenuUserHome').on('click', showHideMenuLinks)
    $('#linkMenuMyMessages').on('click', listMessages)
    $('#linkUserHomeMyMessages').on('click', listMessages)
    $('#linkMenuArchiveSent').on('click', listSentMessages)
    $('#linkUserHomeArchiveSent').on('click', listSentMessages)
    $('#linkMenuSendMessage').on('click', loadUsers)
    $('#linkUserHomeSendMessage').on('click', loadUsers)
    $('#btnSubmitMessage').on('click', sendMessage)


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