function solution(input) {
    input = input.split(' ')

    for (let word of input) {
        if (word.startsWith('#') && word.length > 1) {
            word = word.substring(1)
            let validCharCounter = 0

            for (let i = 0; i < word.length; i++) {
                if ((word.charCodeAt(i) >= 65 && word.charCodeAt(i) <= 90) ||
                    (word.charCodeAt(i) >= 97 && word.charCodeAt(i) <= 122)) {
                    validCharCounter++
                }
            }
            if (validCharCounter == word.length) {
                console.log(word)
            }
        }
    }
}
solution('Nowadays everyone uses # to tag a #special word in #socialMedia^')