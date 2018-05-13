function startApp() {
    const BASE_URL = 'https://baas.kinvey.com/'
    const APP_KEY = 'kid_BkCH9Bkjz'
    const APP_SECRET = 'cf0b30f0a99443f3b669eff781780be3'
    const AUTH_HEADERS = { 'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET) }


    showHideMenuLinks()
    loadingBox()
    showHome()
    //fixing the bug in the consolle: sessionStorage.setItem('subscriptions', JSON.stringify([]))
    $('#linkHome').on('click', showHome)
    $('#linkLogin').on('click', showLogin)
    $('#linkRegister').on('click', showRegister)
    $('#btnRegister').on('click', register)
    $('#linkLogout').on('click', logout)
    $('#btnLogin').on('click', login)
    $('#btnSubmitChirp').on('click', () => postChirp('formSubmitChirp'))
    $('#btnSubmitChirpMy').on('click', () => postChirp('formSubmitChirpMy'))
    $('#linkMe').on('click', userFeed)
    $('#btnFollow').on('click', fallow)
    $('#linkDiscover').on('click', discover)

    $("form").on('submit', function (event) { event.preventDefault() })

    function showHideMenuLinks() {
        $('#main > section').hide()
        if (sessionStorage.getItem('authToken') === null) { //// No logged in user
            showView('linkLogin')
            showView('linkRegister')
            $('#linkHome').hide()
            $('#linkDiscover').hide()
            $('#linkMe').hide()
            $('#linkLogout').hide()
        } else {// We have logged in user
            showView('linkHome')
            showView('linkDiscover')
            showView('linkMe')
            showView('linkLogout')
            $('#linkLogin').hide()
            $('#linkRegister').hide()
        }
    }

    function showView(viewName) {
        $('#main > section').hide() // Hide all views
        $('#' + viewName).show() // Show the selected view only
    }

    function showLogin() {
        showView('viewLogin')
        $('#formLogin').trigger('reset')
        $('#linkRegisterLoginForm').on('click', function () {
            showView('viewRegister')
        })
    }

    function showRegister() {
        showView('viewRegister')
        $('#formRegister').trigger('reset')
        $('#linkLoginFormRegister').on('click', function () {
            showView('viewLogin')
        })

    }

    function handleAjaxError(response) {
        let errorMsg = JSON.stringify(response)
        if (response.readyState === 0)
            errorMsg = "Cannot connect due to network error."
        if (response.responseJSON && response.responseJSON.description)
            errorMsg = response.responseJSON.description
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
        infoBox.find('span').text(message)
        infoBox.show()
        setTimeout(function () {
            $('#infoBox').fadeOut()
        }, 3000)
    }
    function showError(errorMsg) {
        let errorBox = $('#errorBox').on('click', function () {
            $(this).fadeOut()
        })
        errorBox.find('span').text("Error: " + errorMsg)
        errorBox.show()
    }

    function register() {
        let username = $('#formRegister input[name="username"]').val()
        let password = $('#formRegister input[name="password"]').val()
        let passwordRepeat = $('#formRegister input[name="repeatPass"]').val()
        //let subscriptions = []

        if (username.length > 4) {
            if (password !== '') {
                if (password === passwordRepeat) {
                    $.ajax({
                        method: 'POST',
                        url: BASE_URL + 'user/' + APP_KEY + '/',
                        headers: AUTH_HEADERS,
                        data: { username, password }
                    }).then(function (res) {
                        showInfo('User registration successful.')
                        signInUser(res)
                        $('#formRegister').trigger('reset')
                        showView('viewFeed')
                    }).catch(handleAjaxError)
                } else {
                    showError('Passwords dont match')
                }
            } else {
                showError('Invalid password, must not be empty.')
            }
        } else {
            showError('Invalid username, must be at least 5 characters.')
        }
    }

    function signInUser(res) {
        sessionStorage.setItem('username', res.username)
        sessionStorage.setItem('authToken', res._kmd.authtoken)
        sessionStorage.setItem('id', res._id)
        sessionStorage.setItem('subscriptions', JSON.stringify(res.subscriptions))
        showHideMenuLinks()
    }
    function logout() {
        $.ajax({
            method: 'POST',
            url: BASE_URL + 'user/' + APP_KEY + '/_logout',
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
        }).then(function () {
            sessionStorage.clear()
            showInfo('Logout successful.')
            showHideMenuLinks()
            $('#viewFeed h2').first().text('')
        }).catch(handleAjaxError)
    }

    function login() {
        let username = $('#formLogin input[name="username"]').val()
        let password = $('#formLogin input[name="password"]').val()

        if (username.length > 4) {
            if (password !== '') {
                $.ajax({
                    method: 'POST',
                    url: BASE_URL + 'user/' + APP_KEY + '/login',
                    headers: AUTH_HEADERS,
                    data: { username, password }
                }).then(function (res) {
                    showHideMenuLinks()
                    showInfo('Login successful.')
                    signInUser(res)
                    $('#formLogin').trigger('reset')
                    showView('viewFeed')
                    showHome()
                }).catch(handleAjaxError)
            } else {
                showError('Invalid password, must not be empty.')
            }
        } else {
            showError('Invalid username, must be at least 5 characters.')
        }
    }

    function showHome() {
        showView('viewFeed')
        showPost('viewFeed', 'userStats')
        let subscriptions = sessionStorage.getItem('subscriptions')
        //$('#userStats').append($(`<span>${chirps} chirps</span> | <span>${following} following</span> | <span>${followers} followers</span>`))
        $('#chirps article').empty()

        $.ajax({
            method: 'GET',
            url: BASE_URL + 'appdata/' + APP_KEY + `/chirps?query={"author":{"$in": ${subscriptions}}}&sort={"_kmd.ect": 1}`,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
        }).then(function (res) {
            if (res.length > 0) {
                res.reverse()
                for (let chirp of res) {
                    $('#chirps').append($('<article>').addClass('chirp')
                        .append($('<div>').addClass('titlebar')
                            .append($('<a>').addClass('chirp-author').attr('href', '#').text(chirp.author).on('click', function () {
                                viewProfile(chirp)
                            }))
                            .append($('<span>').addClass('chirp-time').text(calcTime(chirp._kmd.ect)))
                        ).append($('<p>').text(chirp.text))
                    )



                    // $('#chirps').append($(`
                    // <article class="chirp">
                    //     <div class="titlebar">
                    //         <a href="#" class="chirp-author">${chirp.author}</a>
                    //         <span class="chirp-time">${calcTime(chirp._kmd.ect)}</span>
                    //     </div>
                    //     <p>${chirp.text}</p>
                    // </article>
                    // `))
                }
            } else {
                $('#chirps article').text('No chirps in database')
            }
        }).catch(handleAjaxError)

    }

    function showPost(sectionId, divStatsId, usernameInput) {
        let username = sessionStorage.getItem('username')
        if (usernameInput !== undefined) {
            username = usernameInput
        }
        $(`#${sectionId} h2`).first().text(username)
        let chirps = 0
        let following = JSON.parse(sessionStorage.getItem('subscriptions')).length
        let followers = 0

        //$('#userStats').empty()

        $.ajax({
            method: 'GET',
            url: BASE_URL + 'appdata/' + APP_KEY + `/chirps?query={"author":"${username}"}`,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
        }).then(function (res) {
            userfeeds = res
            chirps = res.length
            $(`#${divStatsId} span`).first().text(`${chirps} chirps`)
        }).catch(handleAjaxError)


        $.ajax({
            method: 'GET',
            url: BASE_URL + 'user/' + APP_KEY + `/?query={"subscriptions":"${username}"}`,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
        }).then(function (res) {
            followers = res.length
            $(`#${divStatsId} span`).last().text(`${followers} followers`)
        }).catch(handleAjaxError)

        $(`#${divStatsId} span`).each((i, e) => {
            if (i == 1) {
                $(e).text(`${following} following`)
            }
        })
    }

    function calcTime(dateIsoFormat) {
        let diff = new Date - (new Date(dateIsoFormat));
        diff = Math.floor(diff / 60000);
        if (diff < 1) return 'less than a minute';
        if (diff < 60) return diff + ' minute' + pluralize(diff);
        diff = Math.floor(diff / 60);
        if (diff < 24) return diff + ' hour' + pluralize(diff);
        diff = Math.floor(diff / 24);
        if (diff < 30) return diff + ' day' + pluralize(diff);
        diff = Math.floor(diff / 30);
        if (diff < 12) return diff + ' month' + pluralize(diff);
        diff = Math.floor(diff / 12);
        return diff + ' year' + pluralize(diff);
        function pluralize(value) {
            if (value !== 1) return 's';
            else return '';
        }
    }
    function postChirp(formName) {
        let text = $(`#${formName} textarea[name=text]`).val()
        let author = sessionStorage.getItem('username')

        if (text.length > 0) {
            if (text.length <= 150) {
                $.ajax({
                    method: 'POST',
                    url: BASE_URL + 'appdata/' + APP_KEY + '/chirps',
                    headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
                    data: { text, author }
                }).then(function (res) {
                    showInfo('Chirp published.')
                    $(`#${formName}`).trigger('reset')
                    userFeed()
                })
                    .catch(handleAjaxError)
            } else {
                showError('Your chirps is over 150 characters')
            }
        } else {
            showError('Enter text.')
        }
    }

    function userFeed() {
        showView('viewMe')
        showPost('viewMe', 'myStats')
        let username = sessionStorage.getItem('username')

        $.ajax({
            method: 'GET',
            url: BASE_URL + 'appdata/' + APP_KEY + `/chirps?query={"author":"${username}"}&sort={"_kmd.ect": 1}`,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
        }).then(function (res) {
            if (res.length > 0) {
                $('#myChirps div').remove()
                $('#myChirps').empty()
            }
            //$('#myChirpsa a .chirp-author').on('click', viewProfile)
            for (let chirp of res) {
                $('#myChirps').append($('<article>').addClass('chirp')
                    .append($('<div>').addClass('titlebar')
                        .append($('<a>').addClass('chirp-author').attr('href', '#').text(chirp.author).on('click', () => userFeed()))
                        .append($('<span>').addClass('chirp-time')
                            .append($('<a>').attr('href', '#').text('delete').on('click', function () {
                                $(this).parent().parent().parent().remove()
                                deleteChrip(chirp)
                            }))
                            .append($('<a>').text(` ${calcTime(chirp._kmd.ect)}`))
                        )
                    ).append($('<p>').text(chirp.text))
                )
            }
        }).catch(handleAjaxError)
    }

    function deleteChrip(chirp) {
        $.ajax({
            method: 'DELETE',
            url: BASE_URL + 'appdata/' + APP_KEY + '/chirps/' + chirp._id,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
        }).then(function (res) {
            $(this).parent().parent().parent().remove()
            showInfo('Chirp deleted.')
            //showView('viewMe')
            //showPost('viewMe', 'myStats')
        }).catch(handleAjaxError)

    }

    function viewProfile(chirp) {
        //console.log(chirp._id);

        showPost('viewProfile', 'userProfileStats', chirp.author)
        showView('viewProfile')
        fallow(chirp)

        $.ajax({
            method: 'GET',
            url: BASE_URL + 'appdata/' + APP_KEY + `/chirps?query={"author":"${chirp.author}"}`,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
        }).then(function (res) {
            $('#profileChirps article').empty()
            for (let chirp of res) {
                $('#profileChirps').append($('<article>').addClass('chirp')
                    .append($('<div>').addClass('titlebar')
                        .append($('<a>').addClass('chirp-author').attr('href', '#').text(chirp.author))
                        .append($('<span>').addClass('chirp-time')
                            .append($('<a>').text(` ${calcTime(chirp._kmd.ect)}`))
                        )
                    ).append($('<p>').text(chirp.text))
                )
            }
        }).catch(handleAjaxError)


    }

    function fallow(chirp) {
        let subscriptions = JSON.parse(sessionStorage.getItem('subscriptions'))
        if (subscriptions.includes(chirp.author)) {
            $('#btnFollow').hide()
            $('#btnUnfollow').show()
            $('#btnUnfollow').on('click', () => unfallow(chirp))
        } else {
            $('#btnUnfollow').hide()
            $('#btnFollow').show()
            $('#btnFollow').on('click', () => fallowUser(chirp))
        }
    }

    function unfallow(chirp) {
        let userId = sessionStorage.getItem('id')
        let subscriptions = JSON.parse(sessionStorage.getItem('subscriptions'))
        let index = subscriptions.indexOf(chirp.author)
        subscriptions.splice(index, 1)

        $.ajax({
            method: 'PUT',
            url: BASE_URL + 'user/' + APP_KEY + '/' + userId,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
            data: { subscriptions }
        }).then(function (res) {
            showInfo(`Unsubscribed to ${chirp.author}`)
            sessionStorage.setItem('subscriptions', JSON.stringify(subscriptions))
            showHome()
        }).catch(handleAjaxError)

    }

    function discover() {
        showView('viewDiscover')

        $.ajax({
            method: 'GET',
            url: BASE_URL + 'user/' + APP_KEY,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
        }).then(function (res) {
            $('#userlist .userbox').remove()
            for (let chirp of res) {
                if (chirp.username !== sessionStorage.getItem('username')) {
                    countFallowersDiscover(chirp)
                    $('#userlist')
                        .append($('<div>').addClass('userbox')
                            .append($('<div>')
                                .append($('<a>').attr('href', '#').addClass('chirp-author').text(chirp.username).on('click', () => viewProfileOnDiscover(chirp)))
                                .append($('<div>').addClass('user-details')
                                    .append($('<span>'))
                                )
                            )
                        )
                }
            }
        }).catch(handleAjaxError)
    }

    function viewProfileOnDiscover(chirp) {
        showPost('viewProfile', 'userProfileStats', chirp.username)
        showView('viewProfile')
        showFallowUnfallowDiscoverPage(chirp)
        let name = chirp.username

        $.ajax({
            method: 'GET',
            url: BASE_URL + 'appdata/' + APP_KEY + `/chirps?query={"author":"${chirp.username}"}`,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
        }).then(function (res) {
            $('#profileChirps article').empty()
            for (let chirp of res) {
                $('#profileChirps').append($('<article>').addClass('chirp')
                    .append($('<div>').addClass('titlebar')
                        .append($('<a>').addClass('chirp-author').attr('href', '#').text(name))
                        .append($('<span>').addClass('chirp-time')
                            .append($('<a>').text(` ${calcTime(chirp._kmd.ect)}`))
                        )
                    ).append($('<p>').text(chirp.text))
                )
            }
        }).catch(handleAjaxError)
    }

    function countFallowersDiscover(chirp) {
        $.ajax({
            method: 'GET',
            url: BASE_URL + 'user/' + APP_KEY + `/?query={"subscriptions":"${chirp.username}"}`,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') }
        }).then(function (res) {
            console.log(res.length);
            $('#userlist span').text(res.length + ' followers')
        }).catch(handleAjaxError)
    }

    function showFallowUnfallowDiscoverPage(chirp) {
        let subscriptions = JSON.parse(sessionStorage.getItem('subscriptions'))
        if (subscriptions.includes(chirp.username)) {
            $('#btnFollow').hide()
            $('#btnUnfollow').show()
            $('#btnUnfollow').on('click', () => unfallow(chirp))
        } else {
            $('#btnUnfollow').hide()
            $('#btnFollow').show().on('click', () => fallowUser(chirp))
        }
    }

    function fallowUser(chirp) {
        let userId = sessionStorage.getItem('id')
        let subscriptions = JSON.parse(sessionStorage.getItem('subscriptions'))
        subscriptions.push(chirp.username)
        $('#btnFollow').hide()
        $('#btnUnfollow').show()

        $.ajax({
            method: 'PUT',
            url: BASE_URL + 'user/' + APP_KEY + '/' + userId,
            headers: { 'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken') },
            data: { subscriptions }
        }).then(function (res) {
            showInfo(`Subscribed to ${chirp.username}`)
            sessionStorage.setItem('subscriptions', JSON.stringify(subscriptions))
            showHome()
        }).catch(handleAjaxError)
    }
}
