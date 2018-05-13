function showView(viewName) {
    $('main section').hide() // Hide all section views
    $('#' + viewName).show() //Show the selected view only
    $('#loadingBox').hide()
    $('#infoBox').hide()
    $('#errorBox').hide()
}

function showHideMenuLinks() {
    if (sessionStorage.getItem('authToken') == null) { // No logged in user
        $('#linkMenuUserHome').hide()
        $('#linkMenuMyMessages').hide()
        $('#linkMenuArchiveSent').hide()
        $('#linkMenuSendMessage').hide()
        $('#linkMenuLogout').hide()
        $('#spanMenuLoggedInUser').hide()
        $('#viewUserHome').hide()
        showView('viewAppHome')
        $('#linkMenuAppHome').show()
        $('#linkMenuLogin').show()
        $('#linkMenuRegister').show()
    }else { // We have logged in user
        // $('#linkMenuUserHome').show()
        // $('#linkMenuMyMessages').show()
        // $('#linkMenuArchiveSent').show()
        // $('#linkMenuSendMessage').show()
        // $('#linkMenuLogout').show()
        // $('#viewUserHome').show()
        showView('linkMenuUserHome')
        showView('linkMenuMyMessages')
        showView('linkMenuArchiveSent')
        showView('linkMenuSendMessage')
        showView('linkMenuLogout')
        showView('viewUserHome')
        $('#linkMenuAppHome').hide()
        $('#linkMenuLogin').hide()
        $('#linkMenuRegister').hide()
        $('#viewAppHome').hide()
        $('#viewLogin').hide()
        $('#viewRegister').hide()
        $('#spanMenuLoggedInUser').text('Welcome, ' + sessionStorage.getItem('username') + '!')
        $('#viewUserHomeHeading').text('Welcome, ' + sessionStorage.getItem('username') + '!')
    }
}

function showHomeView() {
    showView('viewAppHome')
}

// function showHomeViewUser() {
//     showView('viewUserHome')
// }

function showLoginView() {
    showView('viewLogin')
    $('#formLogin').trigger('reset')
}

function showRegisterView() {
    $('#formRegister').trigger('reset')
    showView('viewRegister')
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