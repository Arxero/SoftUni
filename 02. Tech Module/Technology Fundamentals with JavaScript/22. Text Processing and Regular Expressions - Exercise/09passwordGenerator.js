function solution(input) {
    let [str, str2, word] = input
    let concatenatedStrings = str + str2
    concatenatedStrings = concatenatedStrings.split('')
    
    while (word.length <= concatenatedStrings.length) {
        word += word
    }
    word = word.substring(0, concatenatedStrings.length)

    let counter = 0

    for (let i = 0; i < concatenatedStrings.length; i++) {
        let currentLetter = concatenatedStrings[i]

        if (currentLetter == 'a' || currentLetter == 'e' || currentLetter == 'i' || currentLetter == 'o' || currentLetter == 'u') {
            concatenatedStrings.splice(i, 1, word[counter].toUpperCase())
            counter++
        }
    }

    console.log('Your generated password is ' + concatenatedStrings.reverse().join(''))
}
