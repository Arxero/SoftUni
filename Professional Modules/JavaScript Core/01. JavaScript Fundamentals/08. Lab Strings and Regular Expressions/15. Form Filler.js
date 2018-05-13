function formFiller(username, email, number, input) {
    let usernamePattern = /<![a-zA-Z]+!>/g;
    let emailPattern = /<@[a-zA-Z]+@>/g;
    let numberPattern = /<\+[a-zA-Z]+\+>/g;

    for (let element of input) {
        element = element.replace(usernamePattern, username);
        element = element.replace(emailPattern, email);
        element = element.replace(numberPattern, number);
        console.log(element);
    }
}
// formFiller('Pesho',
//     'pesho@softuni.bg',
//     '90-60-90',
//     ['Hello, <!username!>!',
//         'Welcome to your Personal profile.',
//         'Here you can modify your profile freely.',
//         'Your current username is: <!fdsfs!>. Would you like to change that? (Y/N)',
//         'Your current email is: <@DasEmail@>. Would you like to change that? (Y/N)',
//         'Your current phone number is: <+number+>. Would you like to change that? (Y/N)']);