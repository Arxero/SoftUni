const BASE_URL = 'https://baas.kinvey.com/'
const APP_KEY = '' //your app id
const APP_SECRET = '' //your app secret
const AUTH_HEADERS = { 'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET) }
//headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') } for create, delete, edit
//<body onload="startApp()"> // put on your body section so the app can start

function loginUser() {
    let username = $('#loginForm input[name=username]').val()
    let password = $('#loginForm input[name=password]').val()

    if (RegExp('^[a-zA-Z]{3,}$').test(username)) {
        if (RegExp('^[a-zA-Z0-9]{6,}$').test(password)) {

            $.ajax({
                method: 'POST',
                url: BASE_URL + 'user/' + APP_KEY + '/login',
                headers: AUTH_HEADERS,
                data: { username, password }
            }).then(function (res) {
                $('#loginForm').trigger('reset')
                signInUser(res, 'Login successful.')
            }).catch(handleAjaxError)

        } else {
            showError('A password should be at least 6 characters long and should contain only english alphabet letters and digits.')
        }
    } else {
        showError('A username should be at least 3 characters long and should contain only english alphabet letters.')
    }
}

function registerUser() {
    let username = $('#registerForm input[name=username]').val()
    let password = $('#registerForm input[name=password]').val()
    let repeatPass = $('#registerForm input[name=repeatPass]').val()

    if (RegExp('^[a-zA-Z]{3,}$').test(username)) {
        if (RegExp('^[a-zA-Z0-9]{6,}$').test(password)) {
            if (password == repeatPass) {

                $.ajax({
                    method: 'POST',
                    url: BASE_URL + 'user/' + APP_KEY + '/',
                    headers: AUTH_HEADERS,
                    data: { username, password }
                }).then(function (res) {
                    $('#registerForm').trigger('reset')
                    signInUser(res, 'Registration successful.')
                }).catch(handleAjaxError)

            } else {
                showError('Passwords do not match.')
            }
        } else {
            showError('A password should be at least 6 characters long and should contain only english alphabet letters and digits.')
        }
    } else {
        showError('A username should be at least 3 characters long and should contain only english alphabet letters.')
    }

}

function logoutUser() {
    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/_logout',
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
    }).then(function () {
        sessionStorage.clear()
        showInfo('Logout successful.')
        showHideMenuLinks()
    }).catch(handleAjaxError)

}

function signInUser(res, message) {
    sessionStorage.setItem('username', res.username)
    sessionStorage.setItem('authToken', res._kmd.authtoken)
    sessionStorage.setItem('id', res._id)
    showHideMenuLinks()
    showInfo(message)
}



function deleteElement(element) {
    $.ajax({
        method: 'DELETE',
        url: BASE_URL + 'appdata/' + APP_KEY + '/comments/' + element._id,
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
    }).then(function (res) {
        showInfo('Comment deleted.')
    }).catch(handleAjaxError)

}

function handleAjaxError(response) {
    let errorMsg = JSON.stringify(response)
    if (response.readyState === 0)
        errorMsg = "Cannot connect due to network error."
    if (response.responseJSON && response.responseJSON.description)
        errorMsg = response.responseJSON.description
    showError(errorMsg)
}