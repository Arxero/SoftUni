const BASE_URL = 'https://baas.kinvey.com/'
const APP_KEY = 'kid_Bkh6eAehM' //your app id
const APP_SECRET = '4f862f29c5bc437a8643aef5f77d4ad7' //your app secret
const AUTH_HEADERS = { 'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET) }
//headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') } for create, delete, edit
//<body onload="startApp()"> // put on your body section so the app can start

//IF SOMETHING GOES WRONG USE MY USER:
//USERNAME: Maverick
//PASSWORD: Maverick

function loginUser() {
    let username = $('#login-form input[name=username-login]').val()
    let password = $('#login-form input[name=password-login]').val()

    if (RegExp('^[a-zA-Z]{5,}$').test(username)) {
        if (RegExp('^[a-zA-Z0-9]{4,}$').test(password)) {

            $.ajax({
                method: 'POST',
                url: BASE_URL + 'user/' + APP_KEY + '/login',
                headers: AUTH_HEADERS,
                data: { username, password }
            }).then(function (res) {
                $('#login-form').trigger('reset')
                signInUser(res, 'Login successful.')
            }).catch(handleAjaxError)

        } else {
            showError('A password should be at least 4 characters long and should contain only english alphabet letters and digits.')
        }
    } else {
        showError('A username should be at least 5 characters long and should contain only english alphabet letters.')
    }
}

function registerUser() {
    let username = $('#register-form input[name=username-register]').val()
    let password = $('#register-form input[name=password-register]').val()
    let repeatPass = $('#register-form input[name=password-register-check]').val()

    if (RegExp('^[a-zA-Z]{5,}$').test(username)) {
        if (RegExp('^[a-zA-Z0-9]{4,}$').test(password)) {
            if (password == repeatPass) {

                $.ajax({
                    method: 'POST',
                    url: BASE_URL + 'user/' + APP_KEY + '/',
                    headers: AUTH_HEADERS,
                    data: { username, password }
                }).then(function (res) {
                    $('#register-form').trigger('reset')
                    signInUser(res, 'User registration successful.')
                }).catch(handleAjaxError)

            } else {
                showError('Passwords do not match.')
            }
        } else {
            showError('A password should be at least 4 characters long and should contain only english alphabet letters and digits.')
        }
    } else {
        showError('A username should be at least 5 characters long and should contain only english alphabet letters.')
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

function handleAjaxError(response) {
    let errorMsg = JSON.stringify(response)
    if (response.readyState === 0)
        errorMsg = "Cannot connect due to network error."
    if (response.responseJSON && response.responseJSON.description)
        errorMsg = response.responseJSON.description
    showError(errorMsg)
}

function addEntry() {
    let type = $('#create-entry-form input[name=type]').val()
    let qty = $('#create-entry-form input[name=qty]').val()
    let price = $('#create-entry-form input[name=price]').val()
    let receiptId = sessionStorage.getItem('receiptId')

    if (type.length > 0) {
        if (RegExp('^[0-9]{1,}$').test(qty)) {
            if (RegExp('^\\d+(\\.\\d{1,2})?$').test(price)) {

                $.ajax({
                    method: 'POST',
                    url: BASE_URL + 'appdata/' + APP_KEY + '/entries',
                    headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
                    contentType: 'application/json',
                    data: JSON.stringify({ type, qty, price, receiptId })
                }).then(function (res) {
                    $('#create-entry-form input[name=type]').val('')
                    $('#create-entry-form input[name=qty]').val('')
                    $('#create-entry-form input[name=price]').val('')
                    showInfo('Entry added')
                    listProducts()
                }).catch(handleAjaxError)

            } else {
                showError('Price must be a number')
            }
        } else {
            showError('Quantity must be a number')
        }
    } else {
        showError('Product name must be a non-empty string.')
    }

}

function createReceipt() {
    $.ajax({
        method: 'POST',
        url: BASE_URL + 'appdata/' + APP_KEY + '/receipts',
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
        data: {
            "active": true,
            "productCount": 0,
            "total": 0
        }
    }).then(function (res) {
        showInfo('Receipt created')
    }).catch(handleAjaxError)
}

function listReceipt() {
    showView('create-receipt-view')
    $('#active-entries .row').remove()
    let userId = sessionStorage.getItem('id')

    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + `/receipts?query={"_acl.creator":"${userId}","active":"true"}`,
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
    }).then(function (res) {
        if (res.length == 0) {
            createReceipt()
        }
        sessionStorage.setItem('receiptId', res[0]._id)
        showInfo('Receipt Retrieved')
    }).catch(handleAjaxError)

}

function listProducts() {
    let receiptId = sessionStorage.getItem('receiptId')

    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + `/entries?query={"receiptId":"${receiptId}"}`,
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
    }).then(function (res) {
        displayProducts(res)
        showInfo('Entries Loaded.')
    }).catch(handleAjaxError)
}

function displayProducts(products) {
    $('#active-entries .row').remove()
    let total = 0
    for (let product of products) {
        $('#active-entries').append($('<div>').addClass('row')
            .append($('<div>').addClass('col wide').text(product.type))
            .append($('<div>').addClass('col wide').text(product.qty))
            .append($('<div>').addClass('col wide').text(product.price))
            .append($('<div>').addClass('col wide').text(product.qty * product.price))
            .append($('<div>').addClass('col right')
                .append($('<a>').attr('href', '#').html('&#10006;').on('click', function () {
                    deleteProduct(product)
                }))
            )
        )
        total += product.qty * product.price
    }
    $('#totalPrice').text(total)
    sessionStorage.setItem('total', total)
    sessionStorage.setItem('productCount', products.length)
}

function deleteProduct(product) {
    $.ajax({
        method: 'DELETE',
        url: BASE_URL + 'appdata/' + APP_KEY + '/entries/' + product._id,
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
    }).then(function (res) {
        showInfo('Entry removed')
        listProducts()
    }).catch(handleAjaxError)

}

function checkoutReceipt() {
    let receiptId = sessionStorage.getItem('receiptId')
    let productCount = sessionStorage.getItem('productCount')
    let total = sessionStorage.getItem('total')

    if (Number(productCount) > 0) {
        $.ajax({
            method: 'PUT',
            url: BASE_URL + 'appdata/' + APP_KEY + '/receipts/' + receiptId,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
            data: {
                "active": false,
                "productCount": productCount,
                "total": total
            }
        }).then(function (res) {
            showInfo('Receipt checked out')
            listProducts()
        }).catch(handleAjaxError)
    } else {
        showError('Canot checkout empty receipt!')
    }
}

function listAllReceipts() {
    showView('all-receipt-view')
    $('#allReceiptTable div').each((i, e) => {
        if (i > 4) {
            $(e).remove()
        }
    })

    let userId = sessionStorage.getItem('id')

    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + `/receipts?query={"_acl.creator":"${userId}","active":"false"}`,
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
    }).then(function (res) {
        displayAllReceipts(res)
        showInfo('Loading All Receipts')
    }).catch(handleAjaxError)
}

function displayAllReceipts(allReceipts) {
    $('#allReceiptTable div').each((i, e) => {
        if (i > 4) {
            $(e).remove()
        }
    })

    for (let receipt of allReceipts) {
        $('#allReceiptTable').append($('<div>').addClass('row')
            .append($('<div>').addClass('col wide').text(receipt._kmd.ect))
            .append($('<div>').addClass('col wide').text(receipt.productCount))
            .append($('<div>').addClass('col').text(receipt.total))
            .append($('<div>').addClass('col')
                .append($('<a>').attr('href', '#').text('Details').on('click', function () {
                    listDetails(receipt)
                }))
            )
        )
    }
}

function listDetails(receipt) {
    let receiptId = receipt._id
    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + `/entries?query={"receiptId":"${receiptId}"}`,
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
    }).then(function (res) {
        displayDetails(res)
    }).catch(handleAjaxError)
}

function displayDetails(receipts) {
    showView('receipt-details-view')
    $('#detailsTable div').each((i, e) => {
        if (i > 4) {
            $(e).remove()
        }
    })

    for (let receipt of receipts) {
        $('#detailsTable').append($(`
        <div class="row">
        <div class="col wide">${receipt.type}</div>
        <div class="col wide">${receipt.qty}</div>
        <div class="col wide">${receipt.price}</div>
        <div class="col">${receipt.price * receipt.qty}</div>
        </div>
    `))
    }

}