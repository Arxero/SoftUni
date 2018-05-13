function emailValidation(input) {
    let pattern = /^[A-Za-z0-9]+@[a-z]+.[a-z]+$/;
    let email = input.match(pattern);
    if (email != null) {
        console.log('Valid');
    }
    else {
        console.log('Invalid');
    }
}
// emailValidation('valid@email.bg');
// emailValidation('invalid@emai1.bg');
// emailValidation('invalid*emai1.bg');