function solution(input) {
    let regex = /^[d-z|{}#]+$/g
    let encryptedText = input.shift()
    input = input[0].split(' ')

    if (regex.test(encryptedText)) {
        encryptedText = encryptedText.split('')

        let charCodes = []
        encryptedText.forEach(x => charCodes.push(x.charCodeAt() - 3))

        let decryptedText = []
        charCodes.forEach(x => decryptedText.push(String.fromCharCode(x)))

        decryptedText = decryptedText.join('')
        let regex2 = RegExp(input[0], 'g')

        let result = decryptedText.replace(regex2, input[1])
        console.log(result)
    } else {
        console.log('This is not the book you are looking for.')
    }
}
solution([ 'wkhfn#|rx#jhqfkr#phf#exw#|rxu#uholf#lv#khfgohg#lq#hfrwkhu#sohfhw',
'ec an' ])

// solution([ 'arx#vkdww#qrw#sdvv', 't l' ])