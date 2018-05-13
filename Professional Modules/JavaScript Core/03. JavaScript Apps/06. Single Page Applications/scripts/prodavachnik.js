function startApp() {
    const BASE_URL = 'https://baas.kinvey.com/'
    const APP_KEY = 'kid_SJY0hSoqf'
    const APP_SECRET = '3d4d21d1f0804154bdebb1193b158f26'
    const AUTH_HEADERS = { 'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET) }


    showHideMenuLinks()
    loadingBox()
    $('#linkHome').on('click', showHideMenuLinks)
    $('#linkLogin').on('click', viewLogin)
    $('#linkRegister').on('click', viewRegister)
    $('#linkLogout').on('click', logoutUser)
    $('#linkListAds').on('click', listAds)
    $('#linkCreateAd').on('click', showCreate)
    $('#buttonCreateAd').on('click', createAdd)
    $('#buttonEditAd').on('click', editAdd)




    //login/logout/register/working links
    function showHideMenuLinks() {
        showView('linkHome')
        showView('viewHome')
        if (sessionStorage.getItem('authToken') === null) {// No logged in user
            showView('linkLogin')
            showView('linkRegister')
            hideView('viewLogin')
            hideView('viewRegister')
            hideView('linkListAds')
            hideView('linkCreateAd')
            hideView('linkLogout')
            hideView('viewAds')
            hideView('viewCreateAd')
            hideView('viewEditAd')
            hideView('viewDetailsAd')
            $('#formRegister').trigger('reset')
            $('#formLogin').trigger('reset')
            $('#loggedInUser').text('')
        } else {// We have logged in user
            hideView('linkLogin')
            hideView('linkRegister')
            hideView('viewRegister')
            hideView('viewAds')
            hideView('viewCreateAd')
            hideView('viewEditAd')
            hideView('viewDetailsAd')
            showView('linkListAds')
            showView('linkCreateAd')
            showView('linkLogout')
            showView('loggedInUser')
            $('#loggedInUser').text("Welcome, " + sessionStorage.getItem('username') + "!")
        }
    }

    function viewRegister() {
        $('#buttonRegisterUser').on('click', registerUser)
        showView('viewRegister')
        hideView('viewLogin')
        hideView('viewHome')
        $('#formLogin').trigger('reset')
    }

    function viewLogin() {
        $('#buttonLoginUser').on('click', loginUser)
        showView('viewLogin')
        hideView('viewHome')
        hideView('viewRegister')
        $('#formRegister').trigger('reset')
    }

    function showView(view, message) {
        $('#' + view).show()
    }

    function hideView(view) {
        $('#' + view).hide()
    }

    function loginUser() {
        let username = $('#formLogin input[name="username"]').val()
        let password = $('#formLogin input[name="passwd"]').val()

        if (username != '' && password != '') {
            $.ajax({
                method: 'POST',
                url: BASE_URL + 'user/' + APP_KEY + '/login',
                headers: AUTH_HEADERS,
                data: { username, password }
            }).then(function (res) {
                showHideMenuLinks()
                showInfo('Login Successful')
                signInUser(res)
            }).catch(handleAjaxError)
        }
    }

    function registerUser() {
        let username = $('#formRegister input[name="username"]').val()
        let password = $('#formRegister input[name="passwd"]').val()

        if (username != '' && password != '') {
            $.ajax({
                method: 'POST',
                url: BASE_URL + 'user/' + APP_KEY + '/',
                headers: AUTH_HEADERS,
                data: { username, password }
            }).then(function (res) {
                showInfo('Register Successful')
                signInUser(res)
            }).catch(handleAjaxError)
        }
    }

    function logoutUser() {
        sessionStorage.clear()
        showInfo('Logout Successful')
        showHideMenuLinks()
    }
    function signInUser(res) {
        sessionStorage.setItem('username', res.username)
        sessionStorage.setItem('authToken', res._kmd.authtoken)
        sessionStorage.setItem('id', res._id)
        showView('viewHome')
        showHideMenuLinks()
    }
    function handleAjaxError(response) {
        let errorMsg = JSON.stringify(response)
        if (response.readyState === 0)
            errorMsg = "Cannot connect due to network error."
        if (response.responseJSON && response.responseJSON.description)
            errorMsg = response.responseJSON.description

        function showError(errorMsg) {
            let errorBox = $('#errorBox').on('click', function () {
                $(this).fadeOut()
            })
            errorBox.text("Error: " + errorMsg)
            errorBox.show()
        }
        showError(errorMsg)

    }
    function loadingBox() {
        $(document).on({
            ajaxStart: function () { $("#loadingBox").show() },
            ajaxStop: function () { $("#loadingBox").hide() }
        })
    }
    function showInfo(message) {
        let infoBox = $('#infoBox')
        infoBox.text(message)
        infoBox.show()
        setTimeout(function () {
            $('#infoBox').fadeOut()
        }, 2000)
    }


    function listAds() {
        hideView('viewCreateAd')
        hideView('viewHome')
        showView('viewAds')
        hideView('viewEditAd')
        hideView('viewDetailsAd')

        $('#ads table tr').each((index, element) => {
            if (index > 0) {
                element.remove()
            }
        })

        $.ajax({
            method: 'GET',
            url: BASE_URL + 'appdata/' + APP_KEY + '/ads',
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
        }).then(handleSuccess)
            .catch(handleAjaxError)

        function handleSuccess(res) {
            if (res.length > 0) {
                $('#ads table tr').first().find('th').each((index, element) => {
                    if ($(element).text() === 'Actions') {
                        $(element).remove()
                    }
                })
                $('#ads table tr').first().append($('<th>').text('Actions'))
                $('#ads table tr').each((index, element) => {
                    if (index > 0) {
                        element.remove()
                    }
                })
                for (let add of res) {
                    let tr = $('<tr>')
                    $('#ads table').append($(tr)
                        .append($('<td>').text(add.title))
                        .append($('<td>').text(add.author))
                        .append($('<td>').text(add.description))
                        .append($('<td>').text(add.price))
                        .append($('<td>').text(add.date))
                        .append($('<td>')
                            .append($('<center><a href="#">[Read More]</a></center>').on('click', function () {
                                viewDetailsAd(add)
                            }))
                        ))

                    if (add._acl.creator === sessionStorage.getItem('id')) {
                        $(tr).find('td').last()
                            .append($('<a href="#">[Delete]</a>').on('click', function () {
                                deleteAdd(add)

                            }))
                            .append($('<a href="#">[Edit]</a>').on('click', function () {
                                showView('viewEditAd')
                                hideView('viewAds')
                                loadAddForEdit(add)
                            }))
                    }
                }
            } else {
                $('.titleForm').remove()
                $('#ads table').remove()
                $('#viewAds').empty()
                $('#viewAds').append($('<h3>').text('Advertisements'))
                    .append($('<p>').text('No advertisements available.'))
            }

        }
    }

    function showCreate() {
        showView('viewCreateAd')
        hideView('viewHome')
        hideView('viewAds')
        hideView('viewEditAd')
        hideView('viewDetailsAd')
    }

    function createAdd() {
        let title = $('#formCreateAd input[name="title"]').val()
        let description = $('#formCreateAd textarea[name="description"]').val()
        let date = $('#formCreateAd input[name="datePublished"]').val()
        let price = $('#formCreateAd input[name="price"]').val()
        let author = sessionStorage.getItem('username')
        let image = $('#formCreateAd input[name="image"]').val()

        $.ajax({
            method: 'POST',
            url: BASE_URL + 'appdata/' + APP_KEY + '/ads',
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
            data: { title, description, date, price, author, image }
        }).then(function (res) {
            listAds()
            $('#formCreateAd').trigger('reset')
        }).catch(handleAjaxError)
    }

    function deleteAdd(add) {
        $.ajax({
            method: 'DELETE',
            url: BASE_URL + 'appdata/' + APP_KEY + '/ads/' + add._id,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
        }).then(function (res) {
            listAds()
            showInfo('Add deleted.')
        }).catch(handleAjaxError)
    }

    function loadAddForEdit(add) {
        let title = $('#formEditAd input[name="title"]').val(add.title)
        let description = $('#formEditAd textarea[name="description"]').val(add.description)
        let date = $('#formEditAd input[name="datePublished"]').val(add.date)
        let price = $('#formEditAd input[name="price"]').val(add.price)
        let id = $('#formEditAd input[name="id"]').val(add._id)
        let author = $('#formEditAd input[name="publisher"]').val(add.author)
        let image = $('#formEditAd input[name="image"]').val(add.image)
    }
    function editAdd() {
        let title = $('#formEditAd input[name="title"]').val()
        let description = $('#formEditAd textarea[name="description"]').val()
        let date = $('#formEditAd input[name="datePublished"]').val()
        let price = $('#formEditAd input[name="price"]').val()
        let id = $('#formEditAd input[name="id"]').val()
        let author = $('#formEditAd input[name="publisher"]').val()
        let image = $('#formEditAd input[name="image"]').val()

        $.ajax({
            method: 'PUT',
            url: BASE_URL + 'appdata/' + APP_KEY + '/ads/' + id,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
            data: { title, description, date, price, id, author, image }
        }).then(function (res) {
            listAds()
            showInfo('Add edited.')
        }).catch(handleAjaxError)
    }
    function viewDetailsAd(add) {
        showView('viewDetailsAd')
        hideView('viewAds')
        $('#viewDetailsAd label[for="title"]').find('h3').empty()
        $('#viewDetailsAd label[for="description"]').find('p').empty()
        $('#viewDetailsAd label[for="publisher"]').find('p').empty()
        $('#viewDetailsAd label[for="date"]').find('p').empty()
        $('#viewDetailsAd div').find('img').remove()

        if (add.image == undefined || add.image == '') {
            $('#viewDetailsAd div').prepend($(`<img src="https://cdn.shopify.com/s/files/1/0095/4332/t/30/assets/no-image.svg">`))
        }else {
            $('#viewDetailsAd div').prepend($(`<img src="${add.image}">`))
        }
        
        $('#viewDetailsAd label[for="title"]').append($('<h3>').text(add.title))
        $('#viewDetailsAd label[for="description"]').append($('<p>').text(add.description))
        $('#viewDetailsAd label[for="publisher"]').append($('<p>').text(add.author))
        $('#viewDetailsAd label[for="date"]').append($('<p>').text(add.date))
        
    }
}