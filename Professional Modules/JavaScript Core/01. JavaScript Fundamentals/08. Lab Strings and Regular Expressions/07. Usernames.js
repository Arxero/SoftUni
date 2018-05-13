function usernames(input) {
    let result = [];

    for (let i = 0; i < input.length; i++) {
        let usernameIndex = input[i].indexOf('@'); 
        let username = input[i].substring(0, usernameIndex);
        let domain = input[i].substr(usernameIndex + 1).split('.');
        let firstLetters = '.';

        for (let i = 0; i < domain.length; i++) {
            let arr = domain[i].split('');
            firstLetters += arr.shift();
        }

        result.push(username + firstLetters);
    }
    console.log(result.join(', '));
}
//usernames(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com']);