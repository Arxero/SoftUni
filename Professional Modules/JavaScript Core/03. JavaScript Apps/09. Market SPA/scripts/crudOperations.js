const BASE_URL = 'https://baas.kinvey.com/'
const APP_KEY = 'kid_B1ubnh_jM' //your app id
const APP_SECRET = '436a79a1beed4930823f7c121e68da42' //your app secret
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
        showHideMenuLinks()
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
        showView('viewAppHome')
    }).catch(handleAjaxError)

}

function signInUser(res, message) {
    sessionStorage.setItem('username', res.username)
    sessionStorage.setItem('authToken', res._kmd.authtoken)
    sessionStorage.setItem('id', res._id)
    sessionStorage.setItem('name', res.name)

    showHideMenuLinks()
    showInfo(message)

    //saving the user cart in session storage for leter use
    $.ajax({
        method: 'GET',
        url: BASE_URL + 'user/' + APP_KEY + '/' + res._id,
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
    }).then(function (res) {
        sessionStorage.setItem('userCart', JSON.stringify(res.cart))
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

function listProducts() {
    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + '/products',
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
    }).then(function (res) {
        showView('viewShop')
        dispalyProducts(res)
    }).catch(handleAjaxError)
}

function dispalyProducts(products) {
    products.sort((a, b) => a.price - b.price)
    $('#viewShop table tbody tr').remove()

    for (let product of products) {
        let price = Math.round(product.price * 100) / 100
        $('#viewShop table tbody').append($('<tr>')
            .append($('<td>').text(product.name))
            .append($('<td>').text(product.description))
            .append($('<td>').text(price.toFixed(2)))
            .append($('<td>')
                .append($('<button>').text('Purchase').on('click', function () {
                    purchaseProduct(product)
                    //console.log(product._id);

                }))
            )
        )

    }

}

function listMyProducts() {
    let userId = sessionStorage.getItem('id')

    $.ajax({
        method: 'GET',
        url: BASE_URL + 'user/' + APP_KEY + '/' + userId,
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
    }).then(function (res) {
        showView('viewCart')
        dispalyMyProducts(res)
    }).catch(handleAjaxError)
}

function dispalyMyProducts(myProducts) {
    let cart = myProducts.cart
    $('#viewCart table tbody tr').remove()

    for (let myProduct in cart) {
        let name = cart[myProduct].product.name
        let description = cart[myProduct].product.description
        let quantity = Number(cart[myProduct].quantity)
        let price = Number(cart[myProduct].product.price) * quantity
        let priceRounded = Math.round(price * 100) / 100

        $('#viewCart table tbody').append($('<tr>')
            .append($('<td>').text(name))
            .append($('<td>').text(description))
            .append($('<td>').text(quantity))
            .append($('<td>').text(priceRounded.toFixed(2)))
            .append($('<td>')
                .append($('<button>').text('Discard').on('click', function () {
                    discardProduct(myProduct)
                })))
        )
    }
}

function purchaseProduct(product) {
    let userId = sessionStorage.getItem('id')
    let oldUserCart = {}
    if (sessionStorage.getItem('userCart') != 'undefined') { //user just loged in and have purchased items
        oldUserCart = JSON.parse(sessionStorage.getItem('userCart'))
    }

    let purchasedId = product._id
    let name = product.name
    let description = product.description
    let price = product.price
    let quantity = 1
    let productObj = { name, description, price }

    if (oldUserCart[purchasedId] == undefined) { // product does not exist in the cart
        oldUserCart[purchasedId] = { 'quantity': `${quantity}`, product: productObj }

    } else {// product exist in the cart
        quantity = oldUserCart[purchasedId].quantity
        oldUserCart[purchasedId] = { 'quantity': `${++quantity}`, product: productObj }
    }
    showInfo('Product purchased.')

    $.ajax({
        method: 'PUT',
        url: BASE_URL + 'user/' + APP_KEY + '/' + userId,
        headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
        data: { 'cart': oldUserCart, 'name': sessionStorage.getItem('name') }
    }).then(function (res) {
        sessionStorage.setItem('userCart', JSON.stringify(oldUserCart))
        showView('viewCart')
        dispalyMyProducts(res)
    }).catch(handleAjaxError)
}

function discardProduct(product) {
    let userId = sessionStorage.getItem('id')
    if (sessionStorage.getItem('userCart') != 'undefined') { //user just loged in and does not have any purchased items
        let = oldUserCart = JSON.parse(sessionStorage.getItem('userCart'))
        delete oldUserCart[`${product}`]
        showInfo('Product discarded..')

        $.ajax({
            method: 'PUT',
            url: BASE_URL + 'user/' + APP_KEY + '/' + userId,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
            data: {'cart' : oldUserCart, 'name' : sessionStorage.getItem('name')}
        }).then(function (res) {
            sessionStorage.setItem('userCart', JSON.stringify(oldUserCart))
            showView('viewCart')
            dispalyMyProducts(res)
        }).catch(handleAjaxError)
    }
}
