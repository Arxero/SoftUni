function validate() {
    let usernamePattern = /^[a-zA-Z0-9]{3,20}$/
    let passwordPattern = /^[a-zA-Z0-9_]{5,15}$/
    let emailPattern = /@.*\./
    let companyNumberPattern = /^[1-9][0-9]{3}$/
    $('#company').on('change', show)


    $('#submit').on('click', function (ev) {
        ev.preventDefault()
        let isValid = true

        if ($('#username').val().match(usernamePattern)) {
            $('#username').css('border-color', 'none')
        } else {
            $('#username').css('border-color', 'red')
            isValid = false
        }

        if ($('#email').val().match(emailPattern)) {
            $('#email').css('border-color', 'none')
        } else {
            $('#email').css('border-color', 'red')
            isValid = false
        }

        if ($('#password').val().match(passwordPattern)) {
            $('#password').css('border-color', 'none')
        } else {
            $('#password').css('border-color', 'red')
            isValid = false
        }

        if ($('#password').val() == $('#confirm-password').val() && $('#password').val().match(passwordPattern)) {
            $('#confirm-password').css('border-color', 'none')
        } else {
            $('#confirm-password').css('border-color', 'red')
            isValid = false
        }

        if ($('#company').is(':checked')) {
            if ($('#companyNumber').val().match(companyNumberPattern)) {
                $('#companyNumber').css('border-color', 'none')
            } else {
                $('#companyNumber').css('border-color', 'red')
                isValid = false
            }
        }

        if (isValid) {
            $('#valid').css('display', 'block')
        }
    })

    function show() {
        if ($(this).is(':checked')) {
            $('#companyInfo').css('display', 'inline-block')
        } else {
            $('#companyInfo').css('display', 'none')
        }
    }
}
