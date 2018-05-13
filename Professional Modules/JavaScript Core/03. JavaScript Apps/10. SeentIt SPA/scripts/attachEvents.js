function attachAllEvents() {
    $("form").on('submit', function (event) { event.preventDefault() })
    $('#btnRegister').on('click', registerUser)
    $('#btnLogin').on('click', loginUser)
    $('#logoutBtn').on('click', logoutUser)
    $('#linkCatalog').on('click', listPosts)
    $('#linkViewSubmit').on('click', () => showView('viewSubmit'))
    $('#btnSubmitPost').on('click', viewSubmit)
    $('#btnEditPost').on('click', editPost)
    $('#linkMyPosts').on('click', viewMyPosts)
    $('#btnPostComment').on('click', addComment)


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