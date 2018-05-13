const BASE_URL = 'https://baas.kinvey.com/'
const APP_KEY = 'kid_rydFuSjif' //your app id
const APP_SECRET = '56b505826a514038abb69ee0a7bd55c5' //your app secret
const AUTH_HEADERS = { 'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET) }
//headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') } for create, delete, edit
//<body onload="startApp()"> // put on your body section so the app can start

function loginUser() {
    let username = $('#formLogin input[name=username]').val()
    let password = $('#formLogin input[name=password]').val()

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/login',
        headers: AUTH_HEADERS,
        data: { username, password }
    }).then(function (res) {
        $('#formLogin').trigger('reset')
        signInUser(res, 'Login successful.')
    }).catch(handleAjaxError)
}

function registerUser() {
    let username = $('#formRegister input[name=username]').val()
    let password = $('#formRegister input[name=password]').val()
    let name = $('#formRegister input[name=name]').val()

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/',
        headers: AUTH_HEADERS,
        data: { username, password, name }
    }).then(function (res) {
        $('#formRegister').trigger('reset')
        signInUser(res, 'User registration successful.')
    }).catch(handleAjaxError)

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
    sessionStorage.setItem('name', res.name)
    showHideMenuLinks()
    showInfo(message)
}

function handleAjaxError(response) {
    let errorMsg = JSON.stringify(response)
    if (response.readyState === 0)
        errorMsg = "Cannot connect due to network error."
    if (response.responseJSON && response.responseJSON.description)
        errorMsg = response.responseJSON.description
    showError(errorMsg)
}

function formatDate(dateISO8601) {
    let date = new Date(dateISO8601);
    if (Number.isNaN(date.getDate()))

        return '';
    return date.getDate() + '.' + padZeros(date.getMonth() + 1) +
        "." + date.getFullYear() + ' ' + date.getHours() + ':' +
        padZeros(date.getMinutes()) + ':' + padZeros(date.getSeconds());

    function padZeros(num) {
        return ('0' + num).slice(-2);
    }
}

function formatSender(name, username) {
    if (!name)

        return username;
    else

        return username + ' (' + name + ')';
}

function listMessages() {
    let username = sessionStorage.getItem('username')
    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + `/messages?query={"recipient_username":"${username}"}`,
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
    }).then(function (res) {
        showView('viewMyMessages')
        displayMessages(res)
    }).catch(handleAjaxError)
}

function displayMessages(messages) {
    $('#viewMyMessages table tbody tr').remove()
    for (let message of messages) {
        $('#viewMyMessages table tbody').append($('<tr>')
            .append($('<td>').text(formatSender(message.sender_name, message.sender_username)))
            .append($('<td>').text(message.text))
            .append($('<td>').text(formatDate(message._kmd.ect))))
    }
}

function listSentMessages() {
    let username = sessionStorage.getItem('username')
    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + `/messages?query={"sender_username":"${username}"}`,
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
    }).then(function (res) {
        showView('viewArchiveSent')
        displaySentMessages(res)
    }).catch(handleAjaxError)
}

function displaySentMessages(sentMessages) {
    $('#viewArchiveSent table tbody tr').remove()

    for (let sentMessage of sentMessages) {
        $('#viewArchiveSent table tbody').append($('<tr>')
            .append($('<td>').text(sentMessage.recipient_username))
            .append($('<td>').text(sentMessage.text))
            .append($('<td>').text(formatDate(sentMessage._kmd.ect)))
            .append($('<td>')
                .append($('<button>').text('Delete').on('click', function () {
                    deleteMessage(sentMessage)
                })))
        )
    }
}

function deleteMessage(message) {
    $.ajax({
        method: 'DELETE',
        url: BASE_URL + 'appdata/' + APP_KEY + `/messages/${message._id}`,
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
    }).then(function (res) {
        showInfo('Message deleted.')
        showView('viewMyMessages')
        listSentMessages()
    }).catch(handleAjaxError)
}

function loadUsers() {
    showView('viewSendMessage')
    $('#msgRecipientUsername').empty()

    $.ajax({
        method: 'GET',
        url: BASE_URL + 'user/' + APP_KEY,
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
    }).then(function (res) {
        for (let user of res) {
            $('#msgRecipientUsername')
                .append($('<option>').attr('value', `${user.username}`).text(formatSender(user.name, user.username)))
        }
    }).catch(handleAjaxError)
}

function sendMessage() {
    let recipient_username = $('#msgRecipientUsername').find(':selected').text()
    let text = $('#msgText').val()
    let sender_username = sessionStorage.getItem('username')
    let sender_name = sessionStorage.getItem('name')

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'appdata/' + APP_KEY + '/messages',
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
        data: { recipient_username, text, sender_username, sender_name }
    }).then(function (res) {
        showInfo('Message sent')
        $('#msgText').val('')
        listSentMessages()
    }).catch(handleAjaxError)
}