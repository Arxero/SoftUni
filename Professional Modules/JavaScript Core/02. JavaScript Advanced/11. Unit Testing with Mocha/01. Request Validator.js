function validateRequest(input) {
    let uriPattern = /^([a-zA-Z0-9.]*|\*)$/
    let messagePattern = /^([^<>\\&'"]*)$/

    if ((input.method == 'GET' || input.method == 'POST' || input.method == 'DELETE' || input.method == 'CONNECT') && input.method != undefined) {
        if (uriPattern.test(input.uri) && input.uri != undefined && input.uri != '') {
            if ((input.version == 'HTTP/0.9' || input.version == 'HTTP/1.0' || input.version == 'HTTP/1.1' || input.version == 'HTTP/2.0') && input.version != undefined) {
                if (messagePattern.test(input.message) && input.message != undefined) {
                    return input
                } else {
                    throw new Error('Invalid request header: Invalid Message')
                }
            } else {
                throw new Error('Invalid request header: Invalid Version')
            }
        } else {
            throw new Error('Invalid request header: Invalid URI')
        }
    } else {
        throw new Error('Invalid request header: Invalid Method')
    }
}

// console.log(validateRequest({
//     method: 'GET',
//     uri: 'svn.public.catalog',
//     version: 'HTTP/1.1',
//     message: ''
// }));

// console.log(validateRequest({
//     method: 'POST',
//     version: 'HTTP/2.0',
//     message: 'rm -rf /*'
// }));

// console.log(validateRequest({
//     method: 'GET',
//     uri: '',
//     version: 'HTTP/0.8',
//     message: ''
// }));