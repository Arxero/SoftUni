function ajax(input) {
    let hash = input.pop();
    let methodPattern = /Method: (GET|POST|PUT|DELETE)$/;
    let credentialsPattern = /Credentials: ((Basic|Bearer) ([a-zA-Z0-9]+))$/;
    let contentPattern = /Content: ([a-zA-Z0-9.]+)$/;

    for (let i = 0; i < input.length; i += 3) {
        let matchMethod = methodPattern.exec(input[i]);
        let matchCredentials = credentialsPattern.exec(input[i + 1]);
        let matdhContent = contentPattern.exec(input[i + 2]);
        let authToken = matchCredentials[3];
        //isValid(hash, authToken);


        if (matchMethod && matchCredentials && matdhContent) {
            if (isValid(hash, authToken)) {
                if (matchMethod[1] == 'GET' && matchCredentials[2] == 'Basic') {
                    console.log(`Response–Method:${matchMethod[1]}&Code:200&Header:${authToken}`);
                }
                else if (matchCredentials[2] == 'Basic' && (matchMethod[1] == 'POST' || matchMethod[1] == 'PUT' || matchMethod[1] == 'DELETE')) {
                    console.log(`Response–Method:${matchMethod[1]}&Code:401`);
                }
                else {
                    console.log(`Response–Method:${matchMethod[1]}&Code:200&Header:${authToken}`);
                }
            }
            else {
                console.log(`Response–Method:${matchMethod[1]}&Code:403`);
            }

        }
        else {
            console.log('Response-Code:400');
        }
    }

    function isValid(hashPattern, token) {
        for (let i = 0; i < hashPattern.length; i += 2) {
            let times = Number(hashPattern[i]);
            let letter = hashPattern[i + 1];
            let counter = 0;

            for (let i = 0; i < token.length; i++) {
                if (letter == token[i]) {
                    counter++;
                    if (counter == times) {
                        return true;
                    }
                }
            }
            return false;
        }
    }

}
// ajax([
//     'Method: GET',
//     'Credentials: Bearer asd918721jsdbhjslkfqwkqiuwjoxXJIdahefJAB',
//     'Content: users.asd.1782452.278asd',
//     'Method: POST',
//     'Credentials: Basic 028591u3jtndkgwndsdkfjwelfqkjwporjqebhas',
//     'Content: Johnathan',
//     '2q'
// ]);

ajax([
    'Method: PUT',
    'Credentials: Bearer as9133jsdbhjslkfqwkqiuwjoxXJIdahefJAB',
    'Content: users.asd/1782452$278///**asd123',
    'Method: POST',
    'Credentials: Bearer 028591u3jtndkgwndskfjwelfqkjwporjqebhas',
    'Content: Johnathan',
    'Method: DELETE',
    'Credentials: Bearer 05366u3jtndkgwndssfsfgeryerrrrrryjihvx',
    'Content: This.is.a.sample.content',
    '2e5g'
]);