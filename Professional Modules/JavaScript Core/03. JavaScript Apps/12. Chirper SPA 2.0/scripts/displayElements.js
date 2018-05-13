function showView(viewName) {
    $('body section').hide() // Hide all section views
    $('#' + viewName).show() //Show the selected view only
}

function showHideMenuLinks() {
    if (sessionStorage.getItem('authToken') == null) { // No logged in user
        showView()
        $('#linkLogin').show()
        $('#linkRegister').show()
        showRegisterView()
        showLoginView()
        $('#linkHome').hide()
        $('#linkDiscover').hide()
        $('#linkMe').hide()
        $('#linkLogout').hide()
    }else { // We have logged in user
        showView('linkHome')
        showView('linkDiscover')
        showView('linkMe')
        showView('linkLogout')
        $('#linkLogin').hide()
        $('#linkRegister').hide()
        showHomeView()
        //$('#profile').find('span').text(sessionStorage.getItem('username'))
    }
}

function showInfo(message) {
    let infoBox = $('#infoBox')
    infoBox.find('span').text(message)
    infoBox.show()
    setTimeout(function() {
        $('#infoBox').fadeOut()
    }, 3000)
}

function showError(errorMsg) {
    let errorBox = $('#errorBox')
    errorBox.find('span').text("Error: " + errorMsg)
    errorBox.show()
}

function showRegisterView() {
    showView('viewRegister')
    $('#formRegister').trigger('reset')
}

function showLoginView() {
    showView('viewLogin')
    $('#formLogin').trigger('reset')
}

function showHomeView() {
    showView('viewFeed')
    listChirps()
    
}