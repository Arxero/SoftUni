function showView(viewName) {
    $('main section').hide() // Hide all section views
    $('#' + viewName).show() //Show the selected view only
    $('#loadingBox').hide()
    $('#infoBox').hide()
    $('#errorBox').hide()
}

function showHideMenuLinks() {
    if (sessionStorage.getItem('authToken') == null) { // No logged in user
        $('#viewAppHome').show()
        $('#linkMenuAppHome').show()
        $('#linkMenuLogin').show()
        $('#linkMenuRegister').show()
        $('#linkMenuUserHome').hide()
        $('#linkMenuShop').hide()
        $('#linkMenuCart').hide()
        $('#linkMenuLogout').hide()
        $('#spanMenuLoggedInUser').hide()
    }else { // We have logged in user
        // $('#linkMenuUserHome').show()
        // $('#linkMenuShop').show()
        // $('#linkMenuCart').show()
        // $('#linkMenuLogout').show()
        // $('#viewUserHome').show()
        showView('linkMenuUserHome')
        showView('linkMenuShop')
        showView('linkMenuCart')
        showView('linkMenuLogout')
        showView('viewUserHome')
        $('#spanMenuLoggedInUser').show()
        $('#viewAppHome').hide()
        $('#linkMenuAppHome').hide()
        $('#linkMenuLogin').hide()
        $('#linkMenuRegister').hide()
        $('#spanMenuLoggedInUser').text('Welcome, ' + sessionStorage.getItem('username') + '!')
        $('#viewUserHomeHeading').text('Welcome, ' + sessionStorage.getItem('username') + '!')
    }
}

function showInfo(message) {
    let infoBox = $('#infoBox')
    infoBox.text(message)
    infoBox.show()
    setTimeout(function() {
        $('#infoBox').fadeOut()
    }, 3000)
}

function showError(errorMsg) {
    let errorBox = $('#errorBox')
    errorBox.text("Error: " + errorMsg)
    errorBox.show()
}

function showHomeView() {
    showView('viewAppHome')
}

function showHomeViewUser() {
    showView('viewUserHome')
}

function showLoginView() {
    showView('viewLogin')
    $('#formLogin').trigger('reset')
}

function showRegisterView() {
    $('#formRegister').trigger('reset')
    showView('viewRegister')
}

function showCreateBookView() {
    $('#formCreateBook').trigger('reset')
    showView('viewCreateBook')
}